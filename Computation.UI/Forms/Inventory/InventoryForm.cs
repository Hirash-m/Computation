using Application.Contracts.PersonType;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Application.Contracts.Inventory;
using Application.Contracts.Person;
using Application.Contracts.PhoneContracts;
using DevExpress.XtraVerticalGrid;


namespace Computation.UI.Forms.Inventory;

public partial class InventoryForm : DevExpress.XtraEditors.XtraForm
{
    public InventoryForm()
    {
        InitializeComponent();

        gridView1.MouseDown += GridView1_MouseDown; 

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
                    //// Open the edit form and pass the data of the focused row
                    //PersonTypeEditForm editForm = new PersonTypeEditForm(selectedPerson);
                    //editForm.ShowDialog(); // Show the edit form as a dialog
                }
            }
        }
    }



    private void InventoryForm_Load(object sender, EventArgs e)
    {
        using (var unit = new UnitOfWork())
        {
            var Inventorys = new BindingList<InventoryView>(unit.InventoryApp.GetInventory());

            gridControl.DataSource = Inventorys;
        }

        gridView1.Columns["Id"].OptionsColumn.AllowFocus = false;
    }



    private void AddRow_Click(object sender, EventArgs e)
    {
        
        if (gridControl.DataSource != null)
        {
            var InventoryData = gridControl.DataSource as BindingList<InventoryView>;
            if (InventoryData != null)
            {
                
                foreach (var item in InventoryData)
                {
                    using (var unit = new UnitOfWork())
                    {
                        if (item.Id == 0)
                    {
                       
                            unit.InventoryApp.InventoryAdd(item);
                            unit.Save();
                       
                    }
                    if (item.Id != 0)
                    {
                            unit.InventoryApp.InventoryEdit(item);
                    }
                    }
                }
                InventoryForm_Load(sender, e);
            }
        }
    }

    private void DeleteRow_Click(object sender, EventArgs e)
    {

        if (gridView1.SelectedRowsCount > 0)
        {


            short selectedRowId = (short)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id");

            var mBox = MessageBox.Show($"از حذف رکورد با کد {selectedRowId} مطمئن هستید ؟", "اخطار", MessageBoxButtons.YesNo);

            if (mBox == DialogResult.Yes)
            {
                using (var unit = new UnitOfWork())
                {
                    unit.InventoryApp.InventoryDelete(selectedRowId);
                    unit.Save();
                }
                InventoryForm_Load(sender, e);
            }
        }
        else
        {
            MessageBox.Show(".لطفا یک ردیف را انتخاب نمایید", "اخطار");
        }
    }

  
}