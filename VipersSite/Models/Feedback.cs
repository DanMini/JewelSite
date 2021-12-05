using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VipersSite.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Time { get; set; } = "";
        public string Telephone { get; set; } = "";
        public string Comment { get; set; } = "";
        public string Status { get; set; } = "Новая заявка";
        public DateTime Created { get; set; }
    }
}
