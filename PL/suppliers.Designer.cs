namespace sale_stations.PL
{
    partial class suppliers
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSavaSupplier = new System.Windows.Forms.Button();
            this.supplierNo = new System.Windows.Forms.Label();
            this.supplierTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(258, 144);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(225, 24);
            this.txtName.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(258, 204);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(225, 24);
            this.txtPhone.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم المورد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "رقم الهاتف";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(258, 235);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(225, 24);
            this.txtAddress.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "العنوان";
            // 
            // btnSavaSupplier
            // 
            this.btnSavaSupplier.Location = new System.Drawing.Point(258, 266);
            this.btnSavaSupplier.Name = "btnSavaSupplier";
            this.btnSavaSupplier.Size = new System.Drawing.Size(225, 27);
            this.btnSavaSupplier.TabIndex = 5;
            this.btnSavaSupplier.Text = "حفظ";
            this.btnSavaSupplier.UseVisualStyleBackColor = true;
            this.btnSavaSupplier.Click += new System.EventHandler(this.btnSavaSupplier_Click);
            // 
            // supplierNo
            // 
            this.supplierNo.AutoSize = true;
            this.supplierNo.Location = new System.Drawing.Point(491, 177);
            this.supplierNo.Name = "supplierNo";
            this.supplierNo.Size = new System.Drawing.Size(67, 17);
            this.supplierNo.TabIndex = 8;
            this.supplierNo.Text = "رقم المورد";
            // 
            // supplierTxtBox
            // 
            this.supplierTxtBox.Location = new System.Drawing.Point(258, 174);
            this.supplierTxtBox.Name = "supplierTxtBox";
            this.supplierTxtBox.Size = new System.Drawing.Size(225, 24);
            this.supplierTxtBox.TabIndex = 2;
            // 
            // suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.supplierNo);
            this.Controls.Add(this.supplierTxtBox);
            this.Controls.Add(this.btnSavaSupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Name = "suppliers";
            this.Text = "suppliers";
            this.Load += new System.EventHandler(this.suppliers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSavaSupplier;
        private System.Windows.Forms.Label supplierNo;
        private System.Windows.Forms.TextBox supplierTxtBox;
    }
}