namespace Computation.UI.Forms.Person
{
    partial class PersonsForm
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
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ID = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnFamily = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnNationalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            AddFormShow = new DevExpress.XtraEditors.SimpleButton();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            PageLBL = new Label();
            CountDataLBL = new Label();
            PageNextBTN = new DevExpress.XtraEditors.SimpleButton();
            PageBeforeBTN = new DevExpress.XtraEditors.SimpleButton();
            addedByExcelBTN = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(12, 38);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.RightToLeft = RightToLeft.Yes;
            gridControl1.Size = new Size(979, 440);
            gridControl1.TabIndex = 4;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.EvenRow.BackColor = Color.FromArgb(128, 255, 255);
            gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            gridView1.Appearance.FocusedRow.FontSizeDelta = 2;
            gridView1.Appearance.FocusedRow.Options.UseFont = true;
            gridView1.Appearance.Row.Options.UseTextOptions = true;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Appearance.SelectedRow.BackColor = Color.Silver;
            gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { ID, gridColumnName, gridColumnFamily, gridColumnTypeName, gridColumnNationalCode, gridColumnEmail });
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.FindClick;
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            gridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            gridView1.OptionsView.EnableAppearanceEvenRow = true;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // ID
            // 
            ID.AccessibleName = "";
            ID.Caption = "کد";
            ID.FieldName = "ID";
            ID.Name = "ID";
            ID.Visible = true;
            ID.VisibleIndex = 1;
            ID.Width = 52;
            // 
            // gridColumnName
            // 
            gridColumnName.Caption = "نام";
            gridColumnName.FieldName = "Name";
            gridColumnName.Name = "gridColumnName";
            gridColumnName.Visible = true;
            gridColumnName.VisibleIndex = 2;
            gridColumnName.Width = 122;
            // 
            // gridColumnFamily
            // 
            gridColumnFamily.Caption = "نام خانوادگی";
            gridColumnFamily.FieldName = "Family";
            gridColumnFamily.Name = "gridColumnFamily";
            gridColumnFamily.Visible = true;
            gridColumnFamily.VisibleIndex = 3;
            gridColumnFamily.Width = 125;
            // 
            // gridColumnTypeName
            // 
            gridColumnTypeName.Caption = "نوع هویت";
            gridColumnTypeName.FieldName = "PersonTypeName";
            gridColumnTypeName.Name = "gridColumnTypeName";
            gridColumnTypeName.Visible = true;
            gridColumnTypeName.VisibleIndex = 4;
            gridColumnTypeName.Width = 74;
            // 
            // gridColumnNationalCode
            // 
            gridColumnNationalCode.Caption = "کد ملی";
            gridColumnNationalCode.FieldName = "NationalCode";
            gridColumnNationalCode.Name = "gridColumnNationalCode";
            gridColumnNationalCode.Visible = true;
            gridColumnNationalCode.VisibleIndex = 5;
            gridColumnNationalCode.Width = 149;
            // 
            // gridColumnEmail
            // 
            gridColumnEmail.Caption = "ایمیل";
            gridColumnEmail.FieldName = "Email";
            gridColumnEmail.Name = "gridColumnEmail";
            gridColumnEmail.Visible = true;
            gridColumnEmail.VisibleIndex = 6;
            gridColumnEmail.Width = 163;
            // 
            // AddFormShow
            // 
            AddFormShow.Appearance.BackColor = Color.FromArgb(0, 192, 0);
            AddFormShow.Appearance.Options.UseBackColor = true;
            AddFormShow.Location = new Point(12, 12);
            AddFormShow.Name = "AddFormShow";
            AddFormShow.Size = new Size(62, 22);
            AddFormShow.StyleController = layoutControl1;
            AddFormShow.TabIndex = 0;
            AddFormShow.Text = "+";
            AddFormShow.Click += AddFormShow_Click;
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(PageLBL);
            layoutControl1.Controls.Add(CountDataLBL);
            layoutControl1.Controls.Add(PageNextBTN);
            layoutControl1.Controls.Add(PageBeforeBTN);
            layoutControl1.Controls.Add(addedByExcelBTN);
            layoutControl1.Controls.Add(simpleButton1);
            layoutControl1.Controls.Add(gridControl1);
            layoutControl1.Controls.Add(AddFormShow);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(671, 0, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(1003, 516);
            layoutControl1.TabIndex = 2;
            layoutControl1.Text = "layoutControl1";
            // 
            // PageLBL
            // 
            PageLBL.Location = new Point(277, 482);
            PageLBL.Name = "PageLBL";
            PageLBL.Size = new Size(54, 22);
            PageLBL.TabIndex = 8;
            PageLBL.Text = "label1";
            // 
            // CountDataLBL
            // 
            CountDataLBL.Location = new Point(217, 482);
            CountDataLBL.Name = "CountDataLBL";
            CountDataLBL.Size = new Size(56, 22);
            CountDataLBL.TabIndex = 7;
            CountDataLBL.Text = "label1";
            // 
            // PageNextBTN
            // 
            PageNextBTN.Location = new Point(121, 482);
            PageNextBTN.Name = "PageNextBTN";
            PageNextBTN.Size = new Size(92, 22);
            PageNextBTN.StyleController = layoutControl1;
            PageNextBTN.TabIndex = 6;
            PageNextBTN.Text = "صفحه بعد>";
            PageNextBTN.Click += PageNextBTN_Click;
            // 
            // PageBeforeBTN
            // 
            PageBeforeBTN.Location = new Point(12, 482);
            PageBeforeBTN.Name = "PageBeforeBTN";
            PageBeforeBTN.Size = new Size(105, 22);
            PageBeforeBTN.StyleController = layoutControl1;
            PageBeforeBTN.TabIndex = 5;
            PageBeforeBTN.Text = "<صفحه قبل ";
            PageBeforeBTN.Click += PageBeforeBTN_Click;
            // 
            // addedByExcelBTN
            // 
            addedByExcelBTN.Location = new Point(156, 12);
            addedByExcelBTN.Name = "addedByExcelBTN";
            addedByExcelBTN.Size = new Size(98, 22);
            addedByExcelBTN.StyleController = layoutControl1;
            addedByExcelBTN.TabIndex = 3;
            addedByExcelBTN.Text = "اضافه کردن با اکسل";
            addedByExcelBTN.Click += addedByExcelBTN_Click;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.BackColor = Color.Red;
            simpleButton1.Appearance.ForeColor = Color.Black;
            simpleButton1.Appearance.Options.UseBackColor = true;
            simpleButton1.Appearance.Options.UseForeColor = true;
            simpleButton1.Location = new Point(78, 12);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(74, 22);
            simpleButton1.StyleController = layoutControl1;
            simpleButton1.TabIndex = 2;
            simpleButton1.Text = "حذف";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, emptySpaceItem1, layoutControlItem4, layoutControlItem5, layoutControlItem6, emptySpaceItem2, layoutControlItem7, layoutControlItem8 });
            Root.Name = "Root";
            Root.Size = new Size(1003, 516);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = AddFormShow;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.MaxSize = new Size(66, 26);
            layoutControlItem1.MinSize = new Size(66, 26);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(66, 26);
            layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = gridControl1;
            layoutControlItem2.Location = new Point(0, 26);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(983, 444);
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = simpleButton1;
            layoutControlItem3.Location = new Point(66, 0);
            layoutControlItem3.MaxSize = new Size(78, 26);
            layoutControlItem3.MinSize = new Size(78, 26);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(78, 26);
            layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(246, 0);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(737, 26);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = addedByExcelBTN;
            layoutControlItem4.Location = new Point(144, 0);
            layoutControlItem4.MaxSize = new Size(102, 26);
            layoutControlItem4.MinSize = new Size(102, 26);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(102, 26);
            layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem4.TextSize = new Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = PageBeforeBTN;
            layoutControlItem5.Location = new Point(0, 470);
            layoutControlItem5.MaxSize = new Size(109, 26);
            layoutControlItem5.MinSize = new Size(109, 26);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(109, 26);
            layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem5.TextSize = new Size(0, 0);
            layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = PageNextBTN;
            layoutControlItem6.Location = new Point(109, 470);
            layoutControlItem6.MaxSize = new Size(96, 26);
            layoutControlItem6.MinSize = new Size(96, 26);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(96, 26);
            layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem6.TextSize = new Size(0, 0);
            layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new Point(323, 470);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(660, 26);
            emptySpaceItem2.TextSize = new Size(0, 0);
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = CountDataLBL;
            layoutControlItem7.Location = new Point(205, 470);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new Size(60, 26);
            layoutControlItem7.TextSize = new Size(0, 0);
            layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.Control = PageLBL;
            layoutControlItem8.Location = new Point(265, 470);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Size = new Size(58, 26);
            layoutControlItem8.TextSize = new Size(0, 0);
            layoutControlItem8.TextVisible = false;
            // 
            // simpleButton2
            // 
            simpleButton2.Location = new Point(0, 0);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(75, 23);
            simpleButton2.TabIndex = 3;
            simpleButton2.Text = "simpleButton2";
            // 
            // PersonsForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 516);
            Controls.Add(simpleButton2);
            Controls.Add(layoutControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "PersonsForm";
            RightToLeftLayout = true;
            Text = "PersonsForm";
            WindowState = FormWindowState.Maximized;
            Load += PersonsForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton AddFormShow;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFamily;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNationalCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEmail;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton addedByExcelBTN;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton PageNextBTN;
        private DevExpress.XtraEditors.SimpleButton PageBeforeBTN;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private Label PageLBL;
        private Label CountDataLBL;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}