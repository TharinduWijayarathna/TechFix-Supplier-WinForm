using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreClient.Model
{
    internal class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; } = 0;
        public string Description { get; set; }
    }
}
