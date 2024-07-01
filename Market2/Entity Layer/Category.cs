using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market2.Entity_Layer
{
    internal class Category : BaseEntity
    {
        private static int id = 0;

        public Category() { Id = id++; }

        public string Name { get; set; }
    }
}
