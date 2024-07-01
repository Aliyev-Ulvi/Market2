using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market2.Entity_Layer
{
    internal class User : BaseEntity
    {
        private static int id = 0;

        public User() { Id = id++; }

        public string FullName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }


    }
}
