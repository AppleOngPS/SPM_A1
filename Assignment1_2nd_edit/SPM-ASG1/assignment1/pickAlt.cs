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
    public partial class pickAlt : Form
    {
        public pickAlt()
        {
            InitializeComponent();
        }

        private void q2bnt_Click(object sender, EventArgs e)
        {
            
                Q2 q2 = new Q2();
                q2.Show();
                this.Close();
            
        }

        private void q3bnt_Click(object sender, EventArgs e)
        {
            Q3 q3 = new Q3();
            q3.Show();
            this.Close();
        }
    }
}
