namespace Computation.UI.Forms.Person
{
    partial class PersonTypesForm
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
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            AddRow = new DevExpress.XtraEditors.SimpleButton();
            DeleteRow = new DevExpress.XtraEditors.SimpleButton();
            personTypeAppBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personTypeAppBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gridControl
            // 
            gridControl.DataSource = personTypeAppBindingSource;
            gridControl.Dock = DockStyle.Bottom;
            gridControl.Location = new Point(0, 31);
            gridControl.MainView = gridView1;
            gridControl.Name = "gridControl";
            gridControl.RightToLeft = RightToLeft.Yes;
            gridControl.Size = new Size(351, 319);
            gridControl.TabIndex = 0;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // AddRow
            // 
            AddRow.Location = new Point(0, 2);
            AddRow.Name = "AddRow";
            AddRow.Size = new Size(75, 23);
            AddRow.TabIndex = 1;
            AddRow.Text = "اضافه کردن";
            AddRow.Click += AddRow_Click;
            // 
            // DeleteRow
            // 
            DeleteRow.Location = new Point(81, 2);
            DeleteRow.Name = "DeleteRow";
            DeleteRow.Size = new Size(75, 23);
            DeleteRow.TabIndex = 2;
            DeleteRow.Text = "حذف";
            // 
            // personTypeAppBindingSource
            // 
            personTypeAppBindingSource.DataSource = typeof(Application.PersonTypeApp);
            // 
            // PersonTypesForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 350);
            Controls.Add(DeleteRow);
            Controls.Add(AddRow);
            Controls.Add(gridControl);
            MaximizeBox = false;
            Name = "PersonTypesForm";
            Text = "PersonTypesForm";
            Shown += PersonTypesForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personTypeAppBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton AddRow;
        private DevExpress.XtraEditors.SimpleButton DeleteRow;
        private BindingSource personTypeAppBindingSource;
    }
}