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
    public partial class ChooseMode : Form
    {
        public ChooseMode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameInstructionForArcadeMode gameInstructionForArcadeMode = new gameInstructionForArcadeMode();
            gameInstructionForArcadeMode.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameInstructionForFreePlay gameInstructionForFreePlay = new gameInstructionForFreePlay();
            gameInstructionForFreePlay.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
