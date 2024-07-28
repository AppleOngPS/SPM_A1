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
    public partial class Loadpage : Form
    {
        public Loadpage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            menu menu = new menu(); 
            menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SharedData.savef=true;
            arcadeMode arcadeMode = new arcadeMode();
            arcadeMode.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SharedData.freeGamesavef = true;
            freeGameMode freeGame = new freeGameMode();
            freeGame.Show();
            this.Close();
        }

        private void backbnt_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Close();
        }
    }
}
