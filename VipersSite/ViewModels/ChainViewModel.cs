using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipersSite.Models;

namespace VipersSite.ViewModels
{
    public class ChainViewModel
    {
        public string Category { get; set; }
        public IEnumerable<Chain> Chains { get; set; }
    }
}
