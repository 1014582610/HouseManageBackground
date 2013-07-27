namespace HouseManageBackground
{
    partial class Agent_Info
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
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label namesLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label professionLabel;
            System.Windows.Forms.Label trade_numberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agent_Info));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_search1 = new System.Windows.Forms.TextBox();
            this.fcglDataSet = new HouseManageBackground.fcglDataSet();
            this.agent_person_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentTableAdapter = new HouseManageBackground.fcglDataSetTableAdapters.agentTableAdapter();
            this.delegateTableAdapter = new HouseManageBackground.fcglDataSetTableAdapters.delegateTableAdapter();
            this.personTableAdapter = new HouseManageBackground.fcglDataSetTableAdapters.personTableAdapter();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.trade_numberTextBox = new System.Windows.Forms.TextBox();
            this.professionTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.namesTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.delegateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.agentDataGridView = new System.Windows.Forms.DataGridView();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager = new HouseManageBackground.fcglDataSetTableAdapters.TableAdapterManager();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            namesLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            professionLabel = new System.Windows.Forms.Label();
            trade_numberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fcglDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agent_person_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delegateBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(17, 143);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(89, 12);
            label11.TabIndex = 29;
            label11.Text = "register date:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(17, 170);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(71, 12);
            label12.TabIndex = 31;
            label12.Text = "valid date:";
            // 
            // namesLabel
            // 
            namesLabel.AutoSize = true;
            namesLabel.Location = new System.Drawing.Point(17, 35);
            namesLabel.Name = "namesLabel";
            namesLabel.Size = new System.Drawing.Size(41, 12);
            namesLabel.TabIndex = 40;
            namesLabel.Text = "names:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(17, 62);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(41, 12);
            emailLabel.TabIndex = 41;
            emailLabel.Text = "email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(17, 89);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 12);
            phoneLabel.TabIndex = 42;
            phoneLabel.Text = "phone:";
            // 
            // professionLabel
            // 
            professionLabel.AutoSize = true;
            professionLabel.Location = new System.Drawing.Point(17, 116);
            professionLabel.Name = "professionLabel";
            professionLabel.Size = new System.Drawing.Size(71, 12);
            professionLabel.TabIndex = 43;
            professionLabel.Text = "profession:";
            // 
            // trade_numberLabel
            // 
            trade_numberLabel.AutoSize = true;
            trade_numberLabel.Location = new System.Drawing.Point(17, 197);
            trade_numberLabel.Name = "trade_numberLabel";
            trade_numberLabel.Size = new System.Drawing.Size(83, 12);
            trade_numberLabel.TabIndex = 44;
            trade_numberLabel.Text = "trade number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查找经纪人：";
            // 
            // tb_search1
            // 
            this.tb_search1.Location = new System.Drawing.Point(123, 26);
            this.tb_search1.Name = "tb_search1";
            this.tb_search1.Size = new System.Drawing.Size(100, 21);
            this.tb_search1.TabIndex = 1;
            // 
            // fcglDataSet
            // 
            this.fcglDataSet.DataSetName = "fcglDataSet";
            this.fcglDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentTableAdapter
            // 
            this.agentTableAdapter.ClearBeforeFill = true;
            // 
            // delegateTableAdapter
            // 
            this.delegateTableAdapter.ClearBeforeFill = true;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "agent_person";
            this.personBindingSource.DataSource = this.agentBindingSource;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(trade_numberLabel);
            this.groupBox1.Controls.Add(this.trade_numberTextBox);
            this.groupBox1.Controls.Add(professionLabel);
            this.groupBox1.Controls.Add(this.professionTextBox);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(namesLabel);
            this.groupBox1.Controls.Add(this.namesTextBox);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(label12);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(label11);
            this.groupBox1.Location = new System.Drawing.Point(42, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 280);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "经纪人详细信息";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "解雇";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trade_numberTextBox
            // 
            this.trade_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "trade_number", true));
            this.trade_numberTextBox.Enabled = false;
            this.trade_numberTextBox.Location = new System.Drawing.Point(108, 197);
            this.trade_numberTextBox.Name = "trade_numberTextBox";
            this.trade_numberTextBox.Size = new System.Drawing.Size(100, 21);
            this.trade_numberTextBox.TabIndex = 45;
            // 
            // professionTextBox
            // 
            this.professionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "profession", true));
            this.professionTextBox.Location = new System.Drawing.Point(108, 116);
            this.professionTextBox.Name = "professionTextBox";
            this.professionTextBox.Size = new System.Drawing.Size(100, 21);
            this.professionTextBox.TabIndex = 44;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(108, 89);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 21);
            this.phoneTextBox.TabIndex = 43;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(108, 62);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 21);
            this.emailTextBox.TabIndex = 42;
            // 
            // namesTextBox
            // 
            this.namesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "names", true));
            this.namesTextBox.Location = new System.Drawing.Point(108, 35);
            this.namesTextBox.Name = "namesTextBox";
            this.namesTextBox.Size = new System.Drawing.Size(100, 21);
            this.namesTextBox.TabIndex = 41;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agentBindingSource, "valid_date", true));
            this.dateTimePicker2.Location = new System.Drawing.Point(108, 170);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 21);
            this.dateTimePicker2.TabIndex = 32;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agentBindingSource, "register_date", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 21);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // delegateBindingSource
            // 
            this.delegateBindingSource.DataMember = "FK__delegate__agent__0F975522";
            this.delegateBindingSource.DataSource = this.agentBindingSource;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(450, 456);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 102);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "该经纪人的事务";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "管理相关";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "委托相关";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(450, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 147);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "照片";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 127);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
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
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DataBindings.Add(new System.Windows.Forms.Binding("BindingSource", this.fcglDataSet, "agent.person_id", true));
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(42, 238);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(206, 25);
            this.bindingNavigator1.TabIndex = 41;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // agentDataGridView
            // 
            this.agentDataGridView.AllowUserToAddRows = false;
            this.agentDataGridView.AllowUserToDeleteRows = false;
            this.agentDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.agentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.agentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.agentDataGridView.DataSource = this.agentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.agentDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.agentDataGridView.Location = new System.Drawing.Point(42, 68);
            this.agentDataGridView.Name = "agentDataGridView";
            this.agentDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.agentDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.agentDataGridView.RowTemplate.Height = 23;
            this.agentDataGridView.Size = new System.Drawing.Size(544, 163);
            this.agentDataGridView.TabIndex = 40;
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataMember = "agent";
            this.agentBindingSource.DataSource = this.fcglDataSet;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = null;
            this.tableAdapterManager.agentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
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
            // Agent_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 595);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.agentDataGridView);
            this.Controls.Add(this.tb_search1);
            this.Controls.Add(this.label1);
            this.Name = "Agent_Info";
            this.Text = "经纪人信息管理";
            this.Load += new System.EventHandler(this.Agent_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fcglDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agent_person_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delegateBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_search1;
        private fcglDataSet fcglDataSet;
        private System.Windows.Forms.BindingSource agent_person_bindingSource;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private fcglDataSetTableAdapters.agentTableAdapter agentTableAdapter;
        private fcglDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private fcglDataSetTableAdapters.personTableAdapter personTableAdapter;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private fcglDataSetTableAdapters.delegateTableAdapter delegateTableAdapter;
        private System.Windows.Forms.BindingSource delegateBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox trade_numberTextBox;
        private System.Windows.Forms.TextBox professionTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox namesTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView agentDataGridView;
    }
}