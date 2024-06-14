using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class arcadeMode : Form
    {
        int i = 1;
        bool flag = false;
        public arcadeMode()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

      
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Close();
        }

        private void arcadeMode_Load(object sender, EventArgs e)
        {
            lblTurn.Text = i.ToString();
            SharedData.turn = i;
            int coins = 16;
            int point = 0;
            lblCoins.Text = coins.ToString();
            lblPoint.Text = point.ToString();
        }

       


        private PictureBox FindPictureBoxById(string id)
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is PictureBox pictureBox && pictureBox.Name == id)
                {
                    return pictureBox;
                }
            }
            return null; // PictureBox with specified ID not found
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Perform some action if the flag is true
            if (flag)
            {
                // Example action: increment x and update label2
                i++;
                lblTurn.Text = i.ToString();
                SharedData.turn = i;
                // Reset the flag if needed
                flag = false;
            }

            if (!String.IsNullOrEmpty(SharedData.building))
            {
                string row;
                string column;
                row = SharedData.Row.ToString();

                column = SharedData.Column.ToString();
                string id = "X" + row + "Y" + column;
                PictureBox pictureBox = FindPictureBoxById(id);
                if (pictureBox != null)
                {
                    // PictureBox found, perform actions
                    pictureBox.BackColor = Color.Red; // Example action
                }
                else
                {
                    // PictureBox not found with the specified ID
                    MessageBox.Show($"PictureBox with ID {id} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pictureBox.Image = Image.FromFile(@"C:\NP.2\SPM\C#\SPM-ASG1\assignment1\Resources\Screenshot 2024-06-10 222221.png");


            }
            if (i > 2)
            {
                if (!String.IsNullOrEmpty(SharedData.Row) && !String.IsNullOrEmpty(SharedData.Column))
                {
                    string row;
                    string column;
                    row = SharedData.x.ToString();

                    column = SharedData.y.ToString();
                    string id = "X" + row + "Y" + column;
                    PictureBox pictureBox = FindPictureBoxById(id);
                    if (pictureBox != null)
                    {
                        // PictureBox found, perform actions
                        pictureBox.BackColor = Color.Red; // Example action
                    }
                    else
                    {
                        // PictureBox not found with the specified ID
                        MessageBox.Show($"PictureBox with ID {id} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    pictureBox.Image = Image.FromFile(@"C:\NP.2\SPM\C#\SPM-ASG1\assignment1\Resources\Screenshot 2024-06-10 222221.png");

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Set the flag to true when the End Turn button is clicked
            flag = true;

            Q1 q1 = new Q1();
            q1.Show();
        }
    }
}
