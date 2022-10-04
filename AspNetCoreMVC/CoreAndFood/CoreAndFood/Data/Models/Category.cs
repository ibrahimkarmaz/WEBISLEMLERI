﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreAndFood.Data.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage ="GATEGORY NAME NOT EMPYT")]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public List<Food> Foods { get; set; }
    }
}
