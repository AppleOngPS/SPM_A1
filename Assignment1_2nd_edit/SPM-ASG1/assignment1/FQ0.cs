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
    public partial class FQ0 : Form
    {
        public FQ0()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SharedData.turn == 1)
            {


                SharedData.PreviousOption = SharedData.building;
                SharedData.building = button1.Text;
                SharedData.CurrentOption = SharedData.building;

                FQ1 fQ1 = new FQ1();
                fQ1.Show();
                this.Close();

            }
            else
            {
                //SharedData.point += 1;

                SharedData.PreviousOption = SharedData.building;
                SharedData.building = button1.Text;
                SharedData.CurrentOption = SharedData.building;
                if (SharedData.TFlag2 == true)
                {
                    FQ2 fQ2 = new FQ2();
                    fQ2.Show();
                    this.Close();
                }
                else if (SharedData.TFlag3 == true)
                {
                    FQ3 fQ3 = new FQ3();
                    fQ3.Show();
                    this.Close();
                }
                else
                {
                    FQ1 fQ1 = new FQ1();
                    fQ1.Show();
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SharedData.turn == 1)
            {


                SharedData.PreviousOption = SharedData.building;
                SharedData.building = button2.Text;
                SharedData.CurrentOption = SharedData.building;

                FQ1 fQ1 = new FQ1();
                fQ1.Show();
                this.Close();

            }
            else
            {
                //SharedData.point += 1;

                SharedData.PreviousOption = SharedData.building;
                SharedData.building = button2.Text;
                SharedData.CurrentOption = SharedData.building;
                if (SharedData.TFlag2 == true)
                {
                    FQ2 fQ2 = new FQ2();
                    fQ2.Show();
                    this.Close();
                }
                else if (SharedData.TFlag3 == true)
                {
                    FQ3 fQ3 = new FQ3();
                    fQ3.Show();
                    this.Close();
                }
                else
                {
                    FQ1 fQ1 = new FQ1();
                    fQ1.Show();
                    this.Close();
                }
            }
        }

        private void FQ0_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SharedData.turn == 1)
            {


                SharedData.PreviousOption = SharedData.building;
                SharedData.building = button3.Text;
                SharedData.CurrentOption = SharedData.building;

                FQ1 fQ1 = new FQ1();
                fQ1.Show();
                this.Close();

            }
            else
            {
                //SharedData.point += 1;

                SharedData.PreviousOption = SharedData.building;
                SharedData.building = button3.Text;
                SharedData.CurrentOption = SharedData.building;
                if (SharedData.TFlag2 == true)
                {
                    FQ2 fQ2 = new FQ2();
                    fQ2.Show();
                    this.Close();
                }
                else if (SharedData.TFlag3 == true)
                {
                    FQ3 fQ3 = new FQ3();
                    fQ3.Show();
                    this.Close();
                }
                else
                {
                    FQ1 fQ1 = new FQ1();
                    fQ1.Show();
                    this.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SharedData.turn == 1)
            {


                SharedData.PreviousOption = SharedData.building;
                SharedData.building = button4.Text;
                SharedData.CurrentOption = SharedData.building;

                FQ1 fQ1 = new FQ1();
                fQ1.Show();
                this.Close();

            }
            else
            {
                //SharedData.point += 1;

                SharedData.PreviousOption = SharedData.building;
                SharedData.building = button4.Text;
                SharedData.CurrentOption = SharedData.building;
                if (SharedData.TFlag2 == true)
                {
                    FQ2 fQ2 = new FQ2();
                    fQ2.Show();
                    this.Close();
                }
                else if (SharedData.TFlag3 == true)
                {
                    FQ3 fQ3 = new FQ3();
                    fQ3.Show();
                    this.Close();
                }
                else
                {
                    FQ1 fQ1 = new FQ1();
                    fQ1.Show();
                    this.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (SharedData.turn == 1)
            {


                SharedData.PreviousOption = SharedData.building;
                SharedData.building = button5.Text;
                SharedData.CurrentOption = SharedData.building;

                FQ1 fQ1 = new FQ1();
                fQ1.Show();
                this.Close();

            }
            else
            {
                //SharedData.point += 1;

                SharedData.PreviousOption = SharedData.building;
                SharedData.building = button5.Text;
                SharedData.CurrentOption = SharedData.building;
                if (SharedData.TFlag2 == true)
                {
                    FQ2 fQ2 = new FQ2();
                    fQ2.Show();
                    this.Close();
                }
                else if (SharedData.TFlag3 == true)
                {
                    FQ3 fQ3 = new FQ3();
                    fQ3.Show();
                    this.Close();
                }
                else
                {
                    FQ1 fQ1 = new FQ1();
                    fQ1.Show();
                    this.Close();
                }
            }
        }
    }
}
