namespace Computation.UI.Forms.Inventory
{
    partial class InventoryForm
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
            components = new System.ComponentModel.Container();
            gridControl = new DevExpress.XtraGrid.GridControl();
            personTypeAppBindingSource = new BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            AddRow = new DevExpress.XtraEditors.SimpleButton();
            DeleteRow = new DevExpress.XtraEditors.SimpleButton();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personTypeAppBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            SuspendLayout();
            // 
            // gridControl
            // 
            gridControl.DataSource = personTypeAppBindingSource;
            gridControl.Location = new Point(12, 38);
            gridControl.MainView = gridView1;
            gridControl.Name = "gridControl";
            gridControl.RightToLeft = RightToLeft.Yes;
            gridControl.Size = new Size(938, 345);
            gridControl.TabIndex = 3;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // personTypeAppBindingSource
            // 
            personTypeAppBindingSource.DataSource = typeof(Application.PersonTypeApp);
            // 
            // gridView1
            // 
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridView1.GridControl = gridControl;
            gridView1.GroupPanelText = "test";
            gridView1.Name = "gridView1";
            gridView1.OptionsCustomization.AllowGroup = false;
            gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            gridView1.OptionsView.AllowHtmlDrawGroups = false;
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // AddRow
            // 
            AddRow.Location = new Point(12, 12);
            AddRow.Name = "AddRow";
            AddRow.Size = new Size(64, 22);
            AddRow.StyleController = layoutControl1;
            AddRow.TabIndex = 0;
            AddRow.Text = "اضافه کردن";
            AddRow.Click += AddRow_Click;
            // 
            // DeleteRow
            // 
            DeleteRow.Location = new Point(80, 12);
            DeleteRow.Name = "DeleteRow";
            DeleteRow.Size = new Size(67, 22);
            DeleteRow.StyleController = layoutControl1;
            DeleteRow.TabIndex = 2;
            DeleteRow.Text = "حذف";
            DeleteRow.Click += DeleteRow_Click;
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(AddRow);
            layoutControl1.Controls.Add(DeleteRow);
            layoutControl1.Controls.Add(gridControl);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(816, 0, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(962, 395);
            layoutControl1.TabIndex = 3;
            layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, emptySpaceItem1 });
            Root.Name = "Root";
            Root.Size = new Size(962, 395);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gridControl;
            layoutControlItem1.Location = new Point(0, 26);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(942, 349);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = DeleteRow;
            layoutControlItem2.Location = new Point(68, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(71, 26);
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = AddRow;
            layoutControlItem3.Location = new Point(0, 0);
            layoutControlItem3.MaxSize = new Size(68, 26);
            layoutControlItem3.MinSize = new Size(68, 26);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(68, 26);
            layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(139, 0);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(803, 26);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 395);
            Controls.Add(layoutControl1);
            MaximizeBox = false;
            Name = "InventoryForm";
            Text = "PersonTypesForm";
            Load += InventoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)personTypeAppBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton AddRow;
        private DevExpress.XtraEditors.SimpleButton DeleteRow;
        private BindingSource personTypeAppBindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}