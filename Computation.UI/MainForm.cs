using Computation.UI.MainData.Person;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computation.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void اشخاصToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var personForm = new PersonForm();
            personForm.ShowDialog();
        }

        private void نوعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var personTypeForm = new PersonTypeForm();
            personTypeForm.ShowDialog();
        }
    }
}
