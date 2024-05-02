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
using Application.Contracts.AddressContracts;
using DevExpress.Mvvm.POCO;

// فضای‌نام‌ها
namespace Computation.UI.Forms.Person
{
    public partial class PersonAddForm : DevExpress.XtraEditors.XtraForm
    {
        private PersonView personView;

        // سازنده بدون پارامتر
        public PersonAddForm()
        {
            InitializeComponent();
        }

        // سازنده با پارامتر
        public PersonAddForm(PersonView personView)
        {
            this.personView = personView;
            InitializeComponent();
        }

        // رویداد Load فرم
        private void PersonAddForm_Load(object sender, EventArgs e)
        {
            // اتصال رویدادها
            gridView1.PopupMenuShowing += GridView_PopupMenuShowing;
            gridView1.CellValueChanging += gridView1_CellValueChanged;

            gridView2.PopupMenuShowing += GridView_PopupMenuShowing;
            gridView2.CellValueChanging += gridView2_CellValueChanged;

            // دریافت انواع شخص از دیتابیس
            using (var unit = new UnitOfWork())
            {
                var persontypes = new BindingList<PersonTypeView>(unit.PersonTypeApp.GetPersonTypes());

                comboBox1.DataSource = persontypes;
                comboBox1.ValueMember = "Id";
                comboBox1.DisplayMember = "Name";
            }

            // اگر شخص مورد نظر برای ویرایش وجود داشت
            if (personView != null)
            {
                // دریافت اطلاعات شخص از دیتابیس
                using (var unit = new UnitOfWork())
                {
                    var personForEdit = unit.PersonApp.GetPerson(personView.ID);

                    comboBox1.SelectedValue = personForEdit.personType.Id;
                    NameText.Text = personForEdit.Name;
                    FamilyText.Text = personForEdit.Family;
                    NationalCodeText.Text = personForEdit.NationalCode;
                    EmailText.Text = personForEdit.Email;

                    gridControl1.DataSource = new BindingList<PhoneView>(personForEdit.Phones.ToList());
                    gridControl2.DataSource = new BindingList<AddressView>(personForEdit.Addresses.ToList());
                }
            }
            else
            {
                var phones = new BindingList<PhoneView>();
                gridControl1.DataSource = phones;

                var address = new BindingList<AddressView>();
                gridControl2.DataSource = address;
            }
        }

        // رویداد کلیک بر روی دکمه ذخیره
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
                Phones = new List<PhoneView>(),
                Addresses = new List<AddressView>()
            };

            if (gridControl1.DataSource != null)
            {
                var phoneData = gridControl1.DataSource as BindingList<PhoneView>;
                if (phoneData != null)
                {
                    personAdd.Phones = phoneData.ToList();
                }
            }
            if (gridControl2.DataSource != null)
            {
                var addressData = gridControl2.DataSource as BindingList<AddressView>;
                if (addressData != null)
                {
                    personAdd.Addresses = addressData.ToList();
                }
            }

            if (personView is null)
            {
                // افزودن شخص جدید
                using (var unit = new UnitOfWork())
                {
                    unit.PersonApp.PersonAdd(personAdd);
                }
            }
            else
            {
                // ویرایش شخص موجود
                personAdd.ID = personView.ID;
                using (var unit = new UnitOfWork())
                {
                    unit.PersonApp.PersonEdit(personAdd);
                }
            }
            this.Close();
        }

        // رویداد تغییر مقدار در سلول‌های جدول
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

        // رویداد نمایش منوی روی گرید
        private void GridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView focusedGrid = sender as GridView;
            var a = focusedGrid.Name;
            if (e.MenuType == GridMenuType.Row & focusedGrid == gridView1)
            {
                e.Menu.Items.Add(new DXMenuItem("حذف", OnDeleteRow));
            }
            if (e.MenuType == GridMenuType.Row & focusedGrid == gridView2)
            {
                e.Menu.Items.Add(new DXMenuItem("حذف", OnDeleteRow2));
            }
        }



        // رویداد حذف رکورد
        private void OnDeleteRow(object sender, EventArgs e)
        {



            if (gridView1.FocusedRowHandle >= 0)
            {

                if (gridView1.FocusedRowHandle >= 0)
                {
                    if (MessageBox.Show("آیا مطمئن هستید که می‌خواهید این رکورد را حذف کنید؟", "تایید حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (var unit = new UnitOfWork())
                        {
                            var id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id");
                            unit.PhoneApp.DeletePhone(Convert.ToInt32(id));

                            gridView1.DeleteRow(gridView1.FocusedRowHandle);
                            unit.Save();
                        }
                    }
                }


            }

         
        }
        private void OnDeleteRow2(object sender, EventArgs e)
        {



          

            

                if (gridView2.FocusedRowHandle >= 0)
                {
                    if (MessageBox.Show("آیا مطمئن هستید که می‌خواهید این رکورد را حذف کنید22؟", "تایید حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (var unit = new UnitOfWork())
                        {
                            var id = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Id");
                            unit.AddressApp.DeleteAddress(Convert.ToInt32(id));

                            gridView2.DeleteRow(gridView2.FocusedRowHandle);
                            unit.Save();
                        }
                    }
                }
            
        }




        //Address Grid

        private void gridView2_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            {
                if (e != null && e.Column != null && e.Column.FieldName == "IsMain" && e.Value != null && (bool)e.Value == true)
                {
                    for (int i = 0; i < gridView2.RowCount; i++)
                    {
                        if (i != e.RowHandle)
                        {
                            try
                            {
                                gridView2.SetRowCellValue(i, "IsMain", false);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"An exception occurred: {ex.Message}");
                            }
                        }
                    }
                }
            }
        }
    }
}

