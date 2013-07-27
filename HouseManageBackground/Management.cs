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
    public partial class Management : Form
    {
        private int agentID;
        public int agentid
        {
            get { return agentID; }
            set { agentID = value; }
        }

        public Management()
        {
            InitializeComponent();
        }

        private void manageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fcglDataSet);

        }

        private void Management_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“fcglDataSet.manage”中。您可以根据需要移动或删除它。
            //this.manageTableAdapter.Fill(this.fcglDataSet.manage);
            string str = "select * from manage where [agent] = @agent";
            SqlParameter[] paras = new SqlParameter[] { new SqlParameter("@agent", this.agentid) };
            DataBase db = new DataBase();
            db.Fill_Table(str, this.fcglDataSet.manage, paras);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.manageDataGridView.SelectedRows.Count == 1)
            {
                //记录下要被删除的管理记录中的house数值，以便在数据库中进行实际删除
                int house_id = (int)this.manageDataGridView.CurrentRow.Cells[0].Value;
                this.manageDataGridView.Rows.Remove(this.manageDataGridView.CurrentRow);
                string str = "delete from manage where [house] = @house";
                SqlParameter[] paras = new SqlParameter[] { new SqlParameter("@house", house_id) };
                DataBase db = new DataBase();
                db.Delete_Row(str, this.fcglDataSet.manage, paras);
            }
        }
    }
}
