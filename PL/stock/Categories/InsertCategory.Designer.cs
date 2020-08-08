namespace sale_stations.PL.stock.Categories
{
    partial class InsertCategory
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 30);
            this.button1.TabIndex = 31;
            this.button1.Text = "ادخال";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "اسم الفئة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "رقم الفئة";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(250, 211);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(224, 24);
            this.TxtName.TabIndex = 28;
            // 
            // TxtNo
            // 
            this.TxtNo.Location = new System.Drawing.Point(250, 180);
            this.TxtNo.Name = "TxtNo";
            this.TxtNo.ReadOnly = true;
            this.TxtNo.Size = new System.Drawing.Size(224, 24);
            this.TxtNo.TabIndex = 27;
            // 
            // InsertCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtNo);
            this.Name = "InsertCategory";
            this.Text = "InsertCategory";
            this.Load += new System.EventHandler(this.InsertCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtName;
        public System.Windows.Forms.TextBox TxtNo;
    }
}