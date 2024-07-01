using Market2.Buisness_Layer.Abstract;
using Market2.Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market2.Buisness_Layer.Concrete
{
    internal class CategoryManager : ICategoryService
    {
        public List<Category> categories = new();

        public void Add(User user, Category category)
        {
            if (user.Role == "Admin" || user.Role == "Cassier")
                categories.Add(category);
        }


        public void Delete(User user, Category category)
        {
            if (user.Role == "Admin" || user.Role == "Cassier")
                categories.Remove(category);
        }


        public List<Category> GetAll(User user)
        {
            if (user.Role == "Admin" || user.Role == "Cassier" || user.Role == "Seller")
                return categories;
            else return null;
        }

        public Category GetById(User user, int id)
        {
            if (user.Role == "Admin" || user.Role == "Cassier" || user.Role == "Seller")
            {
                foreach (Category category in categories)
                {
                    if (category.Id == id)
                        return category;
                }
            }
            return null;
        }

        public void Update(User user, Category category)
        {
            if (user.Role == "Admin" || user.Role == "Cassier")
            {
                category.Name = "New name";
            }
        }
    }
}
