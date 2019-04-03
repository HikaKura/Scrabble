using System;
using System.Windows.Forms;

namespace Scrabble
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void PlayForm()
        {
            this.buttonToMenu = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonToMenu
            // 
            this.buttonToMenu.Location = new System.Drawing.Point(724, 387);
            this.buttonToMenu.Name = "buttonToMenu";
            this.buttonToMenu.Size = new System.Drawing.Size(74, 60);
            this.buttonToMenu.TabIndex = 1;
            this.buttonToMenu.Text = "Back to menu";
            this.buttonToMenu.UseVisualStyleBackColor = true;
            this.buttonToMenu.Click += new System.EventHandler(this.buttonToMenu_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(564, 387);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(74, 60);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(644, 387);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(74, 60);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonToMenu);
            this.Name = "PlayForm";
            this.Text = "Play";
            this.ResumeLayout(false);
        }

        private void RulesForm()
        {
            this.buttonToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonToMenu
            // 
            this.buttonToMenu.Location = new System.Drawing.Point(517, 5);
            this.buttonToMenu.Name = "buttonToMenu";
            this.buttonToMenu.Size = new System.Drawing.Size(248, 60);
            this.buttonToMenu.TabIndex = 0;
            this.buttonToMenu.Text = "Back to menu";
            this.buttonToMenu.UseVisualStyleBackColor = true;
            this.buttonToMenu.Click += new System.EventHandler(this.buttonToMenu_Click);
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonToMenu);
            this.Name = "RulesForm";
            this.Text = "Rules";
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.pictureBoxRules = new System.Windows.Forms.PictureBox();
            this.pictureBoxScore = new System.Windows.Forms.PictureBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonRules = new System.Windows.Forms.Button();
            this.buttonScore = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScore)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Location = new System.Drawing.Point(0, 428);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(348, 147);
            this.pictureBoxExit.TabIndex = 0;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxStart.Location = new System.Drawing.Point(620, 137);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(433, 148);
            this.pictureBoxStart.TabIndex = 1;
            this.pictureBoxStart.TabStop = false;
            this.pictureBoxStart.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // pictureBoxRules
            // 
            this.pictureBoxRules.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxRules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRules.Location = new System.Drawing.Point(620, 291);
            this.pictureBoxRules.Name = "pictureBoxRules";
            this.pictureBoxRules.Size = new System.Drawing.Size(433, 131);
            this.pictureBoxRules.TabIndex = 2;
            this.pictureBoxRules.TabStop = false;
            this.pictureBoxRules.Click += new System.EventHandler(this.buttonRules_Click);
            // 
            // pictureBoxScore
            // 
            this.pictureBoxScore.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxScore.Location = new System.Drawing.Point(620, 428);
            this.pictureBoxScore.Name = "pictureBoxScore";
            this.pictureBoxScore.Size = new System.Drawing.Size(433, 131);
            this.pictureBoxScore.TabIndex = 3;
            this.pictureBoxScore.TabStop = false;
            this.pictureBoxScore.Click += new System.EventHandler(this.buttonScore_Click);
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
            this.buttonExit.Location = new System.Drawing.Point(0, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Scrabble.Properties.Resources.backgroundMenuNew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 571);
            //this.Controls.Add(this.buttonExit);
            //this.Controls.Add(this.buttonScore);
            //this.Controls.Add(this.buttonRules);
            //this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.pictureBoxScore);
            this.Controls.Add(this.pictureBoxRules);
            this.Controls.Add(this.pictureBoxStart);
            this.Controls.Add(this.pictureBoxExit);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScore)).EndInit();
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

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonRules;
        private System.Windows.Forms.Button buttonScore;
        private System.Windows.Forms.Button buttonExit;
        private Button buttonToMenu;
        private Button buttonChange;
        private Button buttonHelp;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private PictureBox pictureBoxStart;
        private PictureBox pictureBoxRules;
        private PictureBox pictureBoxScore;
    }
}

