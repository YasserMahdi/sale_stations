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
            this.btnstore = new System.Windows.Forms.Button();
            this.btnsuplier = new System.Windows.Forms.Button();
            this.btninvoive = new System.Windows.Forms.Button();
            this.btnqueryinvoice = new System.Windows.Forms.Button();
            this.btndept = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnSuppilerQuerye = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.الرئيسيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلالدخولToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انشاءنسخةاحتياطيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.استعادةنسخةاحياطيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المستخدمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافةمستخدمجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفمستخدمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnstore
            // 
            this.btnstore.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnstore.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnstore.Location = new System.Drawing.Point(847, 163);
            this.btnstore.Name = "btnstore";
            this.btnstore.Size = new System.Drawing.Size(169, 94);
            this.btnstore.TabIndex = 0;
            this.btnstore.Text = "المخزن";
            this.btnstore.UseVisualStyleBackColor = false;
            this.btnstore.Click += new System.EventHandler(this.btnstore_Click);
            // 
            // btnsuplier
            // 
            this.btnsuplier.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnsuplier.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnsuplier.Location = new System.Drawing.Point(275, 163);
            this.btnsuplier.Name = "btnsuplier";
            this.btnsuplier.Size = new System.Drawing.Size(169, 96);
            this.btnsuplier.TabIndex = 1;
            this.btnsuplier.Text = "الموردين";
            this.btnsuplier.UseVisualStyleBackColor = false;
            this.btnsuplier.Click += new System.EventHandler(this.btnsuplier_Click);
            // 
            // btninvoive
            // 
            this.btninvoive.BackColor = System.Drawing.Color.Blue;
            this.btninvoive.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btninvoive.Location = new System.Drawing.Point(467, 163);
            this.btninvoive.Name = "btninvoive";
            this.btninvoive.Size = new System.Drawing.Size(169, 94);
            this.btninvoive.TabIndex = 2;
            this.btninvoive.Text = "فاتورة جديدة";
            this.btninvoive.UseVisualStyleBackColor = false;
            this.btninvoive.Click += new System.EventHandler(this.btninvoive_Click);
            // 
            // btnqueryinvoice
            // 
            this.btnqueryinvoice.BackColor = System.Drawing.Color.Blue;
            this.btnqueryinvoice.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnqueryinvoice.Location = new System.Drawing.Point(467, 291);
            this.btnqueryinvoice.Name = "btnqueryinvoice";
            this.btnqueryinvoice.Size = new System.Drawing.Size(169, 96);
            this.btnqueryinvoice.TabIndex = 3;
            this.btnqueryinvoice.Text = "استعلام عن الفواتير";
            this.btnqueryinvoice.UseVisualStyleBackColor = false;
            // 
            // btndept
            // 
            this.btndept.BackColor = System.Drawing.Color.Red;
            this.btndept.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btndept.Location = new System.Drawing.Point(656, 163);
            this.btndept.Name = "btndept";
            this.btndept.Size = new System.Drawing.Size(169, 94);
            this.btndept.TabIndex = 4;
            this.btndept.Text = "الديون";
            this.btndept.UseVisualStyleBackColor = false;
            this.btndept.Click += new System.EventHandler(this.btndept_Click);
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnreport.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnreport.Location = new System.Drawing.Point(656, 291);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(169, 96);
            this.btnreport.TabIndex = 5;
            this.btnreport.Text = "التقارير";
            this.btnreport.UseVisualStyleBackColor = false;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnSuppilerQuerye
            // 
            this.btnSuppilerQuerye.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnSuppilerQuerye.Location = new System.Drawing.Point(275, 291);
            this.btnSuppilerQuerye.Name = "btnSuppilerQuerye";
            this.btnSuppilerQuerye.Size = new System.Drawing.Size(169, 96);
            this.btnSuppilerQuerye.TabIndex = 6;
            this.btnSuppilerQuerye.Text = "استعلام عن الموردين";
            this.btnSuppilerQuerye.UseVisualStyleBackColor = true;
            this.btnSuppilerQuerye.Click += new System.EventHandler(this.btnSuppilerQuerye_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.button1.Location = new System.Drawing.Point(847, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 96);
            this.button1.TabIndex = 7;
            this.button1.Text = "استعلام عن المخزن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.button2.Location = new System.Drawing.Point(84, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 94);
            this.button2.TabIndex = 8;
            this.button2.Text = "اضافة زبون";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.button3.Location = new System.Drawing.Point(84, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 96);
            this.button3.TabIndex = 9;
            this.button3.Text = "استعلام عن الزبائن";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الرئيسيةToolStripMenuItem,
            this.المستخدمينToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1112, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // الرئيسيةToolStripMenuItem
            // 
            this.الرئيسيةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تسجيلالدخولToolStripMenuItem,
            this.انشاءنسخةاحتياطيةToolStripMenuItem,
            this.استعادةنسخةاحياطيةToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.الرئيسيةToolStripMenuItem.Name = "الرئيسيةToolStripMenuItem";
            this.الرئيسيةToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.الرئيسيةToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.الرئيسيةToolStripMenuItem.Text = "الرئيسية";
            // 
            // تسجيلالدخولToolStripMenuItem
            // 
            this.تسجيلالدخولToolStripMenuItem.Name = "تسجيلالدخولToolStripMenuItem";
            this.تسجيلالدخولToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.تسجيلالدخولToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.تسجيلالدخولToolStripMenuItem.Text = "تسجيل الدخول";
            // 
            // انشاءنسخةاحتياطيةToolStripMenuItem
            // 
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Name = "انشاءنسخةاحتياطيةToolStripMenuItem";
            this.انشاءنسخةاحتياطيةToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Text = "انشاء نسخة احتياطية";
            // 
            // استعادةنسخةاحياطيةToolStripMenuItem
            // 
            this.استعادةنسخةاحياطيةToolStripMenuItem.Name = "استعادةنسخةاحياطيةToolStripMenuItem";
            this.استعادةنسخةاحياطيةToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.استعادةنسخةاحياطيةToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.استعادةنسخةاحياطيةToolStripMenuItem.Text = "استعادة نسخة احتياطية";
            this.استعادةنسخةاحياطيةToolStripMenuItem.Click += new System.EventHandler(this.استعادةنسخةاحياطيةToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.خروجToolStripMenuItem.Text = "خروج";
            // 
            // المستخدمينToolStripMenuItem
            // 
            this.المستخدمينToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافةمستخدمجديدToolStripMenuItem,
            this.حذفمستخدمToolStripMenuItem});
            this.المستخدمينToolStripMenuItem.Name = "المستخدمينToolStripMenuItem";
            this.المستخدمينToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.المستخدمينToolStripMenuItem.Text = "المستخدمين";
            // 
            // اضافةمستخدمجديدToolStripMenuItem
            // 
            this.اضافةمستخدمجديدToolStripMenuItem.Name = "اضافةمستخدمجديدToolStripMenuItem";
            this.اضافةمستخدمجديدToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.اضافةمستخدمجديدToolStripMenuItem.Text = "اضافة مستخدم جديد";
            // 
            // حذفمستخدمToolStripMenuItem
            // 
            this.حذفمستخدمToolStripMenuItem.Name = "حذفمستخدمToolStripMenuItem";
            this.حذفمستخدمToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.حذفمستخدمToolStripMenuItem.Text = "حذف مستخدم";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 568);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSuppilerQuerye);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btndept);
            this.Controls.Add(this.btnqueryinvoice);
            this.Controls.Add(this.btninvoive);
            this.Controls.Add(this.btnsuplier);
            this.Controls.Add(this.btnstore);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstore;
        private System.Windows.Forms.Button btnsuplier;
        private System.Windows.Forms.Button btninvoive;
        private System.Windows.Forms.Button btnqueryinvoice;
        private System.Windows.Forms.Button btndept;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnSuppilerQuerye;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem الرئيسيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسجيلالدخولToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انشاءنسخةاحتياطيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem استعادةنسخةاحياطيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المستخدمينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافةمستخدمجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفمستخدمToolStripMenuItem;
    }
}