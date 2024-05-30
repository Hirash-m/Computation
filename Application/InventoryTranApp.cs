using Application.Contracts.Inventory;
using Application.Contracts.InventoryTranContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.App;

namespace Application
{
    public class InventoryTranApp : IInventoryTranApp
    {
        public OperationResult AddInvenroeyTran(InventoryTranView inventoryTran)
        {
            throw new NotImplementedException();
        }

        public OperationResult DeleteInvenroeyTran(int id)
        {
            throw new NotImplementedException();
        }

        public OperationResult EditInvenroeyTran(InventoryTranView inventoryTran)
        {
            throw new NotImplementedException();
        }

        public InventoryTranView GetInvenroeyTran(int id)
        {
            throw new NotImplementedException();
        }

        public int GetInvenroeyTranCount()
        {
            throw new NotImplementedException();
        }

        public List<InventoryView> InventoryTrans(int skip, int rows, int inventoryId)
        {
            throw new NotImplementedException();
        }
    }
}
