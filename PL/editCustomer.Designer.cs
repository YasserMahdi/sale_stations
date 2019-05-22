namespace sale_stations.PL
{
    partial class editCustomer
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
            this.SuspendLayout();
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Location = new System.Drawing.Point(164, 188);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(240, 32);
            this.btnSaveCustomer.TabIndex = 10;
            this.btnSaveCustomer.Text = "تحديث";
            this.btnSaveCustomer.UseVisualStyleBackColor = true;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(164, 157);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(240, 24);
            this.textBoxPhone.TabIndex = 9;
            // 
            // textBoxNmae
            // 
            this.textBoxNmae.Location = new System.Drawing.Point(164, 127);
            this.textBoxNmae.Name = "textBoxNmae";
            this.textBoxNmae.Size = new System.Drawing.Size(240, 24);
            this.textBoxNmae.TabIndex = 8;
            // 
            // textBoxNO
            // 
            this.textBoxNO.Location = new System.Drawing.Point(164, 97);
            this.textBoxNO.Name = "textBoxNO";
            this.textBoxNO.ReadOnly = true;
            this.textBoxNO.Size = new System.Drawing.Size(240, 24);
            this.textBoxNO.TabIndex = 7;
            // 
            // editCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 337);
            this.Controls.Add(this.btnSaveCustomer);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxNmae);
            this.Controls.Add(this.textBoxNO);
            this.Name = "editCustomer";
            this.Text = "editCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSaveCustomer;
        public System.Windows.Forms.TextBox textBoxPhone;
        public System.Windows.Forms.TextBox textBoxNmae;
        public System.Windows.Forms.TextBox textBoxNO;
    }
}