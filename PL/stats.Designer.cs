namespace sale_stations.PL
{
    partial class stats
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
            this.txtSumDpt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSumDpt
            // 
            this.txtSumDpt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSumDpt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumDpt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSumDpt.HintForeColor = System.Drawing.Color.Empty;
            this.txtSumDpt.HintText = "";
            this.txtSumDpt.isPassword = false;
            this.txtSumDpt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.txtSumDpt.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSumDpt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.txtSumDpt.LineThickness = 3;
            this.txtSumDpt.Location = new System.Drawing.Point(8, 24);
            this.txtSumDpt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSumDpt.Name = "txtSumDpt";
            this.txtSumDpt.Size = new System.Drawing.Size(385, 48);
            this.txtSumDpt.TabIndex = 6;
            this.txtSumDpt.Text = " ";
            this.txtSumDpt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSumDpt);
            this.groupBox3.Location = new System.Drawing.Point(138, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 85);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اجمالي الديون";
            // 
            // stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 385);
            this.Controls.Add(this.groupBox3);
            this.Name = "stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stats";
            this.Load += new System.EventHandler(this.stats_Load);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSumDpt;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}