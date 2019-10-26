using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore
{
    public class BookModel
    {
        public string Title { get; set; }
        public long ISBN { get; set; }
        public decimal Price { get; set; }
        public string Edition { get; set; }
    }
}
