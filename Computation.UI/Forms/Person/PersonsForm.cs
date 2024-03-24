using Application.Contracts.Person;
using Application.Contracts.PersonType;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computation.UI.Forms.Person
{
    public partial class PersonsForm : DevExpress.XtraEditors.XtraForm
    {
        public PersonsForm()
        {
            InitializeComponent();
        }

        private void PersonsForm_Load(object sender, EventArgs e)
        {

            using (var unit = new UnitOfWork())
            {
                var persons = new BindingList<PersonView>(unit.PersonApp.GetPersons());

                gridControl1.DataSource = persons;
            }

            gridView1.Columns["ID"].OptionsColumn.AllowFocus = false;

        }

        private void AddFormShow_Click(object sender, EventArgs e)
        {
            PersonAddForm form = new PersonAddForm();
            form.FormClosed += ChildForm_FormClosed;
            form.ShowDialog();
        }


        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PersonsForm_Load(sender, e);
        }



    }
}