namespace SW_project
{
    partial class Purchasesconcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchasesconcs));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addPurchaseButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.getallmedicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new SW_project.PharmacyDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.getallmedicineTableAdapter = new SW_project.PharmacyDataSetTableAdapters.getallmedicineTableAdapter();
            this.quantityNumericInput = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getallmedicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericInput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quantityNumericInput);
            this.groupBox1.Controls.Add(this.addPurchaseButton);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(834, 295);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase contents";
            // 
            // addPurchaseButton
            // 
            this.addPurchaseButton.Location = new System.Drawing.Point(678, 259);
            this.addPurchaseButton.Margin = new System.Windows.Forms.Padding(4);
            this.addPurchaseButton.Name = "addPurchaseButton";
            this.addPurchaseButton.Size = new System.Drawing.Size(148, 28);
            this.addPurchaseButton.TabIndex = 3;
            this.addPurchaseButton.Text = "Add";
            this.addPurchaseButton.UseVisualStyleBackColor = true;
            this.addPurchaseButton.Click += new System.EventHandler(this.addPurchaseButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox1.DataSource = this.getallmedicineBindingSource;
            this.comboBox1.DisplayMember = "Tradename";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 44);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(330, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Code";
            // 
            // getallmedicineBindingSource
            // 
            this.getallmedicineBindingSource.DataMember = "getallmedicine";
            this.getallmedicineBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // getallmedicineTableAdapter
            // 
            this.getallmedicineTableAdapter.ClearBeforeFill = true;
            // 
            // quantityNumericInput
            // 
            this.quantityNumericInput.Location = new System.Drawing.Point(99, 85);
            this.quantityNumericInput.Name = "quantityNumericInput";
            this.quantityNumericInput.Size = new System.Drawing.Size(120, 21);
            this.quantityNumericInput.TabIndex = 4;
            // 
            // Purchasesconcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(853, 303);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Purchasesconcs";
            this.Text = "Roshdy PASS Purchase Window";
            this.Load += new System.EventHandler(this.Purchasesconcs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getallmedicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addPurchaseButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource getallmedicineBindingSource;
        private PharmacyDataSetTableAdapters.getallmedicineTableAdapter getallmedicineTableAdapter;
        private System.Windows.Forms.NumericUpDown quantityNumericInput;
    }
}