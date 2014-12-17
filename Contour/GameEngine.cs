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
            this.MidiEngine = new MidiEngine();
                
            this.MidiFiles = new List<string>(Directory.GetFiles(@"../../media/"));                               
            this.UserScore = 0;
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
            
        public bool isUserCorrect(){
            if(UserSelected == CorrectDirection){
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
        private int CorrectDirection { get; set; }
        public int UserSelected {get; set;}            
        public int UserScore { get; set; } //TODO to bind
        private MidiEngine MidiEngine;
    }
}

