using GroceryShopData.DTO;
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
        string GetAllProduct();
        string UpdateProduct(ProductDTO ProductDTO);
        void DeleteProduct(string userId);
    }
}
