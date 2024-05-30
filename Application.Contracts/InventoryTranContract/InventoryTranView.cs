using Application.Contracts.Inventory;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.App;

namespace Application.Contracts.InventoryTranContract
{
    public class InventoryTranView
    {
        public int Id { get; set; }

        public DateOnly CreateDate { get; set; }

        public DateOnly AcceptDate { get; set; }

        public string? Number { get; set; }

        public List<InventoryTranDetailView> inventoryTranDetailViews { get; set; }

    }
    public class InventoryTranDetailView
    {
        public int Id { get; set; }

        public int InventoryTransactionId { get; set; }

        public int ProductId { get; set; }

        public decimal Amount { get; set; }

        public decimal? UnitPrice { get; set; }

        public virtual InventoryTransaction IdNavigation { get; set; } = null!;

        public virtual Product Product { get; set; } = null!;
    }
    public interface IInventoryTranApp
    {
        List<InventoryView> InventoryTrans(int skip, int rows,int inventoryId);
        OperationResult AddInvenroeyTran(InventoryTranView inventoryTran);
        OperationResult EditInvenroeyTran(InventoryTranView inventoryTran);
        InventoryTranView GetInvenroeyTran(int id);
        OperationResult DeleteInvenroeyTran(int id);
        int GetInvenroeyTranCount();
    }

}
