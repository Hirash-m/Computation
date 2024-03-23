using Application.Contracts.PersonType;
using DevExpress.CodeParser;
using DevExpress.XtraCharts;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Infrastructure.Models;
using System.Data;
using System.Windows.Controls;
using DevExpress.XtraEditors;
using DevExpress.Mvvm.Native;
using DevExpress.Utils.Extensions;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;


namespace Computation.UI.Forms.Person
{
    public partial class PersonTypesForm : DevExpress.XtraEditors.XtraForm
    {
        public PersonTypesForm()
        {
            InitializeComponent();

            gridView1.MouseDown += GridView1_MouseDown; ;

        }

        private void GridView1_MouseDown(object? sender, MouseEventArgs e)
        {

            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.Button == MouseButtons.Right && view != null)
            {
                GridHitInfo hitInfo = view.CalcHitInfo(e.Location);

                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;

                    // Get the data of the focused row
                    PersonTypeView selectedPerson = view.GetRow(hitInfo.RowHandle) as PersonTypeView;

                    if (selectedPerson != null)
                    {
                        // Open the edit form and pass the data of the focused row
                        PersonTypeEditForm editForm = new PersonTypeEditForm(selectedPerson);
                        editForm.ShowDialog(); // Show the edit form as a dialog
                    }
                }
            }
        }



        private void PersonTypesForm_Load(object sender, EventArgs e)
        {
            using (var unit = new UnitOfWork())
            {
                var personTypes = new BindingList<PersonTypeView>(unit.PersonTypeApp.GetPersonTypes());

                gridControl.DataSource = personTypes;
            }

            gridView1.Columns["Id"].OptionsColumn.AllowFocus = false;
            
        }



        private void AddRow_Click(object sender, EventArgs e)
        {
            BindingList<PersonTypeView> personTypes = gridControl.DataSource as BindingList<PersonTypeView>;

            foreach (PersonTypeView personType in personTypes)
            {
                using (var unit = new UnitOfWork())
                {
                    if (personType.Id == 0)
                    {
                        var newPersonType = new PersonType() { Name = personType.Name };
                        var result = unit.PersonTypeApp.AddPersonType(newPersonType);

                        if (!result.IsSucceeded)
                        {
                            MessageBox.Show(result.Message, "خطا", MessageBoxButtons.OK);
                        }
                    }
                }
            }

            PersonTypesForm_Load(sender, e);
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {

            if (gridView1.SelectedRowsCount > 0)
            {


                byte selectedRowId = (byte)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id");

                var mBox = MessageBox.Show($"از حذف رکورد با آی دی {selectedRowId} مطمئن هستید ؟", "اخطار", MessageBoxButtons.YesNo);

                if (mBox == DialogResult.Yes)
                {
                    using (var unit = new UnitOfWork())
                    {
                        unit.PersonTypeApp.DeletePersonType(selectedRowId);
                        unit.Save();
                    }
                    PersonTypesForm_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show(".لطفا یک ردیف را انتخاب نمایید", "اخطار");
            }
        }

        private void PersonTypesForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}