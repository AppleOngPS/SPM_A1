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
    public partial class displayHighScore : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\ongap\\OneDrive\\Desktop\\NP\\SPM\\8th edit\\Assignment1_2nd_edit\\SPM-ASG1\\assignment1\\Database1.mdf\";Integrated Security=True");
        public displayHighScore()
        {
            InitializeComponent();
        }

        private void displayHighScore_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TOP 10 * FROM [dbo].[Table]  ORDER BY score DESC ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["password"].Visible = false;
            dataGridView1.Columns[0].Visible = false;
            con.Close();
            CustomizeRowHeaders();
           
            

        }
        

        private void CustomizeRowHeaders()
        {
           
            // Handle the RowPostPaint event to customize row header content
            dataGridView1.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dataGridView1_RowPostPaint);
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Custom text to display in row headers
            string rowHeaderText = (e.RowIndex + 1).ToString(); // Example: rank (row number)

            // Calculate the size of the text
            SizeF textSize = e.Graphics.MeasureString(rowHeaderText, dataGridView1.Font);

            // Define the bounds for the text
            Rectangle bounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dataGridView1.RowHeadersWidth, e.RowBounds.Height);

            // Draw the text
            e.Graphics.DrawString(rowHeaderText, dataGridView1.Font, Brushes.Black, bounds.X + (bounds.Width - textSize.Width) / 2, bounds.Y + (bounds.Height - textSize.Height) / 2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
