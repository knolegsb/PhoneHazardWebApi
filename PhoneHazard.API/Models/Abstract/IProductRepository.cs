using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneHazard.API.Models.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts(int categoryId);
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
        Product SaveProduct(Product product);
        bool UpdateProduct(int id, Product product);
        void Delete(int id);
    }
}
