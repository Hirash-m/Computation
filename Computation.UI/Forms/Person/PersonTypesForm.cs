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


namespace Computation.UI.Forms.Person
{
    public partial class PersonTypesForm : DevExpress.XtraEditors.XtraForm
    {
        public PersonTypesForm()
        {
            InitializeComponent();

           
           
        }

       

      

        private void PersonTypesForm_Load(object sender, EventArgs e)
        {
            using (var unit = new UnitOfWork())
            {
                var personTypes = unit.PersonTypeApp.GetPersonTypes();

                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Name", typeof(string));

                foreach (var personType in personTypes)
                {
                    dt.Rows.Add(personType.Id, personType.Name);
                }

                gridControl.DataSource = dt;
            }
        }



        private void AddRow_Click(object sender, EventArgs e)
        {

            DataTable added = gridControl.DataSource as DataTable;
            
            foreach (DataRow row in added.Rows)
            {

                using (var unit = new UnitOfWork())
                {
                    if (row.RowState == DataRowState.Added)
                    {
                        var personType = new PersonType() { Name = row["Name"].ToString() };
                        unit.PersonTypeApp.AddPersonType(personType);
                    }
                }
            }
            PersonTypesForm_Load(sender, e);
        }





    }
}