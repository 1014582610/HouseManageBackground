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
    public partial class SaleHouseForm : Form
    {
        public SaleHouseForm()
        {
            InitializeComponent();
        }

        private void salehouseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salehouseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fcglDataSet);

        }

        private void salehouseBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.salehouseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fcglDataSet);

        }

        private void SaleHouseForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“fcglDataSet.agent”中。您可以根据需要移动或删除它。
            this.agentTableAdapter.Fill(this.fcglDataSet.agent);
            // TODO: 这行代码将数据加载到表“fcglDataSet.person”中。您可以根据需要移动或删除它。
            this.personTableAdapter.Fill(this.fcglDataSet.person);
            // TODO: 这行代码将数据加载到表“fcglDataSet.member”中。您可以根据需要移动或删除它。
            this.memberTableAdapter.Fill(this.fcglDataSet.member);
            // TODO: 这行代码将数据加载到表“fcglDataSet.address”中。您可以根据需要移动或删除它。
            this.addressTableAdapter.Fill(this.fcglDataSet.address);
            // TODO: 这行代码将数据加载到表“fcglDataSet.house”中。您可以根据需要移动或删除它。
            this.houseTableAdapter.Fill(this.fcglDataSet.house);
            // TODO: 这行代码将数据加载到表“fcglDataSet.house”中。您可以根据需要移动或删除它。
            this.houseTableAdapter.Fill(this.fcglDataSet.house);
            // TODO: 这行代码将数据加载到表“fcglDataSet.salehouse”中。您可以根据需要移动或删除它。
            this.salehouseTableAdapter.Fill(this.fcglDataSet.salehouse);


            //隐藏详细信息面板
            panelDetail.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelDetail.Hide();
        }

        private void buttonToDetail_Click(object sender, EventArgs e)
        {
            panelDetail.Show();
            panelDetail.Dock = DockStyle.Fill;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
