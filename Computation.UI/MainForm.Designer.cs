namespace Computation.UI
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            testToolStripMenuItem = new ToolStripMenuItem();
            اشخاصToolStripMenuItem = new ToolStripMenuItem();
            نوعToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { testToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { اشخاصToolStripMenuItem });
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(80, 20);
            testToolStripMenuItem.Text = "اطلاعات پایه";
            // 
            // اشخاصToolStripMenuItem
            // 
            اشخاصToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { نوعToolStripMenuItem });
            اشخاصToolStripMenuItem.Name = "اشخاصToolStripMenuItem";
            اشخاصToolStripMenuItem.Size = new Size(180, 22);
            اشخاصToolStripMenuItem.Text = "اشخاص";
            اشخاصToolStripMenuItem.Click += اشخاصToolStripMenuItem_Click;
            // 
            // نوعToolStripMenuItem
            // 
            نوعToolStripMenuItem.Name = "نوعToolStripMenuItem";
            نوعToolStripMenuItem.Size = new Size(180, 22);
            نوعToolStripMenuItem.Text = "نوع";
            نوعToolStripMenuItem.Click += نوعToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 420);
            Controls.Add(menuStrip1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem اشخاصToolStripMenuItem;
        private ToolStripMenuItem نوعToolStripMenuItem;
    }
}