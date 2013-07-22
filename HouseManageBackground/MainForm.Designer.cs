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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.agentButton1 = new System.Windows.Forms.Button();
            this.agentButton2 = new System.Windows.Forms.Button();
            this.agentButton3 = new System.Windows.Forms.Button();
            this.houseButtons1 = new System.Windows.Forms.Button();
            this.memberButton1 = new System.Windows.Forms.Button();
            this.memberButton2 = new System.Windows.Forms.Button();
            this.otherButton1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.otherButton1);
            this.splitContainer1.Panel2.Controls.Add(this.memberButton2);
            this.splitContainer1.Panel2.Controls.Add(this.memberButton1);
            this.splitContainer1.Panel2.Controls.Add(this.houseButtons1);
            this.splitContainer1.Panel2.Controls.Add(this.agentButton3);
            this.splitContainer1.Panel2.Controls.Add(this.agentButton2);
            this.splitContainer1.Panel2.Controls.Add(this.agentButton1);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 451);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(12, 273);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 35);
            this.button5.TabIndex = 8;
            this.button5.Text = "关于及帮助";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(12, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "会员管理";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(12, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "房源管理";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(12, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "经纪人管理";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // agentButton1
            // 
            this.agentButton1.Location = new System.Drawing.Point(231, 99);
            this.agentButton1.Name = "agentButton1";
            this.agentButton1.Size = new System.Drawing.Size(141, 23);
            this.agentButton1.TabIndex = 0;
            this.agentButton1.Text = "agentButton1";
            this.agentButton1.UseVisualStyleBackColor = true;
            // 
            // agentButton2
            // 
            this.agentButton2.Location = new System.Drawing.Point(416, 135);
            this.agentButton2.Name = "agentButton2";
            this.agentButton2.Size = new System.Drawing.Size(118, 23);
            this.agentButton2.TabIndex = 1;
            this.agentButton2.Text = "agentButton2";
            this.agentButton2.UseVisualStyleBackColor = true;
            // 
            // agentButton3
            // 
            this.agentButton3.Location = new System.Drawing.Point(204, 194);
            this.agentButton3.Name = "agentButton3";
            this.agentButton3.Size = new System.Drawing.Size(168, 23);
            this.agentButton3.TabIndex = 2;
            this.agentButton3.Text = "agentButton3";
            this.agentButton3.UseVisualStyleBackColor = true;
            // 
            // houseButtons1
            // 
            this.houseButtons1.Location = new System.Drawing.Point(101, 133);
            this.houseButtons1.Name = "houseButtons1";
            this.houseButtons1.Size = new System.Drawing.Size(137, 23);
            this.houseButtons1.TabIndex = 3;
            this.houseButtons1.Text = "houseButtons1";
            this.houseButtons1.UseVisualStyleBackColor = true;
            // 
            // memberButton1
            // 
            this.memberButton1.Location = new System.Drawing.Point(107, 49);
            this.memberButton1.Name = "memberButton1";
            this.memberButton1.Size = new System.Drawing.Size(175, 26);
            this.memberButton1.TabIndex = 4;
            this.memberButton1.Text = "memberButton1";
            this.memberButton1.UseVisualStyleBackColor = true;
            // 
            // memberButton2
            // 
            this.memberButton2.Location = new System.Drawing.Point(126, 263);
            this.memberButton2.Name = "memberButton2";
            this.memberButton2.Size = new System.Drawing.Size(123, 38);
            this.memberButton2.TabIndex = 5;
            this.memberButton2.Text = "memberButton2";
            this.memberButton2.UseVisualStyleBackColor = true;
            // 
            // otherButton1
            // 
            this.otherButton1.Location = new System.Drawing.Point(353, 64);
            this.otherButton1.Name = "otherButton1";
            this.otherButton1.Size = new System.Drawing.Size(129, 23);
            this.otherButton1.TabIndex = 6;
            this.otherButton1.Text = "otherButton1";
            this.otherButton1.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button agentButton3;
        private System.Windows.Forms.Button agentButton2;
        private System.Windows.Forms.Button agentButton1;
        private System.Windows.Forms.Button houseButtons1;
        private System.Windows.Forms.Button otherButton1;
        private System.Windows.Forms.Button memberButton2;
        private System.Windows.Forms.Button memberButton1;

    }
}