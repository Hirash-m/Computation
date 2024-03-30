using Infrastructure.IRepository;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class AddressRepositpry : BaseRepository<Address, int>, IAddressRepository
    {
        private readonly ComputationContext ctx;

        public AddressRepositpry(ComputationContext ctx) : base(ctx)
        {
            this.ctx = ctx;
        }

       
    }
}
