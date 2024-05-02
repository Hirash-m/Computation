using Computation.UI.Forms.Person;
using Computation.UI.MainData.Person;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computation.UI.Forms
{
    public partial class ToolbarForm1 : DevExpress.XtraEditors.XtraForm
    {
        public ToolbarForm1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void PersonBaseBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var personForm = new PersonsForm();
            personForm.MdiParent = this;
            personForm.Show();
        }
    }
}