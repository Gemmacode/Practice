using GroceryShopData.DTO;
using GroceryShopDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopCore.IServices
{
    public interface IProductRepository
    {
        void CreateProduct(ProductDTO ProductDTO);
        string GetProductById(string Id);
        List<Product> GetAllProduct();
        Product UpdateProduct(string productId, ProductDTO ProductDTO);
        void DeleteProduct(string userId);
    }
}
