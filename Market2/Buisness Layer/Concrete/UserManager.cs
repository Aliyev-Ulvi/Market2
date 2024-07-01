using Market2.Buisness_Layer.Abstract;
using Market2.Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market2.Buisness_Layer.Concrete
{
    internal class UserManager : IUserService
    {
        public List<User> users = new();

        public void Add(User user, User entityUser)
        {
            if (user.Role == "Admin")
                users.Add(entityUser);
        }

        public void Delete(User user)
        {
            users.Remove(user);
        }

        public void Delete(User user, User entityUser)
        {
            if (user.Role == "Admin")
                users.Remove(entityUser);
        }

        public List<User> GetAll(User user)
        {
            if (user.Role == "Admin")
                return users;
            else return null;
        }

        public User GetById(User user, int id)
        {
            if (user.Role == "Admin")
            {
                foreach (User entityUser in users)
                {
                    if (entityUser.Id == id)
                        return entityUser;
                }
            }
            return null;
        }

        public void Update(User user, User entityUser)
        {
            if (user.Role == "Admin")
            {
                entityUser.FullName = "New name";
                entityUser.UserName = "New name";
                entityUser.Password = "New password";
                entityUser.Role = "New role";
            }
        }
    }
}
