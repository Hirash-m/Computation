using Application.Contracts.Person;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Computation.UI.MainData.Person;
using DevExpress.XtraTab;
using DevExpress.XtraGrid;
using Utility.App;
using Computation.UI.Forms.Person;
using Application.Contracts.ProductContract;

namespace Computation.UI.Forms.Inventory
{
    public partial class InventoryTransacrionForm : DevExpress.XtraEditors.XtraForm
    {
        
       
            private int _pageSize = 50;
            public Pagination pagination = new Pagination();


            public InventoryTransacrionForm()
            {
                InitializeComponent();
                gridView1.DoubleClick += GridView1_DoubleClick;
                LoadData(); // Load the first page on initial load
            }

            private void GridView1_DoubleClick(object sender, EventArgs e)
            {
                GridView view = sender as GridView;

                if (view != null)
                {
                    GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

                    if (hitInfo.InRow)
                    {
                        view.FocusedRowHandle = hitInfo.RowHandle;

                        ProductView selectedProduct = view.GetRow(hitInfo.RowHandle) as ProductView;

                        if (selectedProduct != null)
                        {
                            ProductEditForm form = new ProductEditForm(selectedProduct);
                            if (this.Parent != null) form.MdiParent = this.ParentForm;
                            form.FormClosed += ChildForm_FormClosed;
                            form.Show();
                        }
                    }
                }
            }

            private void PersonsForm_Load(object sender, EventArgs e)
            {
                LoadData();
            }

            private void AddFormShow_Click(object sender, EventArgs e)
            {
                ProductEditForm form = new ProductEditForm();
                if (this.Parent != null) form.MdiParent = this.ParentForm;
                form.FormClosed += ChildForm_FormClosed;
                form.Show();
            }

            private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
            {
                LoadData();
            }

            private void DeleteSelectedRecords()
            {
                int[] selectedRows = gridView1.GetSelectedRows();

                if (selectedRows.Length > 0)
                {
                    if (MessageBox.Show("Are you sure you want to delete the selected records?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        List<ProductView> selectedProducts = new List<ProductView>();
                        using (var unit = new UnitOfWork())
                        {
                            foreach (int rowHandle in selectedRows)
                            {
                                ProductView selectedProduct = gridView1.GetRow(rowHandle) as ProductView;

                                if (selectedProduct != null)
                                {
                                    var id = selectedProduct.Id;
                                    unit.ProductApp.DeleteProduct(id);
                                    unit.Save();
                                }
                            }
                        }
                        LoadData(); // Reload data after deletion
                    }
                }
            }

            private void LoadData()
            {


                int skip = (_pageSize * pagination.PageIndex) - _pageSize;

                using (var unit = new UnitOfWork())
                {
                    pagination.TotalCount = unit.PersonApp.PersonCount();

                    BindingList<ProductView> products = new BindingList<ProductView>(unit.ProductApp.GetProducts(pagination.Skip(), pagination.DataRow));
                    int totalCount = unit.PersonApp.PersonCount();
                    CountDataLBL.Text = totalCount.ToString();
                    gridControl1.DataSource = products;
                    gridView1.RefreshData();
                }
                CountDataLBL.Text = pagination.TotalCount.ToString();
                PageLBL.Text = pagination.PageIndex.ToString() + " / " + pagination.CalculatePageCount().ToString();
            }

            private void simpleButton1_Click(object sender, EventArgs e)
            {
                DeleteSelectedRecords();
            }

            private void addedByExcelBTN_Click(object sender, EventArgs e)
            {
                XtraForm xtraForm = new XtraForm();
                if (this.ParentForm != null)
                {
                    xtraForm.MdiParent = this.ParentForm;
                }
                xtraForm.Show();
            }

            private void PageNextBTN_Click(object sender, EventArgs e)
            {
                if (pagination.PageIndex != pagination.CalculatePageCount())
                {
                    pagination.PageIndex = pagination.PageIndex + 1;
                    LoadData();

                }
            }

            private void PageBeforeBTN_Click(object sender, EventArgs e)
            {
                if (pagination.PageIndex != 1)
                {
                    pagination.PageIndex = pagination.PageIndex - 1;
                    LoadData();

                }

            }

        
    }
}