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
            initUserDataList();
        }

        private void initUserDataList()
        {
            try
            {
                List<UserData> allUserData = this.GameEngine.GetAllUsersInfo();
                foreach (UserData user in allUserData)
                {
                    ui_userNames.Items.Add(user.Name);
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Error: GameEngine could not provide user settings. UserSettings object probably not initialised." + e.Message);
            }
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

      
        private void ui_addUser_Click(object sender, EventArgs e)
        {
            string newUser = (ui_newUsername.Text).Trim();
            if (newUser != ""){
                try
                {
                    this.GameEngine.AddUser(newUser);
                    ui_userNames.Items.Add(newUser);
                }
                catch (ArgumentException argEx)
                {
                    string errorString = "Error: Could not add user. " + argEx.Message;
                    Console.WriteLine(errorString);
                    MessageBox.Show(errorString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ui_newUsername.Text = "";  
        }

        private void ui_RemoveUser_Click(object sender, EventArgs e)
        {
            string removeUser = (ui_RemoveUsername.Text).Trim();
            if (removeUser != "")
            {
                try
                {
                    this.GameEngine.RemoveUser(removeUser);
                    foreach (string userName in ui_userNames.Items)
                    {
                        if (userName.Trim() == removeUser)
                        {
                            ui_userNames.Items.Remove(userName);
                            break;
                        }
                    }
                }
                catch (ArgumentException argEx)
                {
                    string errorString = "Error: Could not remove user. " + argEx.Message;
                    Console.WriteLine(errorString);
                    MessageBox.Show(errorString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ui_RemoveUsername.Text = "";  

        }

        private void ui_ActiveUsername_TextChanged(object sender, EventArgs e)
        {
            string activeUser = (ui_ActiveUsername.Text).Trim();
            if (activeUser != "")
            {
                try
                {
                    this.GameEngine.SetActiveUser(activeUser);
                    
                }
                catch (ArgumentException argEx)
                {
                    string errorString = "Error: Could not make user active. " + argEx.Message;
                    Console.WriteLine(errorString);
                    MessageBox.Show(errorString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ui_ActiveUsername.Text = "";  
        }  
    } 
}
