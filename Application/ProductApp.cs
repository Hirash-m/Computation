using Application.Contracts.Person;
using Application.Contracts.ProductContract;
using Azure;
using Infrastructure.IRepository;
using Infrastructure.Models;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.App;

namespace Application
{
    public class ProductApp : IProductApp
    {



        private readonly IProductRepository _productRepository;

        public ProductApp(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<ProductView> GetProducts(int skip, int row)
        {
            
            var products = _productRepository.GetProducts(skip, row);
            List<ProductView> productViews = new List<ProductView>();

            foreach (var Product in products)
            {
                ProductView productView = new ProductView
                {
                  Id = Product.Id,
                  Name = Product.Name,
                    IsService=Product.IsService,
                    UnitPrice=Product.UnitPrice,
                    LastPriceUpdate=Product.LastPriceUpdate,
                    SaleAble=Product.SaleAble,
                    UnitId=Product.UnitId


                };

                productViews.Add(productView);
            }

            return productViews;
        }

        OperationResult IProductApp.AddProduct(ProductView command)
        {
            var operation = new OperationResult();
            var product = new Product()
            {
                Name = command.Name,
                IsService = command.IsService,
                UnitPrice = command.UnitPrice,
                SaleAble = command.SaleAble,
                UnitId = command.UnitId,
                LastPriceUpdate = command.LastPriceUpdate,

            };
            _productRepository.Create(product);
            _productRepository.SaveChanges();
            return operation.Succeeded();
        }
    }
}
