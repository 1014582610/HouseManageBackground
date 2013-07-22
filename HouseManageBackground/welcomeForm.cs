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
    public partial class WelcomeForm : Form
    {
        string name = "111";
        string password = "111";
        int max = 0;
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == name)
            {
                if (textBox2.Text == password)
                {
                    if (max < 3)
                    {
                        max++;
                        MainForm form = new MainForm();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("已达到最大连接数！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("密码错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("用户名错误！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
