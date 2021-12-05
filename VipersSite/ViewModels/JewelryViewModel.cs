using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipersSite.Models;

namespace VipersSite.ViewModels
{
    public class JewelryViewModel
    {
        public string Category { get; set; }
        public IEnumerable<Jewelry> Jewelries { get; set; }
    }
}
