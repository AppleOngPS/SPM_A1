﻿using System;
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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            
        }
       
        private void menu_Load(object sender, EventArgs e)
        {
            lblName.Text = SharedData.Data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameInstructionForArcadeMode arcademodepage = new gameInstructionForArcadeMode();
            arcademodepage.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gameInstructionForFreePlay freeGameMode = new gameInstructionForFreePlay();
            freeGameMode.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void DisplayHighScoreBtn_Click(object sender, EventArgs e)
        {
            displayHighScore displayHighScore = new displayHighScore();
            displayHighScore.Show();
            this.Hide();
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}