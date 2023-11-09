using GroceryShopCore.IServices;
using GroceryShopData.DTO;
using GroceryShopData.GSContext;
using GroceryShopDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopCore.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly GSDbContext _dbContext;

        public ProductRepository(GSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateProduct(ProductDTO ProductDTO)
        {
            var product = new Product()
            {
                Id = Guid.NewGuid().ToString(),
                Price = ProductDTO.Price,
                ProductName = ProductDTO.ProductName,   
                Quantity = ProductDTO.Quantity,
                Category = ProductDTO.Category, 
                Status = ProductDTO.Status,
                Description = ProductDTO.Description,   
                UpdatedAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
                IsDeleted = false,
            };
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        public void DeleteProduct(string userId)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.Id == userId);
            if (product != null)
            {
                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();
            }
        }

        public List<Product> GetAllProduct()
        {
            var products = _dbContext.Products.ToList();
            return products;
        }

        public string GetProductById(string Id)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.Id == Id);
            return product != null ? product.ProductName : "Product not found";
        }


        public Product UpdateProduct( string productId, ProductDTO productDTO)
        {
            var product = _dbContext.Products.FirstOrDefault(P =>P.Id == productId); 
            product.ProductName = productDTO.ProductName;
            product.Quantity = productDTO.Quantity;
            product.Category = productDTO.Category;
            product.Status = productDTO.Status;
            product.Description = productDTO.Description;
            product.UpdatedAt = DateTime.UtcNow;
            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
            return product;


        }
    }
}
