using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VipersSite.Models
{
    public class Earring
    {
        public int Id { get; set; }
        public string VendorCode { get; set; } = "";
        public string Name { get; set; } = "";
        public string Info { get; set; } = "";
        public string EarringCategory { get; set; } = "";
        public int Price { get; set; }
        public string Availability { get; set; } = "";
    }
}
