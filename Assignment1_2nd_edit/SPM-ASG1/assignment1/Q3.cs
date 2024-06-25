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
    public partial class Q3 : Form
    {
        arcadeMode arcade;
        bool flag=false;
        public Q3()
        {
            InitializeComponent();
            arcade = new arcadeMode();
           
        }

        private void Top_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(SharedData.Row) != 1)
            {
                int x, y;
                x = Convert.ToInt32(SharedData.Row) - 1;
                y = Convert.ToInt32(SharedData.Column);
               SharedData.x = x; SharedData.y = y;
                SharedData.Row = x.ToString();
                SharedData.Column = y.ToString();
                SharedData.TempRow = SharedData.Row;
                SharedData.TempColumn = SharedData.Column;
             
                this.Close();
              
                
            }
            else
            {
                MessageBox.Show("cant go top");
            }
            
        }

        private void Bot_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(SharedData.Row) != 20)
            {
                SharedData.TempRow = SharedData.Row;
                SharedData.TempColumn = SharedData.Column;
                int x, y;
                x = Convert.ToInt32(SharedData.Row) + 1;
                y = Convert.ToInt32(SharedData.Column);
                SharedData.x = x; SharedData.y = y;
                SharedData.Row = x.ToString();
                SharedData.Column = y.ToString();
                
                
                this.Close();
             

            }
            else
            {
                MessageBox.Show("cant go top");
            }
            

        }

        private void left_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(SharedData.Column) != 1 || Convert.ToInt32(SharedData.Column) != 20)
            {
                SharedData.TempRow = SharedData.Row;
                SharedData.TempColumn = SharedData.Column;
                int x, y;
                x = Convert.ToInt32(SharedData.Row);
                y = Convert.ToInt32(SharedData.Column) - 1;
                SharedData.x = x; SharedData.y = y;
                SharedData.Row = x.ToString();
                SharedData.Column = y.ToString();
                
                
                this.Close();
               


            }
            else if (SharedData.Row != SharedData.Row)
            {
                MessageBox.Show("This PictureBox already has an image.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("cant go top");
            }
            
        }

        private void right_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(SharedData.Column) != 1 || Convert.ToInt32(SharedData.Column) != 20)
            {
                SharedData.TempRow = SharedData.Row;
                SharedData.TempColumn = SharedData.Column;
                int x, y;
                x = Convert.ToInt32(SharedData.Row);
                y = Convert.ToInt32(SharedData.Column) + 1;
                SharedData.x = x; SharedData.y = y;
                SharedData.Row = x.ToString();
                SharedData.Column = y.ToString();
                
             
                this.Close();
             
                
            }
            else
            {
                MessageBox.Show("cant go top");
            }
            
        }


        private void SetBuildingImage(PictureBox pictureBox)
        {
            if (SharedData.building == "Road")
            {
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(@"C:\NP.2\SPM\vvvvv\Assignment1_2nd_edit\SPM-ASG1\assignment1\Resources\Road.png");
            }
            else if (SharedData.building == "Park")
            {
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(@"C:\NP.2\SPM\vvvvv\Assignment1_2nd_edit\SPM-ASG1\assignment1\Resources\park.png");
            }
            else if (SharedData.building == "Commercial")
            {
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(@"C:\NP.2\SPM\vvvvv\Assignment1_2nd_edit\SPM-ASG1\assignment1\Resources\commercial.png");
            }
            else if (SharedData.building == "Industry")
            {
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(@"C:\NP.2\SPM\vvvvv\Assignment1_2nd_edit\SPM-ASG1\assignment1\Resources\industry.png");
            }
            else if (SharedData.building == "Residential")
            {
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(@"C:\NP.2\SPM\vvvvv\Assignment1_2nd_edit\SPM-ASG1\assignment1\Resources\residential.png");
            }
            else
            {
                MessageBox.Show("Invalid building type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
