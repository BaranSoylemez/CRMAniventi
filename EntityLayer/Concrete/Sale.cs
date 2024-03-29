﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Sale
    {
        [Key]
        public int SaleID { get; set; }
        public int QuoteID { get; set; }
        public virtual Quote Quote { get; set; }

        [StringLength(10)]
        public string SaleDate { get; set; }
    }
}
