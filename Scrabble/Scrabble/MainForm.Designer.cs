using Scrabble.Properties;
using System;
using System.Drawing;
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
            this.ClientSize = new System.Drawing.Size(1054, 571);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonToMenu);
            this.Name = "PlayForm";
            this.Text = "Play";
            this.ResumeLayout(false);
        }

        private void RulesForm()
        {
            this.pictureBoxBackToMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackToMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBackToMenu
            // 
            this.pictureBoxBackToMenu.Image = BackToMenu;
            this.pictureBoxBackToMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxBackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBackToMenu.Location = new System.Drawing.Point(720, 450);
            this.pictureBoxBackToMenu.Name = "pictureBoxBackToMenu";
            this.pictureBoxBackToMenu.Size = new System.Drawing.Size(348, 147);
            this.pictureBoxBackToMenu.TabIndex = 0;
            this.pictureBoxBackToMenu.TabStop = false;
            this.pictureBoxBackToMenu.Click += new System.EventHandler(this.buttonToMenu_Click);
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 571);
            this.Controls.Add(this.pictureBoxBackToMenu);
            this.Name = "RulesForm";
            this.Text = "Rules";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackToMenu)).EndInit();
            this.ResumeLayout(false);
        }

        private void ScoreForm()
        {
            this.pictureBoxBackToMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackToMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBackToMenu
            // 
            this.pictureBoxBackToMenu.Image = BackToMenu;
            this.pictureBoxBackToMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxBackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBackToMenu.Location = new System.Drawing.Point(720, 450);
            this.pictureBoxBackToMenu.Name = "pictureBoxBackToMenu";
            this.pictureBoxBackToMenu.Size = new System.Drawing.Size(348, 147);
            this.pictureBoxBackToMenu.TabIndex = 0;
            this.pictureBoxBackToMenu.TabStop = false;
            this.pictureBoxBackToMenu.Click += new System.EventHandler(this.buttonToMenu_Click);
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 571);
            this.Controls.Add(this.pictureBoxBackToMenu);
            this.Name = "ScoreForm";
            this.Text = "HighScore";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackToMenu)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScore)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = Exit;
            this.pictureBoxExit.SizeMode = PictureBoxSizeMode.StretchImage;
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
            this.pictureBoxStart.Image = Start;
            this.pictureBoxStart.SizeMode = PictureBoxSizeMode.StretchImage;
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
            this.pictureBoxRules.Image = Rules;
            this.pictureBoxRules.SizeMode = PictureBoxSizeMode.StretchImage;
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
            this.pictureBoxScore.Image = Score;
            this.pictureBoxScore.SizeMode = PictureBoxSizeMode.StretchImage;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Scrabble.Properties.Resources.backgroundMenuNew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 571);
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

        private Button buttonToMenu;
        private Button buttonChange;
        private Button buttonHelp;
        private PictureBox pictureBoxExit;
        private PictureBox pictureBoxStart;
        private PictureBox pictureBoxRules;
        private PictureBox pictureBoxScore;
        private PictureBox pictureBoxBackToMenu;
        Image Exit = Resources.ExitButton;
        Image Start = Resources.StartButton;
        Image Rules = Resources.RulesButton;
        Image Score = Resources.ScoreButton;
        Image BackToMenu = Resources.BackToMenuButton;
    }
}

