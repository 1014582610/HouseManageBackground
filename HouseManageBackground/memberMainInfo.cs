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
            textBox4.Text = row["email"].ToString();
            textBox5.Text = row["phone"].ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
