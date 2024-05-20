using Application.Contracts.ProductContract;
using DevExpress.CodeParser;
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

namespace Computation.UI.Forms.Inventory
{
    public partial class ProductEditForm : DevExpress.XtraEditors.XtraForm
    {
        public ProductEditForm()
        {
            InitializeComponent();
        }

        private void ProductEditForm_Load(object sender, EventArgs e)
        {

        }



        private void SaveBTN_Click(object sender, EventArgs e)
        {
            var unitId = new byte();

            if (comboBoxUnitType.SelectedIndex > 10)
            {
                unitId = 0;

            }
            else
            {
                unitId = (byte)comboBoxUnitType.SelectedIndex;
            }
            var newProduct = new ProductView()
            {
                Name = ProductNameTBOX.Text,
                IsService = IsServiceCBOX.Checked,
                SaleAble = SaleAbleCBOX.Checked,
                UnitId = unitId

            };
            string inputText = UnitPriceTBOX.Text;


            if (decimal.TryParse(inputText, out decimal unitPrice))
            {
                // در اینجا می‌توانید از متغیر unitPrice که اکنون نوع decimal استفاده کنید
                // مثلا:
                newProduct.UnitPrice = unitPrice;
            }
            else
            {
                newProduct.UnitPrice = 0;


            }

            using (var unit = new UnitOfWork())
            {
                unit.ProductApp.AddProduct(newProduct);
            }
        }


        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // اگر کاربر عدد یا کلیدهای کنترلی (مثل کلید Backspace) را فشرده کرد
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // عدد نیست، پس رویداد را متوقف کن و وارد کردن آن را ممنوع کن
                e.Handled = true;
            }
        }
    }
}