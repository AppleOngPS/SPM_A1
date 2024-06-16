using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class Q2 : Form
    {
        arcadeMode arcadeMode;
        public Q2()
        {
            InitializeComponent();

        }


        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            // Check if the input is numeric and within the range of 1 to 20
            if (int.TryParse(textBox2.Text, out int number))
            {
                if (number < 1 || number > 20)
                {
                    MessageBox.Show("Please enter a number between 1 and 20.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Text = string.Empty;
                }
            }
            else if (!string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Text = string.Empty;
            }
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Reject the key press
                MessageBox.Show("Please enter a number between 1 and 20.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // Check if the input is numeric and within the range of 1 to 20
            if (int.TryParse(textBox1.Text, out int number))
            {
                if (number < 1 || number > 20)
                {
                    MessageBox.Show("Please enter a number between 1 and 20.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = string.Empty;
                }
            }
            else if (!string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = string.Empty;
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Reject the key press
                MessageBox.Show("Please enter a number between 1 and 20.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /* if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
             {
                 string row = textBox1.Text;
                 string column = textBox2.Text;
                 SharedData.Row = row;
                 SharedData.Column = column;


             }
             else
             {
                 MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }*/
            arcadeMode arcadeForm = new arcadeMode();
            UpdatePictureBoxImage(arcadeForm);
            arcadeForm.Refresh();

        }


        public void UpdatePictureBoxImage(arcadeMode arcadeForm)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                string row = textBox1.Text;
                string column = textBox2.Text;
                SharedData.Row = row;
                SharedData.Column = column;

                if (!string.IsNullOrEmpty(SharedData.building))
                {
                    string id = "X" + row + "Y" + column;
                    PictureBox pictureBox = arcadeForm.FindPictureBoxById(id);
                    if (pictureBox != null)
                    {
                        try
                        {
                            // PictureBox found, perform actions
                            pictureBox.Image = Image.FromFile(@"C:\NP.2\SPM\C#\SPM-ASG1\assignment1\Resources\Screenshot 2024-06-10 222221.png");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            // Handle file not found or other exceptions
                            MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // PictureBox not found with the specified ID
                        MessageBox.Show($"PictureBox with ID {id} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
