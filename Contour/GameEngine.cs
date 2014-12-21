using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Contour
{
    public struct NoteData
    {
        public int NoteValue { get; set; }
        public int NoteIndex { get; set; }
    }

    enum NoteDirection
    {
        ABOVE, BELOW, SAME
    }

    class GameEngine
    {
        public GameEngine()
        {
            //TODO data bindings

            //TODO filter file list for midi files
            this.UserSettings = null;
            this.MidiEngine = new MidiEngine(); //Midi engine can throw OutputDeviceException
            this.MidiFiles = new List<string>(Directory.GetFiles(@"../../media/"));
            this.UserScore = 0;
                       
        }

        public void initUserSettings()
        {
            this.UserSettings = new UserSettings("settings.json");
        }

        private NoteData RandNote()
        {
            Random random = new Random();
            NoteData noteData = new NoteData();

            noteData.NoteIndex = random.Next(1, this.Notes.Count); // can't pick the first note
            noteData.NoteValue = this.Notes.ElementAt(noteData.NoteIndex);
            return noteData;
        }
            
        private string RandSong()
        {
            Random randGen = new Random();
            int size = this.MidiFiles.Count;
            return this.MidiFiles.ElementAt(randGen.Next(size));
        }

        private int getDirectionFromPrevious()
        {
            int previousNoteValue = this.Notes.ElementAt(this.AnswerNote.NoteIndex - 1);
            if (this.AnswerNote.NoteValue == previousNoteValue)
            {
                return (int)NoteDirection.SAME;
            }
            else if (this.AnswerNote.NoteValue > previousNoteValue)
            {
                return (int)NoteDirection.ABOVE;
            }
            else
            {
                return (int)NoteDirection.BELOW;
            }
        }
        /*
        public List<UserData> GetAllUsersInfo()
        {
            if (this.UserSettings != null)
                return this.UserSettings.GetAllUsersInfo();
            else throw new InvalidOperationException("UserSettings not initialized.");
        }*/

        public void AddUser(string userName)
        {
            if (this.UserSettings != null)
                this.UserSettings.AddUser(userName);
            else throw new InvalidOperationException("UserSettings not initialized.");
        }
        public void RemoveUser(string userName)
        {
            if (this.UserSettings != null)
                this.UserSettings.RemoveUser(userName);
            else throw new InvalidOperationException("UserSettings not initialized.");
        }
        public void SetActiveUser(string userName)
        {
            this.UserSettings.SetActiveUser(userName);
            this.UserScore = this.UserSettings.GetUserScore();
        }
        //TODO test all midi files
        public void NextGo()
        {
            this.FileName = RandSong();
            this.Notes = this.MidiEngine.GetNoteOn();
            this.AnswerNote = RandNote();
            this.CorrectDirection = getDirectionFromPrevious();
        }

        public void Play()
        {
            this.MidiEngine.Play();
        }
            
        public bool SubmitAnswer(int userAnswer){
            if(userAnswer == CorrectDirection){
                //TODO link score with ui and usersettings
                this.UserScore++;
                return true;
            }
            else{
                return false;
            }
        }
        
        public string FileName{
            get{
                return this.MidiEngine.FileName;
            }
            set{
                this.MidiEngine.FileName = value;
            }
        }

        private List<string> MidiFiles;
        private List<int> Notes;
        public NoteData AnswerNote{get; private set;}
        private int CorrectDirection { get; set; } //TODO if no active user then local score until new profile created. then copy to new user
        private MidiEngine MidiEngine;
        public UserSettings UserSettings { get; private set; }
         public int UserScore // if no active user then store user score locally.
        {
            get
            {
                if (this.UserSettings != null)
                    return this.UserSettings.GetUserScore();
                return userScore;
            }
            set
            {
                if (this.UserSettings != null)
                    this.UserSettings.SetUserScore(value);
                else
                    userScore = value;
            }
        }
        private int userScore;
        
        //TODO to bind 
        /*
        public string UserName
        {
            get
            {
                if (this.UserSettings != null && this.UserSettings.IsActiveUser)
                    return this.UserSettings.GetUserName();
                else return "";
            }
            set
            {   if(this.UserSettings != null)
                    this.UserSettings.SetActiveUser(value.ToString());
            }
        } */
            //TODO new game ... login bla bla
      
        
    }
}

