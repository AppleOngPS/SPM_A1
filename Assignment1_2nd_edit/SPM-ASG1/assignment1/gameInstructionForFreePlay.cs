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
    public partial class gameInstructionForFreePlay : Form
    {
        public gameInstructionForFreePlay()
        {
            InitializeComponent();
        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            freeGameMode freeGameMode = new freeGameMode();
            freeGameMode.Show();
            this.Hide();
        }
    }
}
