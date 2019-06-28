namespace sale_stations.PL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btninvoive = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.الرئيسيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلالدخولToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انشاءنسخةاحتياToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.استعادةالنسخةالاحتياطيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلالخروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اغلاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الزبائنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.استعلامعنالزبائنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btninvoive
            // 
            this.btninvoive.BackColor = System.Drawing.Color.MediumBlue;
            this.btninvoive.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btninvoive.ForeColor = System.Drawing.SystemColors.Control;
            this.btninvoive.Location = new System.Drawing.Point(46, 54);
            this.btninvoive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btninvoive.Name = "btninvoive";
            this.btninvoive.Size = new System.Drawing.Size(193, 94);
            this.btninvoive.TabIndex = 2;
            this.btninvoive.Text = "فاتورة جديدة";
            this.btninvoive.UseVisualStyleBackColor = false;
            this.btninvoive.Click += new System.EventHandler(this.btninvoive_Click);
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnreport.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnreport.Location = new System.Drawing.Point(39, 66);
            this.btnreport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(193, 96);
            this.btnreport.TabIndex = 5;
            this.btnreport.Text = "التقارير";
            this.btnreport.UseVisualStyleBackColor = false;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.button1.Location = new System.Drawing.Point(50, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 96);
            this.button1.TabIndex = 7;
            this.button1.Text = "المخزن";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(624, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 202);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المواد و المخزن";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnreport);
            this.groupBox2.Location = new System.Drawing.Point(53, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 202);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "التقارير و الديون";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.btninvoive);
            this.groupBox3.Location = new System.Drawing.Point(334, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 202);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "المبيعات";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الرئيسيةToolStripMenuItem,
            this.الزبائنToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(981, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // الرئيسيةToolStripMenuItem
            // 
            this.الرئيسيةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تسجيلالدخولToolStripMenuItem,
            this.انشاءنسخةاحتياToolStripMenuItem,
            this.استعادةالنسخةالاحتياطيةToolStripMenuItem,
            this.تسجيلالخروجToolStripMenuItem,
            this.اغلاقToolStripMenuItem});
            this.الرئيسيةToolStripMenuItem.Name = "الرئيسيةToolStripMenuItem";
            this.الرئيسيةToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.الرئيسيةToolStripMenuItem.Text = "الرئيسية";
            // 
            // تسجيلالدخولToolStripMenuItem
            // 
            this.تسجيلالدخولToolStripMenuItem.Name = "تسجيلالدخولToolStripMenuItem";
            this.تسجيلالدخولToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.تسجيلالدخولToolStripMenuItem.Text = "تسجيل الدخول";
            // 
            // انشاءنسخةاحتياToolStripMenuItem
            // 
            this.انشاءنسخةاحتياToolStripMenuItem.Name = "انشاءنسخةاحتياToolStripMenuItem";
            this.انشاءنسخةاحتياToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.انشاءنسخةاحتياToolStripMenuItem.Text = "انشاء نسخة احتياطية";
            this.انشاءنسخةاحتياToolStripMenuItem.Click += new System.EventHandler(this.انشاءنسخةاحتياToolStripMenuItem_Click);
            // 
            // استعادةالنسخةالاحتياطيةToolStripMenuItem
            // 
            this.استعادةالنسخةالاحتياطيةToolStripMenuItem.Name = "استعادةالنسخةالاحتياطيةToolStripMenuItem";
            this.استعادةالنسخةالاحتياطيةToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.استعادةالنسخةالاحتياطيةToolStripMenuItem.Text = "استعادة النسخة الاحتياطية";
            this.استعادةالنسخةالاحتياطيةToolStripMenuItem.Click += new System.EventHandler(this.استعادةالنسخةالاحتياطيةToolStripMenuItem_Click);
            // 
            // تسجيلالخروجToolStripMenuItem
            // 
            this.تسجيلالخروجToolStripMenuItem.Name = "تسجيلالخروجToolStripMenuItem";
            this.تسجيلالخروجToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.تسجيلالخروجToolStripMenuItem.Text = "تسجيل الخروج";
            // 
            // اغلاقToolStripMenuItem
            // 
            this.اغلاقToolStripMenuItem.Name = "اغلاقToolStripMenuItem";
            this.اغلاقToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.اغلاقToolStripMenuItem.Text = "اغلاق";
            this.اغلاقToolStripMenuItem.Click += new System.EventHandler(this.اغلاقToolStripMenuItem_Click);
            // 
            // الزبائنToolStripMenuItem
            // 
            this.الزبائنToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.استعلامعنالزبائنToolStripMenuItem});
            this.الزبائنToolStripMenuItem.Name = "الزبائنToolStripMenuItem";
            this.الزبائنToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.الزبائنToolStripMenuItem.Text = "الزبائن";
            // 
            // استعلامعنالزبائنToolStripMenuItem
            // 
            this.استعلامعنالزبائنToolStripMenuItem.Name = "استعلامعنالزبائنToolStripMenuItem";
            this.استعلامعنالزبائنToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.استعلامعنالزبائنToolStripMenuItem.Text = "استعلام عن الزبائن";
            this.استعلامعنالزبائنToolStripMenuItem.Click += new System.EventHandler(this.استعلامعنالزبائنToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(334, 336);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(284, 106);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "الديون";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.button2.Location = new System.Drawing.Point(46, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 65);
            this.button2.TabIndex = 16;
            this.button2.Text = "الديون";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 494);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btninvoive;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem الرئيسيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسجيلالدخولToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انشاءنسخةاحتياToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem استعادةالنسخةالاحتياطيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسجيلالخروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اغلاقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الزبائنToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem استعلامعنالزبائنToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}