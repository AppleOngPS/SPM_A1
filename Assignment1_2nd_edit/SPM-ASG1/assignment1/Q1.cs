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

        

        private void button1_Click(object sender, EventArgs e)
        {
            
          
            if (SharedData.turn == 1)
            {
                
                
                SharedData.PreviousOption = SharedData.building;
                SharedData.building = button1.Text;
                SharedData.CurrentOption = SharedData.building;

                Q2 q2 = new Q2();
                q2.Show();
                this.Close();
            }
            else
            {
                //SharedData.point += 1;

                SharedData.PreviousOption = SharedData.building;
                SharedData.building = button1.Text;
                SharedData.CurrentOption = SharedData.building;

                pickAlt pickAlt = new pickAlt();
                pickAlt.Show();
               // pointSystem();
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            if (SharedData.turn == 1)
            {

                
                SharedData.PreviousOption = SharedData.building;
                SharedData.building = button2.Text;
                SharedData.CurrentOption = SharedData.building;


                Q2 q2 = new Q2();
                q2.Show();
                this.Close();
            }
            else
            {
                //SharedData.point += 1;
                //SharedData.coins += 1;
                SharedData.PreviousOption = SharedData.building;
                SharedData.building = button2.Text;
                SharedData.CurrentOption = SharedData.building;

                pickAlt pickAlt = new pickAlt();
                pickAlt.Show();
                //pointSystem();
                this.Close();
            }
        }

        private void Q1_Load_1(object sender, EventArgs e)
        {
            List<string> names = new List<string> { "Residential", "Industry", "Commercial", "Park", "Road" };

            // Create an instance of Random       //"Residential", "Industry", "Commercial", "Park", "Road"
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

        private void pointSystem()
        {
            if (!string.IsNullOrEmpty(SharedData.building) && !string.IsNullOrEmpty(SharedData.PreviousOption))
            {
                if (SharedData.building == "Residential" && SharedData.PreviousOption == "Park")
                {

                    SharedData.point += 1;
                    
                }
                else if (SharedData.building == "Park"&&SharedData.PreviousOption== "Residential")
                {
                    SharedData.point += 1;
                }
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
