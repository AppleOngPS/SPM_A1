using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace assignment1
{
    public partial class SignUp : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\ongap\\OneDrive\\Desktop\\NP\\SPM\\16th edit\\Assignment1_2nd_edit\\SPM-ASG1\\assignment1\\Database1.mdf\";Integrated Security=True");

        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameInput.Text == "" && passwordInput.Text == "")
            {
                MessageBox.Show("Please choose a unique username.", "", MessageBoxButtons.OK);
            }
            else 
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                SqlDataAdapter da= new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * From [dbo].[Table] WHERE name='"+usernameInput.Text+"'";
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
               
                

                if (dr.Read()==true)
                {
                    //con.Close();
                    usernameInput.Text = "";
                    passwordInput.Text = "";

                    MessageBox.Show("Please choose a unique username.", "", MessageBoxButtons.OK);

                }
                else
                {
                    con.Close();
                   con.Open();
                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "INSERT INTO [dbo].[Table] (name, password) VALUES ('" + usernameInput.Text + "','" + passwordInput.Text + "')";
                    cmd2.ExecuteNonQuery();
                  con.Close() ;
                    MessageBox.Show("Signed up succesfully", "", MessageBoxButtons.OK);
                    menu menu = new menu();
                    menu.Show();
                    this.Close();
                }

                con.Close();
                /*string insertQuery = "INSERT INTO [dbo].[Table] (name,password) VALUES (@Value1, @Value2)";

                using (SqlCommand command = new SqlCommand(insertQuery, con))
                {
                    // Replace value1 and value2 with your actual values
                    command.Parameters.AddWithValue("@Value1", usernameInput.Text);
                    command.Parameters.AddWithValue("@Value2", passwordInput.Text);

                    command.ExecuteNonQuery();
                }*/


            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void backbnt_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Close();
        }
    }
}
