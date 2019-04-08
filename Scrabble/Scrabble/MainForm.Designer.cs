using Scrabble.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Scrabble
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Random rnd = new Random();
        private Random rand = new Random();
       


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
            char tmp = (char)rand.Next('A', 'Z' + 1);
            int let = 0;
            this.pictureBoxChange = new System.Windows.Forms.PictureBox();
            this.pictureBoxHelp = new System.Windows.Forms.PictureBox();
            this.pictureBoxField = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.Label();
            this.record = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList();
            this.timer = new System.Windows.Forms.Timer();
            this.letter1 = new System.Windows.Forms.PictureBox();
            this.letter2 = new System.Windows.Forms.PictureBox();
            this.letter3 = new System.Windows.Forms.PictureBox();
            this.letter4 = new System.Windows.Forms.PictureBox();
            this.letter5 = new System.Windows.Forms.PictureBox();
            this.letter6 = new System.Windows.Forms.PictureBox();
            this.letter7 = new System.Windows.Forms.PictureBox();
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.AddRange(new Image[] { A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z });

            PoleButtons.pb.SetImages(imageList);
            PoleButtons.pb.CreateButtons();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letter3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letter4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letter5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letter6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letter7)).BeginInit();
            PoleButtons.pb.StartInit();
            this.SuspendLayout();
            PoleButtons.pb.Init();
            // 
            // letter1
            // 
            let = rnd.Next(0, imageList.Images.Count);
            this.letter1.Image = imageList.Images[let];
            this.letter1.MouseDown += (object sender, MouseEventArgs e) =>
            {
                DoDragDrop('x', DragDropEffects.Move | DragDropEffects.Copy);
            };
            this.letter1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.letter1.BackColor = System.Drawing.Color.Transparent;
            this.letter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.letter1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letter1.Location = new System.Drawing.Point(800, 130);
            this.letter1.Name = "letter1";
            this.letter1.Size = new System.Drawing.Size(50, 50);
            this.letter1.Text = let.ToString();
            this.letter1.TabIndex = 0;
            this.letter1.TabStop = false;
            // 
            // letter2
            // 
            let = rnd.Next(0, imageList.Images.Count);
            this.letter2.Image = imageList.Images[let]; 
            this.letter2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.letter2.BackColor = System.Drawing.Color.Transparent;
            this.letter2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.letter2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letter2.Location = new System.Drawing.Point(900, 130);
            this.letter2.Name = "letter2";
            this.letter2.Size = new System.Drawing.Size(50, 50);
            this.letter2.Text = let.ToString();
            this.letter2.TabIndex = 0;
            this.letter2.TabStop = false;
            // 
            // letter3
            //
            let = rnd.Next(0, imageList.Images.Count);
            this.letter3.Image = imageList.Images[let]; 
            this.letter3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.letter3.BackColor = System.Drawing.Color.Transparent;
            this.letter3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.letter3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letter3.Location = new System.Drawing.Point(800, 200);
            this.letter3.Name = "letter3";
            this.letter3.Size = new System.Drawing.Size(50, 50);
            this.letter3.Text = let.ToString();
            this.letter3.TabIndex = 0;
            this.letter3.TabStop = false;
            // 
            // letter4
            // 
            let = rnd.Next(0, imageList.Images.Count);
            this.letter4.Image = imageList.Images[let]; 
            this.letter4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.letter4.BackColor = System.Drawing.Color.Transparent;
            this.letter4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.letter4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letter4.Location = new System.Drawing.Point(900, 200);
            this.letter4.Name = "letter4";
            this.letter4.Size = new System.Drawing.Size(50, 50);
            this.letter4.Text = let.ToString();
            this.letter4.TabIndex = 0;
            this.letter4.TabStop = false;
            // 
            // letter5
            // 
            let = rnd.Next(0, imageList.Images.Count);
            this.letter5.Image = imageList.Images[let]; 
            this.letter5.SizeMode = PictureBoxSizeMode.StretchImage;
            this.letter5.BackColor = System.Drawing.Color.Transparent;
            this.letter5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.letter5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letter5.Location = new System.Drawing.Point(800, 270);
            this.letter5.Name = "letter5";
            this.letter5.Size = new System.Drawing.Size(50, 50);
            this.letter5.Text = let.ToString();
            this.letter5.TabIndex = 0;
            this.letter5.TabStop = false;
            // 
            // letter6
            // 
            let = rnd.Next(0, imageList.Images.Count);
            this.letter6.Image = imageList.Images[let]; 
            this.letter6.SizeMode = PictureBoxSizeMode.StretchImage;
            this.letter6.BackColor = System.Drawing.Color.Transparent;
            this.letter6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.letter6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letter6.Location = new System.Drawing.Point(900, 270);
            this.letter6.Name = "letter6";
            this.letter6.Size = new System.Drawing.Size(50, 50);
            this.letter6.Text = let.ToString();
            this.letter6.TabIndex = 0;
            this.letter6.TabStop = false;
            // 
            // letter7
            // 
            let = rnd.Next(0, imageList.Images.Count);
            this.letter7.Image = imageList.Images[let]; 
            this.letter7.SizeMode = PictureBoxSizeMode.StretchImage;
            this.letter7.BackColor = System.Drawing.Color.Transparent;
            this.letter7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.letter7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letter7.Location = new System.Drawing.Point(800, 340);
            this.letter7.Name = "letter7";
            this.letter7.Size = new System.Drawing.Size(50, 50);
            this.letter7.Text = let.ToString();
            this.letter7.TabIndex = 0;
            this.letter7.TabStop = false;
            // 
            // pictureBoxChange
            // 
            this.pictureBoxChange.Image = Change;
            this.pictureBoxChange.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxChange.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxChange.Location = new System.Drawing.Point(810, 450);
            this.pictureBoxChange.Name = "pictureBoxChange";
            this.pictureBoxChange.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxChange.TabIndex = 0;
            this.pictureBoxChange.TabStop = false;
            this.pictureBoxChange.Click += new System.EventHandler(this.buttonToMenu_Click);
            // 
            // pictureBoxHelp
            // 
            this.pictureBoxHelp.Image = Help;
            this.pictureBoxHelp.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxHelp.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHelp.Location = new System.Drawing.Point(673, 450);
            this.pictureBoxHelp.Name = "pictureBoxHelp";
            this.pictureBoxHelp.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxHelp.TabIndex = 1;
            this.pictureBoxHelp.TabStop = false;
            this.pictureBoxHelp.Click += new System.EventHandler(this.buttonPlayer_Click);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = Back;
            this.pictureBoxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Location = new System.Drawing.Point(943, 450);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxBack.TabIndex = 1;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.buttonToMenu_Click);
            // 
            // pictureBoxField
            // 
            this.pictureBoxField.Image = Field;
            this.pictureBoxField.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxField.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxField.Location = new System.Drawing.Point(40, 65);
            this.pictureBoxField.Name = "pictureBoxField";
            this.pictureBoxField.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxField.TabIndex = 2;
            this.pictureBoxField.TabStop = false; 
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            System.Drawing.Text.PrivateFontCollection f = new System.Drawing.Text.PrivateFontCollection();
            string path = Environment.CurrentDirectory + "\\operational_amplifier.ttf";
            //C:\\Users\\kimab\\source\\repos\\Scrabble\\Scrabble\\Scrabble\\Resources
            f.AddFontFile(path);
            this.time.Font = new Font(f.Families[0], 35F);
            this.time.ForeColor = Color.White;
            this.time.Location = new System.Drawing.Point(880,5);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(104, 39);
            this.time.TabIndex = 5;
            this.time.Text = "timer";
            // 
            // labelrecord
            // 
            this.record.AutoSize = true;
            this.record.BackColor = System.Drawing.Color.Transparent;
            this.record.Font = new Font(f.Families[0], 35F);
            this.record.ForeColor = Color.White;
            this.record.Location = new System.Drawing.Point(600, 7);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(104, 39);
            this.record.TabIndex = 5;
            //this.record.Text = tmp.ToString();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Scrabble.Properties.Resources.backgroundPlay;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 571);
            PoleButtons.pb.AddToControls(this.Controls);
            this.Controls.Add(this.pictureBoxChange);
            this.Controls.Add(this.pictureBoxHelp);
            //this.Controls.Add(this.pictureBoxField);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.letter1);
            this.Controls.Add(this.letter2);
            this.Controls.Add(this.letter3);
            this.Controls.Add(this.letter4);
            this.Controls.Add(this.letter5);
            this.Controls.Add(this.letter6);
            this.Controls.Add(this.letter7);
            this.Controls.Add(this.time);
            this.Controls.Add(this.record);
            this.Name = "PlayForm";
            this.Text = "Play";
            PoleButtons.pb.EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letter3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letter4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letter5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letter6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letter7)).EndInit();
            this.ResumeLayout(false);
        }

        private void RulesForm()
        {
            this.pictureBoxBackToMenu = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightPage = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeftPage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackToMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftPage)).BeginInit();
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
            // pictureBoxRightPage
            // 
            this.pictureBoxRightPage.Image = RightPage;
            this.pictureBoxRightPage.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxRightPage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRightPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxRightPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRightPage.Location = new System.Drawing.Point(270, 490);
            this.pictureBoxRightPage.Name = "pictureBoxRightPage";
            this.pictureBoxRightPage.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxRightPage.TabIndex = 0;
            this.pictureBoxRightPage.TabStop = false;
            this.pictureBoxRightPage.Click += new System.EventHandler(this.buttonRightPage_Click);
            // 
            // pictureBoxLeftPage
            // 
            this.pictureBoxLeftPage.Image = LeftPage;
            this.pictureBoxLeftPage.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxLeftPage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLeftPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLeftPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLeftPage.Location = new System.Drawing.Point(-5, 490);
            this.pictureBoxLeftPage.Name = "pictureBoxLeftPage";
            this.pictureBoxLeftPage.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxLeftPage.TabIndex = 0;
            this.pictureBoxLeftPage.TabStop = false;
            this.pictureBoxLeftPage.Click += new System.EventHandler(this.buttonLeftPage_Click);
            OnePage();
            this.Controls.Add(this.pictureBoxBackToMenu);
            this.Controls.Add(this.pictureBoxRightPage);
            this.Controls.Add(this.pictureBoxLeftPage);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackToMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftPage)).EndInit();
            this.ResumeLayout(false);
        }

        private void OnePage()
        {
            // 
            // RulesFormOnePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Scrabble.Properties.Resources.RulesOnePage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 571);
            this.Name = "OnePage";
            this.Text = "Rules";
        }

        private void TwoPage()
        {
            // 
            // RulesFormTwoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Scrabble.Properties.Resources.RulesTwoPage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 571);
            this.Name = "TwoPage";
            this.Text = "Rules";
        }

        private void ThreePage()
        {
            // 
            // RulesFormThreePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Scrabble.Properties.Resources.RulesThreePage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 571);
            this.Name = "ThreePage";
            this.Text = "Rules";
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
            //score
            //
            string path = Environment.CurrentDirectory + "\\Score.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                int count = 1;
                int sdvig = 0;
                string line = "";
                while (!sr.EndOfStream && count <= 5)
                {
                    line = sr.ReadLine();
                    string strlabel = "label" + count;
                    // 
                    // strlabel
                    // 
                    this.strlabel = new System.Windows.Forms.Label();
                    this.strlabel.AutoSize = true;
                    this.strlabel.BackColor = System.Drawing.Color.Transparent;
                    this.strlabel.Font = new System.Drawing.Font("Haettenschweiler", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    this.strlabel.Location = new System.Drawing.Point(135, 95 + sdvig);
                    this.strlabel.Name = "label1";
                    this.strlabel.Size = new System.Drawing.Size(109, 39);
                    this.strlabel.TabIndex = 5;
                    this.strlabel.Text = line;
                    this.Controls.Add(this.strlabel);
                    count++;
                    sdvig += 72;
                }
            }
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Scrabble.Properties.Resources.ScoreForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            page = 1;
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
            this.Visible = false;
            this.Controls.Clear();
            this.Visible = true;

            /*
            while (this.Controls.Count > 0)
            {
                this.Controls.RemoveAt(0);
            }
            */
        }

        private PictureBox pictureBoxExit;
        private PictureBox pictureBoxStart;
        private PictureBox pictureBoxRules;
        private PictureBox pictureBoxScore;
        private PictureBox pictureBoxBackToMenu;
        private System.Windows.Forms.Timer timer;
        private PictureBox letter1;
        private PictureBox letter2;
        private PictureBox letter3;
        private PictureBox letter4;
        private PictureBox letter5;
        private PictureBox letter6;
        private PictureBox letter7;
        private Label strlabel;
        Image Exit = Resources.ExitButton;
        Image Start = Resources.StartButton;
        Image Rules = Resources.RulesButton;
        Image Score = Resources.ScoreButton;
        Image BackToMenu = Resources.BackToMenuButton;
        Image Change = Resources.Change;
        Image Help = Resources.Help;
        Image Back = Resources.Back;
        Image Field = Resources.Field;
        Image RightPage = Resources.right;
        Image LeftPage = Resources.left;
        private PictureBox pictureBoxChange;
        private PictureBox pictureBoxHelp;
        private PictureBox pictureBoxField;
        private PictureBox pictureBoxBack;
        private Label time;
        public Label record;
        private ImageList imageList;
        private PictureBox pictureBoxRightPage;
        private PictureBox pictureBoxLeftPage;
        private int page = 1;
        Image A = Resources.A;
        Image B = Resources.B;
        Image C = Resources.C;
        Image D = Resources.D;
        Image E = Resources.E;
        Image F = Resources.F;
        Image G = Resources.G;
        Image H = Resources.H;
        Image I = Resources.I;
        Image J = Resources.J;
        Image K = Resources.K;
        Image L = Resources.L;
        Image M = Resources.M;
        Image N = Resources.N;
        Image O = Resources.O;
        Image P = Resources.P;
        Image Q = Resources.Q;
        Image R = Resources.R;
        Image S = Resources.S;
        Image T = Resources.T;
        Image U = Resources.U;
        Image V = Resources.V;
        Image W = Resources.W;
        Image X = Resources.X;
        Image Y = Resources.Y;
        Image Z = Resources.Z;
    }
}

