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
    }
}
