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
        private List<Button> currentFuncButtons;
        private List<Button> agentFuncButtons;
        private List<Button> houseFuncButtons;
        private List<Button> memberFuncButtons;
        private List<Button> otherFuncButtons;
        public MainForm()
        {
            InitializeComponent();
            InitAgentButtons();
            InitMemberFuncButtons();
            InitHouseFuncButtons();
            InitOtherFuncButtons();
        }
        private void InitOtherFuncButtons()
        {
            otherFuncButtons = new List<Button>();
            otherFuncButtons.Add(otherButton1);
            //add other function buttons here ...
        }
        private void InitMemberFuncButtons()
        {
            memberFuncButtons = new List<Button>();
            memberFuncButtons.Add(memberButton1);
            memberFuncButtons.Add(memberButton2);
            //add your member function buttons here...
        }
        private void InitHouseFuncButtons()
        {
            houseFuncButtons = new List<Button>();
            houseFuncButtons.Add(houseButtons1);
            //add your house functions buttons here....
        }
        private void InitAgentButtons()
        {
            agentFuncButtons = new List<Button>();
            agentFuncButtons.Add(this.agentButton1);
            agentFuncButtons.Add(this.agentButton2);
            agentFuncButtons.Add(this.agentButton3);
        }
        private void ShowButtonsToUser(List<Button> buttons, bool makeSure)
        {
            if (makeSure)
            {
                if (buttons != currentFuncButtons)
                {
                    foreach (Button button in currentFuncButtons)
                    {
                        button.Hide();
                    }
                    foreach (Button button in buttons)
                    {
                        button.Show();
                    }
                    currentFuncButtons = buttons;
                }
            }
            else
            {
                foreach (Button button in buttons)
                {
                    button.Hide();
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //初始化当前显示功能为经纪人
            currentFuncButtons = agentFuncButtons;
            ShowButtonsToUser(agentFuncButtons, true);

            ShowButtonsToUser(houseFuncButtons, false);
            ShowButtonsToUser(memberFuncButtons, false);
            ShowButtonsToUser(otherFuncButtons, false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowButtonsToUser(agentFuncButtons, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowButtonsToUser(houseFuncButtons, true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowButtonsToUser(memberFuncButtons, true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowButtonsToUser(otherFuncButtons, true);
        }
    }
}
