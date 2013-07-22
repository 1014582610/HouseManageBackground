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
    public partial class memberForm1 : Form
    {
        public memberForm1()
        {
            InitializeComponent();
        }

        private void memberForm1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“housemanagementDataSet.person”中。您可以根据需要移动或删除它。
            this.personTableAdapter.Fill(this.housemanagementDataSet.person);

        }
    }
}
