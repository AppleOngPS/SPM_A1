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
            lblTurn.Text ="Turn "+ i.ToString();
            SharedData.turn = i;

            lblCoins.Text ="Coin "+ coins.ToString();
            lblPoint.Text = "Point "+SharedData.point.ToString();
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
            lblPoint.Text="Point " + SharedData.point.ToString();

            // Perform some action if the flag is true
            if (flag==true)
            {
                // Example action: increment x and update label2
                i++;
               lblTurn.Text ="Turn "+ i.ToString();
                SharedData.turn = i;
                // Reset the flag if needed
                flag = false;
            }
            if (!string.IsNullOrEmpty(SharedData.building))
            {
                string row;
                string column;
                row = SharedData.Row.ToString();

                column = SharedData.Column.ToString();
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
                    }
                }
                else
                {
                    // PictureBox not found with the specified ID
                    MessageBox.Show($"PictureBox with ID {id} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void SetBuildingImage(PictureBox pictureBox)
        {
            if (SharedData.building == "Road")
            {
                string imagePath = @"C:\NP.2\SPM\vvvvv\Assignment1_2nd_edit\SPM-ASG1\assignment1\Resources\Road.png";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(imagePath);
                pictureBox.Tag = imagePath;
            }
            else if (SharedData.building == "Park")
            {
                string imagePath = @"C:\NP.2\SPM\vvvvv\Assignment1_2nd_edit\SPM-ASG1\assignment1\Resources\park.png";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(imagePath);
                pictureBox.Tag = imagePath;
            }
            else if (SharedData.building == "Commercial")
            {
                string imagePath = @"C:\NP.2\SPM\vvvvv\Assignment1_2nd_edit\SPM-ASG1\assignment1\Resources\commercial.png";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(imagePath);
                pictureBox.Tag = imagePath;
            }
            else if (SharedData.building == "Industry")
            {
                string imagePath = @"C:\NP.2\SPM\vvvvv\Assignment1_2nd_edit\SPM-ASG1\assignment1\Resources\industry.png";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(imagePath);
                pictureBox.Tag = imagePath;
            }
            else if (SharedData.building == "Residential")
            {
                string imagePath = @"C:\NP.2\SPM\vvvvv\Assignment1_2nd_edit\SPM-ASG1\assignment1\Resources\residential.png";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(imagePath);
                pictureBox.Tag = imagePath;
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

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\NP.2\\SPM\\vvvvv\\Assignment1_2nd_edit\\SPM-ASG1\\assignment1\\Database1.mdf;Integrated Security=True");
        private void Save_Click(object sender, EventArgs e)
        {
            v++;
            string Version = "V"+v.ToString();
            SharedData.Version = Version;

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
    }
}
