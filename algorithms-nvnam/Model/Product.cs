using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_nvnam
{
    class Product
    {
        public string name { get; set; }
        public int price { get; set; }
        public int quality { get; set; }
        public int categoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
