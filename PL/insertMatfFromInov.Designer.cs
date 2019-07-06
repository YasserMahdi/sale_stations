namespace sale_stations.PL
{
    partial class insertMatfFromInov
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qte = new System.Windows.Forms.TextBox();
            this.saleCost = new System.Windows.Forms.TextBox();
            this.buyCost = new System.Windows.Forms.TextBox();
            this.nameMtr = new System.Windows.Forms.TextBox();
            this.noMtr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "ادخال";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "الكمية";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "سعر البيع";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "سعر الشراء";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "اسم المادة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "رقم المادة";
            // 
            // qte
            // 
            this.qte.Location = new System.Drawing.Point(76, 186);
            this.qte.Name = "qte";
            this.qte.Size = new System.Drawing.Size(224, 24);
            this.qte.TabIndex = 15;
            // 
            // saleCost
            // 
            this.saleCost.Location = new System.Drawing.Point(76, 156);
            this.saleCost.Name = "saleCost";
            this.saleCost.Size = new System.Drawing.Size(224, 24);
            this.saleCost.TabIndex = 14;
            // 
            // buyCost
            // 
            this.buyCost.Location = new System.Drawing.Point(76, 126);
            this.buyCost.Name = "buyCost";
            this.buyCost.Size = new System.Drawing.Size(224, 24);
            this.buyCost.TabIndex = 13;
            // 
            // nameMtr
            // 
            this.nameMtr.Location = new System.Drawing.Point(76, 96);
            this.nameMtr.Name = "nameMtr";
            this.nameMtr.Size = new System.Drawing.Size(224, 24);
            this.nameMtr.TabIndex = 12;
            // 
            // noMtr
            // 
            this.noMtr.Location = new System.Drawing.Point(76, 65);
            this.noMtr.Name = "noMtr";
            this.noMtr.Size = new System.Drawing.Size(224, 24);
            this.noMtr.TabIndex = 11;
            // 
            // insertMatfFromInov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qte);
            this.Controls.Add(this.saleCost);
            this.Controls.Add(this.buyCost);
            this.Controls.Add(this.nameMtr);
            this.Controls.Add(this.noMtr);
            this.Name = "insertMatfFromInov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "insertMatfFromInov";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox qte;
        public System.Windows.Forms.TextBox saleCost;
        public System.Windows.Forms.TextBox buyCost;
        public System.Windows.Forms.TextBox nameMtr;
        public System.Windows.Forms.TextBox noMtr;
    }
}