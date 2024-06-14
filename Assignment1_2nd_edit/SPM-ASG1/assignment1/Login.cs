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

namespace assignment1
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ongap\\OneDrive\\Desktop\\NP\\SPM\\Assignment1_2nd_edit\\SPM-ASG1\\assignment1\\Database1.mdf;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void submitBttn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From [dbo].[Table] WHERE name='" + usernameInput.Text + "' and password='"+passwordInput.Text+"'";
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                string name = dr["Name"].ToString();
                SharedData.Data = name;
                menu menu = new menu();
                menu.Show();
                
                this.Close();

                MessageBox.Show("Login succesfully.", "valid Message", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                usernameInput.Text = "";
                passwordInput.Text = "";

                MessageBox.Show("Please choose a unique username or wrong password.", "Invalid Message", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            con.Close();
        }
    }
}
