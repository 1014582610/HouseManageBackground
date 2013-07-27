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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            agentPanel.Show();
            agentPanel.Dock = DockStyle.Fill;
            housePanel.Hide();
            memberPanel.Hide();
            otherPanel.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (agentPanel.Visible == false)
            {
                agentPanel.Show();
                agentPanel.Dock = DockStyle.Fill;
                housePanel.Hide();
                memberPanel.Hide();
                otherPanel.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (housePanel.Visible == false)
            {
                housePanel.Show();
                housePanel.Dock = DockStyle.Fill;
                agentPanel.Hide();
                memberPanel.Hide();
                otherPanel.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (memberPanel.Visible == false)
            {
                memberPanel.Show();
                memberPanel.Dock = DockStyle.Fill;
                agentPanel.Hide();
                housePanel.Hide();
                otherPanel.Hide();
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (otherPanel.Visible == false)
            {
                otherPanel.Show();
                otherPanel.Dock = DockStyle.Fill;
                memberPanel.Hide();
                housePanel.Hide();
                agentPanel.Hide();
            }
        }

        private void memberButton1_Click(object sender, EventArgs e)
        {
            memberForm1 form = new memberForm1();
            form.Show();

        }

        private void memberButton3_Click(object sender, EventArgs e)
        {
            HouseSelectForm form = new HouseSelectForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewerRegistion nr = new NewerRegistion();
            nr.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AgentForm af = new AgentForm();
            af.Show();
        }
    }
}
