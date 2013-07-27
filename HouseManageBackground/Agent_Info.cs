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
    public partial class Agent_Info : Form
    {
        public Agent_Info()
        {
            InitializeComponent();
            //
            //string str1 = "select * from person";
            //string str2 = "select * from agent";
            //DataBase db = new DataBase();
            //db.Fill_Table(str1, this.fcglDataSet.person);
            //db.Fill_Table(str2, this.fcglDataSet.agent);

            //DataTable person_table = this.fcglDataSet.person;
            //DataTable agent_table = this.fcglDataSet.agent;
            //DataTable agent_person_table = person_table.Copy();
            //agent_person_table.Merge(agent_table);
            //agent_person_bindingSource.DataSource = this.fcglDataSet.agent;
            //agent_person_dataGridView1.DataSource = agent_person_bindingSource;
        }

        private void Agent_Info_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“fcglDataSet._delegate”中。您可以根据需要移动或删除它。
            this.delegateTableAdapter.Fill(this.fcglDataSet._delegate);
            // TODO: 这行代码将数据加载到表“fcglDataSet._delegate”中。您可以根据需要移动或删除它。
            this.delegateTableAdapter.Fill(this.fcglDataSet._delegate);
            // TODO: 这行代码将数据加载到表“fcglDataSet.person”中。您可以根据需要移动或删除它。
            this.personTableAdapter.Fill(this.fcglDataSet.person);
            // TODO: 这行代码将数据加载到表“fcglDataSet.agent”中。您可以根据需要移动或删除它。
            this.agentTableAdapter.Fill(this.fcglDataSet.agent);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = this.namesTextBox.ToString();
            string email = this.emailTextBox.ToString();
            string phone = this.phoneTextBox.ToString();
            string profession = this.professionTextBox.ToString();
            DateTime date1 = this.dateTimePicker1.Value;
            DateTime date2 = this.dateTimePicker2.Value;
            //
            DataBase db = new DataBase();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //解雇需要删除两条基本信息记录，以及相关的所有记录
            int person_id = (int)this.agentDataGridView.CurrentRow.Cells[0].Value;
            //删除person
            string str1 = "delete from person where [person_id] = @personId";
            SqlParameter[] paras1 = new SqlParameter[] { new SqlParameter("@personId", person_id) };
            DataBase db = new DataBase();
            db.Delete_Row(str1, this.fcglDataSet.person, paras1);
            //删除agent
            string str2 = "delete from agent where [person_id] = @agentId";
            SqlParameter[] paras2 = new SqlParameter[] { new SqlParameter("@agentId", person_id) };
            db.Delete_Row(str2, this.fcglDataSet.agent, paras2);
        }
    }
}
