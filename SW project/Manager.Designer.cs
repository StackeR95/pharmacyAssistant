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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ManagerTabs = new System.Windows.Forms.TabControl();
            this.orderPageTab = new System.Windows.Forms.TabPage();
            this.orderTotalPriceValueTextLabel = new System.Windows.Forms.Label();
            this.orderTotalPriceLabel = new System.Windows.Forms.Label();
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
            this.addMedicineGroupBox = new System.Windows.Forms.GroupBox();
            this.addMedicineCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.getMedicinesByCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addMedicineNewCategoryCheckBox = new System.Windows.Forms.CheckBox();
            this.addMedicineCategoryTextField = new System.Windows.Forms.TextBox();
            this.addMedicineBarCodeLabel = new System.Windows.Forms.Label();
            this.addMedicineAddButton = new System.Windows.Forms.Button();
            this.addMedicineCategoryLabel = new System.Windows.Forms.Label();
            this.addMedicinePriceOfSaleLabel = new System.Windows.Forms.Label();
            this.addMedicineConcectrationTextField = new System.Windows.Forms.TextBox();
            this.addMedicineConcentrationLabel = new System.Windows.Forms.Label();
            this.addMedicinePriceOfSaleTextField = new System.Windows.Forms.TextBox();
            this.addMedicineBarcodeTextField = new System.Windows.Forms.TextBox();
            this.addMedicineActiveIngrdTextField = new System.Windows.Forms.TextBox();
            this.addMedicineTradeNameLabel = new System.Windows.Forms.Label();
            this.addMedicineActiveIngredientLabel = new System.Windows.Forms.Label();
            this.addMedicineTradeNameTextField = new System.Windows.Forms.TextBox();
            this.addCustomerTabPage = new System.Windows.Forms.TabPage();
            this.addCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.addCustomerCommentsTextField = new System.Windows.Forms.RichTextBox();
            this.addCustomerCommentsLabel = new System.Windows.Forms.Label();
            this.addCustomerTelephoneTextField = new System.Windows.Forms.TextBox();
            this.addCustomerAddressTextField = new System.Windows.Forms.TextBox();
            this.addCustomerNameTextField = new System.Windows.Forms.TextBox();
            this.addCustomerTelephoneNumbLabel = new System.Windows.Forms.Label();
            this.addCustomerAddressLabel = new System.Windows.Forms.Label();
            this.addCustomerNameLabel = new System.Windows.Forms.Label();
            this.addCustomerAddButton = new System.Windows.Forms.Button();
            this.addPurchaseTabPage = new System.Windows.Forms.TabPage();
            this.addPurchaseGroupBox = new System.Windows.Forms.GroupBox();
            this.addPurchaseAddButton = new System.Windows.Forms.Button();
            this.addPurchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addPurchaseDateLabel = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.editPageTab = new System.Windows.Forms.TabPage();
            this.editDataTablControl = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.editMedicineGroupBox = new System.Windows.Forms.GroupBox();
            this.editMedicineBarcodeComboBox = new System.Windows.Forms.ComboBox();
            this.getMedicinesBarCodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editMedicineCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.editMedicineBarCodeLabel = new System.Windows.Forms.Label();
            this.editMedicineButton = new System.Windows.Forms.Button();
            this.editMedicineCategoryLabel = new System.Windows.Forms.Label();
            this.editMedicinePriceOfSaleLabel = new System.Windows.Forms.Label();
            this.editMedicineConcentrationTextField = new System.Windows.Forms.TextBox();
            this.editMedicineConcentrationLabel = new System.Windows.Forms.Label();
            this.editMedicinePriceOfSaleTextField = new System.Windows.Forms.TextBox();
            this.editMedicineActiveIngredientTextField = new System.Windows.Forms.TextBox();
            this.editMedicineTradenameLabel = new System.Windows.Forms.Label();
            this.editMedicineActiveIngredientLabel = new System.Windows.Forms.Label();
            this.editMedicineTradeNameTextField = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.editCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.editCustomerNameComboBox = new System.Windows.Forms.ComboBox();
            this.getcustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editCustomerCommentsTextField = new System.Windows.Forms.RichTextBox();
            this.editCustomerCommentsLabel = new System.Windows.Forms.Label();
            this.editCustomerTelephoneTextField = new System.Windows.Forms.TextBox();
            this.editCustomerAddressTextField = new System.Windows.Forms.TextBox();
            this.editCustomerTelephoneNumbLabel = new System.Windows.Forms.Label();
            this.editCustomerAddressLabel = new System.Windows.Forms.Label();
            this.editCustomerNameLabel = new System.Windows.Forms.Label();
            this.editCustomerButton = new System.Windows.Forms.Button();
            this.deletePageTab = new System.Windows.Forms.TabPage();
            this.deleteCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.deleteCustomerNameLabel = new System.Windows.Forms.Label();
            this.deleteCustomerNameComboBox = new System.Windows.Forms.ComboBox();
            this.deleteOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.deleteOrderTransNumbLabel = new System.Windows.Forms.Label();
            this.deleteOrderTransNumberComboBox = new System.Windows.Forms.ComboBox();
            this.getordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchPageTab = new System.Windows.Forms.TabPage();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.searchCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.searchFromLabel = new System.Windows.Forms.Label();
            this.searchToLabel = new System.Windows.Forms.Label();
            this.searchToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchViewButton = new System.Windows.Forms.Button();
            this.searchChooseLabel = new System.Windows.Forms.Label();
            this.searchFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchMethodsComboBox = new System.Windows.Forms.ComboBox();
            this.searchActiveIngredientTradeNameLabel = new System.Windows.Forms.Label();
            this.searchMultipleOptionTextField = new System.Windows.Forms.TextBox();
            this.accountPageTab = new System.Windows.Forms.TabPage();
            this.accountGroupBox = new System.Windows.Forms.GroupBox();
            this.accountChangePasswordButton = new System.Windows.Forms.Button();
            this.accountRenterNewPassLabel = new System.Windows.Forms.Label();
            this.accountNewPassLabel = new System.Windows.Forms.Label();
            this.accountOldPassLabel = new System.Windows.Forms.Label();
            this.accountNewPasswordTextField = new System.Windows.Forms.TextBox();
            this.accountOldPasswordTextField = new System.Windows.Forms.TextBox();
            this.accountRenterNewPasswordTextField = new System.Windows.Forms.TextBox();
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
            this.addMedicineGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getMedicinesByCategoryBindingSource)).BeginInit();
            this.addCustomerTabPage.SuspendLayout();
            this.addCustomerGroupBox.SuspendLayout();
            this.addPurchaseTabPage.SuspendLayout();
            this.addPurchaseGroupBox.SuspendLayout();
            this.editPageTab.SuspendLayout();
            this.editDataTablControl.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.editMedicineGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getMedicinesBarCodeBindingSource)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.editCustomerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getcustomersBindingSource)).BeginInit();
            this.deletePageTab.SuspendLayout();
            this.deleteCustomerGroupBox.SuspendLayout();
            this.deleteOrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getordersBindingSource)).BeginInit();
            this.searchPageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            this.accountPageTab.SuspendLayout();
            this.accountGroupBox.SuspendLayout();
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
            this.orderPageTab.Controls.Add(this.orderTotalPriceValueTextLabel);
            this.orderPageTab.Controls.Add(this.orderTotalPriceLabel);
            this.orderPageTab.Controls.Add(this.orderDescriptionGridView);
            this.orderPageTab.Controls.Add(this.orderDataGroupBox);
            this.orderPageTab.Location = new System.Drawing.Point(4, 29);
            this.orderPageTab.Name = "orderPageTab";
            this.orderPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.orderPageTab.Size = new System.Drawing.Size(982, 444);
            this.orderPageTab.TabIndex = 1;
            this.orderPageTab.Text = "Order";
            // 
            // orderTotalPriceValueTextLabel
            // 
            this.orderTotalPriceValueTextLabel.AutoSize = true;
            this.orderTotalPriceValueTextLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderTotalPriceValueTextLabel.Location = new System.Drawing.Point(865, 414);
            this.orderTotalPriceValueTextLabel.Name = "orderTotalPriceValueTextLabel";
            this.orderTotalPriceValueTextLabel.Size = new System.Drawing.Size(17, 17);
            this.orderTotalPriceValueTextLabel.TabIndex = 3;
            this.orderTotalPriceValueTextLabel.Text = "0";
            this.orderTotalPriceValueTextLabel.Visible = false;
            // 
            // orderTotalPriceLabel
            // 
            this.orderTotalPriceLabel.AutoSize = true;
            this.orderTotalPriceLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderTotalPriceLabel.Location = new System.Drawing.Point(761, 414);
            this.orderTotalPriceLabel.Name = "orderTotalPriceLabel";
            this.orderTotalPriceLabel.Size = new System.Drawing.Size(97, 17);
            this.orderTotalPriceLabel.TabIndex = 2;
            this.orderTotalPriceLabel.Text = "Total Price :";
            // 
            // orderDescriptionGridView
            // 
            this.orderDescriptionGridView.AllowUserToAddRows = false;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.orderDescriptionGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.orderDescriptionGridView.RowTemplate.ReadOnly = true;
            this.orderDescriptionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            this.addMedicineTabPage.Controls.Add(this.addMedicineGroupBox);
            this.addMedicineTabPage.Location = new System.Drawing.Point(4, 29);
            this.addMedicineTabPage.Name = "addMedicineTabPage";
            this.addMedicineTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addMedicineTabPage.Size = new System.Drawing.Size(857, 403);
            this.addMedicineTabPage.TabIndex = 4;
            this.addMedicineTabPage.Text = "Medicine";
            this.addMedicineTabPage.UseVisualStyleBackColor = true;
            // 
            // addMedicineGroupBox
            // 
            this.addMedicineGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addMedicineGroupBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addMedicineGroupBox.Controls.Add(this.addMedicineCategoryComboBox);
            this.addMedicineGroupBox.Controls.Add(this.addMedicineNewCategoryCheckBox);
            this.addMedicineGroupBox.Controls.Add(this.addMedicineCategoryTextField);
            this.addMedicineGroupBox.Controls.Add(this.addMedicineBarCodeLabel);
            this.addMedicineGroupBox.Controls.Add(this.addMedicineAddButton);
            this.addMedicineGroupBox.Controls.Add(this.addMedicineCategoryLabel);
            this.addMedicineGroupBox.Controls.Add(this.addMedicinePriceOfSaleLabel);
            this.addMedicineGroupBox.Controls.Add(this.addMedicineConcectrationTextField);
            this.addMedicineGroupBox.Controls.Add(this.addMedicineConcentrationLabel);
            this.addMedicineGroupBox.Controls.Add(this.addMedicinePriceOfSaleTextField);
            this.addMedicineGroupBox.Controls.Add(this.addMedicineBarcodeTextField);
            this.addMedicineGroupBox.Controls.Add(this.addMedicineActiveIngrdTextField);
            this.addMedicineGroupBox.Controls.Add(this.addMedicineTradeNameLabel);
            this.addMedicineGroupBox.Controls.Add(this.addMedicineActiveIngredientLabel);
            this.addMedicineGroupBox.Controls.Add(this.addMedicineTradeNameTextField);
            this.addMedicineGroupBox.Location = new System.Drawing.Point(6, 6);
            this.addMedicineGroupBox.Name = "addMedicineGroupBox";
            this.addMedicineGroupBox.Size = new System.Drawing.Size(845, 391);
            this.addMedicineGroupBox.TabIndex = 36;
            this.addMedicineGroupBox.TabStop = false;
            this.addMedicineGroupBox.Text = "Add new medicine";
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
            // addMedicineBarCodeLabel
            // 
            this.addMedicineBarCodeLabel.AutoSize = true;
            this.addMedicineBarCodeLabel.Location = new System.Drawing.Point(6, 27);
            this.addMedicineBarCodeLabel.Name = "addMedicineBarCodeLabel";
            this.addMedicineBarCodeLabel.Size = new System.Drawing.Size(73, 17);
            this.addMedicineBarCodeLabel.TabIndex = 34;
            this.addMedicineBarCodeLabel.Text = "Barcode:";
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
            // addMedicineCategoryLabel
            // 
            this.addMedicineCategoryLabel.AutoSize = true;
            this.addMedicineCategoryLabel.Location = new System.Drawing.Point(6, 111);
            this.addMedicineCategoryLabel.Name = "addMedicineCategoryLabel";
            this.addMedicineCategoryLabel.Size = new System.Drawing.Size(78, 17);
            this.addMedicineCategoryLabel.TabIndex = 28;
            this.addMedicineCategoryLabel.Text = "Category:";
            // 
            // addMedicinePriceOfSaleLabel
            // 
            this.addMedicinePriceOfSaleLabel.AutoSize = true;
            this.addMedicinePriceOfSaleLabel.Location = new System.Drawing.Point(6, 167);
            this.addMedicinePriceOfSaleLabel.Name = "addMedicinePriceOfSaleLabel";
            this.addMedicinePriceOfSaleLabel.Size = new System.Drawing.Size(106, 17);
            this.addMedicinePriceOfSaleLabel.TabIndex = 32;
            this.addMedicinePriceOfSaleLabel.Text = "Price of Sale:";
            // 
            // addMedicineConcectrationTextField
            // 
            this.addMedicineConcectrationTextField.Location = new System.Drawing.Point(150, 136);
            this.addMedicineConcectrationTextField.Name = "addMedicineConcectrationTextField";
            this.addMedicineConcectrationTextField.Size = new System.Drawing.Size(235, 23);
            this.addMedicineConcectrationTextField.TabIndex = 4;
            // 
            // addMedicineConcentrationLabel
            // 
            this.addMedicineConcentrationLabel.AutoSize = true;
            this.addMedicineConcentrationLabel.Location = new System.Drawing.Point(6, 139);
            this.addMedicineConcentrationLabel.Name = "addMedicineConcentrationLabel";
            this.addMedicineConcentrationLabel.Size = new System.Drawing.Size(114, 17);
            this.addMedicineConcentrationLabel.TabIndex = 29;
            this.addMedicineConcentrationLabel.Text = "Concentration:";
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
            // addMedicineTradeNameLabel
            // 
            this.addMedicineTradeNameLabel.AutoSize = true;
            this.addMedicineTradeNameLabel.Location = new System.Drawing.Point(6, 55);
            this.addMedicineTradeNameLabel.Name = "addMedicineTradeNameLabel";
            this.addMedicineTradeNameLabel.Size = new System.Drawing.Size(95, 17);
            this.addMedicineTradeNameLabel.TabIndex = 33;
            this.addMedicineTradeNameLabel.Text = "Tradename:";
            // 
            // addMedicineActiveIngredientLabel
            // 
            this.addMedicineActiveIngredientLabel.AutoSize = true;
            this.addMedicineActiveIngredientLabel.Location = new System.Drawing.Point(6, 83);
            this.addMedicineActiveIngredientLabel.Name = "addMedicineActiveIngredientLabel";
            this.addMedicineActiveIngredientLabel.Size = new System.Drawing.Size(135, 17);
            this.addMedicineActiveIngredientLabel.TabIndex = 31;
            this.addMedicineActiveIngredientLabel.Text = "Active ingredient:";
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
            this.addCustomerTabPage.Controls.Add(this.addCustomerGroupBox);
            this.addCustomerTabPage.Location = new System.Drawing.Point(4, 29);
            this.addCustomerTabPage.Name = "addCustomerTabPage";
            this.addCustomerTabPage.Size = new System.Drawing.Size(857, 403);
            this.addCustomerTabPage.TabIndex = 5;
            this.addCustomerTabPage.Text = "Customer";
            this.addCustomerTabPage.UseVisualStyleBackColor = true;
            // 
            // addCustomerGroupBox
            // 
            this.addCustomerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addCustomerGroupBox.Controls.Add(this.addCustomerCommentsTextField);
            this.addCustomerGroupBox.Controls.Add(this.addCustomerCommentsLabel);
            this.addCustomerGroupBox.Controls.Add(this.addCustomerTelephoneTextField);
            this.addCustomerGroupBox.Controls.Add(this.addCustomerAddressTextField);
            this.addCustomerGroupBox.Controls.Add(this.addCustomerNameTextField);
            this.addCustomerGroupBox.Controls.Add(this.addCustomerTelephoneNumbLabel);
            this.addCustomerGroupBox.Controls.Add(this.addCustomerAddressLabel);
            this.addCustomerGroupBox.Controls.Add(this.addCustomerNameLabel);
            this.addCustomerGroupBox.Controls.Add(this.addCustomerAddButton);
            this.addCustomerGroupBox.Location = new System.Drawing.Point(3, 3);
            this.addCustomerGroupBox.Name = "addCustomerGroupBox";
            this.addCustomerGroupBox.Size = new System.Drawing.Size(851, 397);
            this.addCustomerGroupBox.TabIndex = 0;
            this.addCustomerGroupBox.TabStop = false;
            this.addCustomerGroupBox.Text = "Add new customer";
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
            // addCustomerCommentsLabel
            // 
            this.addCustomerCommentsLabel.AutoSize = true;
            this.addCustomerCommentsLabel.Location = new System.Drawing.Point(6, 113);
            this.addCustomerCommentsLabel.Name = "addCustomerCommentsLabel";
            this.addCustomerCommentsLabel.Size = new System.Drawing.Size(87, 17);
            this.addCustomerCommentsLabel.TabIndex = 12;
            this.addCustomerCommentsLabel.Text = "Comments:";
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
            // addCustomerTelephoneNumbLabel
            // 
            this.addCustomerTelephoneNumbLabel.AutoSize = true;
            this.addCustomerTelephoneNumbLabel.Location = new System.Drawing.Point(6, 85);
            this.addCustomerTelephoneNumbLabel.Name = "addCustomerTelephoneNumbLabel";
            this.addCustomerTelephoneNumbLabel.Size = new System.Drawing.Size(118, 17);
            this.addCustomerTelephoneNumbLabel.TabIndex = 10;
            this.addCustomerTelephoneNumbLabel.Text = "Telephone no.:";
            // 
            // addCustomerAddressLabel
            // 
            this.addCustomerAddressLabel.AutoSize = true;
            this.addCustomerAddressLabel.Location = new System.Drawing.Point(6, 59);
            this.addCustomerAddressLabel.Name = "addCustomerAddressLabel";
            this.addCustomerAddressLabel.Size = new System.Drawing.Size(72, 17);
            this.addCustomerAddressLabel.TabIndex = 8;
            this.addCustomerAddressLabel.Text = "Address:";
            // 
            // addCustomerNameLabel
            // 
            this.addCustomerNameLabel.AutoSize = true;
            this.addCustomerNameLabel.Location = new System.Drawing.Point(6, 33);
            this.addCustomerNameLabel.Name = "addCustomerNameLabel";
            this.addCustomerNameLabel.Size = new System.Drawing.Size(54, 17);
            this.addCustomerNameLabel.TabIndex = 6;
            this.addCustomerNameLabel.Text = "Name:";
            // 
            // addCustomerAddButton
            // 
            this.addCustomerAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addCustomerAddButton.Location = new System.Drawing.Point(700, 368);
            this.addCustomerAddButton.Name = "addCustomerAddButton";
            this.addCustomerAddButton.Size = new System.Drawing.Size(145, 29);
            this.addCustomerAddButton.TabIndex = 5;
            this.addCustomerAddButton.Text = "Add Customer";
            this.addCustomerAddButton.UseVisualStyleBackColor = true;
            this.addCustomerAddButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // addPurchaseTabPage
            // 
            this.addPurchaseTabPage.BackColor = System.Drawing.Color.Transparent;
            this.addPurchaseTabPage.Controls.Add(this.addPurchaseGroupBox);
            this.addPurchaseTabPage.Controls.Add(this.button11);
            this.addPurchaseTabPage.Location = new System.Drawing.Point(4, 29);
            this.addPurchaseTabPage.Name = "addPurchaseTabPage";
            this.addPurchaseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addPurchaseTabPage.Size = new System.Drawing.Size(857, 403);
            this.addPurchaseTabPage.TabIndex = 6;
            this.addPurchaseTabPage.Text = "Purchase";
            // 
            // addPurchaseGroupBox
            // 
            this.addPurchaseGroupBox.Controls.Add(this.addPurchaseAddButton);
            this.addPurchaseGroupBox.Controls.Add(this.addPurchaseDateTimePicker);
            this.addPurchaseGroupBox.Controls.Add(this.addPurchaseDateLabel);
            this.addPurchaseGroupBox.Location = new System.Drawing.Point(6, 6);
            this.addPurchaseGroupBox.Name = "addPurchaseGroupBox";
            this.addPurchaseGroupBox.Size = new System.Drawing.Size(841, 391);
            this.addPurchaseGroupBox.TabIndex = 16;
            this.addPurchaseGroupBox.TabStop = false;
            this.addPurchaseGroupBox.Text = "Purchase info";
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
            this.addPurchaseAddButton.Click += new System.EventHandler(this.addPurchaseAddButton_Click);
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
            // addPurchaseDateLabel
            // 
            this.addPurchaseDateLabel.AutoSize = true;
            this.addPurchaseDateLabel.Location = new System.Drawing.Point(6, 26);
            this.addPurchaseDateLabel.Name = "addPurchaseDateLabel";
            this.addPurchaseDateLabel.Size = new System.Drawing.Size(47, 17);
            this.addPurchaseDateLabel.TabIndex = 15;
            this.addPurchaseDateLabel.Text = "Date:";
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
            this.tabPage7.Controls.Add(this.editMedicineGroupBox);
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(857, 403);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "Medicine";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // editMedicineGroupBox
            // 
            this.editMedicineGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editMedicineGroupBox.Controls.Add(this.editMedicineBarcodeComboBox);
            this.editMedicineGroupBox.Controls.Add(this.editMedicineCategoryComboBox);
            this.editMedicineGroupBox.Controls.Add(this.editMedicineBarCodeLabel);
            this.editMedicineGroupBox.Controls.Add(this.editMedicineButton);
            this.editMedicineGroupBox.Controls.Add(this.editMedicineCategoryLabel);
            this.editMedicineGroupBox.Controls.Add(this.editMedicinePriceOfSaleLabel);
            this.editMedicineGroupBox.Controls.Add(this.editMedicineConcentrationTextField);
            this.editMedicineGroupBox.Controls.Add(this.editMedicineConcentrationLabel);
            this.editMedicineGroupBox.Controls.Add(this.editMedicinePriceOfSaleTextField);
            this.editMedicineGroupBox.Controls.Add(this.editMedicineActiveIngredientTextField);
            this.editMedicineGroupBox.Controls.Add(this.editMedicineTradenameLabel);
            this.editMedicineGroupBox.Controls.Add(this.editMedicineActiveIngredientLabel);
            this.editMedicineGroupBox.Controls.Add(this.editMedicineTradeNameTextField);
            this.editMedicineGroupBox.Location = new System.Drawing.Point(6, 6);
            this.editMedicineGroupBox.Name = "editMedicineGroupBox";
            this.editMedicineGroupBox.Size = new System.Drawing.Size(851, 397);
            this.editMedicineGroupBox.TabIndex = 37;
            this.editMedicineGroupBox.TabStop = false;
            this.editMedicineGroupBox.Text = "Edit medicine";
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
            // editMedicineBarCodeLabel
            // 
            this.editMedicineBarCodeLabel.AutoSize = true;
            this.editMedicineBarCodeLabel.Location = new System.Drawing.Point(6, 27);
            this.editMedicineBarCodeLabel.Name = "editMedicineBarCodeLabel";
            this.editMedicineBarCodeLabel.Size = new System.Drawing.Size(73, 17);
            this.editMedicineBarCodeLabel.TabIndex = 34;
            this.editMedicineBarCodeLabel.Text = "Barcode:";
            // 
            // editMedicineButton
            // 
            this.editMedicineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editMedicineButton.Location = new System.Drawing.Point(696, 363);
            this.editMedicineButton.Name = "editMedicineButton";
            this.editMedicineButton.Size = new System.Drawing.Size(149, 28);
            this.editMedicineButton.TabIndex = 7;
            this.editMedicineButton.Text = "Edit Medicine";
            this.editMedicineButton.UseVisualStyleBackColor = true;
            this.editMedicineButton.Click += new System.EventHandler(this.editMedicineButton_Click);
            // 
            // editMedicineCategoryLabel
            // 
            this.editMedicineCategoryLabel.AutoSize = true;
            this.editMedicineCategoryLabel.Location = new System.Drawing.Point(6, 111);
            this.editMedicineCategoryLabel.Name = "editMedicineCategoryLabel";
            this.editMedicineCategoryLabel.Size = new System.Drawing.Size(78, 17);
            this.editMedicineCategoryLabel.TabIndex = 28;
            this.editMedicineCategoryLabel.Text = "Category:";
            // 
            // editMedicinePriceOfSaleLabel
            // 
            this.editMedicinePriceOfSaleLabel.AutoSize = true;
            this.editMedicinePriceOfSaleLabel.Location = new System.Drawing.Point(6, 167);
            this.editMedicinePriceOfSaleLabel.Name = "editMedicinePriceOfSaleLabel";
            this.editMedicinePriceOfSaleLabel.Size = new System.Drawing.Size(106, 17);
            this.editMedicinePriceOfSaleLabel.TabIndex = 32;
            this.editMedicinePriceOfSaleLabel.Text = "Price of Sale:";
            // 
            // editMedicineConcentrationTextField
            // 
            this.editMedicineConcentrationTextField.Location = new System.Drawing.Point(141, 136);
            this.editMedicineConcentrationTextField.Name = "editMedicineConcentrationTextField";
            this.editMedicineConcentrationTextField.Size = new System.Drawing.Size(235, 23);
            this.editMedicineConcentrationTextField.TabIndex = 5;
            // 
            // editMedicineConcentrationLabel
            // 
            this.editMedicineConcentrationLabel.AutoSize = true;
            this.editMedicineConcentrationLabel.Location = new System.Drawing.Point(6, 139);
            this.editMedicineConcentrationLabel.Name = "editMedicineConcentrationLabel";
            this.editMedicineConcentrationLabel.Size = new System.Drawing.Size(114, 17);
            this.editMedicineConcentrationLabel.TabIndex = 29;
            this.editMedicineConcentrationLabel.Text = "Concentration:";
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
            // editMedicineTradenameLabel
            // 
            this.editMedicineTradenameLabel.AutoSize = true;
            this.editMedicineTradenameLabel.Location = new System.Drawing.Point(6, 55);
            this.editMedicineTradenameLabel.Name = "editMedicineTradenameLabel";
            this.editMedicineTradenameLabel.Size = new System.Drawing.Size(95, 17);
            this.editMedicineTradenameLabel.TabIndex = 33;
            this.editMedicineTradenameLabel.Text = "Tradename:";
            // 
            // editMedicineActiveIngredientLabel
            // 
            this.editMedicineActiveIngredientLabel.AutoSize = true;
            this.editMedicineActiveIngredientLabel.Location = new System.Drawing.Point(6, 83);
            this.editMedicineActiveIngredientLabel.Name = "editMedicineActiveIngredientLabel";
            this.editMedicineActiveIngredientLabel.Size = new System.Drawing.Size(135, 17);
            this.editMedicineActiveIngredientLabel.TabIndex = 31;
            this.editMedicineActiveIngredientLabel.Text = "Active ingredient:";
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
            this.tabPage9.Controls.Add(this.editCustomerGroupBox);
            this.tabPage9.Location = new System.Drawing.Point(4, 29);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(857, 403);
            this.tabPage9.TabIndex = 5;
            this.tabPage9.Text = "Customer";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // editCustomerGroupBox
            // 
            this.editCustomerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editCustomerGroupBox.Controls.Add(this.editCustomerNameComboBox);
            this.editCustomerGroupBox.Controls.Add(this.editCustomerCommentsTextField);
            this.editCustomerGroupBox.Controls.Add(this.editCustomerCommentsLabel);
            this.editCustomerGroupBox.Controls.Add(this.editCustomerTelephoneTextField);
            this.editCustomerGroupBox.Controls.Add(this.editCustomerAddressTextField);
            this.editCustomerGroupBox.Controls.Add(this.editCustomerTelephoneNumbLabel);
            this.editCustomerGroupBox.Controls.Add(this.editCustomerAddressLabel);
            this.editCustomerGroupBox.Controls.Add(this.editCustomerNameLabel);
            this.editCustomerGroupBox.Controls.Add(this.editCustomerButton);
            this.editCustomerGroupBox.Location = new System.Drawing.Point(3, 3);
            this.editCustomerGroupBox.Name = "editCustomerGroupBox";
            this.editCustomerGroupBox.Size = new System.Drawing.Size(851, 397);
            this.editCustomerGroupBox.TabIndex = 1;
            this.editCustomerGroupBox.TabStop = false;
            this.editCustomerGroupBox.Text = "Edit customer";
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
            // editCustomerCommentsLabel
            // 
            this.editCustomerCommentsLabel.AutoSize = true;
            this.editCustomerCommentsLabel.Location = new System.Drawing.Point(6, 113);
            this.editCustomerCommentsLabel.Name = "editCustomerCommentsLabel";
            this.editCustomerCommentsLabel.Size = new System.Drawing.Size(87, 17);
            this.editCustomerCommentsLabel.TabIndex = 12;
            this.editCustomerCommentsLabel.Text = "Comments:";
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
            // editCustomerTelephoneNumbLabel
            // 
            this.editCustomerTelephoneNumbLabel.AutoSize = true;
            this.editCustomerTelephoneNumbLabel.Location = new System.Drawing.Point(6, 85);
            this.editCustomerTelephoneNumbLabel.Name = "editCustomerTelephoneNumbLabel";
            this.editCustomerTelephoneNumbLabel.Size = new System.Drawing.Size(118, 17);
            this.editCustomerTelephoneNumbLabel.TabIndex = 10;
            this.editCustomerTelephoneNumbLabel.Text = "Telephone no.:";
            // 
            // editCustomerAddressLabel
            // 
            this.editCustomerAddressLabel.AutoSize = true;
            this.editCustomerAddressLabel.Location = new System.Drawing.Point(6, 55);
            this.editCustomerAddressLabel.Name = "editCustomerAddressLabel";
            this.editCustomerAddressLabel.Size = new System.Drawing.Size(72, 17);
            this.editCustomerAddressLabel.TabIndex = 8;
            this.editCustomerAddressLabel.Text = "Address:";
            // 
            // editCustomerNameLabel
            // 
            this.editCustomerNameLabel.AutoSize = true;
            this.editCustomerNameLabel.Location = new System.Drawing.Point(6, 25);
            this.editCustomerNameLabel.Name = "editCustomerNameLabel";
            this.editCustomerNameLabel.Size = new System.Drawing.Size(54, 17);
            this.editCustomerNameLabel.TabIndex = 6;
            this.editCustomerNameLabel.Text = "Name:";
            // 
            // editCustomerButton
            // 
            this.editCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editCustomerButton.Location = new System.Drawing.Point(700, 368);
            this.editCustomerButton.Name = "editCustomerButton";
            this.editCustomerButton.Size = new System.Drawing.Size(145, 29);
            this.editCustomerButton.TabIndex = 5;
            this.editCustomerButton.Text = "Edit Customer";
            this.editCustomerButton.UseVisualStyleBackColor = true;
            this.editCustomerButton.Click += new System.EventHandler(this.editCustomerButton_Click);
            // 
            // deletePageTab
            // 
            this.deletePageTab.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.deletePageTab.Controls.Add(this.deleteCustomerGroupBox);
            this.deletePageTab.Controls.Add(this.deleteOrderGroupBox);
            this.deletePageTab.Location = new System.Drawing.Point(4, 29);
            this.deletePageTab.Name = "deletePageTab";
            this.deletePageTab.Size = new System.Drawing.Size(982, 444);
            this.deletePageTab.TabIndex = 6;
            this.deletePageTab.Text = "Delete";
            // 
            // deleteCustomerGroupBox
            // 
            this.deleteCustomerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteCustomerGroupBox.Controls.Add(this.deleteCustomerButton);
            this.deleteCustomerGroupBox.Controls.Add(this.deleteCustomerNameLabel);
            this.deleteCustomerGroupBox.Controls.Add(this.deleteCustomerNameComboBox);
            this.deleteCustomerGroupBox.Location = new System.Drawing.Point(7, 81);
            this.deleteCustomerGroupBox.Name = "deleteCustomerGroupBox";
            this.deleteCustomerGroupBox.Size = new System.Drawing.Size(861, 62);
            this.deleteCustomerGroupBox.TabIndex = 13;
            this.deleteCustomerGroupBox.TabStop = false;
            this.deleteCustomerGroupBox.Text = "Customer";
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteCustomerButton.Location = new System.Drawing.Point(675, 27);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(178, 29);
            this.deleteCustomerButton.TabIndex = 2;
            this.deleteCustomerButton.Text = "Delete Customer";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // deleteCustomerNameLabel
            // 
            this.deleteCustomerNameLabel.AutoSize = true;
            this.deleteCustomerNameLabel.Location = new System.Drawing.Point(12, 27);
            this.deleteCustomerNameLabel.Name = "deleteCustomerNameLabel";
            this.deleteCustomerNameLabel.Size = new System.Drawing.Size(54, 17);
            this.deleteCustomerNameLabel.TabIndex = 19;
            this.deleteCustomerNameLabel.Text = "Name:";
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
            // deleteOrderGroupBox
            // 
            this.deleteOrderGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteOrderGroupBox.Controls.Add(this.deleteOrderButton);
            this.deleteOrderGroupBox.Controls.Add(this.deleteOrderTransNumbLabel);
            this.deleteOrderGroupBox.Controls.Add(this.deleteOrderTransNumberComboBox);
            this.deleteOrderGroupBox.Location = new System.Drawing.Point(7, 13);
            this.deleteOrderGroupBox.Name = "deleteOrderGroupBox";
            this.deleteOrderGroupBox.Size = new System.Drawing.Size(861, 62);
            this.deleteOrderGroupBox.TabIndex = 12;
            this.deleteOrderGroupBox.TabStop = false;
            this.deleteOrderGroupBox.Text = "Order";
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteOrderButton.Location = new System.Drawing.Point(675, 27);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(178, 29);
            this.deleteOrderButton.TabIndex = 2;
            this.deleteOrderButton.Text = "Delete Order";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // deleteOrderTransNumbLabel
            // 
            this.deleteOrderTransNumbLabel.AutoSize = true;
            this.deleteOrderTransNumbLabel.Location = new System.Drawing.Point(12, 27);
            this.deleteOrderTransNumbLabel.Name = "deleteOrderTransNumbLabel";
            this.deleteOrderTransNumbLabel.Size = new System.Drawing.Size(83, 17);
            this.deleteOrderTransNumbLabel.TabIndex = 19;
            this.deleteOrderTransNumbLabel.Text = "Trans. no.";
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
            this.searchPageTab.Controls.Add(this.searchDataGridView);
            this.searchPageTab.Controls.Add(this.searchGroupBox);
            this.searchPageTab.Location = new System.Drawing.Point(4, 29);
            this.searchPageTab.Name = "searchPageTab";
            this.searchPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchPageTab.Size = new System.Drawing.Size(982, 444);
            this.searchPageTab.TabIndex = 4;
            this.searchPageTab.Text = "Search";
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.AllowUserToAddRows = false;
            this.searchDataGridView.AllowUserToDeleteRows = false;
            this.searchDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(11, 87);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.ReadOnly = true;
            this.searchDataGridView.Size = new System.Drawing.Size(966, 338);
            this.searchDataGridView.TabIndex = 4;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchGroupBox.Controls.Add(this.categoryLabel);
            this.searchGroupBox.Controls.Add(this.searchCategoryComboBox);
            this.searchGroupBox.Controls.Add(this.searchFromLabel);
            this.searchGroupBox.Controls.Add(this.searchToLabel);
            this.searchGroupBox.Controls.Add(this.searchToDateTimePicker);
            this.searchGroupBox.Controls.Add(this.searchViewButton);
            this.searchGroupBox.Controls.Add(this.searchChooseLabel);
            this.searchGroupBox.Controls.Add(this.searchFromDateTimePicker);
            this.searchGroupBox.Controls.Add(this.searchMethodsComboBox);
            this.searchGroupBox.Controls.Add(this.searchActiveIngredientTradeNameLabel);
            this.searchGroupBox.Controls.Add(this.searchMultipleOptionTextField);
            this.searchGroupBox.Location = new System.Drawing.Point(7, 20);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(968, 61);
            this.searchGroupBox.TabIndex = 3;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(329, 29);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(73, 17);
            this.categoryLabel.TabIndex = 30;
            this.categoryLabel.Text = "Category";
            // 
            // searchCategoryComboBox
            // 
            this.searchCategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCategoryComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.searchCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCategoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCategoryComboBox.FormattingEnabled = true;
            this.searchCategoryComboBox.Items.AddRange(new object[] {
            "Digestion",
            "Flu",
            "Sedative",
            "Cough Relieve",
            "Alergie"});
            this.searchCategoryComboBox.Location = new System.Drawing.Point(408, 25);
            this.searchCategoryComboBox.Name = "searchCategoryComboBox";
            this.searchCategoryComboBox.Size = new System.Drawing.Size(168, 24);
            this.searchCategoryComboBox.TabIndex = 29;
            // 
            // searchFromLabel
            // 
            this.searchFromLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchFromLabel.AutoSize = true;
            this.searchFromLabel.Location = new System.Drawing.Point(340, 28);
            this.searchFromLabel.Name = "searchFromLabel";
            this.searchFromLabel.Size = new System.Drawing.Size(49, 17);
            this.searchFromLabel.TabIndex = 24;
            this.searchFromLabel.Text = "From:";
            // 
            // searchToLabel
            // 
            this.searchToLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchToLabel.AutoSize = true;
            this.searchToLabel.Location = new System.Drawing.Point(650, 28);
            this.searchToLabel.Name = "searchToLabel";
            this.searchToLabel.Size = new System.Drawing.Size(32, 17);
            this.searchToLabel.TabIndex = 26;
            this.searchToLabel.Text = "To:";
            // 
            // searchToDateTimePicker
            // 
            this.searchToDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchToDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.searchToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchToDateTimePicker.Location = new System.Drawing.Point(694, 25);
            this.searchToDateTimePicker.Name = "searchToDateTimePicker";
            this.searchToDateTimePicker.ShowUpDown = true;
            this.searchToDateTimePicker.Size = new System.Drawing.Size(116, 23);
            this.searchToDateTimePicker.TabIndex = 25;
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
            // searchChooseLabel
            // 
            this.searchChooseLabel.AutoSize = true;
            this.searchChooseLabel.Location = new System.Drawing.Point(1, 29);
            this.searchChooseLabel.Name = "searchChooseLabel";
            this.searchChooseLabel.Size = new System.Drawing.Size(67, 17);
            this.searchChooseLabel.TabIndex = 19;
            this.searchChooseLabel.Text = "Choose:";
            // 
            // searchFromDateTimePicker
            // 
            this.searchFromDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchFromDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.searchFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchFromDateTimePicker.Location = new System.Drawing.Point(438, 26);
            this.searchFromDateTimePicker.Name = "searchFromDateTimePicker";
            this.searchFromDateTimePicker.ShowUpDown = true;
            this.searchFromDateTimePicker.Size = new System.Drawing.Size(109, 23);
            this.searchFromDateTimePicker.TabIndex = 23;
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
            // searchActiveIngredientTradeNameLabel
            // 
            this.searchActiveIngredientTradeNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchActiveIngredientTradeNameLabel.AutoSize = true;
            this.searchActiveIngredientTradeNameLabel.Location = new System.Drawing.Point(582, 29);
            this.searchActiveIngredientTradeNameLabel.Name = "searchActiveIngredientTradeNameLabel";
            this.searchActiveIngredientTradeNameLabel.Size = new System.Drawing.Size(100, 17);
            this.searchActiveIngredientTradeNameLabel.TabIndex = 21;
            this.searchActiveIngredientTradeNameLabel.Text = "Tradename :";
            // 
            // searchMultipleOptionTextField
            // 
            this.searchMultipleOptionTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchMultipleOptionTextField.Location = new System.Drawing.Point(694, 25);
            this.searchMultipleOptionTextField.Name = "searchMultipleOptionTextField";
            this.searchMultipleOptionTextField.Size = new System.Drawing.Size(138, 23);
            this.searchMultipleOptionTextField.TabIndex = 27;
            // 
            // accountPageTab
            // 
            this.accountPageTab.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.accountPageTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.accountPageTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountPageTab.Controls.Add(this.accountGroupBox);
            this.accountPageTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.accountPageTab.Location = new System.Drawing.Point(4, 29);
            this.accountPageTab.Name = "accountPageTab";
            this.accountPageTab.Size = new System.Drawing.Size(982, 444);
            this.accountPageTab.TabIndex = 5;
            this.accountPageTab.Text = "Account";
            // 
            // accountGroupBox
            // 
            this.accountGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountGroupBox.Controls.Add(this.accountChangePasswordButton);
            this.accountGroupBox.Controls.Add(this.accountRenterNewPassLabel);
            this.accountGroupBox.Controls.Add(this.accountNewPassLabel);
            this.accountGroupBox.Controls.Add(this.accountOldPassLabel);
            this.accountGroupBox.Controls.Add(this.accountNewPasswordTextField);
            this.accountGroupBox.Controls.Add(this.accountOldPasswordTextField);
            this.accountGroupBox.Controls.Add(this.accountRenterNewPasswordTextField);
            this.accountGroupBox.Location = new System.Drawing.Point(7, 13);
            this.accountGroupBox.Name = "accountGroupBox";
            this.accountGroupBox.Size = new System.Drawing.Size(855, 130);
            this.accountGroupBox.TabIndex = 1;
            this.accountGroupBox.TabStop = false;
            this.accountGroupBox.Text = "Change Password";
            // 
            // accountChangePasswordButton
            // 
            this.accountChangePasswordButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.accountChangePasswordButton.Location = new System.Drawing.Point(694, 92);
            this.accountChangePasswordButton.Name = "accountChangePasswordButton";
            this.accountChangePasswordButton.Size = new System.Drawing.Size(155, 32);
            this.accountChangePasswordButton.TabIndex = 4;
            this.accountChangePasswordButton.Text = "Change Password";
            this.accountChangePasswordButton.UseVisualStyleBackColor = true;
            this.accountChangePasswordButton.Click += new System.EventHandler(this.accountChangePasswordButton_Click);
            // 
            // accountRenterNewPassLabel
            // 
            this.accountRenterNewPassLabel.AutoSize = true;
            this.accountRenterNewPassLabel.Location = new System.Drawing.Point(6, 92);
            this.accountRenterNewPassLabel.Name = "accountRenterNewPassLabel";
            this.accountRenterNewPassLabel.Size = new System.Drawing.Size(183, 17);
            this.accountRenterNewPassLabel.TabIndex = 5;
            this.accountRenterNewPassLabel.Text = "Re-enter new password:";
            // 
            // accountNewPassLabel
            // 
            this.accountNewPassLabel.AutoSize = true;
            this.accountNewPassLabel.Location = new System.Drawing.Point(6, 56);
            this.accountNewPassLabel.Name = "accountNewPassLabel";
            this.accountNewPassLabel.Size = new System.Drawing.Size(158, 17);
            this.accountNewPassLabel.TabIndex = 4;
            this.accountNewPassLabel.Text = "Enter new password:";
            // 
            // accountOldPassLabel
            // 
            this.accountOldPassLabel.AutoSize = true;
            this.accountOldPassLabel.Location = new System.Drawing.Point(6, 28);
            this.accountOldPassLabel.Name = "accountOldPassLabel";
            this.accountOldPassLabel.Size = new System.Drawing.Size(111, 17);
            this.accountOldPassLabel.TabIndex = 3;
            this.accountOldPassLabel.Text = "Old password:";
            // 
            // accountNewPasswordTextField
            // 
            this.accountNewPasswordTextField.Location = new System.Drawing.Point(210, 50);
            this.accountNewPasswordTextField.Name = "accountNewPasswordTextField";
            this.accountNewPasswordTextField.Size = new System.Drawing.Size(119, 23);
            this.accountNewPasswordTextField.TabIndex = 2;
            this.accountNewPasswordTextField.UseSystemPasswordChar = true;
            // 
            // accountOldPasswordTextField
            // 
            this.accountOldPasswordTextField.Location = new System.Drawing.Point(210, 19);
            this.accountOldPasswordTextField.Name = "accountOldPasswordTextField";
            this.accountOldPasswordTextField.Size = new System.Drawing.Size(119, 23);
            this.accountOldPasswordTextField.TabIndex = 1;
            this.accountOldPasswordTextField.UseSystemPasswordChar = true;
            // 
            // accountRenterNewPasswordTextField
            // 
            this.accountRenterNewPasswordTextField.Location = new System.Drawing.Point(210, 89);
            this.accountRenterNewPasswordTextField.Name = "accountRenterNewPasswordTextField";
            this.accountRenterNewPasswordTextField.Size = new System.Drawing.Size(119, 23);
            this.accountRenterNewPasswordTextField.TabIndex = 3;
            this.accountRenterNewPasswordTextField.UseSystemPasswordChar = true;
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
            this.addMedicineGroupBox.ResumeLayout(false);
            this.addMedicineGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getMedicinesByCategoryBindingSource)).EndInit();
            this.addCustomerTabPage.ResumeLayout(false);
            this.addCustomerGroupBox.ResumeLayout(false);
            this.addCustomerGroupBox.PerformLayout();
            this.addPurchaseTabPage.ResumeLayout(false);
            this.addPurchaseGroupBox.ResumeLayout(false);
            this.addPurchaseGroupBox.PerformLayout();
            this.editPageTab.ResumeLayout(false);
            this.editDataTablControl.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.editMedicineGroupBox.ResumeLayout(false);
            this.editMedicineGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getMedicinesBarCodeBindingSource)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.editCustomerGroupBox.ResumeLayout(false);
            this.editCustomerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getcustomersBindingSource)).EndInit();
            this.deletePageTab.ResumeLayout(false);
            this.deleteCustomerGroupBox.ResumeLayout(false);
            this.deleteCustomerGroupBox.PerformLayout();
            this.deleteOrderGroupBox.ResumeLayout(false);
            this.deleteOrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getordersBindingSource)).EndInit();
            this.searchPageTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.accountPageTab.ResumeLayout(false);
            this.accountGroupBox.ResumeLayout(false);
            this.accountGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox accountGroupBox;
        private System.Windows.Forms.Button accountChangePasswordButton;
        private System.Windows.Forms.Label accountRenterNewPassLabel;
        private System.Windows.Forms.Label accountNewPassLabel;
        private System.Windows.Forms.Label accountOldPassLabel;
        private System.Windows.Forms.TextBox accountNewPasswordTextField;
        private System.Windows.Forms.TextBox accountOldPasswordTextField;
        private System.Windows.Forms.TextBox accountRenterNewPasswordTextField;
        private System.Windows.Forms.TabControl editDataTablControl;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.GroupBox addCustomerGroupBox;
        private System.Windows.Forms.RichTextBox addCustomerCommentsTextField;
        private System.Windows.Forms.Label addCustomerCommentsLabel;
        private System.Windows.Forms.TextBox addCustomerTelephoneTextField;
        private System.Windows.Forms.TextBox addCustomerAddressTextField;
        private System.Windows.Forms.TextBox addCustomerNameTextField;
        private System.Windows.Forms.Label addCustomerTelephoneNumbLabel;
        private System.Windows.Forms.Label addCustomerAddressLabel;
        private System.Windows.Forms.Label addCustomerNameLabel;
        private System.Windows.Forms.Button addCustomerAddButton;
        private System.Windows.Forms.GroupBox editCustomerGroupBox;
        private System.Windows.Forms.RichTextBox editCustomerCommentsTextField;
        private System.Windows.Forms.Label editCustomerCommentsLabel;
        private System.Windows.Forms.TextBox editCustomerTelephoneTextField;
        private System.Windows.Forms.TextBox editCustomerAddressTextField;
        private System.Windows.Forms.Label editCustomerTelephoneNumbLabel;
        private System.Windows.Forms.Label editCustomerAddressLabel;
        private System.Windows.Forms.Label editCustomerNameLabel;
        private System.Windows.Forms.Button editCustomerButton;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Label searchToLabel;
        private System.Windows.Forms.DateTimePicker searchToDateTimePicker;
        private System.Windows.Forms.Label searchFromLabel;
        private System.Windows.Forms.DateTimePicker searchFromDateTimePicker;
        private System.Windows.Forms.Button searchViewButton;
        private System.Windows.Forms.Label searchActiveIngredientTradeNameLabel;
        private System.Windows.Forms.Label searchChooseLabel;
        private System.Windows.Forms.ComboBox searchMethodsComboBox;
        private System.Windows.Forms.ComboBox editCustomerNameComboBox;
        private System.Windows.Forms.GroupBox addMedicineGroupBox;
        private System.Windows.Forms.Label addMedicineBarCodeLabel;
        private System.Windows.Forms.Button addMedicineAddButton;
        private System.Windows.Forms.Label addMedicineCategoryLabel;
        private System.Windows.Forms.Label addMedicinePriceOfSaleLabel;
        private System.Windows.Forms.TextBox addMedicineConcectrationTextField;
        private System.Windows.Forms.Label addMedicineConcentrationLabel;
        private System.Windows.Forms.TextBox addMedicinePriceOfSaleTextField;
        private System.Windows.Forms.TextBox addMedicineBarcodeTextField;
        private System.Windows.Forms.TextBox addMedicineActiveIngrdTextField;
        private System.Windows.Forms.Label addMedicineTradeNameLabel;
        private System.Windows.Forms.Label addMedicineActiveIngredientLabel;
        private System.Windows.Forms.TextBox addMedicineTradeNameTextField;
        private System.Windows.Forms.GroupBox editMedicineGroupBox;
        private System.Windows.Forms.ComboBox editMedicineBarcodeComboBox;
        private System.Windows.Forms.ComboBox editMedicineCategoryComboBox;
        private System.Windows.Forms.Label editMedicineBarCodeLabel;
        private System.Windows.Forms.Button editMedicineButton;
        private System.Windows.Forms.Label editMedicineCategoryLabel;
        private System.Windows.Forms.Label editMedicinePriceOfSaleLabel;
        private System.Windows.Forms.TextBox editMedicineConcentrationTextField;
        private System.Windows.Forms.Label editMedicineConcentrationLabel;
        private System.Windows.Forms.TextBox editMedicinePriceOfSaleTextField;
        private System.Windows.Forms.TextBox editMedicineActiveIngredientTextField;
        private System.Windows.Forms.Label editMedicineTradenameLabel;
        private System.Windows.Forms.Label editMedicineActiveIngredientLabel;
        private System.Windows.Forms.TextBox editMedicineTradeNameTextField;
        private System.Windows.Forms.TabPage deletePageTab;
        private System.Windows.Forms.GroupBox deleteCustomerGroupBox;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Label deleteCustomerNameLabel;
        private System.Windows.Forms.ComboBox deleteCustomerNameComboBox;
        private System.Windows.Forms.GroupBox deleteOrderGroupBox;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Label deleteOrderTransNumbLabel;
        private System.Windows.Forms.ComboBox deleteOrderTransNumberComboBox;
        private System.Windows.Forms.TabPage addPurchaseTabPage;
        private System.Windows.Forms.GroupBox addPurchaseGroupBox;
        private System.Windows.Forms.DateTimePicker addPurchaseDateTimePicker;
        private System.Windows.Forms.Label addPurchaseDateLabel;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button addPurchaseAddButton;
        private System.Windows.Forms.TextBox searchMultipleOptionTextField;
        private System.Windows.Forms.ComboBox searchCategoryComboBox;
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
        private System.Windows.Forms.Label orderTotalPriceLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicinePriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.Label orderTotalPriceValueTextLabel;
        private System.Windows.Forms.Label categoryLabel;


    }
}