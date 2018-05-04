namespace SW_project
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ManagerTabs = new System.Windows.Forms.TabControl();
            this.orderPageTab = new System.Windows.Forms.TabPage();
            this.totalPriceValueTextLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderDescriptionGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicinePriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDataGroupBox = new System.Windows.Forms.GroupBox();
            this.orderNewOrderButton = new System.Windows.Forms.Button();
            this.addNewOrderButton = new System.Windows.Forms.Button();
            this.orderQuantityLabel = new System.Windows.Forms.Label();
            this.orderChooseMedicineLabel = new System.Windows.Forms.Label();
            this.orderQuantityTextField = new System.Windows.Forms.TextBox();
            this.orderChooseMedicineComboBox = new System.Windows.Forms.ComboBox();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new SW_project.PharmacyDataSet();
            this.addPageTab = new System.Windows.Forms.TabPage();
            this.addDataTabControl = new System.Windows.Forms.TabControl();
            this.addMedicineTabPage = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.addMedicineCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.getMedicinesByCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addMedicineNewCategoryCheckBox = new System.Windows.Forms.CheckBox();
            this.addMedicineCategoryTextField = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.addMedicineAddButton = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.addMedicineConcectrationTextField = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.addMedicinePriceOfSaleTextField = new System.Windows.Forms.TextBox();
            this.addMedicineBarcodeTextField = new System.Windows.Forms.TextBox();
            this.addMedicineActiveIngrdTextField = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.addMedicineTradeNameTextField = new System.Windows.Forms.TextBox();
            this.addCustomerTabPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addCustomerCommentsTextField = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addCustomerTelephoneTextField = new System.Windows.Forms.TextBox();
            this.addCustomerAddressTextField = new System.Windows.Forms.TextBox();
            this.addCustomerNameTextField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addCustomerAddButton = new System.Windows.Forms.Button();
            this.addPurchaseTabPage = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.addPurchaseAddButton = new System.Windows.Forms.Button();
            this.addPurchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.editPageTab = new System.Windows.Forms.TabPage();
            this.editDataTablControl = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.editMedicineBarcodeComboBox = new System.Windows.Forms.ComboBox();
            this.getMedicinesBarCodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editMedicineCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.editMedicineButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.editMedicineConcentrationTextField = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.editMedicinePriceOfSaleTextField = new System.Windows.Forms.TextBox();
            this.editMedicineActiveIngredientTextField = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.editMedicineTradeNameTextField = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.editCustomerNameComboBox = new System.Windows.Forms.ComboBox();
            this.getcustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editCustomerCommentsTextField = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.editCustomerTelephoneTextField = new System.Windows.Forms.TextBox();
            this.editCustomerAddressTextField = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.editCustomerButton = new System.Windows.Forms.Button();
            this.deletePageTab = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.deleteCustomerNameComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.deleteOrderTransNumberComboBox = new System.Windows.Forms.ComboBox();
            this.getordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchPageTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label141 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.searchViewButton = new System.Windows.Forms.Button();
            this.label94 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.searchMethodsComboBox = new System.Windows.Forms.ComboBox();
            this.activeIngredientTradeNameLabel = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.accountPageTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox25 = new System.Windows.Forms.ComboBox();
            this.label90 = new System.Windows.Forms.Label();
            this.button26 = new System.Windows.Forms.Button();
            this.getMedicinesBarCodeTableAdapter = new SW_project.PharmacyDataSetTableAdapters.getMedicinesBarCodeTableAdapter();
            this.getMedicinesByCategoryTableAdapter = new SW_project.PharmacyDataSetTableAdapters.getMedicinesByCategoryTableAdapter();
            this.getcustomersTableAdapter = new SW_project.PharmacyDataSetTableAdapters.getcustomersTableAdapter();
            this.stockTableAdapter = new SW_project.PharmacyDataSetTableAdapters.stockTableAdapter();
            this.getordersTableAdapter = new SW_project.PharmacyDataSetTableAdapters.getordersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.ManagerTabs.SuspendLayout();
            this.orderPageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDescriptionGridView)).BeginInit();
            this.orderDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            this.addPageTab.SuspendLayout();
            this.addDataTabControl.SuspendLayout();
            this.addMedicineTabPage.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getMedicinesByCategoryBindingSource)).BeginInit();
            this.addCustomerTabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.addPurchaseTabPage.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.editPageTab.SuspendLayout();
            this.editDataTablControl.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getMedicinesBarCodeBindingSource)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getcustomersBindingSource)).BeginInit();
            this.deletePageTab.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getordersBindingSource)).BeginInit();
            this.searchPageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.accountPageTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(988, 109);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 597);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(990, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(20, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(20, 20);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // ManagerTabs
            // 
            this.ManagerTabs.Controls.Add(this.orderPageTab);
            this.ManagerTabs.Controls.Add(this.addPageTab);
            this.ManagerTabs.Controls.Add(this.editPageTab);
            this.ManagerTabs.Controls.Add(this.deletePageTab);
            this.ManagerTabs.Controls.Add(this.searchPageTab);
            this.ManagerTabs.Controls.Add(this.accountPageTab);
            this.ManagerTabs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManagerTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ManagerTabs.ItemSize = new System.Drawing.Size(125, 25);
            this.ManagerTabs.Location = new System.Drawing.Point(1, 113);
            this.ManagerTabs.Margin = new System.Windows.Forms.Padding(4);
            this.ManagerTabs.Name = "ManagerTabs";
            this.ManagerTabs.SelectedIndex = 0;
            this.ManagerTabs.ShowToolTips = true;
            this.ManagerTabs.Size = new System.Drawing.Size(990, 477);
            this.ManagerTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.ManagerTabs.TabIndex = 10;
            // 
            // orderPageTab
            // 
            this.orderPageTab.AutoScroll = true;
            this.orderPageTab.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.orderPageTab.Controls.Add(this.totalPriceValueTextLabel);
            this.orderPageTab.Controls.Add(this.label1);
            this.orderPageTab.Controls.Add(this.orderDescriptionGridView);
            this.orderPageTab.Controls.Add(this.orderDataGroupBox);
            this.orderPageTab.Location = new System.Drawing.Point(4, 29);
            this.orderPageTab.Name = "orderPageTab";
            this.orderPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.orderPageTab.Size = new System.Drawing.Size(982, 444);
            this.orderPageTab.TabIndex = 1;
            this.orderPageTab.Text = "Order";
            // 
            // totalPriceValueTextLabel
            // 
            this.totalPriceValueTextLabel.AutoSize = true;
            this.totalPriceValueTextLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalPriceValueTextLabel.Location = new System.Drawing.Point(865, 414);
            this.totalPriceValueTextLabel.Name = "totalPriceValueTextLabel";
            this.totalPriceValueTextLabel.Size = new System.Drawing.Size(17, 17);
            this.totalPriceValueTextLabel.TabIndex = 3;
            this.totalPriceValueTextLabel.Text = "0";
            this.totalPriceValueTextLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(761, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Price :";
            // 
            // orderDescriptionGridView
            // 
            this.orderDescriptionGridView.AllowUserToAddRows = false;
            this.orderDescriptionGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDescriptionGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.orderDescriptionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDescriptionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.medicinePriceColumn,
            this.totalPrice});
            this.orderDescriptionGridView.GridColor = System.Drawing.Color.Black;
            this.orderDescriptionGridView.Location = new System.Drawing.Point(331, 6);
            this.orderDescriptionGridView.Name = "orderDescriptionGridView";
            this.orderDescriptionGridView.ReadOnly = true;
            this.orderDescriptionGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.orderDescriptionGridView.RowTemplate.ReadOnly = true;
            this.orderDescriptionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.orderDescriptionGridView.Size = new System.Drawing.Size(606, 429);
            this.orderDescriptionGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Barcode";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // medicinePriceColumn
            // 
            this.medicinePriceColumn.HeaderText = "Item Price";
            this.medicinePriceColumn.Name = "medicinePriceColumn";
            this.medicinePriceColumn.ReadOnly = true;
            this.medicinePriceColumn.Width = 110;
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Price";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // orderDataGroupBox
            // 
            this.orderDataGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.orderDataGroupBox.Controls.Add(this.orderNewOrderButton);
            this.orderDataGroupBox.Controls.Add(this.addNewOrderButton);
            this.orderDataGroupBox.Controls.Add(this.orderQuantityLabel);
            this.orderDataGroupBox.Controls.Add(this.orderChooseMedicineLabel);
            this.orderDataGroupBox.Controls.Add(this.orderQuantityTextField);
            this.orderDataGroupBox.Controls.Add(this.orderChooseMedicineComboBox);
            this.orderDataGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.orderDataGroupBox.Location = new System.Drawing.Point(3, 3);
            this.orderDataGroupBox.Name = "orderDataGroupBox";
            this.orderDataGroupBox.Size = new System.Drawing.Size(322, 438);
            this.orderDataGroupBox.TabIndex = 0;
            this.orderDataGroupBox.TabStop = false;
            this.orderDataGroupBox.Text = "New Order";
            // 
            // orderNewOrderButton
            // 
            this.orderNewOrderButton.Location = new System.Drawing.Point(166, 168);
            this.orderNewOrderButton.Name = "orderNewOrderButton";
            this.orderNewOrderButton.Size = new System.Drawing.Size(121, 23);
            this.orderNewOrderButton.TabIndex = 5;
            this.orderNewOrderButton.Text = "Order";
            this.orderNewOrderButton.UseVisualStyleBackColor = true;
            this.orderNewOrderButton.Click += new System.EventHandler(this.orderNewOrderButton_Click);
            // 
            // addNewOrderButton
            // 
            this.addNewOrderButton.Location = new System.Drawing.Point(6, 139);
            this.addNewOrderButton.Name = "addNewOrderButton";
            this.addNewOrderButton.Size = new System.Drawing.Size(281, 23);
            this.addNewOrderButton.TabIndex = 4;
            this.addNewOrderButton.Text = "Add";
            this.addNewOrderButton.UseVisualStyleBackColor = true;
            this.addNewOrderButton.Click += new System.EventHandler(this.addNewOrderButton_Click_1);
            // 
            // orderQuantityLabel
            // 
            this.orderQuantityLabel.AutoSize = true;
            this.orderQuantityLabel.Location = new System.Drawing.Point(6, 111);
            this.orderQuantityLabel.Name = "orderQuantityLabel";
            this.orderQuantityLabel.Size = new System.Drawing.Size(74, 17);
            this.orderQuantityLabel.TabIndex = 3;
            this.orderQuantityLabel.Text = "Quantity:";
            // 
            // orderChooseMedicineLabel
            // 
            this.orderChooseMedicineLabel.AutoSize = true;
            this.orderChooseMedicineLabel.Location = new System.Drawing.Point(6, 72);
            this.orderChooseMedicineLabel.Name = "orderChooseMedicineLabel";
            this.orderChooseMedicineLabel.Size = new System.Drawing.Size(136, 17);
            this.orderChooseMedicineLabel.TabIndex = 2;
            this.orderChooseMedicineLabel.Text = "Choose Medicine:";
            // 
            // orderQuantityTextField
            // 
            this.orderQuantityTextField.Location = new System.Drawing.Point(166, 108);
            this.orderQuantityTextField.Name = "orderQuantityTextField";
            this.orderQuantityTextField.Size = new System.Drawing.Size(121, 23);
            this.orderQuantityTextField.TabIndex = 1;
            // 
            // orderChooseMedicineComboBox
            // 
            this.orderChooseMedicineComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.orderChooseMedicineComboBox.DataSource = this.stockBindingSource;
            this.orderChooseMedicineComboBox.DisplayMember = "Tradename";
            this.orderChooseMedicineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderChooseMedicineComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderChooseMedicineComboBox.FormattingEnabled = true;
            this.orderChooseMedicineComboBox.Location = new System.Drawing.Point(166, 72);
            this.orderChooseMedicineComboBox.Name = "orderChooseMedicineComboBox";
            this.orderChooseMedicineComboBox.Size = new System.Drawing.Size(121, 24);
            this.orderChooseMedicineComboBox.TabIndex = 0;
            this.orderChooseMedicineComboBox.ValueMember = "Code";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "stock";
            this.stockBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addPageTab
            // 
            this.addPageTab.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.addPageTab.Controls.Add(this.addDataTabControl);
            this.addPageTab.Location = new System.Drawing.Point(4, 29);
            this.addPageTab.Name = "addPageTab";
            this.addPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.addPageTab.Size = new System.Drawing.Size(982, 444);
            this.addPageTab.TabIndex = 2;
            this.addPageTab.Text = "Add";
            // 
            // addDataTabControl
            // 
            this.addDataTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addDataTabControl.Controls.Add(this.addMedicineTabPage);
            this.addDataTabControl.Controls.Add(this.addCustomerTabPage);
            this.addDataTabControl.Controls.Add(this.addPurchaseTabPage);
            this.addDataTabControl.ItemSize = new System.Drawing.Size(125, 25);
            this.addDataTabControl.Location = new System.Drawing.Point(4, 4);
            this.addDataTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.addDataTabControl.Name = "addDataTabControl";
            this.addDataTabControl.SelectedIndex = 0;
            this.addDataTabControl.ShowToolTips = true;
            this.addDataTabControl.Size = new System.Drawing.Size(865, 436);
            this.addDataTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.addDataTabControl.TabIndex = 11;
            // 
            // addMedicineTabPage
            // 
            this.addMedicineTabPage.Controls.Add(this.groupBox5);
            this.addMedicineTabPage.Location = new System.Drawing.Point(4, 29);
            this.addMedicineTabPage.Name = "addMedicineTabPage";
            this.addMedicineTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addMedicineTabPage.Size = new System.Drawing.Size(857, 403);
            this.addMedicineTabPage.TabIndex = 4;
            this.addMedicineTabPage.Text = "Medicine";
            this.addMedicineTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Controls.Add(this.addMedicineCategoryComboBox);
            this.groupBox5.Controls.Add(this.addMedicineNewCategoryCheckBox);
            this.groupBox5.Controls.Add(this.addMedicineCategoryTextField);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.addMedicineAddButton);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.addMedicineConcectrationTextField);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.addMedicinePriceOfSaleTextField);
            this.groupBox5.Controls.Add(this.addMedicineBarcodeTextField);
            this.groupBox5.Controls.Add(this.addMedicineActiveIngrdTextField);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.addMedicineTradeNameTextField);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(845, 391);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add new medicine";
            // 
            // addMedicineCategoryComboBox
            // 
            this.addMedicineCategoryComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.addMedicineCategoryComboBox.DataSource = this.getMedicinesByCategoryBindingSource;
            this.addMedicineCategoryComboBox.DisplayMember = "Category";
            this.addMedicineCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addMedicineCategoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMedicineCategoryComboBox.FormattingEnabled = true;
            this.addMedicineCategoryComboBox.Location = new System.Drawing.Point(150, 109);
            this.addMedicineCategoryComboBox.Name = "addMedicineCategoryComboBox";
            this.addMedicineCategoryComboBox.Size = new System.Drawing.Size(235, 24);
            this.addMedicineCategoryComboBox.TabIndex = 38;
            this.addMedicineCategoryComboBox.ValueMember = "Category";
            // 
            // getMedicinesByCategoryBindingSource
            // 
            this.getMedicinesByCategoryBindingSource.DataMember = "getMedicinesByCategory";
            this.getMedicinesByCategoryBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // addMedicineNewCategoryCheckBox
            // 
            this.addMedicineNewCategoryCheckBox.AutoSize = true;
            this.addMedicineNewCategoryCheckBox.Location = new System.Drawing.Point(84, 112);
            this.addMedicineNewCategoryCheckBox.Name = "addMedicineNewCategoryCheckBox";
            this.addMedicineNewCategoryCheckBox.Size = new System.Drawing.Size(62, 21);
            this.addMedicineNewCategoryCheckBox.TabIndex = 36;
            this.addMedicineNewCategoryCheckBox.Text = "New ";
            this.addMedicineNewCategoryCheckBox.UseVisualStyleBackColor = true;
            this.addMedicineNewCategoryCheckBox.CheckedChanged += new System.EventHandler(this.addMedicineNewCategoryCheckBox_CheckedChanged);
            // 
            // addMedicineCategoryTextField
            // 
            this.addMedicineCategoryTextField.Location = new System.Drawing.Point(150, 109);
            this.addMedicineCategoryTextField.Name = "addMedicineCategoryTextField";
            this.addMedicineCategoryTextField.Size = new System.Drawing.Size(235, 23);
            this.addMedicineCategoryTextField.TabIndex = 35;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 27);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 17);
            this.label26.TabIndex = 34;
            this.label26.Text = "Barcode:";
            // 
            // addMedicineAddButton
            // 
            this.addMedicineAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addMedicineAddButton.Location = new System.Drawing.Point(692, 359);
            this.addMedicineAddButton.Name = "addMedicineAddButton";
            this.addMedicineAddButton.Size = new System.Drawing.Size(147, 26);
            this.addMedicineAddButton.TabIndex = 6;
            this.addMedicineAddButton.Text = "Add Medicine";
            this.addMedicineAddButton.UseVisualStyleBackColor = true;
            this.addMedicineAddButton.Click += new System.EventHandler(this.addNewMedicine_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 111);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 17);
            this.label21.TabIndex = 28;
            this.label21.Text = "Category:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 167);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(106, 17);
            this.label27.TabIndex = 32;
            this.label27.Text = "Price of Sale:";
            // 
            // addMedicineConcectrationTextField
            // 
            this.addMedicineConcectrationTextField.Location = new System.Drawing.Point(150, 136);
            this.addMedicineConcectrationTextField.Name = "addMedicineConcectrationTextField";
            this.addMedicineConcectrationTextField.Size = new System.Drawing.Size(235, 23);
            this.addMedicineConcectrationTextField.TabIndex = 4;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 139);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(114, 17);
            this.label22.TabIndex = 29;
            this.label22.Text = "Concentration:";
            // 
            // addMedicinePriceOfSaleTextField
            // 
            this.addMedicinePriceOfSaleTextField.Location = new System.Drawing.Point(150, 164);
            this.addMedicinePriceOfSaleTextField.Name = "addMedicinePriceOfSaleTextField";
            this.addMedicinePriceOfSaleTextField.Size = new System.Drawing.Size(235, 23);
            this.addMedicinePriceOfSaleTextField.TabIndex = 5;
            // 
            // addMedicineBarcodeTextField
            // 
            this.addMedicineBarcodeTextField.Location = new System.Drawing.Point(150, 24);
            this.addMedicineBarcodeTextField.Name = "addMedicineBarcodeTextField";
            this.addMedicineBarcodeTextField.Size = new System.Drawing.Size(235, 23);
            this.addMedicineBarcodeTextField.TabIndex = 0;
            // 
            // addMedicineActiveIngrdTextField
            // 
            this.addMedicineActiveIngrdTextField.Location = new System.Drawing.Point(150, 80);
            this.addMedicineActiveIngrdTextField.Name = "addMedicineActiveIngrdTextField";
            this.addMedicineActiveIngrdTextField.Size = new System.Drawing.Size(235, 23);
            this.addMedicineActiveIngrdTextField.TabIndex = 2;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 55);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(95, 17);
            this.label25.TabIndex = 33;
            this.label25.Text = "Tradename:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 83);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(135, 17);
            this.label24.TabIndex = 31;
            this.label24.Text = "Active ingredient:";
            // 
            // addMedicineTradeNameTextField
            // 
            this.addMedicineTradeNameTextField.Location = new System.Drawing.Point(150, 52);
            this.addMedicineTradeNameTextField.Name = "addMedicineTradeNameTextField";
            this.addMedicineTradeNameTextField.Size = new System.Drawing.Size(235, 23);
            this.addMedicineTradeNameTextField.TabIndex = 1;
            // 
            // addCustomerTabPage
            // 
            this.addCustomerTabPage.Controls.Add(this.groupBox3);
            this.addCustomerTabPage.Location = new System.Drawing.Point(4, 29);
            this.addCustomerTabPage.Name = "addCustomerTabPage";
            this.addCustomerTabPage.Size = new System.Drawing.Size(857, 403);
            this.addCustomerTabPage.TabIndex = 5;
            this.addCustomerTabPage.Text = "Customer";
            this.addCustomerTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.addCustomerCommentsTextField);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.addCustomerTelephoneTextField);
            this.groupBox3.Controls.Add(this.addCustomerAddressTextField);
            this.groupBox3.Controls.Add(this.addCustomerNameTextField);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.addCustomerAddButton);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(851, 397);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add new customer";
            // 
            // addCustomerCommentsTextField
            // 
            this.addCustomerCommentsTextField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addCustomerCommentsTextField.Location = new System.Drawing.Point(131, 113);
            this.addCustomerCommentsTextField.Name = "addCustomerCommentsTextField";
            this.addCustomerCommentsTextField.Size = new System.Drawing.Size(714, 249);
            this.addCustomerCommentsTextField.TabIndex = 4;
            this.addCustomerCommentsTextField.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Comments:";
            // 
            // addCustomerTelephoneTextField
            // 
            this.addCustomerTelephoneTextField.Location = new System.Drawing.Point(131, 82);
            this.addCustomerTelephoneTextField.MaxLength = 11;
            this.addCustomerTelephoneTextField.Name = "addCustomerTelephoneTextField";
            this.addCustomerTelephoneTextField.Size = new System.Drawing.Size(171, 23);
            this.addCustomerTelephoneTextField.TabIndex = 3;
            // 
            // addCustomerAddressTextField
            // 
            this.addCustomerAddressTextField.Location = new System.Drawing.Point(131, 56);
            this.addCustomerAddressTextField.Name = "addCustomerAddressTextField";
            this.addCustomerAddressTextField.Size = new System.Drawing.Size(171, 23);
            this.addCustomerAddressTextField.TabIndex = 2;
            // 
            // addCustomerNameTextField
            // 
            this.addCustomerNameTextField.Location = new System.Drawing.Point(131, 30);
            this.addCustomerNameTextField.Name = "addCustomerNameTextField";
            this.addCustomerNameTextField.Size = new System.Drawing.Size(171, 23);
            this.addCustomerNameTextField.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Telephone no.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name:";
            // 
            // addCustomerAddButton
            // 
            this.addCustomerAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addCustomerAddButton.Location = new System.Drawing.Point(700, 368);
            this.addCustomerAddButton.Name = "addCustomerAddButton";
            this.addCustomerAddButton.Size = new System.Drawing.Size(145, 23);
            this.addCustomerAddButton.TabIndex = 5;
            this.addCustomerAddButton.Text = "Add Customer";
            this.addCustomerAddButton.UseVisualStyleBackColor = true;
            this.addCustomerAddButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // addPurchaseTabPage
            // 
            this.addPurchaseTabPage.BackColor = System.Drawing.Color.Transparent;
            this.addPurchaseTabPage.Controls.Add(this.groupBox10);
            this.addPurchaseTabPage.Controls.Add(this.button11);
            this.addPurchaseTabPage.Location = new System.Drawing.Point(4, 29);
            this.addPurchaseTabPage.Name = "addPurchaseTabPage";
            this.addPurchaseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addPurchaseTabPage.Size = new System.Drawing.Size(857, 403);
            this.addPurchaseTabPage.TabIndex = 6;
            this.addPurchaseTabPage.Text = "Purchase";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.addPurchaseAddButton);
            this.groupBox10.Controls.Add(this.addPurchaseDateTimePicker);
            this.groupBox10.Controls.Add(this.label28);
            this.groupBox10.Location = new System.Drawing.Point(6, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(841, 391);
            this.groupBox10.TabIndex = 16;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Purchase info";
            // 
            // addPurchaseAddButton
            // 
            this.addPurchaseAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addPurchaseAddButton.Location = new System.Drawing.Point(695, 359);
            this.addPurchaseAddButton.Name = "addPurchaseAddButton";
            this.addPurchaseAddButton.Size = new System.Drawing.Size(140, 26);
            this.addPurchaseAddButton.TabIndex = 2;
            this.addPurchaseAddButton.Text = "Add Purchase";
            this.addPurchaseAddButton.UseVisualStyleBackColor = true;
            this.addPurchaseAddButton.Click += new System.EventHandler(this.button10_Click);
            // 
            // addPurchaseDateTimePicker
            // 
            this.addPurchaseDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.addPurchaseDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.addPurchaseDateTimePicker.Location = new System.Drawing.Point(85, 21);
            this.addPurchaseDateTimePicker.Name = "addPurchaseDateTimePicker";
            this.addPurchaseDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.addPurchaseDateTimePicker.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 26);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(47, 17);
            this.label28.TabIndex = 15;
            this.label28.Text = "Date:";
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Location = new System.Drawing.Point(776, 467);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 13;
            this.button11.Text = "Add";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // editPageTab
            // 
            this.editPageTab.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.editPageTab.Controls.Add(this.editDataTablControl);
            this.editPageTab.Location = new System.Drawing.Point(4, 29);
            this.editPageTab.Name = "editPageTab";
            this.editPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.editPageTab.Size = new System.Drawing.Size(982, 444);
            this.editPageTab.TabIndex = 3;
            this.editPageTab.Text = "Edit";
            // 
            // editDataTablControl
            // 
            this.editDataTablControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editDataTablControl.Controls.Add(this.tabPage7);
            this.editDataTablControl.Controls.Add(this.tabPage9);
            this.editDataTablControl.ItemSize = new System.Drawing.Size(125, 25);
            this.editDataTablControl.Location = new System.Drawing.Point(4, 4);
            this.editDataTablControl.Margin = new System.Windows.Forms.Padding(4);
            this.editDataTablControl.Name = "editDataTablControl";
            this.editDataTablControl.SelectedIndex = 0;
            this.editDataTablControl.ShowToolTips = true;
            this.editDataTablControl.Size = new System.Drawing.Size(865, 436);
            this.editDataTablControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.editDataTablControl.TabIndex = 12;
            // 
            // tabPage7
            // 
            this.tabPage7.AutoScroll = true;
            this.tabPage7.Controls.Add(this.groupBox6);
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(857, 403);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "Medicine";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.editMedicineBarcodeComboBox);
            this.groupBox6.Controls.Add(this.editMedicineCategoryComboBox);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.editMedicineButton);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.editMedicineConcentrationTextField);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.editMedicinePriceOfSaleTextField);
            this.groupBox6.Controls.Add(this.editMedicineActiveIngredientTextField);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.editMedicineTradeNameTextField);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(851, 397);
            this.groupBox6.TabIndex = 37;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Edit medicine";
            // 
            // editMedicineBarcodeComboBox
            // 
            this.editMedicineBarcodeComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.editMedicineBarcodeComboBox.DataSource = this.getMedicinesBarCodeBindingSource;
            this.editMedicineBarcodeComboBox.DisplayMember = "Code";
            this.editMedicineBarcodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editMedicineBarcodeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMedicineBarcodeComboBox.FormattingEnabled = true;
            this.editMedicineBarcodeComboBox.Location = new System.Drawing.Point(141, 24);
            this.editMedicineBarcodeComboBox.Name = "editMedicineBarcodeComboBox";
            this.editMedicineBarcodeComboBox.Size = new System.Drawing.Size(235, 24);
            this.editMedicineBarcodeComboBox.TabIndex = 1;
            this.editMedicineBarcodeComboBox.ValueMember = "Code";
            // 
            // getMedicinesBarCodeBindingSource
            // 
            this.getMedicinesBarCodeBindingSource.DataMember = "getMedicinesBarCode";
            this.getMedicinesBarCodeBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // editMedicineCategoryComboBox
            // 
            this.editMedicineCategoryComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.editMedicineCategoryComboBox.DataSource = this.getMedicinesByCategoryBindingSource;
            this.editMedicineCategoryComboBox.DisplayMember = "Category";
            this.editMedicineCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editMedicineCategoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMedicineCategoryComboBox.FormattingEnabled = true;
            this.editMedicineCategoryComboBox.Location = new System.Drawing.Point(141, 108);
            this.editMedicineCategoryComboBox.Name = "editMedicineCategoryComboBox";
            this.editMedicineCategoryComboBox.Size = new System.Drawing.Size(235, 24);
            this.editMedicineCategoryComboBox.TabIndex = 4;
            this.editMedicineCategoryComboBox.ValueMember = "Category";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 17);
            this.label14.TabIndex = 34;
            this.label14.Text = "Barcode:";
            // 
            // editMedicineButton
            // 
            this.editMedicineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editMedicineButton.Location = new System.Drawing.Point(700, 368);
            this.editMedicineButton.Name = "editMedicineButton";
            this.editMedicineButton.Size = new System.Drawing.Size(145, 23);
            this.editMedicineButton.TabIndex = 7;
            this.editMedicineButton.Text = "Edit Medicine";
            this.editMedicineButton.UseVisualStyleBackColor = true;
            this.editMedicineButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "Category:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 17);
            this.label16.TabIndex = 32;
            this.label16.Text = "Price of Sale:";
            // 
            // editMedicineConcentrationTextField
            // 
            this.editMedicineConcentrationTextField.Location = new System.Drawing.Point(141, 136);
            this.editMedicineConcentrationTextField.Name = "editMedicineConcentrationTextField";
            this.editMedicineConcentrationTextField.Size = new System.Drawing.Size(235, 23);
            this.editMedicineConcentrationTextField.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 17);
            this.label17.TabIndex = 29;
            this.label17.Text = "Concentration:";
            // 
            // editMedicinePriceOfSaleTextField
            // 
            this.editMedicinePriceOfSaleTextField.Location = new System.Drawing.Point(141, 164);
            this.editMedicinePriceOfSaleTextField.Name = "editMedicinePriceOfSaleTextField";
            this.editMedicinePriceOfSaleTextField.Size = new System.Drawing.Size(235, 23);
            this.editMedicinePriceOfSaleTextField.TabIndex = 6;
            // 
            // editMedicineActiveIngredientTextField
            // 
            this.editMedicineActiveIngredientTextField.Location = new System.Drawing.Point(141, 80);
            this.editMedicineActiveIngredientTextField.Name = "editMedicineActiveIngredientTextField";
            this.editMedicineActiveIngredientTextField.Size = new System.Drawing.Size(235, 23);
            this.editMedicineActiveIngredientTextField.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 17);
            this.label18.TabIndex = 33;
            this.label18.Text = "Tradename:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 17);
            this.label19.TabIndex = 31;
            this.label19.Text = "Active ingredient:";
            // 
            // editMedicineTradeNameTextField
            // 
            this.editMedicineTradeNameTextField.Location = new System.Drawing.Point(141, 52);
            this.editMedicineTradeNameTextField.Name = "editMedicineTradeNameTextField";
            this.editMedicineTradeNameTextField.Size = new System.Drawing.Size(235, 23);
            this.editMedicineTradeNameTextField.TabIndex = 2;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.groupBox4);
            this.tabPage9.Location = new System.Drawing.Point(4, 29);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(857, 403);
            this.tabPage9.TabIndex = 5;
            this.tabPage9.Text = "Customer";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.editCustomerNameComboBox);
            this.groupBox4.Controls.Add(this.editCustomerCommentsTextField);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.editCustomerTelephoneTextField);
            this.groupBox4.Controls.Add(this.editCustomerAddressTextField);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.editCustomerButton);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(851, 397);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Edit customer";
            // 
            // editCustomerNameComboBox
            // 
            this.editCustomerNameComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.editCustomerNameComboBox.DataSource = this.getcustomersBindingSource;
            this.editCustomerNameComboBox.DisplayMember = "cname";
            this.editCustomerNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editCustomerNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCustomerNameComboBox.FormattingEnabled = true;
            this.editCustomerNameComboBox.Location = new System.Drawing.Point(131, 22);
            this.editCustomerNameComboBox.Name = "editCustomerNameComboBox";
            this.editCustomerNameComboBox.Size = new System.Drawing.Size(171, 24);
            this.editCustomerNameComboBox.TabIndex = 1;
            this.editCustomerNameComboBox.ValueMember = "cname";
            // 
            // getcustomersBindingSource
            // 
            this.getcustomersBindingSource.DataMember = "getcustomers";
            this.getcustomersBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // editCustomerCommentsTextField
            // 
            this.editCustomerCommentsTextField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editCustomerCommentsTextField.Location = new System.Drawing.Point(131, 113);
            this.editCustomerCommentsTextField.Name = "editCustomerCommentsTextField";
            this.editCustomerCommentsTextField.Size = new System.Drawing.Size(714, 249);
            this.editCustomerCommentsTextField.TabIndex = 4;
            this.editCustomerCommentsTextField.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Comments:";
            // 
            // editCustomerTelephoneTextField
            // 
            this.editCustomerTelephoneTextField.Location = new System.Drawing.Point(131, 82);
            this.editCustomerTelephoneTextField.MaxLength = 11;
            this.editCustomerTelephoneTextField.Name = "editCustomerTelephoneTextField";
            this.editCustomerTelephoneTextField.Size = new System.Drawing.Size(171, 23);
            this.editCustomerTelephoneTextField.TabIndex = 3;
            // 
            // editCustomerAddressTextField
            // 
            this.editCustomerAddressTextField.Location = new System.Drawing.Point(131, 52);
            this.editCustomerAddressTextField.Name = "editCustomerAddressTextField";
            this.editCustomerAddressTextField.Size = new System.Drawing.Size(171, 23);
            this.editCustomerAddressTextField.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Telephone no.:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Address:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Name:";
            // 
            // editCustomerButton
            // 
            this.editCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editCustomerButton.Location = new System.Drawing.Point(700, 368);
            this.editCustomerButton.Name = "editCustomerButton";
            this.editCustomerButton.Size = new System.Drawing.Size(145, 23);
            this.editCustomerButton.TabIndex = 5;
            this.editCustomerButton.Text = "Edit Customer";
            this.editCustomerButton.UseVisualStyleBackColor = true;
            this.editCustomerButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // deletePageTab
            // 
            this.deletePageTab.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.deletePageTab.Controls.Add(this.groupBox7);
            this.deletePageTab.Controls.Add(this.groupBox8);
            this.deletePageTab.Location = new System.Drawing.Point(4, 29);
            this.deletePageTab.Name = "deletePageTab";
            this.deletePageTab.Size = new System.Drawing.Size(982, 444);
            this.deletePageTab.TabIndex = 6;
            this.deletePageTab.Text = "Delete";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.deleteCustomerButton);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.deleteCustomerNameComboBox);
            this.groupBox7.Location = new System.Drawing.Point(7, 81);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(861, 62);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Customer";
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteCustomerButton.Location = new System.Drawing.Point(675, 27);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(178, 23);
            this.deleteCustomerButton.TabIndex = 2;
            this.deleteCustomerButton.Text = "Delete Customer";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += new System.EventHandler(this.button9_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 17);
            this.label23.TabIndex = 19;
            this.label23.Text = "Name:";
            // 
            // deleteCustomerNameComboBox
            // 
            this.deleteCustomerNameComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.deleteCustomerNameComboBox.DataSource = this.getcustomersBindingSource;
            this.deleteCustomerNameComboBox.DisplayMember = "cname";
            this.deleteCustomerNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deleteCustomerNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCustomerNameComboBox.FormattingEnabled = true;
            this.deleteCustomerNameComboBox.Location = new System.Drawing.Point(133, 19);
            this.deleteCustomerNameComboBox.Name = "deleteCustomerNameComboBox";
            this.deleteCustomerNameComboBox.Size = new System.Drawing.Size(187, 24);
            this.deleteCustomerNameComboBox.TabIndex = 1;
            this.deleteCustomerNameComboBox.ValueMember = "cust_code";
            this.deleteCustomerNameComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.deleteOrderButton);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.deleteOrderTransNumberComboBox);
            this.groupBox8.Location = new System.Drawing.Point(7, 13);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(861, 62);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Order";
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteOrderButton.Location = new System.Drawing.Point(675, 27);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(178, 23);
            this.deleteOrderButton.TabIndex = 2;
            this.deleteOrderButton.Text = "Delete Order";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 17);
            this.label20.TabIndex = 19;
            this.label20.Text = "Trans. no.";
            // 
            // deleteOrderTransNumberComboBox
            // 
            this.deleteOrderTransNumberComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.deleteOrderTransNumberComboBox.DataSource = this.getordersBindingSource;
            this.deleteOrderTransNumberComboBox.DisplayMember = "transaction_no";
            this.deleteOrderTransNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deleteOrderTransNumberComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteOrderTransNumberComboBox.FormattingEnabled = true;
            this.deleteOrderTransNumberComboBox.Location = new System.Drawing.Point(133, 19);
            this.deleteOrderTransNumberComboBox.Name = "deleteOrderTransNumberComboBox";
            this.deleteOrderTransNumberComboBox.Size = new System.Drawing.Size(187, 24);
            this.deleteOrderTransNumberComboBox.TabIndex = 1;
            this.deleteOrderTransNumberComboBox.ValueMember = "transaction_no";
            // 
            // getordersBindingSource
            // 
            this.getordersBindingSource.DataMember = "getorders";
            this.getordersBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // searchPageTab
            // 
            this.searchPageTab.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.searchPageTab.Controls.Add(this.dataGridView1);
            this.searchPageTab.Controls.Add(this.groupBox9);
            this.searchPageTab.Location = new System.Drawing.Point(4, 29);
            this.searchPageTab.Name = "searchPageTab";
            this.searchPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchPageTab.Size = new System.Drawing.Size(982, 444);
            this.searchPageTab.TabIndex = 4;
            this.searchPageTab.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(966, 338);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.comboBox8);
            this.groupBox9.Controls.Add(this.label141);
            this.groupBox9.Controls.Add(this.label142);
            this.groupBox9.Controls.Add(this.dateTimePicker6);
            this.groupBox9.Controls.Add(this.categoryLabel);
            this.groupBox9.Controls.Add(this.searchViewButton);
            this.groupBox9.Controls.Add(this.label94);
            this.groupBox9.Controls.Add(this.dateTimePicker4);
            this.groupBox9.Controls.Add(this.searchMethodsComboBox);
            this.groupBox9.Controls.Add(this.activeIngredientTradeNameLabel);
            this.groupBox9.Controls.Add(this.textBox12);
            this.groupBox9.Location = new System.Drawing.Point(7, 20);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(968, 61);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Search";
            // 
            // comboBox8
            // 
            this.comboBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox8.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "Digestion",
            "Flu",
            "Sedative",
            "Cough Relieve",
            "Alergie"});
            this.comboBox8.Location = new System.Drawing.Point(403, 25);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(168, 24);
            this.comboBox8.TabIndex = 29;
            // 
            // label141
            // 
            this.label141.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label141.AutoSize = true;
            this.label141.Location = new System.Drawing.Point(333, 29);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(49, 17);
            this.label141.TabIndex = 24;
            this.label141.Text = "From:";
            // 
            // label142
            // 
            this.label142.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label142.AutoSize = true;
            this.label142.Location = new System.Drawing.Point(572, 30);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(32, 17);
            this.label142.TabIndex = 26;
            this.label142.Text = "To:";
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker6.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker6.Location = new System.Drawing.Point(626, 26);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.ShowUpDown = true;
            this.dateTimePicker6.Size = new System.Drawing.Size(116, 23);
            this.dateTimePicker6.TabIndex = 25;
            // 
            // categoryLabel
            // 
            this.categoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(333, 29);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(61, 17);
            this.categoryLabel.TabIndex = 28;
            this.categoryLabel.Text = "label29";
            // 
            // searchViewButton
            // 
            this.searchViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchViewButton.Location = new System.Drawing.Point(863, 22);
            this.searchViewButton.Name = "searchViewButton";
            this.searchViewButton.Size = new System.Drawing.Size(75, 23);
            this.searchViewButton.TabIndex = 22;
            this.searchViewButton.Text = "View";
            this.searchViewButton.UseVisualStyleBackColor = true;
            this.searchViewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(1, 29);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(67, 17);
            this.label94.TabIndex = 19;
            this.label94.Text = "Choose:";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker4.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(390, 27);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(109, 23);
            this.dateTimePicker4.TabIndex = 23;
            // 
            // searchMethodsComboBox
            // 
            this.searchMethodsComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.searchMethodsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchMethodsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchMethodsComboBox.FormattingEnabled = true;
            this.searchMethodsComboBox.Items.AddRange(new object[] {
            "All Medicine ",
            "Selected Medicine by ingredient",
            "Selected Medicine by name",
            "Purcshases in period",
            "Sales in period",
            "Medicine out of stock",
            "All Customers",
            "Selected customer by tel."});
            this.searchMethodsComboBox.Location = new System.Drawing.Point(72, 26);
            this.searchMethodsComboBox.Name = "searchMethodsComboBox";
            this.searchMethodsComboBox.Size = new System.Drawing.Size(251, 24);
            this.searchMethodsComboBox.TabIndex = 18;
            // 
            // activeIngredientTradeNameLabel
            // 
            this.activeIngredientTradeNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activeIngredientTradeNameLabel.AutoSize = true;
            this.activeIngredientTradeNameLabel.Location = new System.Drawing.Point(572, 29);
            this.activeIngredientTradeNameLabel.Name = "activeIngredientTradeNameLabel";
            this.activeIngredientTradeNameLabel.Size = new System.Drawing.Size(100, 17);
            this.activeIngredientTradeNameLabel.TabIndex = 21;
            this.activeIngredientTradeNameLabel.Text = "Tradename :";
            // 
            // textBox12
            // 
            this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox12.Location = new System.Drawing.Point(674, 24);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(138, 23);
            this.textBox12.TabIndex = 27;
            // 
            // accountPageTab
            // 
            this.accountPageTab.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.accountPageTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.accountPageTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountPageTab.Controls.Add(this.groupBox2);
            this.accountPageTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.accountPageTab.Location = new System.Drawing.Point(4, 29);
            this.accountPageTab.Name = "accountPageTab";
            this.accountPageTab.Size = new System.Drawing.Size(982, 444);
            this.accountPageTab.TabIndex = 5;
            this.accountPageTab.Text = "Account";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(7, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Password";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.Location = new System.Drawing.Point(724, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Change";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Re-enter new password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter new password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Old password:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(210, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 2;
            this.textBox4.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(210, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 1;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // comboBox25
            // 
            this.comboBox25.FormattingEnabled = true;
            this.comboBox25.Location = new System.Drawing.Point(133, 19);
            this.comboBox25.Name = "comboBox25";
            this.comboBox25.Size = new System.Drawing.Size(121, 21);
            this.comboBox25.TabIndex = 18;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(12, 27);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(77, 16);
            this.label90.TabIndex = 19;
            // 
            // button26
            // 
            this.button26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button26.Location = new System.Drawing.Point(774, 27);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(75, 23);
            this.button26.TabIndex = 21;
            this.button26.Text = "Delete";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // getMedicinesBarCodeTableAdapter
            // 
            this.getMedicinesBarCodeTableAdapter.ClearBeforeFill = true;
            // 
            // getMedicinesByCategoryTableAdapter
            // 
            this.getMedicinesByCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // getcustomersTableAdapter
            // 
            this.getcustomersTableAdapter.ClearBeforeFill = true;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // getordersTableAdapter
            // 
            this.getordersTableAdapter.ClearBeforeFill = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 619);
            this.Controls.Add(this.ManagerTabs);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manager";
            this.Text = "Roshdy PASS";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Manager_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ManagerTabs.ResumeLayout(false);
            this.orderPageTab.ResumeLayout(false);
            this.orderPageTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDescriptionGridView)).EndInit();
            this.orderDataGroupBox.ResumeLayout(false);
            this.orderDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            this.addPageTab.ResumeLayout(false);
            this.addDataTabControl.ResumeLayout(false);
            this.addMedicineTabPage.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getMedicinesByCategoryBindingSource)).EndInit();
            this.addCustomerTabPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.addPurchaseTabPage.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.editPageTab.ResumeLayout(false);
            this.editDataTablControl.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getMedicinesBarCodeBindingSource)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getcustomersBindingSource)).EndInit();
            this.deletePageTab.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getordersBindingSource)).EndInit();
            this.searchPageTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.accountPageTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.TabControl ManagerTabs;
        private System.Windows.Forms.TabPage orderPageTab;
        private System.Windows.Forms.DataGridView orderDescriptionGridView;
        private System.Windows.Forms.GroupBox orderDataGroupBox;
        private System.Windows.Forms.Button orderNewOrderButton;
        private System.Windows.Forms.Button addNewOrderButton;
        private System.Windows.Forms.Label orderQuantityLabel;
        private System.Windows.Forms.Label orderChooseMedicineLabel;
        private System.Windows.Forms.TextBox orderQuantityTextField;
        private System.Windows.Forms.ComboBox orderChooseMedicineComboBox;
        private System.Windows.Forms.ComboBox comboBox25;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.TabPage addPageTab;
        private System.Windows.Forms.TabControl addDataTabControl;
        private System.Windows.Forms.TabPage addMedicineTabPage;
        private System.Windows.Forms.TabPage addCustomerTabPage;
        private System.Windows.Forms.TabPage editPageTab;
        private System.Windows.Forms.TabPage searchPageTab;
        private System.Windows.Forms.TabPage accountPageTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabControl editDataTablControl;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox addCustomerCommentsTextField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addCustomerTelephoneTextField;
        private System.Windows.Forms.TextBox addCustomerAddressTextField;
        private System.Windows.Forms.TextBox addCustomerNameTextField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addCustomerAddButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox editCustomerCommentsTextField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox editCustomerTelephoneTextField;
        private System.Windows.Forms.TextBox editCustomerAddressTextField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button editCustomerButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Button searchViewButton;
        private System.Windows.Forms.Label activeIngredientTradeNameLabel;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.ComboBox searchMethodsComboBox;
        private System.Windows.Forms.ComboBox editCustomerNameComboBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button addMedicineAddButton;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox addMedicineConcectrationTextField;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox addMedicinePriceOfSaleTextField;
        private System.Windows.Forms.TextBox addMedicineBarcodeTextField;
        private System.Windows.Forms.TextBox addMedicineActiveIngrdTextField;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox addMedicineTradeNameTextField;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox editMedicineBarcodeComboBox;
        private System.Windows.Forms.ComboBox editMedicineCategoryComboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button editMedicineButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox editMedicineConcentrationTextField;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox editMedicinePriceOfSaleTextField;
        private System.Windows.Forms.TextBox editMedicineActiveIngredientTextField;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox editMedicineTradeNameTextField;
        private System.Windows.Forms.TabPage deletePageTab;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox deleteCustomerNameComboBox;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox deleteOrderTransNumberComboBox;
        private System.Windows.Forms.TabPage addPurchaseTabPage;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DateTimePicker addPurchaseDateTimePicker;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button addPurchaseAddButton;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox comboBox8;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource getMedicinesBarCodeBindingSource;
        private PharmacyDataSetTableAdapters.getMedicinesBarCodeTableAdapter getMedicinesBarCodeTableAdapter;
        private System.Windows.Forms.BindingSource getMedicinesByCategoryBindingSource;
        private PharmacyDataSetTableAdapters.getMedicinesByCategoryTableAdapter getMedicinesByCategoryTableAdapter;
        private System.Windows.Forms.BindingSource getcustomersBindingSource;
        private PharmacyDataSetTableAdapters.getcustomersTableAdapter getcustomersTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private PharmacyDataSetTableAdapters.stockTableAdapter stockTableAdapter;
        private System.Windows.Forms.BindingSource getordersBindingSource;
        private PharmacyDataSetTableAdapters.getordersTableAdapter getordersTableAdapter;
        private System.Windows.Forms.TextBox addMedicineCategoryTextField;
        private System.Windows.Forms.ComboBox addMedicineCategoryComboBox;
        private System.Windows.Forms.CheckBox addMedicineNewCategoryCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicinePriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.Label totalPriceValueTextLabel;


    }
}