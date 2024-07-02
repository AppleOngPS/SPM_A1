using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class freeGameMode : Form
    {
        public freeGameMode()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void freeGameMode_Load(object sender, EventArgs e)
        {

        }

        private void X6Y3_Click(object sender, EventArgs e)
        {

        }

        private void X13Y6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameInstructionForFreePlay gameInstructionForFreePlay = new gameInstructionForFreePlay();
            gameInstructionForFreePlay.Show();

        }
    }
}
