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
    public class ProductRepository : BaseRepository<Product, int>, IProductRepository
    {
        private readonly ComputationContext ctx;


        public ProductRepository(ComputationContext context) : base(context)
        {
            this.ctx = context;
        }

        public List<Product> GetProducts(int skip, int row)
        {
            return ctx.Products.AsNoTracking().OrderBy(p => p.Id)
                             .Skip(skip)
                             .Take(row)
                             .ToList();
        }
       

    }
}
