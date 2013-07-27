namespace HouseManageBackground
{
    partial class Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label houseLabel;
            System.Windows.Forms.Label agentLabel;
            System.Windows.Forms.Label dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            this.fcglDataSet = new HouseManageBackground.fcglDataSet();
            this.manageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manageTableAdapter = new HouseManageBackground.fcglDataSetTableAdapters.manageTableAdapter();
            this.tableAdapterManager = new HouseManageBackground.fcglDataSetTableAdapters.TableAdapterManager();
            this.manageBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.manageDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseLabel1 = new System.Windows.Forms.Label();
            this.agentLabel1 = new System.Windows.Forms.Label();
            this.dateLabel1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            houseLabel = new System.Windows.Forms.Label();
            agentLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fcglDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageBindingNavigator)).BeginInit();
            this.manageBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // houseLabel
            // 
            houseLabel.AutoSize = true;
            houseLabel.Location = new System.Drawing.Point(16, 32);
            houseLabel.Name = "houseLabel";
            houseLabel.Size = new System.Drawing.Size(59, 12);
            houseLabel.TabIndex = 2;
            houseLabel.Text = "房源编号:";
            // 
            // agentLabel
            // 
            agentLabel.AutoSize = true;
            agentLabel.Location = new System.Drawing.Point(16, 55);
            agentLabel.Name = "agentLabel";
            agentLabel.Size = new System.Drawing.Size(71, 12);
            agentLabel.TabIndex = 4;
            agentLabel.Text = "经纪人编号:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(16, 78);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(59, 12);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "管理日期:";
            // 
            // fcglDataSet
            // 
            this.fcglDataSet.DataSetName = "fcglDataSet";
            this.fcglDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manageBindingSource
            // 
            this.manageBindingSource.DataMember = "manage";
            this.manageBindingSource.DataSource = this.fcglDataSet;
            // 
            // manageTableAdapter
            // 
            this.manageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = null;
            this.tableAdapterManager.agentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.delegateTableAdapter = null;
            this.tableAdapterManager.houseTableAdapter = null;
            this.tableAdapterManager.manageTableAdapter = this.manageTableAdapter;
            this.tableAdapterManager.memberTableAdapter = null;
            this.tableAdapterManager.personTableAdapter = null;
            this.tableAdapterManager.photoTableAdapter = null;
            this.tableAdapterManager.renthouseTableAdapter = null;
            this.tableAdapterManager.salehouseTableAdapter = null;
            this.tableAdapterManager.settingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HouseManageBackground.fcglDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // manageBindingNavigator
            // 
            this.manageBindingNavigator.AddNewItem = null;
            this.manageBindingNavigator.BindingSource = this.manageBindingSource;
            this.manageBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.manageBindingNavigator.DeleteItem = null;
            this.manageBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.manageBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.manageBindingNavigator.Location = new System.Drawing.Point(12, 136);
            this.manageBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.manageBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.manageBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.manageBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.manageBindingNavigator.Name = "manageBindingNavigator";
            this.manageBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.manageBindingNavigator.Size = new System.Drawing.Size(206, 25);
            this.manageBindingNavigator.TabIndex = 0;
            this.manageBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // manageDataGridView
            // 
            this.manageDataGridView.AllowUserToAddRows = false;
            this.manageDataGridView.AllowUserToDeleteRows = false;
            this.manageDataGridView.AllowUserToOrderColumns = true;
            this.manageDataGridView.AutoGenerateColumns = false;
            this.manageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.manageDataGridView.DataSource = this.manageBindingSource;
            this.manageDataGridView.Location = new System.Drawing.Point(12, 12);
            this.manageDataGridView.Name = "manageDataGridView";
            this.manageDataGridView.ReadOnly = true;
            this.manageDataGridView.RowTemplate.Height = 23;
            this.manageDataGridView.Size = new System.Drawing.Size(343, 121);
            this.manageDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "house";
            this.dataGridViewTextBoxColumn1.HeaderText = "house";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "agent";
            this.dataGridViewTextBoxColumn2.HeaderText = "agent";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn3.HeaderText = "date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // houseLabel1
            // 
            this.houseLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manageBindingSource, "house", true));
            this.houseLabel1.Location = new System.Drawing.Point(93, 32);
            this.houseLabel1.Name = "houseLabel1";
            this.houseLabel1.Size = new System.Drawing.Size(64, 23);
            this.houseLabel1.TabIndex = 3;
            this.houseLabel1.Text = "label1";
            // 
            // agentLabel1
            // 
            this.agentLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manageBindingSource, "agent", true));
            this.agentLabel1.Location = new System.Drawing.Point(93, 55);
            this.agentLabel1.Name = "agentLabel1";
            this.agentLabel1.Size = new System.Drawing.Size(64, 23);
            this.agentLabel1.TabIndex = 5;
            this.agentLabel1.Text = "label1";
            // 
            // dateLabel1
            // 
            this.dateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manageBindingSource, "date", true));
            this.dateLabel1.Location = new System.Drawing.Point(93, 78);
            this.dateLabel1.Name = "dateLabel1";
            this.dateLabel1.Size = new System.Drawing.Size(64, 23);
            this.dateLabel1.TabIndex = 7;
            this.dateLabel1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(houseLabel);
            this.groupBox1.Controls.Add(this.dateLabel1);
            this.groupBox1.Controls.Add(this.houseLabel1);
            this.groupBox1.Controls.Add(dateLabel);
            this.groupBox1.Controls.Add(agentLabel);
            this.groupBox1.Controls.Add(this.agentLabel1);
            this.groupBox1.Location = new System.Drawing.Point(41, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 143);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "管理详细信息";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "房源信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "删除管理";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 353);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.manageDataGridView);
            this.Controls.Add(this.manageBindingNavigator);
            this.Name = "Management";
            this.Text = "管理相关";
            this.Load += new System.EventHandler(this.Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fcglDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageBindingNavigator)).EndInit();
            this.manageBindingNavigator.ResumeLayout(false);
            this.manageBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private fcglDataSet fcglDataSet;
        private System.Windows.Forms.BindingSource manageBindingSource;
        private fcglDataSetTableAdapters.manageTableAdapter manageTableAdapter;
        private fcglDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator manageBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView manageDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label houseLabel1;
        private System.Windows.Forms.Label agentLabel1;
        private System.Windows.Forms.Label dateLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}