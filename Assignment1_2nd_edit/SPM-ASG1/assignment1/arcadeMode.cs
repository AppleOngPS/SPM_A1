using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class arcadeMode : Form
    {
        int i = 1;
        int coins = 16;
        int point = 0;
        bool flag = false;

        int v = 0;

        public arcadeMode()
        {
            InitializeComponent();
            lblTurn.Text = "Turn " + i;
           // SharedData.turn = i;
            
            lblCoins.Text = "Coin " + coins;
            lblPoint.Text = "Point " + point;
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
            
            if (SharedData.t == true)
            {
                Save.Enabled = true;
            }
            else { Save.Enabled = false; }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From [dbo].[Table] WHERE name='" + SharedData.Data + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][1].ToString() == SharedData.Data)
                {
                    PictureBox pictureBox = FindPictureBoxById(dt.Rows[i][2].ToString());
                    if (pictureBox != null)
                    {
                        string imagePath = dt.Rows[i][3].ToString();
                        pictureBox.Image = Image.FromFile(@imagePath);
                    }
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

        private void button2_Click(object sender, EventArgs e)
        {
            // UpdatePictureBoxes();
            lblPoint.Text = "Point " + point;
            lblCoins.Text = "Coin " + coins;
            lblTurn.Text = SharedData.CurrentOption;
            // Perform some action if the flag is true
            if (flag == true)
            {
                // Example action: increment x and update label2
                i++;
                //lblTurn.Text = "Turn " + i;
                SharedData.turn = i;
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
                       // point -= 1;
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
                if (SharedData.CurrentOption == "Industry" || SharedData.CurrentOption == "Commercial")
                {
                    if (topPic.Tag == "residential" || rightPic.Tag == "residential" || leftPic.Tag == "residential" || bottomPic.Tag == "residential")
                    {
                        coins += 1;
                        lblCoins.Text = "Coin " + coins;
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
                        coins += 1;
                        lblCoins.Text = "Coin " + coins;
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
                }
                /*if (SharedData.CurrentOption == "Industry")
                {

                    if (topPic.Tag == "residential")
                    {
                        
                        coins += 1;
                        lblCoins.Text = "Coin " + coins  ;
                    }
                    else if (rightPic.Tag == "residential")
                    {
                        
                        coins += 1;
                        lblCoins.Text = "Coin " + coins;
                    }
                    else if (leftPic.Tag == "residential")
                    {
                      
                        coins += 1;
                        lblCoins.Text = "Coin " + coins;
                    }
                    else if (bottomPic.Tag == "residential")
                    {
                       
                        coins += 1;
                        lblCoins.Text = "Coin " + coins;
                    }
                    else {coins += 0; }

                }
                else if (SharedData.CurrentOption == "Commercial")
                {
                    if (topPic.Tag == "residential")
                    {
                        
                        coins += 1;
                        lblCoins.Text = "Coin " + coins;
                    }
                    else if (rightPic.Tag == "residential")
                    {
                       
                        coins += 1;
                        lblCoins.Text = "Coin " + coins;
                    }
                    else if (leftPic.Tag == "residential")
                    {
                       
                        coins += 1;
                        lblCoins.Text = "Coin " + coins;
                    }
                    else if (bottomPic.Tag == "residential")
                    {
                        
                        coins += 1;
                        lblCoins.Text = "Coin " + coins;
                    }
                    else { coins += 0; }

                }
                else if (SharedData.CurrentOption == "Residential")
                {
                    if (topPic.Tag == "park")
                    {
                       point += 2;
                        lblPoint.Text = "Point " + point;
                    }
                    else if (rightPic.Tag == "park")
                    {
                        point += 2;
                        lblPoint.Text = "Point " + point;
                    }
                    else if (leftPic.Tag == "park")
                    {
                        point += 2;
                        lblPoint.Text = "Point " + point;
                    }
                    else if (bottomPic.Tag == "park")
                    {
                        point += 2;
                        lblPoint.Text = "Point " + point;
                    }
                    else if (topPic.Tag == "industry")
                    {
                        
                        coins += 1;
                        lblCoins.Text = "Coin " + coins;

                    }
                    else if (rightPic.Tag == "industry")
                    {
                       
                        coins += 1;
                        lblCoins.Text = "Coin " + coins  ;
                    }
                    else if (leftPic.Tag == "industry")
                    {
                        
                        coins += 1;
                        lblCoins.Text = "Coin " +   coins;
                    }
                    else if (bottomPic.Tag == "industry")
                    {
                       
                        coins += 1;
                        lblCoins.Text = "Coin " + coins;
                    }
                    else if (topPic.Tag== "commercial")
                    {
                        
                        coins += 1;
                        lblCoins.Text = "Coin " + coins;

                    }
                    else if (rightPic.Tag == "commercial")
                    {
                        
                        coins += 1;
                        lblCoins.Text = "Coin " + coins;
                    }
                    else if (leftPic.Tag == "commercial")
                    {
                       
                        coins += 1;
                        lblCoins.Text = "Coin " + coins;
                    }
                    else if (bottomPic.Tag == "commercial")
                    {
                        
                        coins += 1;
                        lblCoins.Text = "Coin " + coins;
                    }
                    //else { point += 0;coins += 0; }
                }
                else if (SharedData.CurrentOption == "Road")
                {

                    if (rightPic.Tag == "Road")
                    {
                        point += 1;
                        lblPoint.Text = "Point " + point ;

                    }
                    else if (leftPic.Tag == "Road")
                    {
                        point += 1;
                        lblPoint.Text = "Point " + point;
                    }
                    else { point += 0; }
                }
                else if (SharedData.CurrentOption == "Park")
                {
                    if (topPic.Tag == "residential")
                    {
                        point += 2;
                        lblPoint.Text = "Point " + point ;
                    }
                    else if (rightPic.Tag == "residential")
                    {
                        point += 2;
                        lblPoint.Text = "Point " + point;
                    }
                    else if (leftPic.Tag == "residential")
                    {
                        point += 2;
                        lblPoint.Text = "Point " + point;
                    }
                    else if (bottomPic.Tag == "residential")
                    {
                        point += 2;
                        lblPoint.Text = "Point " + point;
                    }
                    //else { point += 1; }
                }*/
                /*if(SharedData.building == "Industry" || SharedData.building== "Residential")
                {
                    if (topPic.Image == Resource1.industry ||topPic.Image == Resource1.residential)
                    {
                        SharedData.coins += 1;
                        lblCoins.Text = "Coin " + SharedData.coins.ToString();
                    }
                    else if (rightPic.Image == Resource1.industry || rightPic.Image == Resource1.residential)
                    {
                        SharedData.coins += 1;
                        lblCoins.Text = "Coin " + SharedData.coins.ToString();
                    }
                    else if (leftPic.Image == Resource1.industry || leftPic.Image == Resource1.residential)
                    {
                        SharedData.coins += 1;
                        lblCoins.Text = "Coin " + SharedData.coins.ToString();
                    }
                    else if (bottomPic.Image == Resource1.industry || bottomPic.Image == Resource1.residential)
                    {
                        SharedData.coins += 1;
                        lblCoins.Text = "Coin " + SharedData.coins.ToString();
                    }
                    
                }
                else if (SharedData.building == "Commercial" || SharedData.building == "Residential")
                {
                    if (topPic.Image == Resource1.commercial || topPic.Image == Resource1.residential)
                    {
                        SharedData.coins += 1;
                        lblCoins.Text = "Coin " + SharedData.coins.ToString();
                    }
                    else if (rightPic.Image == Resource1.commercial || rightPic.Image == Resource1.residential)
                    {
                        SharedData.coins += 1;
                        lblCoins.Text = "Coin " + SharedData.coins.ToString();
                    }
                    else if (leftPic.Image == Resource1.commercial || leftPic.Image == Resource1.residential)
                    {
                       SharedData.coins += 1;
                        lblCoins.Text = "Coin " + SharedData.coins;                    }
                    else if (bottomPic.Image == Resource1.commercial || bottomPic.Image == Resource1.residential)
                    {
                        SharedData.coins += 1;
                        lblCoins.Text = "Coin " + SharedData.coins.ToString();
                    }

                }
            }*/

            }
        }

        /*if (i > 2)
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
                    pictureBox.Image = Image.FromFile(@"C:\NP.2\SPM\C#\SPM-ASG1\assignment1\Resources\Screenshot 2024-06-10 222221.png");
                }
                else
                {
                    // PictureBox not found with the specified ID
                    MessageBox.Show($"PictureBox with ID {id} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }*/
        private void SetBuildingImage(PictureBox pictureBox)
        {
            if (SharedData.building == "Road")
            {
                string imagePath = @"C:\Users\ongap\OneDrive\Desktop\NP\SPM\10th edit\Assignment1_2nd_edit\SPM-ASG1\assignment1\Resources\Road.png";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                //pictureBox.Image = Image.FromFile(imagePath);
                pictureBox.Image = Resource1.Road;
                pictureBox.Tag ="Road";
            }
            else if (SharedData.building == "Park")
            {
                string imagePath = @"C:\Users\ongap\OneDrive\Desktop\NP\SPM\10th edit\Assignment1_2nd_edit\SPM-ASG1\assignment1\Resources\park.png";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                //pictureBox.Image = Image.FromFile(imagePath);
                pictureBox.Image= Resource1.park;
                pictureBox.Tag ="park";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Set the flag to true when the End Turn button is clicked
            flag = true;

            Q1 q1 = new Q1();
            q1.Show();
           this.Refresh();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\ongap\\OneDrive\\Desktop\\NP\\SPM\\10th edit\\Assignment1_2nd_edit\\SPM-ASG1\\assignment1\\Database1.mdf\";Integrated Security=True");
        private void Save_Click(object sender, EventArgs e)
        {
            SharedData.coins = coins;
            SharedData.point = point;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From [dbo].[Table] WHERE name='" +SharedData.Data +"'";
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
                    cmd3.CommandText = "INSERT INTO [dbo].[SaveSystem] (Point,Coin,Turn,Version) VALUES ('"+SharedData.point+"','"+SharedData.coins+"','"+SharedData.turn+"','"+SharedData.Version+"')";
                    cmd3.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    foreach (var info in pictureBoxInfos)
                    {
                        using (SqlCommand cmd2 = new SqlCommand("INSERT INTO [dbo].[SaveData] (SId,XY,Building,Version) VALUES ('" + dt.Rows[i][0] + "','" + info.ID + "','"+ info.ImageSource + "','"+SharedData.Version+"')", con))
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
                    MessageBox.Show("Successfully Save","Success",MessageBoxButtons.OK);
                }
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



        public class PictureBoxInfo
        {
            public string ID { get; set; }
            public string ImageSource { get; set; }
        }

        private void changeplaceBtn_Click(object sender, EventArgs e)
        {
            Q2 q2 = new Q2();
            q2.Show();
        }

        private void Demolish_Click(object sender, EventArgs e)
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
                    MessageBox.Show("This PictureBox already has an image.",
                                    "Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                   
                    SharedData.point -= 1;
                   
                   
                }
            }
            else
            {
                // PictureBox not found with the specified ID
                //MessageBox.Show($"PictureBox with ID {id} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            gameInstructionForArcadeMode gameInstructionForArcadeMode = new gameInstructionForArcadeMode();
            gameInstructionForArcadeMode.Show();
        }
    }
}
