using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrabble
{
    class PoleButtons
    {
        public static PoleButtons pb = new PoleButtons();
        private System.Windows.Forms.PictureBox[,] Letters;
        private Panel[,] Panels;
        private bool[,] Selects;
        private static Random rnd = new Random();
        private ImageList Images;
        private bool[] isPickedLetter;
        private PictureBox[] LettersPool;
        private PoleButtons()
        {
            Letters = new System.Windows.Forms.PictureBox[15, 15];
            Panels = new Panel[15, 15];
            Selects = new bool[15, 15];
            isPickedLetter = new bool[7];
            LettersPool = new PictureBox[7];
        }
        
        public void AddButtons(PictureBox a0, PictureBox a1, PictureBox a2, PictureBox a3, PictureBox a4, PictureBox a5, PictureBox a6)
        {
            LettersPool[0] = a0;
            LettersPool[1] = a1;
            LettersPool[2] = a2;
            LettersPool[3] = a3;
            LettersPool[4] = a4;
            LettersPool[5] = a5;
            LettersPool[6] = a6;
            Game.game.UpdateButtons();
        }

        public void DragDropDelete(object sender, DragEventArgs e)
        {
            
        }
        
        public void UpdateButtons(char[] letters)
        {
            for (int i = 0; i < 7; i++)
            {
                LettersPool[i].Image = Images.Images[letters[i] - 'a'];
                int num = i;
                LettersPool[i].MouseDown += (object sender, MouseEventArgs e) =>
                {
                    LettersPool[num].Parent.DoDragDrop(letters[num], DragDropEffects.Move | DragDropEffects.Copy);
                };
            }
        }
        public void SetImages(ImageList imageLetters)
        {
            Images = imageLetters;
        }

        public void CreateButtons()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Letters[i, j] = new System.Windows.Forms.PictureBox();
                    Panels[i, j] = new Panel();
                }
            }
            for(int i = 0; i < 7; i++)
            {
                isPickedLetter[i] = false;
            }
        }

        public void StartInit()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    ((System.ComponentModel.ISupportInitialize)(Letters[i, j])).BeginInit();
                }
            }
        }

        public void Init()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    GC.KeepAlive(Letters[i, j]);
                    GC.KeepAlive(Panels[i, j]);
                    Letters[i, j].Image = null; // Images.Images[(rnd.Next() % 26)];
                    Letters[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    Letters[i, j].BackColor = System.Drawing.Color.Transparent;
                    Letters[i, j].BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                    Letters[i, j].Cursor = System.Windows.Forms.Cursors.Hand;
                    //Letters[i, j].Location = new System.Drawing.Point((int)(61 + i * 31.25), (int)(88 + j * 31.85));
                    Letters[i, j].Location = new System.Drawing.Point(0, 0);
                    Letters[i, j].Name = "pictureBoxField";
                    Letters[i, j].Size = new System.Drawing.Size(25, 25);
                    Letters[i, j].TabIndex = 2;
                    Letters[i, j].TabStop = false;
                    int w = i;
                    int h = j;
                    Letters[i, j].Click += (object Sender, EventArgs e) =>
                    {
                        ClickLetter(w, h);
                    };
                    Panels[i, j].Controls.Add(Letters[i,j]);
                    Panels[i, j].AllowDrop = true;
                    Panels[i, j].Location = new System.Drawing.Point((int)(61 + i * 31.25), (int)(88 + j * 31.85));
                    Panels[i, j].Size = new System.Drawing.Size(25, 25);
                    Panels[i, j].DragDrop += (object Sender, DragEventArgs e) =>
                    {
                        char s = (char)e.Data.GetData(e.Data.GetFormats()[0], true);
                        Game.game.PlaceLetter(w, h, s);
                        Letters[w, h].Image = Images.Images[(int)(s - 'a')];
                    };
                    Panels[i, j].DragEnter += (object sender, DragEventArgs e) =>
                    {
                        e.Effect = DragDropEffects.Copy;
                    };
                }
            }
        }

        private void PoleButtons_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void AddToControls(Control.ControlCollection control)
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    control.Add(Panels[i, j]);
                }
            }

        }

        public void EndInit()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    ((System.ComponentModel.ISupportInitialize)(Letters[i, j])).EndInit();
                }
            }
        }
        
        public void ClickLetter(int w, int h)
        {
            if (Game.game.SelectLetter(w, h))
            {
                if (Selects[w, h])
                {
                    Selects[w, h] = false;
                    Rectangle rect = Panels[w, h].Bounds;
                    rect.Inflate(3, 3);
                    Letters[w, h].Parent.Parent.Invalidate(rect);
                }
                else
                {
                    Selects[w, h] = true;
                    using (Graphics g = Letters[w, h].Parent.Parent.CreateGraphics())
                    {
                        g.DrawRectangle(new Pen(Color.Yellow, 5), Panels[w, h].Bounds);
                    }
                }
            }
        }

        public void ClearLetter(int w, int h)
        {
            Selects[w, h] = false;
            Rectangle rect = Panels[w, h].Bounds;
            rect.Inflate(3, 3);
            Letters[w, h].Parent.Parent.Invalidate(rect);
        }
    }
}
