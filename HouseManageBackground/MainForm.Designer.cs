namespace HouseManageBackground
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.otherControlButton = new System.Windows.Forms.Button();
            this.memberControlButton = new System.Windows.Forms.Button();
            this.houseControlButton = new System.Windows.Forms.Button();
            this.agentControlButton = new System.Windows.Forms.Button();
            this.otherPanel = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.agentPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.agentButton = new System.Windows.Forms.Button();
            this.memberPanel = new System.Windows.Forms.Panel();
            this.memberButton3 = new System.Windows.Forms.Button();
            this.memberButton2 = new System.Windows.Forms.Button();
            this.memberButton1 = new System.Windows.Forms.Button();
            this.housePanel = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.otherPanel.SuspendLayout();
            this.agentPanel.SuspendLayout();
            this.memberPanel.SuspendLayout();
            this.housePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem1.Text = "帮助";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 89);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.otherControlButton);
            this.splitContainer1.Panel1.Controls.Add(this.memberControlButton);
            this.splitContainer1.Panel1.Controls.Add(this.houseControlButton);
            this.splitContainer1.Panel1.Controls.Add(this.agentControlButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.otherPanel);
            this.splitContainer1.Panel2.Controls.Add(this.agentPanel);
            this.splitContainer1.Panel2.Controls.Add(this.housePanel);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 451);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.TabIndex = 3;
            // 
            // otherControlButton
            // 
            this.otherControlButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otherControlButton.Location = new System.Drawing.Point(12, 273);
            this.otherControlButton.Name = "otherControlButton";
            this.otherControlButton.Size = new System.Drawing.Size(144, 35);
            this.otherControlButton.TabIndex = 8;
            this.otherControlButton.Text = "关于及帮助";
            this.otherControlButton.UseVisualStyleBackColor = true;
            this.otherControlButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // memberControlButton
            // 
            this.memberControlButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberControlButton.Location = new System.Drawing.Point(12, 200);
            this.memberControlButton.Name = "memberControlButton";
            this.memberControlButton.Size = new System.Drawing.Size(144, 35);
            this.memberControlButton.TabIndex = 7;
            this.memberControlButton.Text = "会员管理";
            this.memberControlButton.UseVisualStyleBackColor = true;
            this.memberControlButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // houseControlButton
            // 
            this.houseControlButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.houseControlButton.Location = new System.Drawing.Point(12, 127);
            this.houseControlButton.Name = "houseControlButton";
            this.houseControlButton.Size = new System.Drawing.Size(144, 35);
            this.houseControlButton.TabIndex = 6;
            this.houseControlButton.Text = "房源管理";
            this.houseControlButton.UseVisualStyleBackColor = true;
            this.houseControlButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // agentControlButton
            // 
            this.agentControlButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.agentControlButton.Location = new System.Drawing.Point(12, 54);
            this.agentControlButton.Name = "agentControlButton";
            this.agentControlButton.Size = new System.Drawing.Size(144, 35);
            this.agentControlButton.TabIndex = 5;
            this.agentControlButton.Text = "经纪人管理";
            this.agentControlButton.UseVisualStyleBackColor = true;
            this.agentControlButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // otherPanel
            // 
            this.otherPanel.Controls.Add(this.button9);
            this.otherPanel.Location = new System.Drawing.Point(683, 169);
            this.otherPanel.Name = "otherPanel";
            this.otherPanel.Size = new System.Drawing.Size(96, 109);
            this.otherPanel.TabIndex = 3;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(98, 50);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(102, 38);
            this.button9.TabIndex = 0;
            this.button9.Text = "other4";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // agentPanel
            // 
            this.agentPanel.Controls.Add(this.button2);
            this.agentPanel.Controls.Add(this.button1);
            this.agentPanel.Controls.Add(this.agentButton);
            this.agentPanel.Controls.Add(this.memberPanel);
            this.agentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agentPanel.Location = new System.Drawing.Point(0, 0);
            this.agentPanel.Name = "agentPanel";
            this.agentPanel.Size = new System.Drawing.Size(833, 451);
            this.agentPanel.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "信息管理";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "录入新人";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // agentButton
            // 
            this.agentButton.Location = new System.Drawing.Point(87, 42);
            this.agentButton.Name = "agentButton";
            this.agentButton.Size = new System.Drawing.Size(134, 78);
            this.agentButton.TabIndex = 0;
            this.agentButton.Text = "agent1";
            this.agentButton.UseVisualStyleBackColor = true;
            // 
            // memberPanel
            // 
            this.memberPanel.BackgroundImage = global::HouseManageBackground.Properties.Resources.member_background;
            this.memberPanel.Controls.Add(this.memberButton3);
            this.memberPanel.Controls.Add(this.memberButton2);
            this.memberPanel.Controls.Add(this.memberButton1);
            this.memberPanel.Location = new System.Drawing.Point(217, 200);
            this.memberPanel.Name = "memberPanel";
            this.memberPanel.Size = new System.Drawing.Size(123, 78);
            this.memberPanel.TabIndex = 2;
            // 
            // memberButton3
            // 
            this.memberButton3.Location = new System.Drawing.Point(530, 250);
            this.memberButton3.Name = "memberButton3";
            this.memberButton3.Size = new System.Drawing.Size(94, 39);
            this.memberButton3.TabIndex = 2;
            this.memberButton3.Text = "委托处理";
            this.memberButton3.UseVisualStyleBackColor = true;
            this.memberButton3.Click += new System.EventHandler(this.memberButton3_Click);
            // 
            // memberButton2
            // 
            this.memberButton2.Location = new System.Drawing.Point(159, 250);
            this.memberButton2.Name = "memberButton2";
            this.memberButton2.Size = new System.Drawing.Size(94, 39);
            this.memberButton2.TabIndex = 1;
            this.memberButton2.Text = "修改信息";
            this.memberButton2.UseVisualStyleBackColor = true;
            this.memberButton2.Click += new System.EventHandler(this.memberButton2_Click);
            // 
            // memberButton1
            // 
            this.memberButton1.Location = new System.Drawing.Point(347, 72);
            this.memberButton1.Name = "memberButton1";
            this.memberButton1.Size = new System.Drawing.Size(94, 39);
            this.memberButton1.TabIndex = 0;
            this.memberButton1.Text = "查看信息";
            this.memberButton1.UseVisualStyleBackColor = true;
            this.memberButton1.Click += new System.EventHandler(this.memberButton1_Click);
            // 
            // housePanel
            // 
            this.housePanel.Controls.Add(this.button7);
            this.housePanel.Location = new System.Drawing.Point(647, 43);
            this.housePanel.Name = "housePanel";
            this.housePanel.Size = new System.Drawing.Size(85, 68);
            this.housePanel.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(646, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "house2";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HouseManageBackground.Properties.Resources.无标题;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 64);
            this.panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "MainForm";
            this.Text = "房产中介管理系统（后台）";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.otherPanel.ResumeLayout(false);
            this.agentPanel.ResumeLayout(false);
            this.memberPanel.ResumeLayout(false);
            this.housePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button otherControlButton;
        private System.Windows.Forms.Button memberControlButton;
        private System.Windows.Forms.Button houseControlButton;
        private System.Windows.Forms.Button agentControlButton;
        private System.Windows.Forms.Panel otherPanel;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel memberPanel;
        private System.Windows.Forms.Button memberButton1;
        private System.Windows.Forms.Panel housePanel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel agentPanel;
        private System.Windows.Forms.Button agentButton;
        private System.Windows.Forms.Button memberButton3;
        private System.Windows.Forms.Button memberButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;

    }
}