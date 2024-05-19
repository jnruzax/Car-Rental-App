namespace AyuboDrive
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label7 = new System.Windows.Forms.Label();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtWeek = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ayuboDataSet = new AyuboDrive.AyuboDataSet();
            this.ayuboDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelVehicle = new System.Windows.Forms.Panel();
            this.BtnClr = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnDel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnUpd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnSav = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSrch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboDataSetBindingSource)).BeginInit();
            this.panelVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.3F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(331, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Type";
            // 
            // txtDriver
            // 
            this.txtDriver.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtDriver.Location = new System.Drawing.Point(199, 328);
            this.txtDriver.Margin = new System.Windows.Forms.Padding(2);
            this.txtDriver.Multiline = true;
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(106, 25);
            this.txtDriver.TabIndex = 8;
            // 
            // txtMonth
            // 
            this.txtMonth.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtMonth.Location = new System.Drawing.Point(199, 285);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonth.Multiline = true;
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(106, 25);
            this.txtMonth.TabIndex = 7;
            // 
            // txtWeek
            // 
            this.txtWeek.BackColor = System.Drawing.Color.Gainsboro;
            this.txtWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtWeek.Location = new System.Drawing.Point(199, 239);
            this.txtWeek.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeek.Multiline = true;
            this.txtWeek.Name = "txtWeek";
            this.txtWeek.Size = new System.Drawing.Size(106, 25);
            this.txtWeek.TabIndex = 6;
            // 
            // txtDay
            // 
            this.txtDay.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtDay.Location = new System.Drawing.Point(199, 194);
            this.txtDay.Margin = new System.Windows.Forms.Padding(2);
            this.txtDay.Multiline = true;
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(106, 25);
            this.txtDay.TabIndex = 5;
            // 
            // txtMake
            // 
            this.txtMake.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtMake.Location = new System.Drawing.Point(199, 150);
            this.txtMake.Margin = new System.Windows.Forms.Padding(2);
            this.txtMake.Multiline = true;
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(106, 25);
            this.txtMake.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.DimGray;
            this.txtID.HideSelection = false;
            this.txtID.Location = new System.Drawing.Point(199, 99);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(169, 26);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "Search Vehicle ID";
            this.txtID.Click += new System.EventHandler(this.txtID_Click);
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "7 SEATER VAN",
            "SEDAN CAR",
            "COMMUTER VAN",
            "SUVs",
            "SMALLCAR"});
            this.cmbType.Location = new System.Drawing.Point(426, 150);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(140, 25);
            this.cmbType.TabIndex = 4;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.3F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(69, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Driver rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.3F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(69, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Monthly Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.3F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(69, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Weekly Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.3F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Daily Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.3F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Make";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.3F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Vehicle ID";
            // 
            // ayuboDataSet
            // 
            this.ayuboDataSet.DataSetName = "AyuboDataSet";
            this.ayuboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ayuboDataSetBindingSource
            // 
            this.ayuboDataSetBindingSource.DataSource = this.ayuboDataSet;
            this.ayuboDataSetBindingSource.Position = 0;
            // 
            // panelVehicle
            // 
            this.panelVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelVehicle.Controls.Add(this.BtnClr);
            this.panelVehicle.Controls.Add(this.BtnDel);
            this.panelVehicle.Controls.Add(this.BtnUpd);
            this.panelVehicle.Controls.Add(this.BtnSav);
            this.panelVehicle.Controls.Add(this.btnSrch);
            this.panelVehicle.Controls.Add(this.txtID);
            this.panelVehicle.Controls.Add(this.label1);
            this.panelVehicle.Controls.Add(this.label7);
            this.panelVehicle.Controls.Add(this.label2);
            this.panelVehicle.Controls.Add(this.label3);
            this.panelVehicle.Controls.Add(this.label4);
            this.panelVehicle.Controls.Add(this.label5);
            this.panelVehicle.Controls.Add(this.label6);
            this.panelVehicle.Controls.Add(this.cmbType);
            this.panelVehicle.Controls.Add(this.txtDriver);
            this.panelVehicle.Controls.Add(this.txtMake);
            this.panelVehicle.Controls.Add(this.txtMonth);
            this.panelVehicle.Controls.Add(this.txtDay);
            this.panelVehicle.Controls.Add(this.txtWeek);
            this.panelVehicle.Location = new System.Drawing.Point(0, 1);
            this.panelVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.panelVehicle.Name = "panelVehicle";
            this.panelVehicle.Size = new System.Drawing.Size(928, 681);
            this.panelVehicle.TabIndex = 91;
            // 
            // BtnClr
            // 
            this.BtnClr.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.BtnClr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnClr.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BtnClr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.BtnClr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClr.BorderRadius = 0;
            this.BtnClr.ButtonText = "Clear";
            this.BtnClr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.BtnClr.ForeColor = System.Drawing.Color.Black;
            this.BtnClr.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnClr.Iconimage = null;
            this.BtnClr.Iconimage_right = null;
            this.BtnClr.Iconimage_right_Selected = null;
            this.BtnClr.Iconimage_Selected = null;
            this.BtnClr.IconZoom = 0D;
            this.BtnClr.IsTab = false;
            this.BtnClr.Location = new System.Drawing.Point(603, 406);
            this.BtnClr.Name = "BtnClr";
            this.BtnClr.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.BtnClr.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.BtnClr.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnClr.selected = false;
            this.BtnClr.Size = new System.Drawing.Size(134, 41);
            this.BtnClr.TabIndex = 41;
            this.BtnClr.Textcolor = System.Drawing.Color.Black;
            this.BtnClr.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClr.Click += new System.EventHandler(this.BtnClr_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.BtnDel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDel.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BtnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.BtnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDel.BorderRadius = 0;
            this.BtnDel.ButtonText = "Delete";
            this.BtnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.BtnDel.ForeColor = System.Drawing.Color.Black;
            this.BtnDel.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnDel.Iconimage = null;
            this.BtnDel.Iconimage_right = null;
            this.BtnDel.Iconimage_right_Selected = null;
            this.BtnDel.Iconimage_Selected = null;
            this.BtnDel.IconZoom = 0D;
            this.BtnDel.IsTab = false;
            this.BtnDel.Location = new System.Drawing.Point(426, 406);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.BtnDel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.BtnDel.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnDel.selected = false;
            this.BtnDel.Size = new System.Drawing.Size(134, 41);
            this.BtnDel.TabIndex = 40;
            this.BtnDel.Textcolor = System.Drawing.Color.Black;
            this.BtnDel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnUpd
            // 
            this.BtnUpd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.BtnUpd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnUpd.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BtnUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.BtnUpd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUpd.BorderRadius = 0;
            this.BtnUpd.ButtonText = "Update";
            this.BtnUpd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.BtnUpd.ForeColor = System.Drawing.Color.Black;
            this.BtnUpd.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnUpd.Iconimage = null;
            this.BtnUpd.Iconimage_right = null;
            this.BtnUpd.Iconimage_right_Selected = null;
            this.BtnUpd.Iconimage_Selected = null;
            this.BtnUpd.IconZoom = 0D;
            this.BtnUpd.IsTab = false;
            this.BtnUpd.Location = new System.Drawing.Point(249, 406);
            this.BtnUpd.Name = "BtnUpd";
            this.BtnUpd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.BtnUpd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.BtnUpd.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnUpd.selected = false;
            this.BtnUpd.Size = new System.Drawing.Size(134, 41);
            this.BtnUpd.TabIndex = 39;
            this.BtnUpd.Textcolor = System.Drawing.Color.Black;
            this.BtnUpd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpd.Click += new System.EventHandler(this.BtnUpd_Click);
            // 
            // BtnSav
            // 
            this.BtnSav.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.BtnSav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSav.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BtnSav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.BtnSav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSav.BorderRadius = 0;
            this.BtnSav.ButtonText = "    Save";
            this.BtnSav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSav.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.BtnSav.ForeColor = System.Drawing.Color.Black;
            this.BtnSav.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSav.Iconimage = null;
            this.BtnSav.Iconimage_right = null;
            this.BtnSav.Iconimage_right_Selected = null;
            this.BtnSav.Iconimage_Selected = null;
            this.BtnSav.IconZoom = 0D;
            this.BtnSav.IsTab = false;
            this.BtnSav.Location = new System.Drawing.Point(74, 406);
            this.BtnSav.Name = "BtnSav";
            this.BtnSav.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.BtnSav.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.BtnSav.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSav.selected = false;
            this.BtnSav.Size = new System.Drawing.Size(134, 41);
            this.BtnSav.TabIndex = 38;
            this.BtnSav.Textcolor = System.Drawing.Color.Black;
            this.BtnSav.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSav.Click += new System.EventHandler(this.BtnSav_Click);
            // 
            // btnSrch
            // 
            this.btnSrch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSrch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSrch.FlatAppearance.BorderSize = 0;
            this.btnSrch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSrch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSrch.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrch.ForeColor = System.Drawing.Color.White;
            this.btnSrch.Image = ((System.Drawing.Image)(resources.GetObject("btnSrch.Image")));
            this.btnSrch.Location = new System.Drawing.Point(338, 100);
            this.btnSrch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSrch.Name = "btnSrch";
            this.btnSrch.Size = new System.Drawing.Size(31, 24);
            this.btnSrch.TabIndex = 2;
            this.btnSrch.UseVisualStyleBackColor = false;
            this.btnSrch.Click += new System.EventHandler(this.btnSrch_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(928, 634);
            this.Controls.Add(this.panelVehicle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ayuboDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboDataSetBindingSource)).EndInit();
            this.panelVehicle.ResumeLayout(false);
            this.panelVehicle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtWeek;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ayuboDataSetBindingSource;
        private AyuboDataSet ayuboDataSet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelVehicle;
        private System.Windows.Forms.Button btnSrch;
        private Bunifu.Framework.UI.BunifuFlatButton BtnClr;
        private Bunifu.Framework.UI.BunifuFlatButton BtnDel;
        private Bunifu.Framework.UI.BunifuFlatButton BtnUpd;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSav;
    }
}

