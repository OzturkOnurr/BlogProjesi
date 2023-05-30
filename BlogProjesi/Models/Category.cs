﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogProjesi.Models
{
    public class Category
    {
        
        public int Id { get; set; }
        public string KategoriAdi  { get; set; }
        public List<Blog> Bloglar { get; set; }

    }
}