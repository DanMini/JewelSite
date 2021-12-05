using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipersSite.Models;

namespace VipersSite.ViewModels
{
    public class BraceletViewModel
    {
        public string Category { get; set; }
        public IEnumerable<Bracelet> Bracelets { get; set; }
    }
}
