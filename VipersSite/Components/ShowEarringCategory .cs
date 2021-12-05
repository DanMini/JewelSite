using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VipersSite.Components
{
    public class ShowEarringCategory : ViewComponent
    {
        private readonly VipersSite.Data.AppDbContext _db;

        public ShowEarringCategory(VipersSite.Data.AppDbContext context)
        {
            _db = context;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _db.EarringCategories.ToList();
            return View(categories);
        }
    }
}
