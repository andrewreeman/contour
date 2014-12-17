using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanford.Multimedia.Midi;


namespace Contour
{
    
    class MidiEngine
    {
        public MidiEngine()
        {
            this.Output = new OutputDevice(0);
            this.Sequencer = new Sequencer();
            this.Sequencer.ChannelMessagePlayed += this.onChannel;
            this.Sequencer.PlayingCompleted += this.onPlayingCompleted;       
        }

        public void onChannel(object sender, ChannelMessageEventArgs args)
        {
            this.Output.Send(args.Message);
        }
    
        public void onPlayingCompleted(object sender, EventArgs args)
        {
            this.isPlaying = false;
        }

        public List<int> GetNoteOn()
        {
            List<int> notes = new List<int>();
            foreach (Track melody in this.Sequence)
            {
                foreach (MidiEvent ev in melody.Iterator())
                {
                    IMidiMessage mess = ev.MidiMessage;
                    if (mess.MessageType == MessageType.Channel)
                    {
                        ChannelMessage channelMess = (ChannelMessage)mess;
                        if (channelMess.Command == ChannelCommand.NoteOn)
                        {
                            notes.Add(channelMess.Data1);
                        }
                    }
                }
            }
            return notes;
        }

        public void Play()
        {
            if (this.isPlaying == false)
            {
                this.Sequencer.Start();
                this.isPlaying = true;
            }
        }
    //TODO visual feedback on which note
        private string fileName;
        public string FileName { 
            get{
                return fileName;
            } 
            set{
                fileName = value;
                this.isPlaying = false;
                this.Sequencer.Sequence = this.Sequence = new Sequence(value);
            } 
        } //TODO to bind
        private OutputDevice Output { get; set; }
        private Sequencer Sequencer { get; set; }
        private Sequence Sequence { get; set; }
        private bool isPlaying;   
    }
}

