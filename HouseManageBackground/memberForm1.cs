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
        int pageSize = 0;
        int pageMaxSize = 0;
        int pageCount = 0;
        int pageCurrent = 0;
        int lineCurrent = 0;
        public memberForm1()
        {
            InitializeComponent();
        }

        private void memberForm1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“housemanagementDataSet.person”中。您可以根据需要移动或删除它。
            //this.personTableAdapter.Fill(this.housemanagementDataSet.person);
            InitDataset();
        }
        private void InitDataset()
        {
            pageSize = 1;
            pageMaxSize = this.housemanagementDataSet.person.Rows.Count;
            pageCount = (pageMaxSize / pageSize);
            if ((pageMaxSize % pageSize) > 0)
            {
                pageCount++;
            }
            pageCurrent = 1;
            lineCurrent = 0;

        }
        private void LoadData()
        {
 
        }
    }
}
