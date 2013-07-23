using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.TemplateEngine;
namespace HouseManageBackground
{
    public partial class memberForm1 : Form
    {
        int pageSize = 0;
        int pageMaxSize = 0;
        int pageCount = 0;
        int pageCurrent = 0;
        int lineCurrent = 0;
        BindingSource source = new BindingSource();
        public memberForm1()
        {
            InitializeComponent();
        }

        private void memberForm1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“fcglDataSet.person”中。您可以根据需要移动或删除它。
            this.personTableAdapter.Fill(this.fcglDataSet.person);
            
            InitDataset();
        }
        private void InitDataset()
        {
            pageSize = 2;
            pageMaxSize = this.fcglDataSet.person.Rows.Count;
            pageCount = (pageMaxSize / pageSize);
            if ((pageMaxSize % pageSize) > 0)
            {
                pageCount++;
            }
            pageCurrent = 1;
            lineCurrent = 0;
            LoadData();
        }
        private void LoadData()
        {
            int startPosition = 0;
            int endPosition = 0;
            DataTable table = this.fcglDataSet.person.Clone();
            if (pageCurrent == pageCount)
            {
                endPosition = pageMaxSize;
            }
            else
            {
                endPosition = pageSize * pageCurrent;
            }

            startPosition = lineCurrent;
            everypageCount.Text = pageCurrent.ToString();
            totalCount.Text = "/ "+pageCount;
            for (int i = startPosition; i < endPosition; i++)
            {
                table.ImportRow(this.fcglDataSet.person.Rows[i]);
                lineCurrent++;
            }
            table.Columns.Remove("photo");
            source.DataSource = table;
            bindingNavigator1.BindingSource = source;
            dataGridView1.DataSource = source;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pageCurrent--;
            toolStripButton4.Enabled = true;
            if (pageCurrent <= 0)
            {
                toolStripButton2.Enabled = false;
                return;
            }
            else
            {
                if (pageCurrent == 1)
                {
                    toolStripButton2.Enabled = false;
                }
                lineCurrent = pageSize * (pageCurrent - 1);              
            }       
            LoadData();
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            pageCurrent++;
            toolStripButton2.Enabled = true;
            if (pageCurrent > pageCount)
            {
                toolStripButton4.Enabled = false;
                return;
            }
            else
            {
                if (pageCurrent == pageCount)
                {
                    toolStripButton4.Enabled = false;
                }
                lineCurrent = pageSize * (pageCurrent - 1);
            }
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {
                    DataTable table1 = this.fcglDataSet.person.Clone();
                    DataTable table2 = this.fcglDataSet.member.Clone();
                    for (int i = 0; i < this.fcglDataSet.person.Count; i++)
                    {
                        table1.ImportRow(this.fcglDataSet.person.Rows[i]);
                    }
                    for (int i = 0; i < this.fcglDataSet.member.Count; i++)
                    {
                        table2.ImportRow(this.fcglDataSet.member.Rows[i]);
                    }
                    table1.Merge(table2,true);
                    MessageBox.Show(table1.Rows[1]["names"].ToString());
                    /*DataRow row = this.fcglDataSet.person[e.RowIndex];
                    memberMainInfo form = new memberMainInfo();
                    form.Show();
                    form.form_load(row);*/
                }
            }
        }

    }
}
