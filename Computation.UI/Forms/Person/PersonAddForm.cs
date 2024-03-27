using Application;
using Application.Contracts.Person;
using Application.Contracts.PersonType;
using Application.Contracts.PhoneContracts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;


namespace Computation.UI.Forms.Person
{
    public partial class PersonAddForm : DevExpress.XtraEditors.XtraForm
    {
        private PersonView personView;

        public PersonAddForm()
        {
            InitializeComponent();
          
        }

        public PersonAddForm(PersonView personView)
        {
            this.personView = personView;
          
            InitializeComponent();
        }
        
        private void PersonAddForm_Load(object sender, EventArgs e)
        {

            gridView1.PopupMenuShowing += GridView_PopupMenuShowing;
            gridView1.CellValueChanging += gridView1_CellValueChanged;

            using (var unit = new UnitOfWork())
            {

                var persontypes = new BindingList<PersonTypeView>(unit.PersonTypeApp.GetPersonTypes());



                comboBox1.DataSource = persontypes;
                comboBox1.ValueMember = "Id";
                comboBox1.DisplayMember = "Name";
            }

            if (personView != null)
            {


                using (var unit = new UnitOfWork())
                {
                    var personForEdit = unit.PersonApp.GetPerson(personView.ID);

                    comboBox1.SelectedValue = personForEdit.personType.Id;
                    NameText.Text = personForEdit.Name;
                    FamilyText.Text = personForEdit.Family;
                    NationalCodeText.Text = personForEdit.NationalCode;
                    EmailText.Text = personForEdit.Email;

                    gridControl1.DataSource = new BindingList<PhoneView>(personForEdit.Phones.ToList());
                }
            }

            else
            {
                var phones = new BindingList<PhoneView>();
                gridControl1.DataSource = phones;
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
                Phones = new List<PhoneView>()
            };

            if (gridControl1.DataSource != null)
            {
                var phoneData = gridControl1.DataSource as BindingList<PhoneView>;
                if (phoneData != null)
                {
                    personAdd.Phones = phoneData.ToList();
                }
            }
            if (personView is null)
            {

                using (var unit = new UnitOfWork())
                {
                    unit.PersonApp.PersonAdd(personAdd);
                }


            }

            else
            {
                personAdd.ID = personView.ID;

                using (var unit = new UnitOfWork())
                {
                    unit.PersonApp.PersonEdit(personAdd);
                }
            }
            this.Close();
        }

        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e != null && e.Column != null && e.Column.FieldName == "IsMain" && e.Value != null && (bool)e.Value == true)
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (i != e.RowHandle)
                    {
                        try
                        {
                            gridView1.SetRowCellValue(i, "IsMain", false);
                        }
                        catch (Exception ex)
                        {
                            // Handle the exception or log it as needed
                            Console.WriteLine($"An exception occurred: {ex.Message}");
                        }
                    }
                }
            }
        }

        private void GridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == GridMenuType.Row)
            {
                e.Menu.Items.Add(new DXMenuItem("حذف", OnDeleteRow));
            }
        }

        // رویداد برای حذف رکورد
        private void OnDeleteRow(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                if (MessageBox.Show("آیا مطمئن هستید که می‌خواهید این رکورد را حذف کنید؟", "تایید حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);
                }
            }
        }

    }
}