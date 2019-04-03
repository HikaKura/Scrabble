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

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonRules;
        private System.Windows.Forms.Button buttonScore;
        private System.Windows.Forms.Button buttonExit;
        private Button buttonToMenu;
        private Button buttonChange;
        private Button buttonHelp;
    }
}

