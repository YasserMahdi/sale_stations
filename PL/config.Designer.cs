namespace sale_stations.PL
{
    partial class config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(config));
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtDatabase = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtServer = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "save setting";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.White;
            this.btnSave.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Location = new System.Drawing.Point(404, 277);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 41);
            this.btnSave.TabIndex = 5;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatabase.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDatabase.HintForeColor = System.Drawing.Color.Empty;
            this.txtDatabase.HintText = "";
            this.txtDatabase.isPassword = false;
            this.txtDatabase.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDatabase.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDatabase.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDatabase.LineThickness = 3;
            this.txtDatabase.Location = new System.Drawing.Point(215, 204);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(370, 44);
            this.txtDatabase.TabIndex = 4;
            this.txtDatabase.Text = "Database Name";
            this.txtDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtServer
            // 
            this.txtServer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtServer.HintForeColor = System.Drawing.Color.Empty;
            this.txtServer.HintText = "";
            this.txtServer.isPassword = false;
            this.txtServer.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtServer.LineIdleColor = System.Drawing.Color.Gray;
            this.txtServer.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtServer.LineThickness = 3;
            this.txtServer.Location = new System.Drawing.Point(215, 152);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(370, 44);
            this.txtServer.TabIndex = 3;
            this.txtServer.Text = "Server Name";
            this.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 1;
            this.btnClose.ActiveCornerRadius = 20;
            this.btnClose.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = "Cancel";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.Color.White;
            this.btnClose.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClose.Location = new System.Drawing.Point(213, 277);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 41);
            this.btnClose.TabIndex = 6;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.txtServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "config";
            this.Load += new System.EventHandler(this.config_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDatabase;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtServer;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
    }
}