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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.otherControlButton = new System.Windows.Forms.Button();
            this.memberControlButton = new System.Windows.Forms.Button();
            this.houseControlButton = new System.Windows.Forms.Button();
            this.agentControlButton = new System.Windows.Forms.Button();
            this.otherPanel = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.memberPanel = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.housePanel = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.agentPanel = new System.Windows.Forms.Panel();
            this.agentButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.otherPanel.SuspendLayout();
            this.memberPanel.SuspendLayout();
            this.housePanel.SuspendLayout();
            this.agentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem1.Text = "帮助";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 64);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("华文行楷", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Image = global::HouseManageBackground.Properties.Resources.mainHead;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1008, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "      缘溪行";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 88);
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
            this.otherPanel.Size = new System.Drawing.Size(10, 10);
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
            // memberPanel
            // 
            this.memberPanel.Controls.Add(this.button8);
            this.memberPanel.Location = new System.Drawing.Point(683, 185);
            this.memberPanel.Name = "memberPanel";
            this.memberPanel.Size = new System.Drawing.Size(10, 10);
            this.memberPanel.TabIndex = 2;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(55, 50);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 0;
            this.button8.Text = "member3";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // housePanel
            // 
            this.housePanel.Controls.Add(this.button7);
            this.housePanel.Location = new System.Drawing.Point(683, 153);
            this.housePanel.Name = "housePanel";
            this.housePanel.Size = new System.Drawing.Size(10, 10);
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
            // agentPanel
            // 
            this.agentPanel.Controls.Add(this.agentButton);
            this.agentPanel.Controls.Add(this.memberPanel);
            this.agentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agentPanel.Location = new System.Drawing.Point(0, 0);
            this.agentPanel.Name = "agentPanel";
            this.agentPanel.Size = new System.Drawing.Size(833, 451);
            this.agentPanel.TabIndex = 0;
            // 
            // agentButton
            // 
            this.agentButton.Location = new System.Drawing.Point(87, 42);
            this.agentButton.Name = "agentButton";
            this.agentButton.Size = new System.Drawing.Size(134, 78);
            this.agentButton.TabIndex = 0;
            this.agentButton.Text = "agent1";
            this.agentButton.UseVisualStyleBackColor = true;
            this.agentButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
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
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.otherPanel.ResumeLayout(false);
            this.memberPanel.ResumeLayout(false);
            this.housePanel.ResumeLayout(false);
            this.agentPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel otherPanel;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel memberPanel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel housePanel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel agentPanel;
        private System.Windows.Forms.Button agentButton;

    }
}