namespace Computation.UI.MainData.Person
{
    partial class PersonTypeForm
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
            dataGridView1 = new DataGridView();
            personTypeAppBindingSource2 = new BindingSource(components);
            personTypeAppBindingSource1 = new BindingSource(components);
            personTypeAppBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personTypeAppBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personTypeAppBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personTypeAppBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.Size = new Size(800, 330);
            dataGridView1.TabIndex = 0;
            // 
            // personTypeAppBindingSource2
            // 
            personTypeAppBindingSource2.DataSource = typeof(Application.PersonTypeApp);
            // 
            // personTypeAppBindingSource1
            // 
            personTypeAppBindingSource1.DataSource = typeof(Application.PersonTypeApp);
            // 
            // personTypeAppBindingSource
            // 
            personTypeAppBindingSource.DataSource = typeof(Application.PersonTypeApp);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 369);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 82);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "نوع جدید";
            // 
            // button1
            // 
            button1.Location = new Point(12, 46);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "ایجاد";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(580, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(727, 19);
            label1.Name = "label1";
            label1.Size = new Size(61, 14);
            label1.TabIndex = 0;
            label1.Text = "نوع هویت :";
            // 
            // PersonTypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "PersonTypeForm";
            Text = "PersonTypeForm";
            Load += PersonTypeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personTypeAppBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)personTypeAppBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personTypeAppBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource personTypeAppBindingSource;
        private BindingSource personTypeAppBindingSource1;
        private BindingSource personTypeAppBindingSource2;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}