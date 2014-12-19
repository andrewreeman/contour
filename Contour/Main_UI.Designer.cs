namespace Contour
{
    partial class Main_UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.PlayMelody = new System.Windows.Forms.Button();
            this.ui_songTitle = new System.Windows.Forms.Label();
            this.ui_noteInd = new System.Windows.Forms.Label();
            this.ui_radioAbove = new System.Windows.Forms.RadioButton();
            this.ui_radioSame = new System.Windows.Forms.RadioButton();
            this.ui_radioBelow = new System.Windows.Forms.RadioButton();
            this.ui_submit = new System.Windows.Forms.Button();
            this.ui_feedback = new System.Windows.Forms.Label();
            this.ui_score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ui_userNames = new System.Windows.Forms.ListBox();
            this.ui_addUser = new System.Windows.Forms.Button();
            this.ui_newUsername = new System.Windows.Forms.TextBox();
            this.ui_RemoveUser = new System.Windows.Forms.Button();
            this.ui_RemoveUsername = new System.Windows.Forms.TextBox();
            this.userSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ui_ActiveUsername = new System.Windows.Forms.TextBox();
            this.ui_SetActiveUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userSettingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(2, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select midi &file";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayMelody
            // 
            this.PlayMelody.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PlayMelody.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayMelody.Location = new System.Drawing.Point(332, 12);
            this.PlayMelody.Name = "PlayMelody";
            this.PlayMelody.Size = new System.Drawing.Size(75, 30);
            this.PlayMelody.TabIndex = 2;
            this.PlayMelody.Text = "&Play Melody";
            this.PlayMelody.UseVisualStyleBackColor = false;
            this.PlayMelody.Click += new System.EventHandler(this.PlayMelody_Click);
            // 
            // ui_songTitle
            // 
            this.ui_songTitle.AutoSize = true;
            this.ui_songTitle.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_songTitle.Location = new System.Drawing.Point(435, 21);
            this.ui_songTitle.Name = "ui_songTitle";
            this.ui_songTitle.Size = new System.Drawing.Size(42, 21);
            this.ui_songTitle.TabIndex = 3;
            this.ui_songTitle.Text = "song";
            // 
            // ui_noteInd
            // 
            this.ui_noteInd.AutoSize = true;
            this.ui_noteInd.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_noteInd.ForeColor = System.Drawing.Color.BlueViolet;
            this.ui_noteInd.Location = new System.Drawing.Point(372, 54);
            this.ui_noteInd.Name = "ui_noteInd";
            this.ui_noteInd.Size = new System.Drawing.Size(119, 30);
            this.ui_noteInd.TabIndex = 5;
            this.ui_noteInd.Text = "note index";
            // 
            // ui_radioAbove
            // 
            this.ui_radioAbove.AutoSize = true;
            this.ui_radioAbove.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_radioAbove.Location = new System.Drawing.Point(332, 130);
            this.ui_radioAbove.Name = "ui_radioAbove";
            this.ui_radioAbove.Size = new System.Drawing.Size(69, 25);
            this.ui_radioAbove.TabIndex = 6;
            this.ui_radioAbove.TabStop = true;
            this.ui_radioAbove.Text = "Above";
            this.ui_radioAbove.UseVisualStyleBackColor = true;
            this.ui_radioAbove.CheckedChanged += new System.EventHandler(this.ui_radioAbove_CheckedChanged);
            // 
            // ui_radioSame
            // 
            this.ui_radioSame.AutoSize = true;
            this.ui_radioSame.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_radioSame.Location = new System.Drawing.Point(332, 153);
            this.ui_radioSame.Name = "ui_radioSame";
            this.ui_radioSame.Size = new System.Drawing.Size(66, 25);
            this.ui_radioSame.TabIndex = 7;
            this.ui_radioSame.TabStop = true;
            this.ui_radioSame.Text = "Same";
            this.ui_radioSame.UseVisualStyleBackColor = true;
            this.ui_radioSame.CheckedChanged += new System.EventHandler(this.ui_radioSame_CheckedChanged);
            // 
            // ui_radioBelow
            // 
            this.ui_radioBelow.AutoSize = true;
            this.ui_radioBelow.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_radioBelow.Location = new System.Drawing.Point(332, 176);
            this.ui_radioBelow.Name = "ui_radioBelow";
            this.ui_radioBelow.Size = new System.Drawing.Size(69, 25);
            this.ui_radioBelow.TabIndex = 8;
            this.ui_radioBelow.TabStop = true;
            this.ui_radioBelow.Text = "Below";
            this.ui_radioBelow.UseVisualStyleBackColor = true;
            this.ui_radioBelow.CheckedChanged += new System.EventHandler(this.ui_radioBelow_CheckedChanged);
            // 
            // ui_submit
            // 
            this.ui_submit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ui_submit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ui_submit.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_submit.Location = new System.Drawing.Point(332, 209);
            this.ui_submit.Name = "ui_submit";
            this.ui_submit.Size = new System.Drawing.Size(75, 27);
            this.ui_submit.TabIndex = 9;
            this.ui_submit.Text = "&Submit";
            this.ui_submit.UseVisualStyleBackColor = false;
            this.ui_submit.Click += new System.EventHandler(this.ui_submit_Click);
            // 
            // ui_feedback
            // 
            this.ui_feedback.AutoSize = true;
            this.ui_feedback.Font = new System.Drawing.Font("Franklin Gothic Book", 18F);
            this.ui_feedback.ForeColor = System.Drawing.Color.BlueViolet;
            this.ui_feedback.Location = new System.Drawing.Point(458, 155);
            this.ui_feedback.Name = "ui_feedback";
            this.ui_feedback.Size = new System.Drawing.Size(0, 30);
            this.ui_feedback.TabIndex = 10;
            // 
            // ui_score
            // 
            this.ui_score.AutoSize = true;
            this.ui_score.Font = new System.Drawing.Font("Franklin Gothic Book", 18F);
            this.ui_score.ForeColor = System.Drawing.Color.BlueViolet;
            this.ui_score.Location = new System.Drawing.Point(618, 55);
            this.ui_score.Name = "ui_score";
            this.ui_score.Size = new System.Drawing.Size(71, 30);
            this.ui_score.TabIndex = 11;
            this.ui_score.Text = "Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.label1.Location = new System.Drawing.Point(264, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Note number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.label2.Location = new System.Drawing.Point(561, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Score:";
            // 
            // ui_userNames
            // 
            this.ui_userNames.FormattingEnabled = true;
            this.ui_userNames.Location = new System.Drawing.Point(33, 88);
            this.ui_userNames.Name = "ui_userNames";
            this.ui_userNames.Size = new System.Drawing.Size(120, 95);
            this.ui_userNames.TabIndex = 14;
            // 
            // ui_addUser
            // 
            this.ui_addUser.Location = new System.Drawing.Point(33, 189);
            this.ui_addUser.Name = "ui_addUser";
            this.ui_addUser.Size = new System.Drawing.Size(75, 23);
            this.ui_addUser.TabIndex = 15;
            this.ui_addUser.Text = "Add User";
            this.ui_addUser.UseVisualStyleBackColor = true;
            this.ui_addUser.Click += new System.EventHandler(this.ui_addUser_Click);
            // 
            // ui_newUsername
            // 
            this.ui_newUsername.Location = new System.Drawing.Point(115, 191);
            this.ui_newUsername.Name = "ui_newUsername";
            this.ui_newUsername.Size = new System.Drawing.Size(100, 20);
            this.ui_newUsername.TabIndex = 16;
            // 
            // ui_RemoveUser
            // 
            this.ui_RemoveUser.Location = new System.Drawing.Point(33, 212);
            this.ui_RemoveUser.Name = "ui_RemoveUser";
            this.ui_RemoveUser.Size = new System.Drawing.Size(75, 23);
            this.ui_RemoveUser.TabIndex = 17;
            this.ui_RemoveUser.Text = "Remove User";
            this.ui_RemoveUser.UseVisualStyleBackColor = true;
            this.ui_RemoveUser.Click += new System.EventHandler(this.ui_RemoveUser_Click);
            // 
            // ui_RemoveUsername
            // 
            this.ui_RemoveUsername.Location = new System.Drawing.Point(115, 217);
            this.ui_RemoveUsername.Name = "ui_RemoveUsername";
            this.ui_RemoveUsername.Size = new System.Drawing.Size(100, 20);
            this.ui_RemoveUsername.TabIndex = 18;
            // 
            // userSettingsBindingSource
            // 
            this.userSettingsBindingSource.DataSource = typeof(Contour.UserSettings);
            // 
            // userDataBindingSource
            // 
            this.userDataBindingSource.DataSource = typeof(Contour.UserData);
            // 
            // ui_ActiveUsername
            // 
            this.ui_ActiveUsername.Location = new System.Drawing.Point(115, 246);
            this.ui_ActiveUsername.Name = "ui_ActiveUsername";
            this.ui_ActiveUsername.Size = new System.Drawing.Size(100, 20);
            this.ui_ActiveUsername.TabIndex = 20;
            this.ui_ActiveUsername.TextChanged += new System.EventHandler(this.ui_ActiveUsername_TextChanged);
            // 
            // ui_SetActiveUser
            // 
            this.ui_SetActiveUser.Location = new System.Drawing.Point(33, 241);
            this.ui_SetActiveUser.Name = "ui_SetActiveUser";
            this.ui_SetActiveUser.Size = new System.Drawing.Size(75, 23);
            this.ui_SetActiveUser.TabIndex = 19;
            this.ui_SetActiveUser.Text = "Set active";
            this.ui_SetActiveUser.UseVisualStyleBackColor = true;

            // 
            // Main_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(766, 262);
            this.Controls.Add(this.ui_ActiveUsername);
            this.Controls.Add(this.ui_SetActiveUser);
            this.Controls.Add(this.ui_RemoveUsername);
            this.Controls.Add(this.ui_RemoveUser);
            this.Controls.Add(this.ui_newUsername);
            this.Controls.Add(this.ui_addUser);
            this.Controls.Add(this.ui_userNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ui_score);
            this.Controls.Add(this.ui_feedback);
            this.Controls.Add(this.ui_submit);
            this.Controls.Add(this.ui_radioBelow);
            this.Controls.Add(this.ui_radioSame);
            this.Controls.Add(this.ui_radioAbove);
            this.Controls.Add(this.ui_noteInd);
            this.Controls.Add(this.ui_songTitle);
            this.Controls.Add(this.PlayMelody);
            this.Controls.Add(this.button1);
            this.Name = "Main_UI";
            this.Load += new System.EventHandler(this.Main_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userSettingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PlayMelody;
        private System.Windows.Forms.Label ui_songTitle;
        private System.Windows.Forms.Label ui_noteInd;
        private System.Windows.Forms.RadioButton ui_radioAbove;
        private System.Windows.Forms.RadioButton ui_radioSame;
        private System.Windows.Forms.RadioButton ui_radioBelow;
        private System.Windows.Forms.Button ui_submit;
        private System.Windows.Forms.Label ui_feedback;
        private System.Windows.Forms.Label ui_score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource userSettingsBindingSource;
        private System.Windows.Forms.BindingSource userDataBindingSource;
        private System.Windows.Forms.ListBox ui_userNames;
        private System.Windows.Forms.Button ui_addUser;
        private System.Windows.Forms.TextBox ui_newUsername;
        private System.Windows.Forms.Button ui_RemoveUser;
        private System.Windows.Forms.TextBox ui_RemoveUsername;
        private System.Windows.Forms.TextBox ui_ActiveUsername;
        private System.Windows.Forms.Button ui_SetActiveUser;
    }
}

