using Application.Contracts.Person;
using Application.Contracts.PersonType;
using DevExpress.XtraEditors;
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
    public partial class PersonAddForm : DevExpress.XtraEditors.XtraForm
    {
        public PersonAddForm()
        {
            InitializeComponent();
        }

        private void PersonAddForm_Load(object sender, EventArgs e)
        {
            using (var unit = new UnitOfWork())
            {
                var persontypes = new BindingList<PersonTypeView>(unit.PersonTypeApp.GetPersonTypes());

                comboBox1.DataSource = persontypes;
                comboBox1.ValueMember = "Id";
                comboBox1.DisplayMember = "Name";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

          
                var p = comboBox1.SelectedItem as PersonTypeView;
            
          

            var personAdd = new PersonAdd 
            { 
                   Name = NameText.Text,
                   Family = FamilyText.Text,
                   TypeId = p.Id,
                   NationalCode = NationalCodeText.Text,
                   Email = EmailText.Text,
                   
            };
            using (var unit = new UnitOfWork())
            {
                unit.PersonApp.PersonAdd(personAdd);
            }
            this.Close();
        }
    }
}