using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HouseManageBackground
{
    public partial class AgentForm : Form
    {
        public AgentForm()
        {
            InitializeComponent();
        }

        private void agentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fcglDataSet);

        }

        private void AgentForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“fcglDataSet.person”中。您可以根据需要移动或删除它。
            this.personTableAdapter.Fill(this.fcglDataSet.person);
            // TODO: 这行代码将数据加载到表“fcglDataSet.agent”中。您可以根据需要移动或删除它。
            this.agentTableAdapter.Fill(this.fcglDataSet.agent);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.agentDataGridView.SelectedRows.Count == 1)
            {
                Delegate dg = new Delegate();
                dg.agentid = (int)(this.agentDataGridView.SelectedRows[0].Cells[0].Value);
                //MessageBox.Show(dg.agentid.ToString());
                dg.Show();
            }
            else
            {
                MessageBox.Show("请选中一个经纪人");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.agentDataGridView.SelectedRows.Count == 1)
            {
                Management mm = new Management();
                mm.agentid = (int)(this.agentDataGridView.SelectedRows[0].Cells[0].Value);
                mm.Show();
            }
            else
            {
                MessageBox.Show("请选中一个经纪人");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.searchTextBox.Text.Length > 0)
            {
                this.fcglDataSet.agent.Clear();
                DataBase db = new DataBase();
                db.Fill_Table_ByName(this.searchTextBox.Text,this.fcglDataSet.agent);
                //int id = db.Find_PK_ByName(this.searchTextBox.Text);
                //string str = "select * from agent where person_id =" + id;
                //db.Fill_Table(str, this.fcglDataSet.agent);
                //MessageBox.Show(this.fcglDataSet.agent.Rows[0][0].ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.agentTableAdapter.Fill(this.fcglDataSet.agent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agentBindingSource.RemoveCurrent();
            this.agentTableAdapter.Update(this.fcglDataSet.agent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.agentDataGridView.SelectedRows.Count == 1)
            {
                int index = this.agentDataGridView.SelectedRows[0].Index;
                //视图推送到dataset
                agentBindingSource.EndEdit();
                //dataset推送到数据库
                this.agentTableAdapter.Update(this.fcglDataSet.agent);
                //更新person
                DataBase db = new DataBase();
                string str = "update person set names = '"+ this.namesTextBox.Text +"',phone = '"+ this.phoneTextBox.Text +"'where person_id = '"+ this.fcglDataSet.agent.Rows[index]["person_id"] +"'";
                if (db.Update_Row(str) == 1)
                {
                    MessageBox.Show("更新成功");
                }
                else
                {
                    MessageBox.Show("更新失败");
                }
                this.personTableAdapter.Update(this.fcglDataSet.person);
            }
            else
            {
                MessageBox.Show("请选中一个经纪人");
            }
        }
    }
}
