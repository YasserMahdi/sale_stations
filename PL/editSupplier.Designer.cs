namespace sale_stations.PL
{
    partial class editSupplier
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
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxNmae = new System.Windows.Forms.TextBox();
            this.textBoxNO = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Location = new System.Drawing.Point(99, 212);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(240, 32);
            this.btnSaveCustomer.TabIndex = 14;
            this.btnSaveCustomer.Text = "تحديث";
            this.btnSaveCustomer.UseVisualStyleBackColor = true;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(99, 155);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(240, 24);
            this.textBoxPhone.TabIndex = 13;
            // 
            // textBoxNmae
            // 
            this.textBoxNmae.Location = new System.Drawing.Point(99, 125);
            this.textBoxNmae.Name = "textBoxNmae";
            this.textBoxNmae.Size = new System.Drawing.Size(240, 24);
            this.textBoxNmae.TabIndex = 12;
            // 
            // textBoxNO
            // 
            this.textBoxNO.Location = new System.Drawing.Point(99, 95);
            this.textBoxNO.Name = "textBoxNO";
            this.textBoxNO.ReadOnly = true;
            this.textBoxNO.Size = new System.Drawing.Size(240, 24);
            this.textBoxNO.TabIndex = 11;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(99, 182);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(240, 24);
            this.textBoxAddress.TabIndex = 15;
            // 
            // editSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 313);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.btnSaveCustomer);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxNmae);
            this.Controls.Add(this.textBoxNO);
            this.Name = "editSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editSupplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSaveCustomer;
        public System.Windows.Forms.TextBox textBoxPhone;
        public System.Windows.Forms.TextBox textBoxNmae;
        public System.Windows.Forms.TextBox textBoxNO;
        public System.Windows.Forms.TextBox textBoxAddress;
    }
}