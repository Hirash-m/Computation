using Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computation.UI.MainData.Person
{
    public partial class PersonTypeForm : Form
    {
        public PersonTypeForm()
        {
            InitializeComponent();
        }

        private void PersonTypeForm_Load(object sender, EventArgs e)
        {
            using (var unit = new UnitOfWork())
            {
                dataGridView1.DataSource=unit.PersonTypeApp.GetPersonTypes();
            }
        }
    }
}
