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
                moveimage();
                this.Close();
                /*if (flag == false)
                {
                  //  x = Convert.ToInt32(SharedData.Row) + 1;
                    //SharedData.Row = x.ToString();
                }
                else
                {
                    this.Close();
                    arcade.Refresh();
                }
                */
                if (SharedData.building== "Road") 
                {
                    SharedData.point += 2;
                }
                else if (SharedData.building == "I")
                {

                }
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
                int x, y;
                x = Convert.ToInt32(SharedData.Row) + 1;
                y = Convert.ToInt32(SharedData.Column);
                SharedData.x = x; SharedData.y = y;
                SharedData.Row = x.ToString();
                SharedData.Column = y.ToString();
                moveimage();
                this.Close();
                /*if (flag == false)
                {
                   // x = Convert.ToInt32(SharedData.Row) - 1;
                  //  SharedData.Row = x.ToString();
                }
                else
                {
                    this.Close();
                    arcade.Refresh();
                }*/

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
                int x, y;
                x = Convert.ToInt32(SharedData.Row);
                y = Convert.ToInt32(SharedData.Column) - 1;
                SharedData.x = x; SharedData.y = y;
                SharedData.Row = x.ToString();
                SharedData.Column = y.ToString();
                moveimage();
                this.Close();
                /*if (flag == false)
                {
                    y = Convert.ToInt32(SharedData.Column) + 1;
                    SharedData.Column = y.ToString();
                }
                else
                {
                    this.Close();
                    arcade.Refresh();
                }*/


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
                int x, y;
                x = Convert.ToInt32(SharedData.Row);
                y = Convert.ToInt32(SharedData.Column) + 1;
                SharedData.x = x; SharedData.y = y;
                SharedData.Row = x.ToString();
                SharedData.Column = y.ToString();
                moveimage();
                this.Close();
                /*if(flag==false)
                {
                   y= Convert.ToInt32(SharedData.Column) - 1;
                    SharedData.Column=y.ToString();
                }
                else
                {
                    this.Close();
                    arcade.Refresh();
                }*/
                
            }
            else
            {
                MessageBox.Show("cant go top");
            }
            
        }

        private void moveimage()
        {
            //if (SharedData.turn >= 2)
            //{
                if (!string.IsNullOrEmpty(SharedData.Row) && !string.IsNullOrEmpty(SharedData.Column))
                {
                    string row;
                    string column;
                    row = SharedData.x.ToString();

                    column = SharedData.y.ToString();
                    string id = "X" + row + "Y" + column;
                    PictureBox pictureBox =arcade.FindPictureBoxById(id);
                    if (pictureBox != null)
                    {
                        if (pictureBox.Image == null)
                        {
                           
                            pictureBox.Image = Image.FromFile(@"C:\NP.2\SPM\C#\SPM-ASG1\assignment1\Resources\Screenshot 2024-06-10 222221.png");
                            flag = true;
                            

                        }
                        else
                        {
                            MessageBox.Show("This PictureBox already has an image.",
                                                                  "Warning",
                                                                  MessageBoxButtons.OK,
                                                                  MessageBoxIcon.Warning);
                            flag = false;
                        }


                    }
                    else
                    {
                        // PictureBox not found with the specified ID
                        MessageBox.Show($"PictureBox with ID {id} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                //}
            }
        }
    }
}
