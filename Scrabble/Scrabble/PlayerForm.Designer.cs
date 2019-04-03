using System.Windows.Forms;

namespace Scrabble
{
    partial class PlayerForm
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 131);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(174, 46);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 180);
            this.Controls.Add(this.buttonSave);
            this.Name = "PlayerForm";
            this.Text = "Player";
            this.ResumeLayout(false);

        }

        private void ScoreForm()
        {
            this.buttonToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonToMenu
            // 
            this.buttonToMenu.Location = new System.Drawing.Point(524, 22);
            this.buttonToMenu.Name = "buttonToMenu";
            this.buttonToMenu.Size = new System.Drawing.Size(248, 60);
            this.buttonToMenu.TabIndex = 1;
            this.buttonToMenu.Text = "Back to menu";
            this.buttonToMenu.UseVisualStyleBackColor = true;
            this.buttonToMenu.Click += new System.EventHandler(this.buttonToMenu_Click);
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonToMenu);
            this.Name = "ScoreForm";
            this.Text = "HighScore";
            this.ResumeLayout(false);
        }

        private void MainForm() {
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonRules = new System.Windows.Forms.Button();
            this.buttonScore = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(48, 104);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(269, 57);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonRules
            // 
            this.buttonRules.Location = new System.Drawing.Point(48, 189);
            this.buttonRules.Name = "buttonRules";
            this.buttonRules.Size = new System.Drawing.Size(269, 57);
            this.buttonRules.TabIndex = 1;
            this.buttonRules.Text = "Rules";
            this.buttonRules.UseVisualStyleBackColor = true;
            this.buttonRules.Click += new System.EventHandler(this.buttonRules_Click);
            // 
            // buttonScore
            // 
            this.buttonScore.Location = new System.Drawing.Point(48, 270);
            this.buttonScore.Name = "buttonScore";
            this.buttonScore.Size = new System.Drawing.Size(269, 57);
            this.buttonScore.TabIndex = 2;
            this.buttonScore.Text = "Score";
            this.buttonScore.UseVisualStyleBackColor = true;
            this.buttonScore.Click += new System.EventHandler(this.buttonScore_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(48, 361);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(269, 57);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonScore);
            this.Controls.Add(this.buttonRules);
            this.Controls.Add(this.buttonPlay);
            this.Name = "MainForm";
            this.Text = "Menu";
            this.ResumeLayout(false);
        }
        #endregion

        private void DeleteComponent()
        {
            while (this.Controls.Count > 0)
            {
                this.Controls.RemoveAt(0);
            }
        }

        private System.Windows.Forms.Button buttonSave;
        private Button buttonToMenu;
        private Button buttonPlay;
        private Button buttonRules;
        private Button buttonScore;
        private Button buttonExit;
    }
}