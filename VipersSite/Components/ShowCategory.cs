using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VipersSite.Components
{
    public class ShowCategory : ViewComponent
    {
        private readonly VipersSite.Data.AppDbContext _db;

        public ShowCategory(VipersSite.Data.AppDbContext context)
        {
            _db = context;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _db.Categories.ToList();
            return View(categories);
        }
    }
}
