using Application.Contracts.PersonType;
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
                dataGridView1.DataSource = unit.PersonTypeApp.GetPersonTypes();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (!string.IsNullOrEmpty(name))
            {
                var persontypeadd = new PersonTypeAdd() { Name = name };
                using (var unit = new UnitOfWork())
                {
                    unit.PersonTypeApp.AddPersonType(persontypeadd);
                    dataGridView1.DataSource = unit.PersonTypeApp.GetPersonTypes();
                }
                textBox1.Text = null;
            }
        }
    }
}
