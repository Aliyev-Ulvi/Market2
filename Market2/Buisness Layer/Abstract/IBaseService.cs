using Market2.Entity_Layer;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market2.Buisness_Layer.Abstract
{
    internal interface IBaseService<T>
    {
        void Add(User user, T entity);

        void Update(User user, T entity);

        void Delete(User user, T entity);

        T GetById(User user, int id);

        List<T> GetAll(User user);


    }
}
