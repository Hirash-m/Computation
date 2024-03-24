using Application.Contracts.PersonType;
using DevExpress.Map.Kml.Model;
using DevExpress.XtraEditors;
using Infrastructure.Models;
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
    public partial class PersonTypeEditForm : DevExpress.XtraEditors.XtraForm
    {
        private PersonTypeView _personTypeView;

        public PersonTypeEditForm(PersonTypeView personTypeView)
        {
            InitializeComponent();

            textBox1.Text = personTypeView.Name;
            _personTypeView = personTypeView;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonTypeView updatedPersonTypeView = new PersonTypeView
            {
                Id = _personTypeView.Id,
                Name = textBox1.Text
            };

            if (updatedPersonTypeView.Name != _personTypeView.Name)
            {
                using (UnitOfWork unit = new UnitOfWork())
                {
                    var result = unit.PersonTypeApp.EditPersonType(updatedPersonTypeView);

                    if (!result.IsSucceeded)
                    {
                        MessageBox.Show(result.Message, "خطا", MessageBoxButtons.OK);
                    }
                    else
                    {
                        _personTypeView.Name = updatedPersonTypeView.Name; 
                    }
                }
            }

            this.Close();
        }


    }
}