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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnOffer = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.BtnOffer);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(81, 578);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1039, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات الممكن تنفيذها";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Location = new System.Drawing.Point(147, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "طباعة قائمة المواد";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.Location = new System.Drawing.Point(763, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 32);
            this.button4.TabIndex = 3;
            this.button4.Text = "اضافة";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(455, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "تعديل معلومات المادة";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(609, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "حذف المادة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(24, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1154, 449);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة المواد";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1109, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(756, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "اسم الماده المراد البحث عنها";
            // 
            // textSearch
            // 
            this.textSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textSearch.HintForeColor = System.Drawing.Color.Empty;
            this.textSearch.HintText = "";
            this.textSearch.isPassword = false;
            this.textSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.textSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.textSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textSearch.LineThickness = 3;
            this.textSearch.Location = new System.Drawing.Point(379, 47);
            this.textSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(370, 44);
            this.textSearch.TabIndex = 8;
            this.textSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textSearch.OnValueChanged += new System.EventHandler(this.textSearch_OnValueChanged);
            // 
            // BtnOffer
            // 
            this.BtnOffer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnOffer.Location = new System.Drawing.Point(301, 46);
            this.BtnOffer.Name = "BtnOffer";
            this.BtnOffer.Size = new System.Drawing.Size(148, 32);
            this.BtnOffer.TabIndex = 5;
            this.BtnOffer.Text = "عرض اسعار";
            this.BtnOffer.UseVisualStyleBackColor = true;
            this.BtnOffer.Click += new System.EventHandler(this.BtnOffer_Click);
            // 
            // FetchMatirial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 718);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FetchMatirial";
            this.Text = "FetchMatirial";
            this.Load += new System.EventHandler(this.FetchMatirial_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnOffer;
    }
}