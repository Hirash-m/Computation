using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.IRepository
{
    public interface IInventoryTranRepository : IRepository <InventoryTransaction,int>
    {
        List<InventoryTransaction> GetInventoryTrans(int skip,int row,int inventoryId);
    }
}
