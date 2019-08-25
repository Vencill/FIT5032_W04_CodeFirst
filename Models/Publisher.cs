using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_W04_CodeFirst.Models
{
    public class Publisher
    {
        public int id { get; set; }
        public String pubName { get; set; }
        public List<Book> Books { get; set; }
    }
}