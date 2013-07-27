namespace HouseManageBackground
{
    partial class AgentForm
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label namesLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label professionLabel;
            System.Windows.Forms.Label register_dateLabel;
            System.Windows.Forms.Label valid_dateLabel;
            System.Windows.Forms.Label trade_numberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentForm));
            this.fcglDataSet = new HouseManageBackground.fcglDataSet();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentTableAdapter = new HouseManageBackground.fcglDataSetTableAdapters.agentTableAdapter();
            this.tableAdapterManager = new HouseManageBackground.fcglDataSetTableAdapters.TableAdapterManager();
            this.agentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.agentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.professionTextBox = new System.Windows.Forms.TextBox();
            this.register_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valid_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.trade_numberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namesTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.personTableAdapter = new HouseManageBackground.fcglDataSetTableAdapters.personTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            emailLabel = new System.Windows.Forms.Label();
            namesLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            professionLabel = new System.Windows.Forms.Label();
            register_dateLabel = new System.Windows.Forms.Label();
            valid_dateLabel = new System.Windows.Forms.Label();
            trade_numberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fcglDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingNavigator)).BeginInit();
            this.agentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(17, 59);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 12);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "邮箱:";
            // 
            // namesLabel
            // 
            namesLabel.AutoSize = true;
            namesLabel.Location = new System.Drawing.Point(17, 32);
            namesLabel.Name = "namesLabel";
            namesLabel.Size = new System.Drawing.Size(35, 12);
            namesLabel.TabIndex = 2;
            namesLabel.Text = "姓名:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(17, 86);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(59, 12);
            phoneLabel.TabIndex = 4;
            phoneLabel.Text = "联系方式:";
            // 
            // professionLabel
            // 
            professionLabel.AutoSize = true;
            professionLabel.Location = new System.Drawing.Point(17, 113);
            professionLabel.Name = "professionLabel";
            professionLabel.Size = new System.Drawing.Size(35, 12);
            professionLabel.TabIndex = 8;
            professionLabel.Text = "就职:";
            // 
            // register_dateLabel
            // 
            register_dateLabel.AutoSize = true;
            register_dateLabel.Location = new System.Drawing.Point(17, 140);
            register_dateLabel.Name = "register_dateLabel";
            register_dateLabel.Size = new System.Drawing.Size(59, 12);
            register_dateLabel.TabIndex = 10;
            register_dateLabel.Text = "注册时间:";
            // 
            // valid_dateLabel
            // 
            valid_dateLabel.AutoSize = true;
            valid_dateLabel.Location = new System.Drawing.Point(17, 167);
            valid_dateLabel.Name = "valid_dateLabel";
            valid_dateLabel.Size = new System.Drawing.Size(59, 12);
            valid_dateLabel.TabIndex = 12;
            valid_dateLabel.Text = "到期时间:";
            // 
            // trade_numberLabel
            // 
            trade_numberLabel.AutoSize = true;
            trade_numberLabel.Location = new System.Drawing.Point(17, 194);
            trade_numberLabel.Name = "trade_numberLabel";
            trade_numberLabel.Size = new System.Drawing.Size(47, 12);
            trade_numberLabel.TabIndex = 14;
            trade_numberLabel.Text = "交易额:";
            // 
            // fcglDataSet
            // 
            this.fcglDataSet.DataSetName = "fcglDataSet";
            this.fcglDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataMember = "agent";
            this.agentBindingSource.DataSource = this.fcglDataSet;
            // 
            // agentTableAdapter
            // 
            this.agentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = null;
            this.tableAdapterManager.agentTableAdapter = this.agentTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.delegateTableAdapter = null;
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
            // agentBindingNavigator
            // 
            this.agentBindingNavigator.AddNewItem = null;
            this.agentBindingNavigator.BindingSource = this.agentBindingSource;
            this.agentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.agentBindingNavigator.DeleteItem = null;
            this.agentBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.agentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.agentBindingNavigator.Location = new System.Drawing.Point(45, 287);
            this.agentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.agentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.agentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.agentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.agentBindingNavigator.Name = "agentBindingNavigator";
            this.agentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.agentBindingNavigator.Size = new System.Drawing.Size(206, 25);
            this.agentBindingNavigator.TabIndex = 0;
            this.agentBindingNavigator.Text = "bindingNavigator1";
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
            // agentDataGridView
            // 
            this.agentDataGridView.AllowUserToAddRows = false;
            this.agentDataGridView.AllowUserToDeleteRows = false;
            this.agentDataGridView.AllowUserToOrderColumns = true;
            this.agentDataGridView.AutoGenerateColumns = false;
            this.agentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.agentDataGridView.DataSource = this.agentBindingSource;
            this.agentDataGridView.Location = new System.Drawing.Point(45, 64);
            this.agentDataGridView.Name = "agentDataGridView";
            this.agentDataGridView.ReadOnly = true;
            this.agentDataGridView.RowTemplate.Height = 23;
            this.agentDataGridView.Size = new System.Drawing.Size(543, 220);
            this.agentDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "person_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "person_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "profession";
            this.dataGridViewTextBoxColumn2.HeaderText = "profession";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "register_date";
            this.dataGridViewTextBoxColumn3.HeaderText = "register_date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valid_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "valid_date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "trade_number";
            this.dataGridViewTextBoxColumn5.HeaderText = "trade_number";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "查找经纪人：";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(128, 30);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 21);
            this.searchTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(professionLabel);
            this.groupBox1.Controls.Add(this.professionTextBox);
            this.groupBox1.Controls.Add(register_dateLabel);
            this.groupBox1.Controls.Add(this.register_dateDateTimePicker);
            this.groupBox1.Controls.Add(valid_dateLabel);
            this.groupBox1.Controls.Add(this.valid_dateDateTimePicker);
            this.groupBox1.Controls.Add(trade_numberLabel);
            this.groupBox1.Controls.Add(this.trade_numberTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(namesLabel);
            this.groupBox1.Controls.Add(this.namesTextBox);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Location = new System.Drawing.Point(47, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 288);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "经纪人详细信息";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "解雇";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // professionTextBox
            // 
            this.professionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "profession", true));
            this.professionTextBox.Location = new System.Drawing.Point(110, 113);
            this.professionTextBox.Name = "professionTextBox";
            this.professionTextBox.Size = new System.Drawing.Size(121, 21);
            this.professionTextBox.TabIndex = 9;
            // 
            // register_dateDateTimePicker
            // 
            this.register_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agentBindingSource, "register_date", true));
            this.register_dateDateTimePicker.Location = new System.Drawing.Point(110, 140);
            this.register_dateDateTimePicker.Name = "register_dateDateTimePicker";
            this.register_dateDateTimePicker.Size = new System.Drawing.Size(121, 21);
            this.register_dateDateTimePicker.TabIndex = 11;
            // 
            // valid_dateDateTimePicker
            // 
            this.valid_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agentBindingSource, "valid_date", true));
            this.valid_dateDateTimePicker.Location = new System.Drawing.Point(110, 167);
            this.valid_dateDateTimePicker.Name = "valid_dateDateTimePicker";
            this.valid_dateDateTimePicker.Size = new System.Drawing.Size(121, 21);
            this.valid_dateDateTimePicker.TabIndex = 13;
            // 
            // trade_numberTextBox
            // 
            this.trade_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "trade_number", true));
            this.trade_numberTextBox.Location = new System.Drawing.Point(110, 194);
            this.trade_numberTextBox.Name = "trade_numberTextBox";
            this.trade_numberTextBox.Size = new System.Drawing.Size(121, 21);
            this.trade_numberTextBox.TabIndex = 15;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "email", true));
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(110, 59);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 21);
            this.emailTextBox.TabIndex = 1;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "agent_person";
            this.personBindingSource.DataSource = this.agentBindingSource;
            // 
            // namesTextBox
            // 
            this.namesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "names", true));
            this.namesTextBox.Location = new System.Drawing.Point(110, 32);
            this.namesTextBox.Name = "namesTextBox";
            this.namesTextBox.Size = new System.Drawing.Size(121, 21);
            this.namesTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(110, 86);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(121, 21);
            this.phoneTextBox.TabIndex = 5;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(460, 499);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 121);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "该经纪人的事务";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "管理";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "委托";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(457, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 171);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(234, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "搜索";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(254, 287);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "查看所有经纪人";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // AgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 642);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agentDataGridView);
            this.Controls.Add(this.agentBindingNavigator);
            this.Name = "AgentForm";
            this.Text = "AgentForm";
            this.Load += new System.EventHandler(this.AgentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fcglDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingNavigator)).EndInit();
            this.agentBindingNavigator.ResumeLayout(false);
            this.agentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private fcglDataSet fcglDataSet;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private fcglDataSetTableAdapters.agentTableAdapter agentTableAdapter;
        private fcglDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator agentBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView agentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource personBindingSource;
        private fcglDataSetTableAdapters.personTableAdapter personTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox professionTextBox;
        private System.Windows.Forms.DateTimePicker register_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker valid_dateDateTimePicker;
        private System.Windows.Forms.TextBox trade_numberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox namesTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}