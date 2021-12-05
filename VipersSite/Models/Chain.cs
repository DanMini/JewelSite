using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VipersSite.Models
{
    public class Chain
    {
        public int Id { get; set; }
        public string VendorCode { get; set; } = "";
        public string Name { get; set; } = "";
        public string Info { get; set; } = "";
        public string ChainCategory { get; set; } = "";
        public int Price { get; set; }
        public string Availability { get; set; } = "";
    }
}
