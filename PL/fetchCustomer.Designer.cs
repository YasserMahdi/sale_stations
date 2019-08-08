namespace sale_stations.PL
{
    partial class fetchCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fetchCustomer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnIns = new Bunifu.Framework.UI.BunifuThinButton2();
            this.searchbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 311);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer list";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnIns);
            this.groupBox2.Location = new System.Drawing.Point(12, 448);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1039, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveBorderThickness = 1;
            this.btnUpdate.ActiveCornerRadius = 20;
            this.btnUpdate.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdate.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.ButtonText = "Update ";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 20;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdate.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.Location = new System.Drawing.Point(216, 40);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 41);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.ActiveBorderThickness = 1;
            this.btnDel.ActiveCornerRadius = 20;
            this.btnDel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDel.ActiveForecolor = System.Drawing.Color.White;
            this.btnDel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDel.BackColor = System.Drawing.SystemColors.Control;
            this.btnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDel.BackgroundImage")));
            this.btnDel.ButtonText = "Delete";
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDel.IdleBorderThickness = 1;
            this.btnDel.IdleCornerRadius = 20;
            this.btnDel.IdleFillColor = System.Drawing.Color.White;
            this.btnDel.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDel.Location = new System.Drawing.Point(405, 40);
            this.btnDel.Margin = new System.Windows.Forms.Padding(5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(181, 41);
            this.btnDel.TabIndex = 3;
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDel.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // btnIns
            // 
            this.btnIns.ActiveBorderThickness = 1;
            this.btnIns.ActiveCornerRadius = 20;
            this.btnIns.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnIns.ActiveForecolor = System.Drawing.Color.White;
            this.btnIns.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnIns.BackColor = System.Drawing.SystemColors.Control;
            this.btnIns.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIns.BackgroundImage")));
            this.btnIns.ButtonText = "Insert";
            this.btnIns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIns.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnIns.IdleBorderThickness = 1;
            this.btnIns.IdleCornerRadius = 20;
            this.btnIns.IdleFillColor = System.Drawing.Color.White;
            this.btnIns.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnIns.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnIns.Location = new System.Drawing.Point(596, 40);
            this.btnIns.Margin = new System.Windows.Forms.Padding(5);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(181, 41);
            this.btnIns.TabIndex = 2;
            this.btnIns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIns.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // searchbox
            // 
            this.searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchbox.HintForeColor = System.Drawing.Color.Empty;
            this.searchbox.HintText = "";
            this.searchbox.isPassword = false;
            this.searchbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.searchbox.LineIdleColor = System.Drawing.Color.Gray;
            this.searchbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.searchbox.LineThickness = 3;
            this.searchbox.Location = new System.Drawing.Point(264, 64);
            this.searchbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(548, 44);
            this.searchbox.TabIndex = 4;
            this.searchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchbox.OnValueChanged += new System.EventHandler(this.searchbox_OnValueChanged);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.Location = new System.Drawing.Point(6, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // fetchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 556);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fetchCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.fetchCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchbox;
        private Bunifu.Framework.UI.BunifuThinButton2 btnIns;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
    }
}