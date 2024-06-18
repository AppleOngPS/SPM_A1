using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        public arcadeMode()
        {
            InitializeComponent();
            lblTurn.Text = i.ToString();
            SharedData.turn = i;
            
            lblCoins.Text = coins.ToString();
            lblPoint.Text = SharedData.point.ToString();
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
            lblPoint.Text = SharedData.point.ToString();
            // Perform some action if the flag is true
            if (flag==true)
            {
                // Example action: increment x and update label2
                i++;
                lblTurn.Text = i.ToString();
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
                    // PictureBox found, perform actions
                    pictureBox.Image = Image.FromFile(@"C:\NP.2\SPM\C#\SPM-ASG1\assignment1\Resources\Screenshot 2024-06-10 222221.png");
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Set the flag to true when the End Turn button is clicked
            flag = true;

            Q1 q1 = new Q1();
            q1.Show();
           this.Refresh();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\NP.2\\SPM\\SPM_A1\\Assignment1_2nd_edit\\SPM-ASG1\\assignment1\\Database1.mdf;Integrated Security=True");
        private void Save_Click(object sender, EventArgs e)
        {
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
                    cmd3.CommandText = "INSERT INTO  (SId,RowColumn,Building,Version) VALUES (@ID, @Image, @Building,@Version)";
                    cmd3.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    foreach (var info in pictureBoxInfos)
                    {
                        using (SqlCommand cmd2 = new SqlCommand("INSERT INTO PictureBoxInfo (SId,RowColumn,Building,Version) VALUES (@ID, @Image, @Building,@Version)", con))
                        {
                            cmd2.Parameters.AddWithValue("@ID", dt.Rows[i][0]);
                            cmd2.Parameters.AddWithValue("@Image", info.ID);
                            cmd2.Parameters.AddWithValue("@Building", info.Image);
                            cmd2.Parameters.AddWithValue("@Version",SharedData.Version);

                            try
                            {
                                cmd2.ExecuteNonQuery();
                                con.Close();
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Error inserting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private List<PictureBoxInfo> GetAllPictureBoxInfos()
        {
            List<PictureBoxInfo> pictureBoxInfos = new List<PictureBoxInfo>();

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    PictureBoxInfo info = new PictureBoxInfo
                    {
                        ID = pictureBox.Name,
                        Image = pictureBox.Image
                    };
                    pictureBoxInfos.Add(info);
                }
            }

            return pictureBoxInfos;
        }

        public class PictureBoxInfo
        {
            public string ID { get; set; }
            public Image Image { get; set; }
        }
    }
}
