﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreClient.Model
{
    internal class QuotationItem
    {
        public int Id { get; set; }
        public int QuotationId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 0;
        public string Description { get; set; }
    }
}
