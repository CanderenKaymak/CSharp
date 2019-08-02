﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL
{
  public  class OrderDetail:BaseEntity
    {
        public short Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public float Discount { get; set; }

        //relational properties 
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

    }
}
