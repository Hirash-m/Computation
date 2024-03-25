namespace Computation.UI.Forms.Person
{
    partial class PersonAddForm
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
            comboBox1 = new ComboBox();
            personTypeAppBindingSource = new BindingSource(components);
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            EmailText = new DevExpress.XtraEditors.TextEdit();
            NationalCodeText = new DevExpress.XtraEditors.TextEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            FamilyText = new DevExpress.XtraEditors.TextEdit();
            NameText = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            PersonType = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)personTypeAppBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmailText.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NationalCodeText.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FamilyText.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NameText.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PersonType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DataSource = personTypeAppBindingSource;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 21);
            comboBox1.TabIndex = 4;
            // 
            // personTypeAppBindingSource
            // 
            personTypeAppBindingSource.DataSource = typeof(Application.PersonTypeApp);
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(EmailText);
            layoutControl1.Controls.Add(NationalCodeText);
            layoutControl1.Controls.Add(comboBox1);
            layoutControl1.Controls.Add(simpleButton1);
            layoutControl1.Controls.Add(FamilyText);
            layoutControl1.Controls.Add(NameText);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            layoutControl1.RightToLeft = RightToLeft.Yes;
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(575, 495);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // EmailText
            // 
            EmailText.Location = new Point(12, 61);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(474, 20);
            EmailText.StyleController = layoutControl1;
            EmailText.TabIndex = 6;
            // 
            // NationalCodeText
            // 
            NationalCodeText.Location = new Point(289, 36);
            NationalCodeText.Name = "NationalCodeText";
            NationalCodeText.Size = new Size(197, 20);
            NationalCodeText.StyleController = layoutControl1;
            NationalCodeText.TabIndex = 3;
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new Point(12, 451);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(129, 32);
            simpleButton1.StyleController = layoutControl1;
            simpleButton1.TabIndex = 5;
            simpleButton1.Text = "ذخیره";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // FamilyText
            // 
            FamilyText.EditValue = "";
            FamilyText.Location = new Point(12, 12);
            FamilyText.Name = "FamilyText";
            FamilyText.Size = new Size(196, 20);
            FamilyText.StyleController = layoutControl1;
            FamilyText.TabIndex = 2;
            // 
            // NameText
            // 
            NameText.Location = new Point(289, 12);
            NameText.Name = "NameText";
            NameText.Size = new Size(197, 20);
            NameText.StyleController = layoutControl1;
            NameText.TabIndex = 0;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem3, layoutControlItem1, layoutControlItem2, emptySpaceItem2, PersonType, emptySpaceItem3, layoutControlItem4, layoutControlItem5 });
            Root.Name = "Root";
            Root.Size = new Size(575, 495);
            Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = NameText;
            layoutControlItem3.Location = new Point(277, 0);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(278, 24);
            layoutControlItem3.Text = "نام :";
            layoutControlItem3.TextSize = new Size(65, 13);
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = FamilyText;
            layoutControlItem1.CustomizationFormText = "نام خانوادگی :";
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(277, 24);
            layoutControlItem1.Text = "نام خانوادگی :";
            layoutControlItem1.TextSize = new Size(65, 13);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = simpleButton1;
            layoutControlItem2.Location = new Point(0, 439);
            layoutControlItem2.MaxSize = new Size(133, 36);
            layoutControlItem2.MinSize = new Size(133, 36);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(133, 36);
            layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new Point(133, 439);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(422, 36);
            emptySpaceItem2.TextSize = new Size(0, 0);
            // 
            // PersonType
            // 
            PersonType.Control = comboBox1;
            PersonType.Location = new Point(0, 24);
            PersonType.Name = "PersonType";
            PersonType.Size = new Size(277, 25);
            PersonType.Text = "نوع :";
            PersonType.TextSize = new Size(65, 13);
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.AllowHotTrack = false;
            emptySpaceItem3.Location = new Point(0, 73);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new Size(555, 366);
            emptySpaceItem3.TextSize = new Size(0, 0);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = NationalCodeText;
            layoutControlItem4.Location = new Point(277, 24);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(278, 25);
            layoutControlItem4.Text = "کد ملی :";
            layoutControlItem4.TextSize = new Size(65, 13);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = EmailText;
            layoutControlItem5.Location = new Point(0, 49);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(555, 24);
            layoutControlItem5.Text = "ایمیل :";
            layoutControlItem5.TextSize = new Size(65, 13);
            // 
            // PersonAddForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 495);
            Controls.Add(layoutControl1);
            Name = "PersonAddForm";
            Text = "PersonAddForm";
            Load += PersonAddForm_Load;
            ((System.ComponentModel.ISupportInitialize)personTypeAppBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EmailText.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)NationalCodeText.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)FamilyText.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)NameText.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PersonType).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit FamilyText;
        private DevExpress.XtraEditors.TextEdit NameText;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.DropDownButton dropDownTypePerson;
        private DevExpress.XtraLayout.LayoutControlItem نوع;
        private ComboBox comboBox1;
        private DevExpress.XtraLayout.LayoutControlItem PersonType;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.TextEdit NationalCodeText;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit EmailText;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private BindingSource personTypeAppBindingSource;
    }
}