using Infrastructure.IRepository;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class InventoryRepository : BaseRepository<Inventory ,short> , IInventoryRepository
    {
        private readonly ComputationContext ctx;

        public InventoryRepository(ComputationContext ctx) : base(ctx)
        {
            this.ctx = ctx;
        }
    }
}
