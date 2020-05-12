namespace sale_stations.PL
{
    partial class orderFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.salesman = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.invoiceNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.phone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtOldDept = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cusname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCustomerID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.matAmaunt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.matno = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.matPrice = new System.Windows.Forms.TextBox();
            this.matName = new System.Windows.Forms.TextBox();
            this.matQte = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AmountReceived = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.remainingAmount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button3 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bunifuDatepicker1);
            this.groupBox1.Controls.Add(this.salesman);
            this.groupBox1.Controls.Add(this.invoiceNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(735, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الفاتوره";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "التاريخ";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(18, 87);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(306, 44);
            this.bunifuDatepicker1.TabIndex = 23;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 7, 29, 23, 16, 50, 917);
            // 
            // salesman
            // 
            this.salesman.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salesman.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.salesman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salesman.HintForeColor = System.Drawing.Color.Empty;
            this.salesman.HintText = "";
            this.salesman.isPassword = false;
            this.salesman.LineFocusedColor = System.Drawing.Color.Green;
            this.salesman.LineIdleColor = System.Drawing.Color.Gray;
            this.salesman.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.salesman.LineThickness = 3;
            this.salesman.Location = new System.Drawing.Point(18, 139);
            this.salesman.Margin = new System.Windows.Forms.Padding(4);
            this.salesman.Name = "salesman";
            this.salesman.Size = new System.Drawing.Size(305, 44);
            this.salesman.TabIndex = 22;
            this.salesman.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // invoiceNo
            // 
            this.invoiceNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.invoiceNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.invoiceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.invoiceNo.HintForeColor = System.Drawing.Color.Empty;
            this.invoiceNo.HintText = "";
            this.invoiceNo.isPassword = false;
            this.invoiceNo.LineFocusedColor = System.Drawing.Color.Green;
            this.invoiceNo.LineIdleColor = System.Drawing.Color.Gray;
            this.invoiceNo.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.invoiceNo.LineThickness = 3;
            this.invoiceNo.Location = new System.Drawing.Point(18, 30);
            this.invoiceNo.Margin = new System.Windows.Forms.Padding(4);
            this.invoiceNo.Name = "invoiceNo";
            this.invoiceNo.Size = new System.Drawing.Size(305, 44);
            this.invoiceNo.TabIndex = 21;
            this.invoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم البائع";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.phone);
            this.groupBox2.Controls.Add(this.txtOldDept);
            this.groupBox2.Controls.Add(this.cusname);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtCustomerID);
            this.groupBox2.Location = new System.Drawing.Point(207, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "معلومات الزبون";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // phone
            // 
            this.phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phone.HintForeColor = System.Drawing.Color.Empty;
            this.phone.HintText = "";
            this.phone.isPassword = false;
            this.phone.LineFocusedColor = System.Drawing.Color.Blue;
            this.phone.LineIdleColor = System.Drawing.Color.Gray;
            this.phone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.phone.LineThickness = 3;
            this.phone.Location = new System.Drawing.Point(69, 95);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(297, 44);
            this.phone.TabIndex = 13;
            this.phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtOldDept
            // 
            this.txtOldDept.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldDept.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOldDept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOldDept.HintForeColor = System.Drawing.Color.Empty;
            this.txtOldDept.HintText = "";
            this.txtOldDept.isPassword = false;
            this.txtOldDept.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtOldDept.LineIdleColor = System.Drawing.Color.Gray;
            this.txtOldDept.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtOldDept.LineThickness = 3;
            this.txtOldDept.Location = new System.Drawing.Point(62, 147);
            this.txtOldDept.Margin = new System.Windows.Forms.Padding(4);
            this.txtOldDept.Name = "txtOldDept";
            this.txtOldDept.Size = new System.Drawing.Size(297, 44);
            this.txtOldDept.TabIndex = 14;
            this.txtOldDept.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cusname
            // 
            this.cusname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cusname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cusname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cusname.HintForeColor = System.Drawing.Color.Empty;
            this.cusname.HintText = "";
            this.cusname.isPassword = false;
            this.cusname.LineFocusedColor = System.Drawing.Color.Blue;
            this.cusname.LineIdleColor = System.Drawing.Color.Gray;
            this.cusname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cusname.LineThickness = 3;
            this.cusname.Location = new System.Drawing.Point(69, 43);
            this.cusname.Margin = new System.Windows.Forms.Padding(4);
            this.cusname.Name = "cusname";
            this.cusname.Size = new System.Drawing.Size(297, 44);
            this.cusname.TabIndex = 0;
            this.cusname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cusname.OnValueChanged += new System.EventHandler(this.cusname_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "الدين السابق";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "رقم الهاتف";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "اسم الزبون";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TxtCustomerID
            // 
            this.TxtCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCustomerID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCustomerID.HintForeColor = System.Drawing.Color.Empty;
            this.TxtCustomerID.HintText = "";
            this.TxtCustomerID.isPassword = false;
            this.TxtCustomerID.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtCustomerID.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtCustomerID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxtCustomerID.LineThickness = 3;
            this.TxtCustomerID.Location = new System.Drawing.Point(69, 43);
            this.TxtCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCustomerID.Name = "TxtCustomerID";
            this.TxtCustomerID.Size = new System.Drawing.Size(297, 44);
            this.TxtCustomerID.TabIndex = 15;
            this.TxtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.matAmaunt);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.matno);
            this.groupBox3.Controls.Add(this.btn_browse);
            this.groupBox3.Controls.Add(this.matPrice);
            this.groupBox3.Controls.Add(this.matName);
            this.groupBox3.Controls.Add(this.matQte);
            this.groupBox3.Location = new System.Drawing.Point(26, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1217, 364);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "المنتجات";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.Location = new System.Drawing.Point(17, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1180, 248);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved_1);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(1090, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 23);
            this.label14.TabIndex = 11;
            this.label14.Text = "اختيار";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(17, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 23);
            this.label13.TabIndex = 10;
            this.label13.Text = "المبلغ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // matAmaunt
            // 
            this.matAmaunt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.matAmaunt.Location = new System.Drawing.Point(17, 66);
            this.matAmaunt.Name = "matAmaunt";
            this.matAmaunt.Size = new System.Drawing.Size(133, 24);
            this.matAmaunt.TabIndex = 9;
            this.matAmaunt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matAmaunt.TextChanged += new System.EventHandler(this.matAmaunt_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(297, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 23);
            this.label12.TabIndex = 8;
            this.label12.Text = "سعر البيع";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(156, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "الكمية";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(431, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(459, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "اسم المنتج";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(896, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "رقم المنتج";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // matno
            // 
            this.matno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.matno.Location = new System.Drawing.Point(896, 67);
            this.matno.Name = "matno";
            this.matno.Size = new System.Drawing.Size(188, 24);
            this.matno.TabIndex = 1;
            this.matno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matno.TextChanged += new System.EventHandler(this.matno_TextChanged);
            // 
            // btn_browse
            // 
            this.btn_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_browse.Location = new System.Drawing.Point(1090, 67);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(107, 24);
            this.btn_browse.TabIndex = 12;
            this.btn_browse.Text = "---";
            this.btn_browse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.button7_Click);
            // 
            // matPrice
            // 
            this.matPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.matPrice.Location = new System.Drawing.Point(297, 66);
            this.matPrice.MaxLength = 12;
            this.matPrice.Name = "matPrice";
            this.matPrice.Size = new System.Drawing.Size(128, 24);
            this.matPrice.TabIndex = 13;
            this.matPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matPrice.TextChanged += new System.EventHandler(this.matPrice_TextChanged_1);
            this.matPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.matPrice_KeyDown);
            this.matPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matPrice_KeyPress);
            this.matPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.matPrice_KeyUp);
            // 
            // matName
            // 
            this.matName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.matName.Location = new System.Drawing.Point(431, 66);
            this.matName.Name = "matName";
            this.matName.Size = new System.Drawing.Size(459, 24);
            this.matName.TabIndex = 3;
            this.matName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matName.TextChanged += new System.EventHandler(this.matName_TextChanged);
            // 
            // matQte
            // 
            this.matQte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.matQte.Location = new System.Drawing.Point(156, 66);
            this.matQte.MaxLength = 12;
            this.matQte.Name = "matQte";
            this.matQte.Size = new System.Drawing.Size(135, 24);
            this.matQte.TabIndex = 5;
            this.matQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matQte.TextChanged += new System.EventHandler(this.matQte_TextChanged);
            this.matQte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.matQte_KeyDown);
            this.matQte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matQte_KeyPress);
            this.matQte.KeyUp += new System.Windows.Forms.KeyEventHandler(this.matQte_KeyUp);
            // 
            // txttotal
            // 
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txttotal.Location = new System.Drawing.Point(33, 680);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(234, 24);
            this.txttotal.TabIndex = 14;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 683);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = ": المبلغ الكلي";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 200);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AmountReceived
            // 
            this.AmountReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AmountReceived.Location = new System.Drawing.Point(33, 710);
            this.AmountReceived.Name = "AmountReceived";
            this.AmountReceived.Size = new System.Drawing.Size(234, 24);
            this.AmountReceived.TabIndex = 16;
            this.AmountReceived.TextChanged += new System.EventHandler(this.AmountReceived_TextChanged);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(273, 713);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = ": المبلغ الواصل";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // remainingAmount
            // 
            this.remainingAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.remainingAmount.Location = new System.Drawing.Point(33, 740);
            this.remainingAmount.Name = "remainingAmount";
            this.remainingAmount.Size = new System.Drawing.Size(234, 24);
            this.remainingAmount.TabIndex = 18;
            this.remainingAmount.TextChanged += new System.EventHandler(this.remainingAmount_TextChanged);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(273, 743);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 17);
            this.label16.TabIndex = 17;
            this.label16.Text = ": الدين الحالي";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.btnPrint);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(393, 686);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(600, 78);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.ActiveBorderThickness = 1;
            this.btnPrint.ActiveCornerRadius = 20;
            this.btnPrint.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.ActiveForecolor = System.Drawing.Color.White;
            this.btnPrint.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.ButtonText = "خروج";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.IdleBorderThickness = 1;
            this.btnPrint.IdleCornerRadius = 20;
            this.btnPrint.IdleFillColor = System.Drawing.Color.White;
            this.btnPrint.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnPrint.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.Location = new System.Drawing.Point(17, 25);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(181, 41);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "حفظ الفاتورة";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.White;
            this.btnSave.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Location = new System.Drawing.Point(208, 25);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 41);
            this.btnSave.TabIndex = 1;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.ActiveBorderThickness = 1;
            this.button3.ActiveCornerRadius = 20;
            this.button3.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button3.ActiveForecolor = System.Drawing.Color.White;
            this.button3.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.ButtonText = "فاتورة جديده";
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.SeaGreen;
            this.button3.IdleBorderThickness = 1;
            this.button3.IdleCornerRadius = 20;
            this.button3.IdleFillColor = System.Drawing.Color.White;
            this.button3.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button3.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button3.Location = new System.Drawing.Point(399, 25);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 41);
            this.button3.TabIndex = 0;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // orderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1282, 873);
            this.Controls.Add(this.remainingAmount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.AmountReceived);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "orderFrm";
            this.Text = "القائمة";
            this.Load += new System.EventHandler(this.orderFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txttotal;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btn_browse;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox matAmaunt;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox matQte;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox matName;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox matno;
        public System.Windows.Forms.TextBox matPrice;
        public System.Windows.Forms.TextBox AmountReceived;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox remainingAmount;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.GroupBox groupBox4;
        public Bunifu.Framework.UI.BunifuMaterialTextbox invoiceNo;
        public Bunifu.Framework.UI.BunifuMaterialTextbox salesman;
        public Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        public System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtOldDept;
        public Bunifu.Framework.UI.BunifuMaterialTextbox phone;
        public Bunifu.Framework.UI.BunifuMaterialTextbox cusname;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        public Bunifu.Framework.UI.BunifuThinButton2 button3;
        public Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        public Bunifu.Framework.UI.BunifuThinButton2 btnPrint;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TxtCustomerID;
    }
}