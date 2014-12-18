using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Contour
{

    //TODO stores multi user settings.
    // File read/write
    // Store in key/value pairs. Use jSon of XML or yaml
    // User1{key: value, key: value} User2{key: value...}...
    class UserData
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
    class UserSettings
    {
        public UserSettings(string settingsPath) {
            

            if (File.Exists(settingsPath))
            {//TODO try catch!
                StreamReader reader = new StreamReader(settingsPath);              
                string settingsContents = reader.ReadToEnd();
                this.AllUsers = JsonConvert.DeserializeObject< List<UserData> >(settingsContents);
                //Console.WriteLine(listData.ElementAt(0).Name); // SO SIMPLE!
                reader.Close();
            }
            this.SettingsPath = settingsPath;
            /*else
            {
                UserData data = new UserData();
                data.Name = "bob";
                data.Score = 5;
                UserData data2 = new UserData();
                data2.Name = "barry";
                data2.Score = 3;


                List<UserData> listData = new List<UserData>(2);
                listData.Add(data);
                listData.Add(data2);

                string output = JsonConvert.SerializeObject(listData);
                Console.WriteLine(output);
                StreamWriter writer = new StreamWriter(settingsPath);
                
                writer.Write(output);
                writer.Close();

                Console.WriteLine("Written: " + output);
            } */
        
        }
        
        public void AddUser(string userName) {
            
            UserData newUser = new UserData();
            newUser.Name = userName;
            newUser.Score = 0;
            this.AllUsers.Add(newUser);
            this.Save();
        }
        
        
        public int GetUserScore(string userName){
            UserData userData = getUser(userName);           
            return userData.Score;
        }
        
        public void SetUserScore(string userName, int newScore) {
            UserData userData = getUser(userName);
            userData.Score = newScore;
            this.Save();
        }
        public void AddToUserScore(string userName, int additionToScore)
        {
            UserData userData = getUser(userName);
            userData.Score += additionToScore;
            this.Save();
        }

        public void ChangeUserName(string userName, string newUserName){
            UserData userData = getUser(userName);
            userData.Name = newUserName;
            this.Save();
        }
        public void Save()
        {
            string output = JsonConvert.SerializeObject(AllUsers);
            StreamWriter writer = new StreamWriter(SettingsPath);
            writer.Write(output);
            writer.Close();
        }
        
        public List<UserData> AllUsers { get; private set; }
        public string SettingsPath { get; private set; }

        private UserData getUser(string userName)
        {
            foreach (UserData user in AllUsers)
            {
                if (user.Name == userName)
                {
                    return user;
                }
            }
            throw new ArgumentException("userName does not exist.");
        }
    }
}
