using Application.Contracts.Person;
using DevExpress.XtraGrid.Views.Base;

using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
            gridView1.DoubleClick += GridView1_DoubleClick;

        }



        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view != null)
            {
                GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;

                    // Get the data of the focused row
                    PersonView selectedPerson = view.GetRow(hitInfo.RowHandle) as PersonView;

                    if (selectedPerson != null)
                    {
                        PersonAddForm form = new PersonAddForm(selectedPerson);
                        form.FormClosed += ChildForm_FormClosed;
                        form.ShowDialog();
                    }
                }
            }
        }


        private void PersonsForm_Load(object sender, EventArgs e)
        {

            using (var unit = new UnitOfWork())
            {
                var persons = new BindingList<PersonView>(unit.PersonApp.GetPersons());

                gridControl1.DataSource = persons;
            }

            // gridView1.Columns["ID"].OptionsColumn.AllowFocus = false;

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




        private void DeleteSelectedRecords()
        {
            // Get the selected rows in the grid
            int[] selectedRows = gridView1.GetSelectedRows();

            if (selectedRows.Length > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected records?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Create a list to store the selected PersonView objects
                    List<PersonView> selectedPersons = new List<PersonView>();
                    using (var unit = new UnitOfWork()) { 
                        foreach (int rowHandle in selectedRows)
                        {
                            PersonView selectedPerson = gridView1.GetRow(rowHandle) as PersonView;

                            if (selectedPerson != null)
                            {
                                var id = selectedPerson.ID; // Retrieve the id value
                                unit.PersonApp.PersonDelete(id);
                                unit.Save();
                               
                            }
                        }
                    }
                  
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DeleteSelectedRecords();
        }
    }
}