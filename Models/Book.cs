using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_W04_CodeFirst.Models
{
    public class Book
    {
        public int id { get; set; }
        public String name { get; set; }
        public virtual Publisher Publisher { get; set; }

    }
}