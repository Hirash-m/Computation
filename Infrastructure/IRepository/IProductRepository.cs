using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.IRepository
{
    public interface IProductRepository : IRepository<Product, int>
    {
        public List<Product> GetProducts(int skip, int row);
    }
}
