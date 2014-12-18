using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contour
{
   
    public partial class Main_UI : Form
    {       
        public Main_UI()
        {

            InitializeComponent();
            this.GameEngine = new GameEngine();
            NextGo();
            UpdateScore(0);
            ui_radioAbove.Checked = true;
            initTimers();
        }

        private void initTimers()
        {
            //Label resetting
            this.LabelReset_Timer = new Sanford.Multimedia.Timers.Timer();
            this.LabelReset_Timer.Mode = Sanford.Multimedia.Timers.TimerMode.OneShot;
            this.LabelReset_Timer.Period = 1500;
            this.LabelReset_Timer.Tick += onTimerTick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Midi files (*.mid; *midi) | *.mid; *.midi; *.MID; *.MIDI";
            DialogResult result = fileDialog.ShowDialog();
            if(result.ToString() == "OK"){
                this.GameEngine.FileName = fileDialog.FileName; 
            }            
        }
        
        private void UpdateScore(int score)
        {
            this.GameEngine.UserScore = score; //TODO data binding
            ui_score.Text = score.ToString();
        }
       
        //TODO test all midi files
        private void NextGo()
        {
            this.GameEngine.NextGo();
            
            ui_songTitle.Text = this.GameEngine.FileName; //TODO data binding   
            ui_noteInd.Text = (this.GameEngine.AnswerNote.NoteIndex + 1).ToString(); // 1 indexed
        }
        //TODO annonymous method?        
        private void PlayMelody_Click(object sender, EventArgs e)
        {
            this.GameEngine.Play();
        }

        private void onTimerTick(object sender, EventArgs e)
        {
            invokeLabelReset();
        }

        private void invokeLabelReset()
        {
            if (ui_feedback.InvokeRequired)
            {
                Invoke( new MethodInvoker(invokeLabelReset));
            }
            else
            {
                ui_feedback.Text = "";
            }
        }

        private void ui_submit_Click(object sender, EventArgs e)
        {
            if( this.GameEngine.isUserCorrect() )
            {
                ui_feedback.Text = "Correct!";
                UpdateScore(GameEngine.UserScore + 1);
                NextGo();
            }
            else {
                ui_feedback.Text = "Incorrect"; 
            }
            this.LabelReset_Timer.Start();
        }

        private void ui_radioAbove_CheckedChanged(object sender, EventArgs e)
        {
            this.GameEngine.UserSelected = (int)NoteDirection.ABOVE;
        }

        private void ui_radioSame_CheckedChanged(object sender, EventArgs e)
        {
            this.GameEngine.UserSelected = (int)NoteDirection.SAME;
        }

        private void ui_radioBelow_CheckedChanged(object sender, EventArgs e)
        {
            this.GameEngine.UserSelected = (int)NoteDirection.BELOW;
        }
  
        private Sanford.Multimedia.Timers.Timer LabelReset_Timer; 
        private GameEngine GameEngine;
    } 
}
