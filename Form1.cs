using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            presently();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void hide()
        {
            panel4.Visible = false;
        }

        private void presently()
        {
            if (panel4.Visible == false)
            {
                panel4.Visible = true;
            }
        }

        private void icbtnmusic_Click(object sender, EventArgs e)
        {

        }
    }
}
