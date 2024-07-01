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
    public partial class Q4 : Form
    {
        public Q4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                string row = textBox1.Text;
                string column = textBox2.Text;
                SharedData.Dx = row;
                SharedData.Dy = column;
                this.Close();


            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Reject the key press
                MessageBox.Show("Please enter a number between 1 and 20.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Reject the key press
                MessageBox.Show("Please enter a number between 1 and 20.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
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
    }
}
