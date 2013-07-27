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
    public partial class Delegate : Form
    {
        private int agentID;
        public int agentid
        {
            get { return agentID; }
            set { agentID = value; }
        }

        public Delegate()
        {
            InitializeComponent();
            //   
        }

        private void delegateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.delegateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fcglDataSet);

        }

        private void 委托信息_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“fcglDataSet._delegate”中。您可以根据需要移动或删除它。
            //this.delegateTableAdapter.Fill(this.fcglDataSet._delegate);
            string str = "select * from delegate where agent = @agent";
            SqlParameter[] paras = new SqlParameter[] { new SqlParameter("@agent", this.agentid) };
            DataBase db = new DataBase();
            db.Fill_Table(str, this.fcglDataSet._delegate, paras);
            //MessageBox.Show("house:"+this.fcglDataSet._delegate.Rows[0]["house"].ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //此时已经有了agent编号了，在通过选中某行得到house，member的编号就能通过三者联合主码删除该委托
            //MessageBox.Show("删除agent编号为" + this.agentid.ToString() + "的委托");
            if (this.delegateDataGridView.SelectedRows.Count == 1)
            {
                //记录下要被删除的管理记录中的house数值，以便在数据库中进行实际删除
                int member_id = (int)this.delegateDataGridView.CurrentRow.Cells[0].Value;
                int agent_id = (int)this.delegateDataGridView.CurrentRow.Cells[1].Value;
                int house_id = (int)this.delegateDataGridView.CurrentRow.Cells[2].Value;
                this.delegateDataGridView.Rows.Remove(this.delegateDataGridView.CurrentRow);
                string str = "delete from delegate where member = @member and agent = @agent and house = @house";
                SqlParameter[] paras = new SqlParameter[] { new SqlParameter("@member", member_id), new SqlParameter("@agent", agent_id), new SqlParameter("@house", house_id) };
                DataBase db = new DataBase();
                db.Delete_Row(str, this.fcglDataSet._delegate, paras);
            }
        }
       
    }
}
