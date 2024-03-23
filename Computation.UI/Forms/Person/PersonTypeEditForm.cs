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
        private  PersonTypeView _personTypeView;

        public PersonTypeEditForm(PersonTypeView personTypeView)
        {
            InitializeComponent();

            textBox1.Text = personTypeView.Name;
            _personTypeView = personTypeView;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_personTypeView.Name != textBox1.Text.ToString())
            {

                _personTypeView.Name = textBox1.Text.ToString();
                var f = textBox1.Text;
                using (UnitOfWork unit = new UnitOfWork())
                {
                  var result =  unit.PersonTypeApp.EditPersonType(_personTypeView);

                    if (!result.IsSucceeded)
                    {
                        MessageBox.Show(result.Message, "خطا", MessageBoxButtons.OK);

                    }

                }
               
               

            }


            this.Close();
          
        }
    }
}