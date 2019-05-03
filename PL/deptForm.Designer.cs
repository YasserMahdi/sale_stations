namespace sale_stations.PL
{
    partial class deptForm
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
            this.textBoxCusNO = new System.Windows.Forms.TextBox();
            this.customerNo = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.textBoxCusName = new System.Windows.Forms.TextBox();
            this.customerOldDept = new System.Windows.Forms.Label();
            this.textBoxCusOldDept = new System.Windows.Forms.TextBox();
            this.customerNewDtpt = new System.Windows.Forms.Label();
            this.textBoxCusNewDept = new System.Windows.Forms.TextBox();
            this.customerPay = new System.Windows.Forms.Label();
            this.textBoxCusPay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxCusNO
            // 
            this.textBoxCusNO.Location = new System.Drawing.Point(257, 156);
            this.textBoxCusNO.Name = "textBoxCusNO";
            this.textBoxCusNO.Size = new System.Drawing.Size(211, 24);
            this.textBoxCusNO.TabIndex = 0;
            // 
            // customerNo
            // 
            this.customerNo.AutoSize = true;
            this.customerNo.Location = new System.Drawing.Point(474, 159);
            this.customerNo.Name = "customerNo";
            this.customerNo.Size = new System.Drawing.Size(65, 17);
            this.customerNo.TabIndex = 1;
            this.customerNo.Text = "رقم الزبون";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(473, 189);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(71, 17);
            this.customerName.TabIndex = 3;
            this.customerName.Text = "اسم الزبون";
            // 
            // textBoxCusName
            // 
            this.textBoxCusName.Location = new System.Drawing.Point(257, 186);
            this.textBoxCusName.Name = "textBoxCusName";
            this.textBoxCusName.Size = new System.Drawing.Size(211, 24);
            this.textBoxCusName.TabIndex = 2;
            // 
            // customerOldDept
            // 
            this.customerOldDept.AutoSize = true;
            this.customerOldDept.Location = new System.Drawing.Point(473, 219);
            this.customerOldDept.Name = "customerOldDept";
            this.customerOldDept.Size = new System.Drawing.Size(78, 17);
            this.customerOldDept.TabIndex = 5;
            this.customerOldDept.Text = "الدين القديم";
            // 
            // textBoxCusOldDept
            // 
            this.textBoxCusOldDept.Location = new System.Drawing.Point(257, 216);
            this.textBoxCusOldDept.Name = "textBoxCusOldDept";
            this.textBoxCusOldDept.Size = new System.Drawing.Size(211, 24);
            this.textBoxCusOldDept.TabIndex = 4;
            // 
            // customerNewDtpt
            // 
            this.customerNewDtpt.AutoSize = true;
            this.customerNewDtpt.Location = new System.Drawing.Point(475, 249);
            this.customerNewDtpt.Name = "customerNewDtpt";
            this.customerNewDtpt.Size = new System.Drawing.Size(79, 17);
            this.customerNewDtpt.TabIndex = 7;
            this.customerNewDtpt.Text = "الدين الجديد";
            // 
            // textBoxCusNewDept
            // 
            this.textBoxCusNewDept.Location = new System.Drawing.Point(257, 246);
            this.textBoxCusNewDept.Name = "textBoxCusNewDept";
            this.textBoxCusNewDept.Size = new System.Drawing.Size(211, 24);
            this.textBoxCusNewDept.TabIndex = 6;
            // 
            // customerPay
            // 
            this.customerPay.AutoSize = true;
            this.customerPay.Location = new System.Drawing.Point(474, 279);
            this.customerPay.Name = "customerPay";
            this.customerPay.Size = new System.Drawing.Size(77, 17);
            this.customerPay.TabIndex = 9;
            this.customerPay.Text = "مبلغ السداد";
            // 
            // textBoxCusPay
            // 
            this.textBoxCusPay.Location = new System.Drawing.Point(257, 276);
            this.textBoxCusPay.Name = "textBoxCusPay";
            this.textBoxCusPay.Size = new System.Drawing.Size(211, 24);
            this.textBoxCusPay.TabIndex = 8;
            // 
            // deptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerPay);
            this.Controls.Add(this.textBoxCusPay);
            this.Controls.Add(this.customerNewDtpt);
            this.Controls.Add(this.textBoxCusNewDept);
            this.Controls.Add(this.customerOldDept);
            this.Controls.Add(this.textBoxCusOldDept);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.textBoxCusName);
            this.Controls.Add(this.customerNo);
            this.Controls.Add(this.textBoxCusNO);
            this.Name = "deptForm";
            this.Text = "deptForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCusNO;
        private System.Windows.Forms.Label customerNo;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.TextBox textBoxCusName;
        private System.Windows.Forms.Label customerOldDept;
        private System.Windows.Forms.TextBox textBoxCusOldDept;
        private System.Windows.Forms.Label customerNewDtpt;
        private System.Windows.Forms.TextBox textBoxCusNewDept;
        private System.Windows.Forms.Label customerPay;
        private System.Windows.Forms.TextBox textBoxCusPay;
    }
}