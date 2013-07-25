using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HouseManageBackground
{
    public partial class memberMainInfo : Form
    {
        public memberMainInfo()
        {
            InitializeComponent();

        }
        public void form_load(DataRow row)
        {
            textBox1.Text = row["names"].ToString();
            textBox2.Text = row["password"].ToString();
            textBox3.Text = row["identity_number"].ToString();
            textBox4.Text = row["email"].ToString();
            textBox5.Text = row["phone"].ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.ReadOnly = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.ReadOnly = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.ReadOnly = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
