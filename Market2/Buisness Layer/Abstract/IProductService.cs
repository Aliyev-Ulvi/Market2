using Market2.Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market2.Buisness_Layer.Abstract
{
    internal interface IProductService : IBaseService<Product>
    {
        void Sell(User user, Product product);

        void CancelSelling(User user, Product product);

        List<Product> GetByCategory(User user, int id);
     
    }
}
