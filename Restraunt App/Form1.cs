using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restraunt_App
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            total += (starter1.Text != "Nachos") ? 0 : 8 * tb1.Value;//Needs to be capitalized
            total += (starter1.Text != "Fries") ? 0 : 8 * tb1.Value;
            
            total += (starter2.Text != "Fries") ? 0 : 8 * tb2.Value;
            total += (starter2.Text != "Nachos") ? 0 : 8 * tb2.Value;

            total += (main1.Text != "Burger") ? 0 : 9 * tb3.Value;
            total += (main1.Text != "Steak") ? 0 : 19 * tb3.Value;
            total += (main1.Text != "Pizza") ? 0 : 4 * tb3.Value;

            total += (main2.Text != "Burger") ? 0 : 9 * tb4.Value;
            total += (main2.Text != "Steak") ? 0 : 19 * tb4.Value;
            total += (main2.Text != "Pizza") ? 0 : 4 * tb4.Value;

            total += (drinks1.Text == "Fanta") ? 0 : 2 * tb5.Value;
            total += (drinks1.Text == "Sprite") ? 0 : 2 * tb5.Value;
            //MessageBox.Show(total.ToString());
            totalLabel.Text = total.ToString();

            //total = 0;
        }


        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SkellXC");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SkellXC");
            Application.Exit();

        }
    }
}
