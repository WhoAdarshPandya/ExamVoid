using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamVoid.Models
{
    public class Food
    {
        public int id { get; set; }

        public string name { get; set; }

        public string category { get; set; }

        public string price { get; set; }

        public string avail { get; set; }
    }
}