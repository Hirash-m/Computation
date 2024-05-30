using Infrastructure.IRepository;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class InventoryTranRepository : BaseRepository<InventoryTransaction, int>, IInventoryTranRepository
    {
        private readonly ComputationContext ctx;

        public InventoryTranRepository(ComputationContext ctx) : base(ctx)
        {
            this.ctx = ctx;
        }

        public List<InventoryTransaction> GetInventoryTrans(int skip, int row, int inventoryId)
        {
            return ctx.InventoryTransactions.AsNoTracking().Where(p=>p.InventoryId == inventoryId)
                            .OrderBy(p => p.Id)
                            .Skip(skip)
                            .Take(row)
                            .ToList();
        }
    }
}
