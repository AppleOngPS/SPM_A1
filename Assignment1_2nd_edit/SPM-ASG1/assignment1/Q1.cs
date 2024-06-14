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
    public partial class Q1 : Form
    {
        public Q1()
        {
            InitializeComponent();
        }

        private void Q1_Load(object sender, EventArgs e)
        {
            List<string> names = new List<string> { "Residential", "Industry", "Commercial", "Park", "Road" };

            // Create an instance of Random
            Random random = new Random();

            // Generate two unique random indices
            int index1 = random.Next(names.Count);
            int index2;
            do
            {
                index2 = random.Next(names.Count);
            } while (index2 == index1);

            // Select names at the generated indices
            string name1 = names[index1];
            string name2 = names[index2];
            button1.Text = name1;
            button2.Text = name2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SharedData.turn == 1)
            {
                SharedData.building = button1.Text;
                Q2 q2 = new Q2();
                q2.Show();
                this.Close();
            }
            else
            {
                SharedData.building = button2.Text;
                Q3 q3 = new Q3();
                q3.Show();
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SharedData.turn == 1)
            {
                SharedData.building = button2.Text;
                Q2 q2 = new Q2();
                q2.Show();
                this.Close();
            }
            else
            {
                SharedData.building = button2.Text;
                Q3 q3 = new Q3();
                q3.Show();
                this.Close();
            }
        }
    }
}
