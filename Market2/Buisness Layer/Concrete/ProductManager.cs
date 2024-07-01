using Market2.Buisness_Layer.Abstract;
using Market2.Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market2.Buisness_Layer.Concrete
{
    internal class ProductManager : IProductService
    {
        public List<Product> products = new List<Product>();
        public List<Product> selledProducts = new List<Product>();
      

        public void Add(User user, Product product)
        {
            if (user.Role == "Admin" || user.Role == "Cassier")
                products.Add(product);
        }

        public void Update(User user, Product product)
        {
            if (user.Role == "Admin" || user.Role == "Cassier")
            {
                product.Name = "New name";
                product.Price = 0;
                product.CategoryId = 1;
            }
            
        }

        public void Delete(User user, Product product)
        {
            if (user.Role == "Admin" || user.Role == "Cassier")
                products.Remove(product);
        }

        public Product GetById(User user, int id)
        {
            if (user.Role == "Admin" || user.Role == "Cassier" || user.Role == "Seller")
            {
                foreach (Product product in products)
                {
                    if (product.Id == id)
                        return product;
                }
            }
            return null;
        }
        
        public List<Product> GetAll(User user)
        {
            if (user.Role == "Admin" || user.Role == "Cassier" || user.Role == "Seller")
                return products;
            else return null;
        }

        public List<Product> GetByCategory(User user,int id)
        {

            List<Product> categoryProducts = new();

            if (user.Role == "Admin" || user.Role == "Cassier" || user.Role == "Seller")
            {
                foreach (Product product in products)
                {
                    if (product.CategoryId == id)
                        categoryProducts.Add(product);
                }
                return categoryProducts;
            }
            return null;
            
        }

        public void Sell(User user, Product product)
        {
            if (user.Role == "Admin" || user.Role == "Cassier" || user.Role == "Seller")
                selledProducts.Add(product);
        }
        public void CancelSelling(User user, Product product)
        {
            if (user.Role == "Admin" || user.Role == "Cassier")
                selledProducts.Remove(product);
        }
    }
}
