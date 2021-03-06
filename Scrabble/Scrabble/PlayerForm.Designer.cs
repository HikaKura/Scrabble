﻿using Scrabble.Properties;
using System.Drawing;
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
            this.pictureBoxSave = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSave
            // 
            this.pictureBoxSave.Image = Save;
            this.pictureBoxSave.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxSave.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSave.Location = new System.Drawing.Point(-30, 130);
            this.pictureBoxSave.Name = "pictureBoxChange";
            this.pictureBoxSave.Size = new System.Drawing.Size(180, 80);
            this.pictureBoxSave.TabIndex = 0;
            this.pictureBoxSave.TabStop = false;
            this.pictureBoxSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(30, 68);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(325, 57);
            this.textBox.TabIndex = 1;
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Scrabble.Properties.Resources.PlayerForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(422, 200);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.pictureBoxSave);
            this.Name = "PlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        private PictureBox pictureBoxSave;
        private System.Windows.Forms.Button buttonSave;
        private Button buttonToMenu;
        private Button buttonPlay;
        private Button buttonRules;
        private Button buttonScore;
        private Button buttonExit;
        private TextBox textBox;
        Image Save = Resources.SaveButton;
    }
}