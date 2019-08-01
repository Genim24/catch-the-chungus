﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catch_the_chungus
{
    public partial class FrmAlien : Form
    {
        Rectangle alienRec = new Rectangle(0, 0, 65, 80);
        Image alien = Image.FromFile(Application.StartupPath + @"\alien.png");
        Graphics g;
        Random rand = new Random();
        int score = 20;
        int speed;

        public FrmAlien()
        {
            InitializeComponent();
        }

        private void FrmAlien_Load(object sender, EventArgs e)
        {

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;// sets g to the Graphics object supplied in the PaintEventArgs
            //set the x and y positions of alienRec
            alienRec.X = rand.Next(240);
            alienRec.Y = rand.Next(240);
            //draw the alien image randomly on the panel
            g.DrawImage(alien, alienRec);

        }

        private void TmrAlien_Tick(object sender, EventArgs e)
        {
            PnlGame.Invalidate();
        }

        private void FrmAlien_MouseDown(object sender, MouseEventArgs e)
        {
            int diffX = e.X - alienRec.X;
            int diffY = e.Y - alienRec.Y;
            double length = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
            if (length < 70)
            {
                score++;//add 1 to the score
                LblScore.Text = score.ToString();// display the score
            }

        }
    }
}
