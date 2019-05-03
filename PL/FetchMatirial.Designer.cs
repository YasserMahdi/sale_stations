namespace sale_stations.PL
{
    partial class FetchMatirial
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
            this.qte = new System.Windows.Forms.TextBox();
            this.saleCost = new System.Windows.Forms.TextBox();
            this.buyCost = new System.Windows.Forms.TextBox();
            this.noMtr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "ادخال";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // qte
            // 
            this.qte.Location = new System.Drawing.Point(288, 251);
            this.qte.Name = "qte";
            this.qte.Size = new System.Drawing.Size(224, 24);
            this.qte.TabIndex = 15;
            // 
            // saleCost
            // 
            this.saleCost.Location = new System.Drawing.Point(288, 221);
            this.saleCost.Name = "saleCost";
            this.saleCost.Size = new System.Drawing.Size(224, 24);
            this.saleCost.TabIndex = 14;
            // 
            // buyCost
            // 
            this.buyCost.Location = new System.Drawing.Point(288, 191);
            this.buyCost.Name = "buyCost";
            this.buyCost.Size = new System.Drawing.Size(224, 24);
            this.buyCost.TabIndex = 13;
            // 
            // noMtr
            // 
            this.noMtr.Location = new System.Drawing.Point(288, 161);
            this.noMtr.Name = "noMtr";
            this.noMtr.Size = new System.Drawing.Size(224, 24);
            this.noMtr.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "الكمية";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "سعر البيع";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "سعر الشراء";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "اسم المادة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "رقم المادة";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(288, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 24);
            this.comboBox1.TabIndex = 22;
            // 
            // FetchMatirial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qte);
            this.Controls.Add(this.saleCost);
            this.Controls.Add(this.buyCost);
            this.Controls.Add(this.noMtr);
            this.Name = "FetchMatirial";
            this.Text = "FetchMatirial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox qte;
        private System.Windows.Forms.TextBox saleCost;
        private System.Windows.Forms.TextBox buyCost;
        private System.Windows.Forms.TextBox noMtr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}