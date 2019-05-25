namespace sale_stations.PL
{
    partial class repayment
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
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRep = new System.Windows.Forms.TextBox();
            this.btnRep = new System.Windows.Forms.Button();
            this.textDept = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(159, 132);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(311, 24);
            this.txtNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم الزبون";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "اسم الزبون";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 162);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(311, 24);
            this.txtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "مبلغ السداد";
            // 
            // txtRep
            // 
            this.txtRep.Location = new System.Drawing.Point(159, 222);
            this.txtRep.Name = "txtRep";
            this.txtRep.Size = new System.Drawing.Size(311, 24);
            this.txtRep.TabIndex = 4;
            this.txtRep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRep_KeyPress);
            // 
            // btnRep
            // 
            this.btnRep.Location = new System.Drawing.Point(159, 254);
            this.btnRep.Name = "btnRep";
            this.btnRep.Size = new System.Drawing.Size(311, 28);
            this.btnRep.TabIndex = 6;
            this.btnRep.Text = "تنفيذ";
            this.btnRep.UseVisualStyleBackColor = true;
            this.btnRep.Click += new System.EventHandler(this.btnRep_Click);
            // 
            // textDept
            // 
            this.textDept.Location = new System.Drawing.Point(159, 192);
            this.textDept.Name = "textDept";
            this.textDept.Size = new System.Drawing.Size(311, 24);
            this.textDept.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "الدين الحالي";
            // 
            // repayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 399);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDept);
            this.Controls.Add(this.btnRep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNo);
            this.Name = "repayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "repayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtNo;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtRep;
        public System.Windows.Forms.Button btnRep;
        public System.Windows.Forms.TextBox textDept;
        public System.Windows.Forms.Label label4;
    }
}