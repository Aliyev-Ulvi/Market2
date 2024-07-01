using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market2.Entity_Layer
{
    internal class Product : BaseEntity
    {
        private static int id = 0;

        public Product() { Id = id++; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int CategoryId { get; set; }
    }
}
