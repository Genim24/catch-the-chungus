using System;
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
        Rectangle alienRec = new Rectangle(0, 0, 50, 65);
        Image alien = Image.FromFile(Application.StartupPath + @"\alien.png");
        Graphics g;

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
            alienRec.X = 30;
            alienRec.Y = 60;
            //draw the alien image in the alien rectangle at (30,60)
            //remember: 30 is 30 to the right and 60 means 60 DOWN
            g.DrawImage(alien, alienRec);

        }
    }
}
