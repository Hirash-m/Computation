using Application.Contracts.Person;
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
    public partial class PersonForm : Form
    {
        

        public PersonForm()
        {
            InitializeComponent();
            
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            using (var unitOfWork= new UnitOfWork()) {
                dataGridView1.DataSource = unitOfWork.PersonApp.GetPersons();
            }
        }
    }
}
