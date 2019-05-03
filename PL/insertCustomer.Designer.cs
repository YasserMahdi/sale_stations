namespace sale_stations.PL
{
    partial class insertCustomer
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
            this.textBoxNO = new System.Windows.Forms.TextBox();
            this.customerNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNmae = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNO
            // 
            this.textBoxNO.Location = new System.Drawing.Point(245, 156);
            this.textBoxNO.Name = "textBoxNO";
            this.textBoxNO.Size = new System.Drawing.Size(240, 24);
            this.textBoxNO.TabIndex = 0;
            // 
            // customerNo
            // 
            this.customerNo.AutoSize = true;
            this.customerNo.Location = new System.Drawing.Point(491, 159);
            this.customerNo.Name = "customerNo";
            this.customerNo.Size = new System.Drawing.Size(65, 17);
            this.customerNo.TabIndex = 1;
            this.customerNo.Text = "رقم الزبون";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "اسم الزبون";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNmae
            // 
            this.textBoxNmae.Location = new System.Drawing.Point(245, 186);
            this.textBoxNmae.Name = "textBoxNmae";
            this.textBoxNmae.Size = new System.Drawing.Size(240, 24);
            this.textBoxNmae.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "رقم الهاتف";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(245, 216);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(240, 24);
            this.textBoxPhone.TabIndex = 4;
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Location = new System.Drawing.Point(245, 247);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(240, 32);
            this.btnSaveCustomer.TabIndex = 6;
            this.btnSaveCustomer.Text = "حفظ";
            this.btnSaveCustomer.UseVisualStyleBackColor = true;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // insertCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNmae);
            this.Controls.Add(this.customerNo);
            this.Controls.Add(this.textBoxNO);
            this.Name = "insertCustomer";
            this.Text = "insertCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNO;
        private System.Windows.Forms.Label customerNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNmae;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button btnSaveCustomer;
    }
}