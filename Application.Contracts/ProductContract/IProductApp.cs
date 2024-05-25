using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.App;

namespace Application.Contracts.ProductContract
{
    public interface IProductApp
    {
        List<ProductView> GetProducts(int skip, int row);
        OperationResult AddProduct(ProductView command);
        ProductView GetProduct(int productId);
        OperationResult DeleteProduct(int productId);
        OperationResult ProductEdit(ProductView command);

    }
    public class ProductView
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public bool IsService { get; set; }= false;

        public decimal UnitPrice { get; set; }

        public DateTime LastPriceUpdate { get; set; } = DateTime.Now;

        public bool SaleAble { get; set; }=true;

        public byte UnitId { get; set; } = 0;

    }
}
