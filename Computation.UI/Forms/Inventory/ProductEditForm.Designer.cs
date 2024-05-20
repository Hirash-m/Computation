namespace Computation.UI.Forms.Inventory
{
    partial class ProductEditForm
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
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            comboBoxUnitType = new ComboBox();
            UnitPriceTBOX = new TextBox();
            ProductNameTBOX = new TextBox();
            SaleAbleCBOX = new DevExpress.XtraEditors.CheckEdit();
            IsServiceCBOX = new DevExpress.XtraEditors.CheckEdit();
            SaveBTN = new DevExpress.XtraEditors.SimpleButton();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            ProductNameField = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ProductUnitPrice = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SaleAbleCBOX.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IsServiceCBOX.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductNameField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductUnitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(comboBoxUnitType);
            layoutControl1.Controls.Add(UnitPriceTBOX);
            layoutControl1.Controls.Add(ProductNameTBOX);
            layoutControl1.Controls.Add(SaleAbleCBOX);
            layoutControl1.Controls.Add(IsServiceCBOX);
            layoutControl1.Controls.Add(SaveBTN);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            layoutControl1.RightToLeft = RightToLeft.Yes;
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(824, 421);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // comboBoxUnitType
            // 
            comboBoxUnitType.AutoCompleteCustomSource.AddRange(new string[] { "عدد", "متر" });
            comboBoxUnitType.FormattingEnabled = true;
            comboBoxUnitType.Items.AddRange(new object[] { "عدد", "کیلو", "تن", "متر", "سانتیمتر" });
            comboBoxUnitType.Location = new Point(12, 60);
            comboBoxUnitType.Name = "comboBoxUnitType";
            comboBoxUnitType.Size = new Size(726, 21);
            comboBoxUnitType.TabIndex = 9;
            // 
            // UnitPriceTBOX
            // 
            UnitPriceTBOX.Location = new Point(12, 12);
            UnitPriceTBOX.Name = "UnitPriceTBOX";
            UnitPriceTBOX.Size = new Size(324, 20);
            UnitPriceTBOX.TabIndex = 5;
            UnitPriceTBOX.KeyPress += NumericTextBox_KeyPress;
            // 
            // ProductNameTBOX
            // 
            ProductNameTBOX.Location = new Point(414, 12);
            ProductNameTBOX.Name = "ProductNameTBOX";
            ProductNameTBOX.Size = new Size(324, 20);
            ProductNameTBOX.TabIndex = 4;
            // 
            // SaleAbleCBOX
            // 
            SaleAbleCBOX.Location = new Point(12, 36);
            SaleAbleCBOX.Name = "SaleAbleCBOX";
            SaleAbleCBOX.Properties.Caption = "قابل فروش";
            SaleAbleCBOX.Size = new Size(398, 20);
            SaleAbleCBOX.StyleController = layoutControl1;
            SaleAbleCBOX.TabIndex = 6;
            // 
            // IsServiceCBOX
            // 
            IsServiceCBOX.Location = new Point(414, 36);
            IsServiceCBOX.Name = "IsServiceCBOX";
            IsServiceCBOX.Properties.Caption = "خدمات";
            IsServiceCBOX.Size = new Size(398, 20);
            IsServiceCBOX.StyleController = layoutControl1;
            IsServiceCBOX.TabIndex = 7;
            // 
            // SaveBTN
            // 
            SaveBTN.Location = new Point(12, 85);
            SaveBTN.Name = "SaveBTN";
            SaveBTN.Size = new Size(800, 22);
            SaveBTN.StyleController = layoutControl1;
            SaveBTN.TabIndex = 10;
            SaveBTN.Text = "ذخیره";
            SaveBTN.Click += SaveBTN_Click;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { ProductNameField, emptySpaceItem1, ProductUnitPrice, layoutControlItem3, layoutControlItem4, layoutControlItem1, layoutControlItem2 });
            Root.Name = "Root";
            Root.Size = new Size(824, 421);
            Root.TextVisible = false;
            // 
            // ProductNameField
            // 
            ProductNameField.Control = ProductNameTBOX;
            ProductNameField.CustomizationFormText = "نام محصول";
            ProductNameField.Location = new Point(402, 0);
            ProductNameField.Name = "ProductNameField";
            ProductNameField.Size = new Size(402, 24);
            ProductNameField.Text = "نام محصول";
            ProductNameField.TextSize = new Size(62, 13);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 99);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(804, 302);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // ProductUnitPrice
            // 
            ProductUnitPrice.Control = UnitPriceTBOX;
            ProductUnitPrice.Location = new Point(0, 0);
            ProductUnitPrice.Name = "ProductUnitPrice";
            ProductUnitPrice.Size = new Size(402, 24);
            ProductUnitPrice.Text = "قیمت واحد";
            ProductUnitPrice.TextSize = new Size(62, 13);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = SaleAbleCBOX;
            layoutControlItem3.Location = new Point(0, 24);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(402, 24);
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = IsServiceCBOX;
            layoutControlItem4.Location = new Point(402, 24);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(402, 24);
            layoutControlItem4.TextSize = new Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = comboBoxUnitType;
            layoutControlItem1.Location = new Point(0, 48);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(804, 25);
            layoutControlItem1.Text = "واحد شمارش";
            layoutControlItem1.TextSize = new Size(62, 13);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = SaveBTN;
            layoutControlItem2.Location = new Point(0, 73);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(804, 26);
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // ProductEditForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 421);
            Controls.Add(layoutControl1);
            Name = "ProductEditForm";
            Text = "محصول جدید";
            Load += ProductEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SaleAbleCBOX.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)IsServiceCBOX.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductNameField).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductUnitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private TextBox ProductNameTBOX;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem ProductNameField;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private TextBox UnitPriceTBOX;
        private DevExpress.XtraLayout.LayoutControlItem ProductUnitPrice;
        private DevExpress.XtraEditors.CheckEdit SaleAbleCBOX;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.CheckEdit IsServiceCBOX;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.DropDownButton UnitTypeDropDown;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private ComboBox comboBoxUnitType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton SaveBTN;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}