﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApiPrac.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(30), Required]
        public string Name { get; set; }


        public Customer() { }
    }
}
