﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYC.DataAccess.Entities
{
    public class Category
    {
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategorySlug { get; set; }
        public string CategoryImage { get; set; }
        public List<Blog> Posts { get; set; }
    }
}
