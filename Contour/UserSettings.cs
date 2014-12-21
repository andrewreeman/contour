using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Contour
{

    class UserData
    {
        public UserData()
        {
            this.Name = "";
            this.Score = 0;
        }
        public string Name { get; set; }
        public int Score { get; set; }
    }
    class UserSettings
    {
        public UserSettings(string settingsPath)
        {
            if (File.Exists(settingsPath))
            {
                StreamReader reader = new StreamReader(settingsPath);
                string settingsContents = reader.ReadToEnd();
                this.AllUsers = JsonConvert.DeserializeObject<List<UserData>>(settingsContents);
                reader.Close();
            }
            else
            {
                this.AllUsers = new List<UserData>();
                UserData defaultUser = new UserData();
                defaultUser.Name = "Guest";
                defaultUser.Score = 0;
                this.AllUsers.Add(defaultUser);
                this.SetActiveUser("Guest");
            }
            this.SettingsPath = settingsPath;
            activeUser = null;
            IsActiveUser = false;
            this.SetActiveUser("Guest");
        }

        public List<UserData> GetAllUsersInfo()
        {
            List<UserData> copy = new List<UserData>();
            foreach (UserData user in AllUsers)
            {
                UserData copyUser = new UserData();
                copyUser.Name = user.Name;
                copyUser.Score = user.Score;
                copy.Add(copyUser);
            }
            return copy;
        }

        
        public void AddUser(string userName) {
            if (isUserExist(userName)) throw new ArgumentException("UserSettings.AddUser(string): User " + userName + " already exists. ");
            UserData newUser = new UserData();
            newUser.Name = userName;
            newUser.Score = 0;
            this.AllUsers.Add(newUser);
            this.Save();
        }

        public void RemoveUser(string userName)
        {
            if (userName == activeUser.Name) throw new ArgumentException("UserSettings.RemoveUser(string): Cannot remove user: " + userName + " as this is the active user.");
            if (isUserExist(userName))
            {
                for (int i = 0; i < AllUsers.Count; ++i)
                {
                    UserData user = AllUsers.ElementAt(i);
                    if (user.Name == userName)
                    {
                        AllUsers.Remove(user); //Do not save yet. Gives the user a chance to quit the program to undo.
                    }
                }
            }
            else throw new ArgumentException("UserSettings.RemoveUser(string): User " + userName + " does not exist. ");
        }

        public void SetActiveUser(string userName)
        {
            IsActiveUser = true;
            activeUser = getUser(userName);
        }
        public int GetUserScore(string userName){
            UserData userData = getUser(userName);           
            return userData.Score;
        }

        public int GetUserScore()
        {
            if (activeUser == null) throw new InvalidOperationException();
            return activeUser.Score;
        }

        public void SetUserScore(string userName, int newScore) {
            UserData userData = getUser(userName);
            userData.Score = newScore;
            this.Save();
        }

        public string GetUserName()
        {
            if (activeUser == null) throw new InvalidOperationException();
            return activeUser.Name;
        }

        public void SetUserScore(int newScore)
        {
            if (activeUser == null) throw new InvalidOperationException();
            activeUser.Score = newScore;
            this.Save();
        }

        public void AddToUserScore(string userName, int additionToScore)
        {
            UserData userData = getUser(userName);
            userData.Score += additionToScore;
            this.Save();
        }

        public void AddToUserScore(int additionToScore)
        {
            if (activeUser == null) throw new InvalidOperationException();
            activeUser.Score += additionToScore;
            this.Save();
        }

        public void ChangeUserName(string userName, string newUserName)
        {
            UserData userData = getUser(userName);
            userData.Name = newUserName;
            this.Save();
        }

        public void Save()
        {
            if (AllUsers.Count > 0)
            {
                List<UserData> AllUsers_ZeroedGuest = this.AllUserData_ZeroedGuest();
                string output = JsonConvert.SerializeObject(AllUsers_ZeroedGuest);
                StreamWriter writer = new StreamWriter(SettingsPath);
                writer.Write(output);
                writer.Close();
            }
        }

        private List<UserData> AllUserData_ZeroedGuest()
        {
            List<UserData> newData = GetAllUsersInfo();
            foreach (UserData user in newData)
            {
                if (user.Name == "Guest")
                {
                    user.Score = 0;
                }
            }
            return newData;
        }

        private List<UserData> AllUsers;
        public string SettingsPath { get; private set; }

        private UserData getUser(string userName)
        {
            if(isUserExist(userName))
            {
                foreach (UserData user in AllUsers)
                {
                    if (user.Name == userName)
                    {
                        return user;
                    }
                }
            }
            throw new ArgumentException("UserSettings.getUser(string): User name " + userName + " does not exist.");
        }

        private bool isUserExist(string userName)
        {
            foreach (UserData user in AllUsers)
            {
                if (user.Name == userName)
                {
                    return true;
                }
            }
            return false;
        }
        private UserData activeUser;
        public bool IsActiveUser { get; set; }
    }   
}
