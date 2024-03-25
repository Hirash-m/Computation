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
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(12, 38);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.RightToLeft = RightToLeft.Yes;
            gridControl1.Size = new Size(946, 568);
            gridControl1.TabIndex = 2;
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
            layoutControl1.Controls.Add(gridControl1);
            layoutControl1.Controls.Add(AddFormShow);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(671, 0, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(970, 618);
            layoutControl1.TabIndex = 2;
            layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, emptySpaceItem2 });
            Root.Name = "Root";
            Root.Size = new Size(970, 618);
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
            layoutControlItem2.Size = new Size(950, 572);
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new Point(66, 0);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(884, 26);
            emptySpaceItem2.TextSize = new Size(0, 0);
            // 
            // PersonsForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 618);
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
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
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
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFamily;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNationalCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEmail;
    }
}