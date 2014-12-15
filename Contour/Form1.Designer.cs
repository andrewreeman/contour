namespace Contour
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.PlayMelody = new System.Windows.Forms.Button();
            this.ui_songTitle = new System.Windows.Forms.Label();
            this.ui_direction = new System.Windows.Forms.Label();
            this.ui_noteInd = new System.Windows.Forms.Label();
            this.ui_radioAbove = new System.Windows.Forms.RadioButton();
            this.ui_radioSame = new System.Windows.Forms.RadioButton();
            this.ui_radioBelow = new System.Windows.Forms.RadioButton();
            this.ui_submit = new System.Windows.Forms.Button();
            this.ui_feedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayMelody
            // 
            this.PlayMelody.Location = new System.Drawing.Point(378, 91);
            this.PlayMelody.Name = "PlayMelody";
            this.PlayMelody.Size = new System.Drawing.Size(75, 23);
            this.PlayMelody.TabIndex = 2;
            this.PlayMelody.Text = "Play Melody";
            this.PlayMelody.UseVisualStyleBackColor = true;
            this.PlayMelody.Click += new System.EventHandler(this.PlayMelody_Click);
            // 
            // ui_songTitle
            // 
            this.ui_songTitle.AutoSize = true;
            this.ui_songTitle.Location = new System.Drawing.Point(254, 119);
            this.ui_songTitle.Name = "ui_songTitle";
            this.ui_songTitle.Size = new System.Drawing.Size(30, 13);
            this.ui_songTitle.TabIndex = 3;
            this.ui_songTitle.Text = "song";
            // 
            // ui_direction
            // 
            this.ui_direction.AutoSize = true;
            this.ui_direction.Location = new System.Drawing.Point(253, 28);
            this.ui_direction.Name = "ui_direction";
            this.ui_direction.Size = new System.Drawing.Size(47, 13);
            this.ui_direction.TabIndex = 4;
            this.ui_direction.Text = "direction";
            // 
            // ui_noteInd
            // 
            this.ui_noteInd.AutoSize = true;
            this.ui_noteInd.Location = new System.Drawing.Point(190, 28);
            this.ui_noteInd.Name = "ui_noteInd";
            this.ui_noteInd.Size = new System.Drawing.Size(56, 13);
            this.ui_noteInd.TabIndex = 5;
            this.ui_noteInd.Text = "note index";
            // 
            // ui_radioAbove
            // 
            this.ui_radioAbove.AutoSize = true;
            this.ui_radioAbove.Location = new System.Drawing.Point(578, 115);
            this.ui_radioAbove.Name = "ui_radioAbove";
            this.ui_radioAbove.Size = new System.Drawing.Size(56, 17);
            this.ui_radioAbove.TabIndex = 6;
            this.ui_radioAbove.TabStop = true;
            this.ui_radioAbove.Text = "Above";
            this.ui_radioAbove.UseVisualStyleBackColor = true;
            this.ui_radioAbove.CheckedChanged += new System.EventHandler(this.ui_radioAbove_CheckedChanged);
            // 
            // ui_radioSame
            // 
            this.ui_radioSame.AutoSize = true;
            this.ui_radioSame.Location = new System.Drawing.Point(578, 138);
            this.ui_radioSame.Name = "ui_radioSame";
            this.ui_radioSame.Size = new System.Drawing.Size(52, 17);
            this.ui_radioSame.TabIndex = 7;
            this.ui_radioSame.TabStop = true;
            this.ui_radioSame.Text = "Same";
            this.ui_radioSame.UseVisualStyleBackColor = true;
            this.ui_radioSame.CheckedChanged += new System.EventHandler(this.ui_radioSame_CheckedChanged);
            // 
            // ui_radioBelow
            // 
            this.ui_radioBelow.AutoSize = true;
            this.ui_radioBelow.Location = new System.Drawing.Point(578, 161);
            this.ui_radioBelow.Name = "ui_radioBelow";
            this.ui_radioBelow.Size = new System.Drawing.Size(54, 17);
            this.ui_radioBelow.TabIndex = 8;
            this.ui_radioBelow.TabStop = true;
            this.ui_radioBelow.Text = "Below";
            this.ui_radioBelow.UseVisualStyleBackColor = true;
            this.ui_radioBelow.CheckedChanged += new System.EventHandler(this.ui_radioBelow_CheckedChanged);
            // 
            // ui_submit
            // 
            this.ui_submit.Location = new System.Drawing.Point(578, 194);
            this.ui_submit.Name = "ui_submit";
            this.ui_submit.Size = new System.Drawing.Size(75, 23);
            this.ui_submit.TabIndex = 9;
            this.ui_submit.Text = "Submit!";
            this.ui_submit.UseVisualStyleBackColor = true;
            this.ui_submit.Click += new System.EventHandler(this.ui_submit_Click);
            // 
            // ui_feedback
            // 
            this.ui_feedback.AutoSize = true;
            this.ui_feedback.Location = new System.Drawing.Point(578, 224);
            this.ui_feedback.Name = "ui_feedback";
            this.ui_feedback.Size = new System.Drawing.Size(52, 13);
            this.ui_feedback.TabIndex = 10;
            this.ui_feedback.Text = "feedback";
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 262);
            this.Controls.Add(this.ui_feedback);
            this.Controls.Add(this.ui_submit);
            this.Controls.Add(this.ui_radioBelow);
            this.Controls.Add(this.ui_radioSame);
            this.Controls.Add(this.ui_radioAbove);
            this.Controls.Add(this.ui_noteInd);
            this.Controls.Add(this.ui_direction);
            this.Controls.Add(this.ui_songTitle);
            this.Controls.Add(this.PlayMelody);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PlayMelody;
        private System.Windows.Forms.Label ui_songTitle;
        private System.Windows.Forms.Label ui_direction;
        private System.Windows.Forms.Label ui_noteInd;
        private System.Windows.Forms.RadioButton ui_radioAbove;
        private System.Windows.Forms.RadioButton ui_radioSame;
        private System.Windows.Forms.RadioButton ui_radioBelow;
        private System.Windows.Forms.Button ui_submit;
        private System.Windows.Forms.Label ui_feedback;
    }
}

