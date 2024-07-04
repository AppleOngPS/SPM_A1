using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static assignment1.arcadeMode;

namespace assignment1
{
    public partial class freeGameMode : Form
    {
        int i = 1;
        
        int point =0;
        bool flag = false;
        bool dflag=false;
        public freeGameMode()
        {
            InitializeComponent();
            lblTurn.Text = "Turn " + i;
            SharedData.turn = i;
            lblCoins.Text = "Coin oo";
            lblPoint.Text = "Point " + point;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void freeGameMode_Load(object sender, EventArgs e)
        {

        }

        private void X6Y3_Click(object sender, EventArgs e)
        {

        }

        private void X13Y6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameInstructionForFreePlay gameInstructionForFreePlay = new gameInstructionForFreePlay();
            gameInstructionForFreePlay.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            if (!dflag)
            {
                // Set the flag to true when the End Turn button is clicked
                flag = true;
                dflag=true;
                // Example action: increment x and update label2
                i++;
                lblTurn.Text = "Turn " + i;
                SharedData.turn = i;
                FQ0 fq0 = new FQ0();
                fq0.Show();
            }
            else
            {
                MessageBox.Show("Please End your turn.", "Turn Start", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void Demolish_Click(object sender, EventArgs e)
        {
            if (dflag == true)
            {
                Q4 q4 = new Q4();
                q4.Show();

                string row;
                string column;
                row = SharedData.Dx;

                column = SharedData.Dy;
                string id = "X" + row + "Y" + column;
                PictureBox pictureBox = FindPictureBoxById(id);

                if (pictureBox != null)
                {
                    if (pictureBox.Image != null)
                    {
                        //pictureBox.Image = Resource1.White;
                        // Dispose of the current image to free up resources
                        pictureBox.Image.Dispose();
                        pictureBox.Image = null; // Clear the reference to the disposed image
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("This PictureBox has no image.",
                                        "Warning",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);

                       


                    }
                
                }
                else
                {
                    // PictureBox not found with the specified ID
                    MessageBox.Show($"PictureBox with ID {id} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
            }
        }

        private void changeplaceBtn_Click(object sender, EventArgs e)
        {
            if (SharedData.TFlag==true)
            {
                FQ1 fQ1 = new FQ1();
                fQ1.Show();
                this.Refresh();
            }
            else if (SharedData.TFlag2 == true)
            {
                FQ2 fQ2 = new FQ2();
                fQ2.Show();
                this.Refresh();
            }
            else if (SharedData.TFlag3 == true)
            {
                FQ3 fQ3 = new FQ3();
                fQ3.Show();
                this.Refresh();
            }
        }   

        private void EndTurn_Click(object sender, EventArgs e)
        {
            lblPoint.Text = "Point " + point;
            dflag = false;

            // Perform some action if the flag is true
            if (flag == true)
            {
               
                // Reset the flag if needed
                flag = false;
            }
            if (!string.IsNullOrEmpty(SharedData.CurrentOption))
            {
                string row;
                string column;
                row = SharedData.Row;

                column = SharedData.Column;
                string id = "X" + row + "Y" + column;
                PictureBox pictureBox = FindPictureBoxById(id);
                if (pictureBox != null)
                {
                    if (pictureBox.Image == null)
                    {
                        // PictureBox found, perform actions
                        SetBuildingImage(pictureBox);

                    }
                    else
                    {
                        MessageBox.Show("This PictureBox already has an image.",
                                                              "Warning",
                                                              MessageBoxButtons.OK,
                                                              MessageBoxIcon.Warning);
                        SharedData.Row = SharedData.TempRow;
                        SharedData.Column = SharedData.TempColumn;
                        point -= 1;
                        pickAlt pickAlt = new pickAlt();
                        pickAlt.Show();
                        flag = false;
                    }
                }
                else
                {
                    // PictureBox not found with the specified ID
                    MessageBox.Show($"PictureBox with ID {id} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                int x = Convert.ToInt32(row); int y = Convert.ToInt32(column);
                string top = "X" + (x + 1) + "Y" + y;
                string bottom = "X" + (x - 1) + "Y" + y;
                string right = "X" + x + "Y" + (y + 1);
                string left = "X" + x + "Y" + (y - 1);
                PictureBox topPic = FindPictureBoxById(top);
                PictureBox bottomPic = FindPictureBoxById(bottom);
                PictureBox rightPic = FindPictureBoxById(right);
                PictureBox leftPic = FindPictureBoxById(left);

                if (topPic != null && leftPic != null && rightPic != null && bottomPic != null)
                {
                    if (SharedData.CurrentOption == "Industry")
                    {
                        if (topPic.Tag == "residential" || rightPic.Tag == "residential" || leftPic.Tag == "residential" || bottomPic.Tag == "residential")
                        {
                            
                            point += 1;
                            
                            lblPoint.Text = "Point " + point;

                        }
                        else if (topPic.Tag == "industry" || rightPic.Tag == "industry" || leftPic.Tag == "industry" || bottomPic.Tag == "industry")
                        {
                            point += 1;
                            lblPoint.Text = "Point " + point;

                        }
                        else if (topPic.Tag == "residential" && rightPic.Tag == "residential" && leftPic.Tag == "residential" && bottomPic.Tag == "residential")
                        {
                            
                            point += 1;
                            
                            lblPoint.Text = "Point " + point;
                        }
                        else if (topPic.Tag == "residential" && bottomPic.Tag == "residential")
                        {
                           
                            point += 1;
                            
                            lblPoint.Text = "Point " + point;
                        }
                        else if (rightPic.Tag == "residential" && leftPic.Tag == "residential")
                        {
                           
                            point += 1;
                            
                            lblPoint.Text = "Point " + point;
                        }
                        else if (topPic.Tag == "residential" && rightPic.Tag == "residential" && leftPic.Tag == "residential")
                        {
                            
                            point += 1;
                           
                            lblPoint.Text = "Point " + point;
                        }
                        else if (rightPic.Tag == "residential" && leftPic.Tag == "residential" && bottomPic.Tag == "residential")
                        {
                            
                            point += 1;
                            
                            lblPoint.Text = "Point " + point;
                        }

                    }
                    else if (SharedData.CurrentOption == "Commercial")
                    {

                        if (topPic.Tag == "commercial" || rightPic.Tag == "commercial" || leftPic.Tag == "commercial" || bottomPic.Tag == "commercial")
                        {
                            point += 1;
                            lblPoint.Text = "Point " + point;


                        }
                        else if (topPic.Tag == "residential" || rightPic.Tag == "residential" || leftPic.Tag == "residential" || bottomPic.Tag == "residential")
                        {
                            
                            point += 1;
                           
                            lblPoint.Text = "Point " + point;

                        }

                    }
                    else if (SharedData.CurrentOption == "Residential")
                    {
                        if (topPic.Tag == "park" || rightPic.Tag == "park" || leftPic.Tag == "park" || bottomPic.Tag == "park")
                        {
                            point += 2;
                            lblPoint.Text = "Point " + point;

                        }
                        else if (topPic.Tag == "industry" || rightPic.Tag == "industry" || leftPic.Tag == "industry" || bottomPic.Tag == "industry" ||
                                 topPic.Tag == "commercial" || rightPic.Tag == "commercial" || leftPic.Tag == "commercial" || bottomPic.Tag == "commercial")
                        {
                          
                            point += 1;
                         
                            lblPoint.Text = "Point " + point;

                        }
                        else if (topPic.Tag == "residential" || rightPic.Tag == "residential" || leftPic.Tag == "residential" || bottomPic.Tag == "residential")
                        {
                            point += 1;
                            lblPoint.Text = "Point " + point;

                        }

                    }
                    else if (SharedData.CurrentOption == "Road")
                    {
                        if (rightPic.Tag == "Road" || leftPic.Tag == "Road")
                        {
                            point += 1;
                            lblPoint.Text = "Point " + point;

                        }

                    }
                    else if (SharedData.CurrentOption == "Park")
                    {
                        if (topPic.Tag == "residential" || rightPic.Tag == "residential" || leftPic.Tag == "residential" || bottomPic.Tag == "residential")
                        {
                            point += 2;
                            lblPoint.Text = "Point " + point;

                        }
                        else if (topPic.Tag == "park" || rightPic.Tag == "park" || leftPic.Tag == "park" || bottomPic.Tag == "park")
                        {
                            point += 1;
                            lblPoint.Text = "Point " + point;

                        }

                    }
                }
                SharedData.TFlag2 = CheckPictureBoxesInSection(tableLayoutPanel1, 0, 0, 4, 4);
                SharedData.TFlag3 = CheckPictureBoxesInSection(tableLayoutPanel1, 5,5 , 14, 14);

                this.Refresh();
            }
        }


        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\NP.2\\SPM\\www\\Assignment1_2nd_edit\\SPM-ASG1\\assignment1\\Database1.mdf;Integrated Security=True");
        private void Save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From [dbo].[Table] WHERE name='" + SharedData.Data + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            List<PictureBoxInfo> pictureBoxInfos = GetAllPictureBoxInfos();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][1].ToString() == SharedData.Data)
                {
                    con.Open();
                    SqlCommand cmd3 = con.CreateCommand();
                    cmd3.CommandType = CommandType.Text;
                    cmd3.CommandText = "INSERT INTO [dbo].[SaveSystem] (Point,Coin,Turn,Version) VALUES ('" + SharedData.point + "','" + SharedData.coins + "','" + SharedData.turn + "','" + SharedData.Version + "')";
                    cmd3.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    foreach (var info in pictureBoxInfos)
                    {
                        using (SqlCommand cmd2 = new SqlCommand("INSERT INTO [dbo].[SaveData] (SId,XY,Building,Version) VALUES ('" + dt.Rows[i][0] + "','" + info.ID + "','" + info.ImageSource + "','" + SharedData.Version + "')", con))
                        {


                            try
                            {
                                cmd2.ExecuteNonQuery();

                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Error inserting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    con.Close();
                    MessageBox.Show("Successfully Save", "Success", MessageBoxButtons.OK);
                }
            }
        }


        public PictureBox FindPictureBoxById(string id)
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

        private void SetBuildingImage(PictureBox pictureBox)
        {
            if (SharedData.building == "Road")
            {
                string imagePath = @"C:\Users\ongap\OneDrive\Desktop\NP\SPM\10th edit\Assignment1_2nd_edit\SPM-ASG1\assignment1\Resources\Road.png";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                //pictureBox.Image = Image.FromFile(imagePath);
                pictureBox.Image = Resource1.Road;
                pictureBox.Tag = "Road";
            }
            else if (SharedData.building == "Park")
            {
                string imagePath = @"C:\Users\ongap\OneDrive\Desktop\NP\SPM\10th edit\Assignment1_2nd_edit\SPM-ASG1\assignment1\Resources\park.png";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                //pictureBox.Image = Image.FromFile(imagePath);
                pictureBox.Image = Resource1.park;
                pictureBox.Tag = "park";
            }
            else if (SharedData.building == "Commercial")
            {
                string imagePath = @"C:\Users\ongap\OneDrive\Desktop\NP\SPM\10th edit\Assignment1_2nd_edit\SPM-ASG1\assignment1\Resources\commercial.png";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Resource1.commercial;
                pictureBox.Tag = "commercial";
            }
            else if (SharedData.building == "Industry")
            {
                string imagePath = @"C:\Users\ongap\OneDrive\Desktop\NP\SPM\10th edit\Assignment1_2nd_edit\SPM-ASG1\assignment1\Resources\industry.png";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Resource1.industry;
                pictureBox.Tag = "industry";
            }
            else if (SharedData.building == "Residential")
            {
                string imagePath = @"C:\Users\ongap\OneDrive\Desktop\NP\SPM\10th edit\Assignment1_2nd_edit\SPM-ASG1\assignment1\Resources\residential.png";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Resource1.residential;
                pictureBox.Tag = "residential";
            }
            else
            {
                MessageBox.Show("Invalid building type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<PictureBoxInfo> GetAllPictureBoxInfos()
        {
            List<PictureBoxInfo> pictureBoxInfos = new List<PictureBoxInfo>();

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is PictureBox pictureBox && !string.IsNullOrEmpty(pictureBox.Name) && pictureBox.Image != null)
                {
                    PictureBoxInfo info = new PictureBoxInfo
                    {
                        ID = pictureBox.Name,
                        ImageSource = pictureBox.Tag as string // Store the image source (file path or resource name)
                    };
                    pictureBoxInfos.Add(info);
                }
            }
            return pictureBoxInfos;
        }


        private bool CheckPictureBoxesInSection(TableLayoutPanel tableLayoutPanel, int startRow, int startColumn, int rowCount, int columnCount)
        {
            for (int row = startRow; row < startRow + rowCount; row++)
            {
                for (int column = startColumn; column < startColumn + columnCount; column++)
                {
                    Control control = tableLayoutPanel.GetControlFromPosition(column, row);
                    if (control is PictureBox pictureBox && pictureBox.Image == null)
                    {
                        return false; // At least one PictureBox in the section does not have an image
                    }
                }
            }
            return true; // All PictureBox controls in the section have images
        }

    }
}
