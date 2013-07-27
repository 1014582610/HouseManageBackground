namespace HouseManageBackground
{
    partial class Delegate
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
            System.Windows.Forms.Label memberLabel;
            System.Windows.Forms.Label agentLabel;
            System.Windows.Forms.Label houseLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label messagesLabel;
            System.Windows.Forms.Label stateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delegate));
            this.fcglDataSet = new HouseManageBackground.fcglDataSet();
            this.delegateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delegateTableAdapter = new HouseManageBackground.fcglDataSetTableAdapters.delegateTableAdapter();
            this.tableAdapterManager = new HouseManageBackground.fcglDataSetTableAdapters.TableAdapterManager();
            this.delegateBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.delegateDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberLabel1 = new System.Windows.Forms.Label();
            this.agentLabel1 = new System.Windows.Forms.Label();
            this.houseLabel1 = new System.Windows.Forms.Label();
            this.dateLabel1 = new System.Windows.Forms.Label();
            this.messagesLabel1 = new System.Windows.Forms.Label();
            this.stateLabel1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            memberLabel = new System.Windows.Forms.Label();
            agentLabel = new System.Windows.Forms.Label();
            houseLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            messagesLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fcglDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delegateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delegateBindingNavigator)).BeginInit();
            this.delegateBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delegateDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberLabel
            // 
            memberLabel.AutoSize = true;
            memberLabel.Location = new System.Drawing.Point(16, 26);
            memberLabel.Name = "memberLabel";
            memberLabel.Size = new System.Drawing.Size(59, 12);
            memberLabel.TabIndex = 2;
            memberLabel.Text = "会员编号:";
            // 
            // agentLabel
            // 
            agentLabel.AutoSize = true;
            agentLabel.Location = new System.Drawing.Point(16, 49);
            agentLabel.Name = "agentLabel";
            agentLabel.Size = new System.Drawing.Size(71, 12);
            agentLabel.TabIndex = 4;
            agentLabel.Text = "经纪人信息:";
            // 
            // houseLabel
            // 
            houseLabel.AutoSize = true;
            houseLabel.Location = new System.Drawing.Point(16, 72);
            houseLabel.Name = "houseLabel";
            houseLabel.Size = new System.Drawing.Size(59, 12);
            houseLabel.TabIndex = 6;
            houseLabel.Text = "房子编号:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(16, 95);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(35, 12);
            dateLabel.TabIndex = 8;
            dateLabel.Text = "日期:";
            // 
            // messagesLabel
            // 
            messagesLabel.AutoSize = true;
            messagesLabel.Location = new System.Drawing.Point(16, 118);
            messagesLabel.Name = "messagesLabel";
            messagesLabel.Size = new System.Drawing.Size(35, 12);
            messagesLabel.TabIndex = 10;
            messagesLabel.Text = "信息:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(16, 141);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 12);
            stateLabel.TabIndex = 12;
            stateLabel.Text = "状态:";
            // 
            // fcglDataSet
            // 
            this.fcglDataSet.DataSetName = "fcglDataSet";
            this.fcglDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // delegateBindingSource
            // 
            this.delegateBindingSource.DataMember = "delegate";
            this.delegateBindingSource.DataSource = this.fcglDataSet;
            // 
            // delegateTableAdapter
            // 
            this.delegateTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = null;
            this.tableAdapterManager.agentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.delegateTableAdapter = this.delegateTableAdapter;
            this.tableAdapterManager.houseTableAdapter = null;
            this.tableAdapterManager.manageTableAdapter = null;
            this.tableAdapterManager.memberTableAdapter = null;
            this.tableAdapterManager.personTableAdapter = null;
            this.tableAdapterManager.photoTableAdapter = null;
            this.tableAdapterManager.renthouseTableAdapter = null;
            this.tableAdapterManager.salehouseTableAdapter = null;
            this.tableAdapterManager.settingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HouseManageBackground.fcglDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // delegateBindingNavigator
            // 
            this.delegateBindingNavigator.AddNewItem = null;
            this.delegateBindingNavigator.BindingSource = this.delegateBindingSource;
            this.delegateBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.delegateBindingNavigator.DeleteItem = null;
            this.delegateBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.delegateBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.delegateBindingNavigator.Location = new System.Drawing.Point(12, 159);
            this.delegateBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.delegateBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.delegateBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.delegateBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.delegateBindingNavigator.Name = "delegateBindingNavigator";
            this.delegateBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.delegateBindingNavigator.Size = new System.Drawing.Size(206, 25);
            this.delegateBindingNavigator.TabIndex = 0;
            this.delegateBindingNavigator.Text = "bindingNavigator1";
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
            // delegateDataGridView
            // 
            this.delegateDataGridView.AllowUserToAddRows = false;
            this.delegateDataGridView.AllowUserToDeleteRows = false;
            this.delegateDataGridView.AllowUserToOrderColumns = true;
            this.delegateDataGridView.AutoGenerateColumns = false;
            this.delegateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.delegateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.delegateDataGridView.DataSource = this.delegateBindingSource;
            this.delegateDataGridView.Location = new System.Drawing.Point(12, 12);
            this.delegateDataGridView.Name = "delegateDataGridView";
            this.delegateDataGridView.ReadOnly = true;
            this.delegateDataGridView.RowTemplate.Height = 23;
            this.delegateDataGridView.Size = new System.Drawing.Size(643, 144);
            this.delegateDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "member";
            this.dataGridViewTextBoxColumn1.HeaderText = "member";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "agent";
            this.dataGridViewTextBoxColumn2.HeaderText = "agent";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "house";
            this.dataGridViewTextBoxColumn3.HeaderText = "house";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn4.HeaderText = "date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "messages";
            this.dataGridViewTextBoxColumn5.HeaderText = "messages";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "state";
            this.dataGridViewTextBoxColumn6.HeaderText = "state";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // memberLabel1
            // 
            this.memberLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delegateBindingSource, "member", true));
            this.memberLabel1.Location = new System.Drawing.Point(100, 26);
            this.memberLabel1.Name = "memberLabel1";
            this.memberLabel1.Size = new System.Drawing.Size(100, 23);
            this.memberLabel1.TabIndex = 3;
            this.memberLabel1.Text = "label1";
            // 
            // agentLabel1
            // 
            this.agentLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delegateBindingSource, "agent", true));
            this.agentLabel1.Location = new System.Drawing.Point(100, 49);
            this.agentLabel1.Name = "agentLabel1";
            this.agentLabel1.Size = new System.Drawing.Size(100, 23);
            this.agentLabel1.TabIndex = 5;
            this.agentLabel1.Text = "label1";
            // 
            // houseLabel1
            // 
            this.houseLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delegateBindingSource, "house", true));
            this.houseLabel1.Location = new System.Drawing.Point(100, 72);
            this.houseLabel1.Name = "houseLabel1";
            this.houseLabel1.Size = new System.Drawing.Size(100, 23);
            this.houseLabel1.TabIndex = 7;
            this.houseLabel1.Text = "label1";
            // 
            // dateLabel1
            // 
            this.dateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delegateBindingSource, "date", true));
            this.dateLabel1.Location = new System.Drawing.Point(100, 95);
            this.dateLabel1.Name = "dateLabel1";
            this.dateLabel1.Size = new System.Drawing.Size(100, 23);
            this.dateLabel1.TabIndex = 9;
            this.dateLabel1.Text = "label1";
            // 
            // messagesLabel1
            // 
            this.messagesLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delegateBindingSource, "messages", true));
            this.messagesLabel1.Location = new System.Drawing.Point(100, 118);
            this.messagesLabel1.Name = "messagesLabel1";
            this.messagesLabel1.Size = new System.Drawing.Size(100, 23);
            this.messagesLabel1.TabIndex = 11;
            this.messagesLabel1.Text = "label1";
            // 
            // stateLabel1
            // 
            this.stateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delegateBindingSource, "state", true));
            this.stateLabel1.Location = new System.Drawing.Point(100, 141);
            this.stateLabel1.Name = "stateLabel1";
            this.stateLabel1.Size = new System.Drawing.Size(100, 23);
            this.stateLabel1.TabIndex = 13;
            this.stateLabel1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(memberLabel);
            this.groupBox1.Controls.Add(this.stateLabel1);
            this.groupBox1.Controls.Add(this.memberLabel1);
            this.groupBox1.Controls.Add(stateLabel);
            this.groupBox1.Controls.Add(agentLabel);
            this.groupBox1.Controls.Add(this.messagesLabel1);
            this.groupBox1.Controls.Add(this.agentLabel1);
            this.groupBox1.Controls.Add(messagesLabel);
            this.groupBox1.Controls.Add(houseLabel);
            this.groupBox1.Controls.Add(this.dateLabel1);
            this.groupBox1.Controls.Add(this.houseLabel1);
            this.groupBox1.Controls.Add(dateLabel);
            this.groupBox1.Location = new System.Drawing.Point(42, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 164);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "委托详细信息";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "委托房源信息";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "房东会员信息";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(305, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 164);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "审核相关信息";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(549, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 46);
            this.button4.TabIndex = 19;
            this.button4.Text = "删除委托";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Delegate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 402);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.delegateDataGridView);
            this.Controls.Add(this.delegateBindingNavigator);
            this.Name = "Delegate";
            this.Text = "委托";
            this.Load += new System.EventHandler(this.委托信息_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fcglDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delegateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delegateBindingNavigator)).EndInit();
            this.delegateBindingNavigator.ResumeLayout(false);
            this.delegateBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delegateDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private fcglDataSet fcglDataSet;
        private System.Windows.Forms.BindingSource delegateBindingSource;
        private fcglDataSetTableAdapters.delegateTableAdapter delegateTableAdapter;
        private fcglDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator delegateBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView delegateDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label memberLabel1;
        private System.Windows.Forms.Label agentLabel1;
        private System.Windows.Forms.Label houseLabel1;
        private System.Windows.Forms.Label dateLabel1;
        private System.Windows.Forms.Label messagesLabel1;
        private System.Windows.Forms.Label stateLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
    }
}