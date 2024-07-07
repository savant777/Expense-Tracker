﻿namespace ExpenseTracker
{
    partial class TransactionAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionAdd));
            this.logoImg = new System.Windows.Forms.PictureBox();
            this.iconHome = new System.Windows.Forms.PictureBox();
            this.iconCat = new System.Windows.Forms.PictureBox();
            this.iconTrans = new System.Windows.Forms.PictureBox();
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCategory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNewTrans = new ExpenseTracker.UI.UI_textbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBack = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateNewTrans = new ExpenseTracker.UI.UI_DateTimePicker();
            this.comboNewCat = new ExpenseTracker.UI.UI_comboBox();
            this.btnSubmit = new ExpenseTracker.UI.UI_button();
            this.numNewAmount = new ExpenseTracker.UI.UI_numericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNewAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // logoImg
            // 
            this.logoImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoImg.Image = global::ExpenseTracker.Properties.Resources.applogo;
            this.logoImg.Location = new System.Drawing.Point(23, 23);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(54, 74);
            this.logoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImg.TabIndex = 1;
            this.logoImg.TabStop = false;
            // 
            // iconHome
            // 
            this.iconHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.iconHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconHome.Image = global::ExpenseTracker.Properties.Resources.home;
            this.iconHome.Location = new System.Drawing.Point(23, 175);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(54, 66);
            this.iconHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconHome.TabIndex = 2;
            this.iconHome.TabStop = false;
            this.iconHome.Click += new System.EventHandler(this.iconHome_Click);
            // 
            // iconCat
            // 
            this.iconCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.iconCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconCat.Image = global::ExpenseTracker.Properties.Resources.category;
            this.iconCat.Location = new System.Drawing.Point(23, 247);
            this.iconCat.Name = "iconCat";
            this.iconCat.Size = new System.Drawing.Size(54, 66);
            this.iconCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCat.TabIndex = 3;
            this.iconCat.TabStop = false;
            this.iconCat.Click += new System.EventHandler(this.iconCat_Click);
            // 
            // iconTrans
            // 
            this.iconTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.iconTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconTrans.Image = global::ExpenseTracker.Properties.Resources.transaction_active;
            this.iconTrans.Location = new System.Drawing.Point(23, 319);
            this.iconTrans.Name = "iconTrans";
            this.iconTrans.Size = new System.Drawing.Size(54, 66);
            this.iconTrans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconTrans.TabIndex = 4;
            this.iconTrans.TabStop = false;
            this.iconTrans.Click += new System.EventHandler(this.iconTrans_Click);
            // 
            // iconPicture
            // 
            this.iconPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.iconPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPicture.Image = global::ExpenseTracker.Properties.Resources.user;
            this.iconPicture.InitialImage = null;
            this.iconPicture.Location = new System.Drawing.Point(23, 463);
            this.iconPicture.Name = "iconPicture";
            this.iconPicture.Size = new System.Drawing.Size(54, 66);
            this.iconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPicture.TabIndex = 5;
            this.iconPicture.TabStop = false;
            this.iconPicture.Click += new System.EventHandler(this.iconPicture_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.panelMenu.ColumnCount = 3;
            this.panelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMenu.Controls.Add(this.iconPicture, 1, 7);
            this.panelMenu.Controls.Add(this.iconTrans, 1, 5);
            this.panelMenu.Controls.Add(this.iconCat, 1, 4);
            this.panelMenu.Controls.Add(this.iconHome, 1, 3);
            this.panelMenu.Controls.Add(this.logoImg, 1, 1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.RowCount = 9;
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMenu.Size = new System.Drawing.Size(100, 553);
            this.panelMenu.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.43169F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.15301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.830602F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.153F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.43169F));
            this.tableLayoutPanel1.Controls.Add(this.labelCategory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(100, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.77916F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.40695F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.40695F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.62779F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.77916F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 553);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelCategory, 3);
            this.labelCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCategory.Font = new System.Drawing.Font("Inter", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(131, 70);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(768, 68);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Create a new transaction";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(131, 209);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(768, 268);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.03003F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.96997F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtNewTrans, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelBack, 3, 9);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.dateNewTrans, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboNewCat, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnSubmit, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.numNewAmount, 2, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(766, 266);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtNewTrans
            // 
            this.txtNewTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtNewTrans.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.txtNewTrans.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.txtNewTrans.BorderRadius = 3;
            this.txtNewTrans.BorderSize = 1;
            this.tableLayoutPanel2.SetColumnSpan(this.txtNewTrans, 2);
            this.txtNewTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewTrans.Font = new System.Drawing.Font("Kanit", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txtNewTrans.Location = new System.Drawing.Point(253, 73);
            this.txtNewTrans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewTrans.Multiline = false;
            this.txtNewTrans.Name = "txtNewTrans";
            this.txtNewTrans.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.txtNewTrans.PasswordChar = false;
            this.txtNewTrans.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewTrans.PlaceholderText = "e.g. Go to Khao Yai";
            this.txtNewTrans.Size = new System.Drawing.Size(460, 34);
            this.txtNewTrans.TabIndex = 2;
            this.txtNewTrans.Texts = "";
            this.txtNewTrans.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Inter", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(53, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Inter", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(53, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBack
            // 
            this.labelBack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBack.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.labelBack.Location = new System.Drawing.Point(525, 211);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(188, 17);
            this.labelBack.TabIndex = 8;
            this.labelBack.Text = "Back";
            this.labelBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Inter", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(53, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Inter", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(53, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateNewTrans
            // 
            this.dateNewTrans.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.dateNewTrans.BorderSize = 1;
            this.dateNewTrans.CalendarFont = new System.Drawing.Font("Inter", 9.5F);
            this.tableLayoutPanel2.SetColumnSpan(this.dateNewTrans, 2);
            this.dateNewTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateNewTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateNewTrans.Font = new System.Drawing.Font("Inter", 9.5F);
            this.dateNewTrans.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNewTrans.Location = new System.Drawing.Point(253, 28);
            this.dateNewTrans.MinimumSize = new System.Drawing.Size(0, 35);
            this.dateNewTrans.Name = "dateNewTrans";
            this.dateNewTrans.Size = new System.Drawing.Size(460, 35);
            this.dateNewTrans.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.dateNewTrans.TabIndex = 1;
            this.dateNewTrans.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            // 
            // comboNewCat
            // 
            this.comboNewCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.comboNewCat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.comboNewCat.BorderSize = 1;
            this.tableLayoutPanel2.SetColumnSpan(this.comboNewCat, 2);
            this.comboNewCat.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboNewCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboNewCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboNewCat.Font = new System.Drawing.Font("Kanit", 10F);
            this.comboNewCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.comboNewCat.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.comboNewCat.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(45)))));
            this.comboNewCat.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.comboNewCat.Location = new System.Drawing.Point(253, 116);
            this.comboNewCat.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboNewCat.Name = "comboNewCat";
            this.comboNewCat.Padding = new System.Windows.Forms.Padding(1);
            this.comboNewCat.Size = new System.Drawing.Size(460, 34);
            this.comboNewCat.TabIndex = 3;
            this.comboNewCat.Texts = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnSubmit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnSubmit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnSubmit.BorderRadius = 3;
            this.btnSubmit.BorderSize = 0;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(53, 203);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(194, 34);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextColor = System.Drawing.Color.White;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // numNewAmount
            // 
            this.numNewAmount.AutoSize = true;
            this.numNewAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.numNewAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.numNewAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numNewAmount.ButtonHighlightColor = System.Drawing.Color.Empty;
            this.tableLayoutPanel2.SetColumnSpan(this.numNewAmount, 2);
            this.numNewAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numNewAmount.DecimalPlaces = 2;
            this.numNewAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numNewAmount.Font = new System.Drawing.Font("Inter", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNewAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.numNewAmount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numNewAmount.Location = new System.Drawing.Point(253, 159);
            this.numNewAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numNewAmount.Name = "numNewAmount";
            this.numNewAmount.Size = new System.Drawing.Size(460, 27);
            this.numNewAmount.TabIndex = 4;
            this.numNewAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNewAmount.ThousandsSeparator = true;
            // 
            // TransactionAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1132, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1050, 550);
            this.Name = "TransactionAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Tracker - Create New Transaction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransactionAdd_FormClosing);
            this.Load += new System.EventHandler(this.TransactionAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNewAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.PictureBox iconHome;
        private System.Windows.Forms.PictureBox iconCat;
        private System.Windows.Forms.PictureBox iconTrans;
        private System.Windows.Forms.PictureBox iconPicture;
        private System.Windows.Forms.TableLayoutPanel panelMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelBack;
        private UI.UI_textbox txtUsername;
        private UI.UI_button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private UI.UI_DateTimePicker uI_DateTimePicker1;
        private UI.UI_comboBox uI_comboBox1;
        private UI.UI_textbox txtNewTrans;
        private UI.UI_DateTimePicker dateNewTrans;
        private UI.UI_comboBox comboNewCat;
        private UI.UI_button btnSubmit;
        private UI.UI_numericUpDown numNewAmount;
    }
}