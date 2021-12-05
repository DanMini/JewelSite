using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VipersSite.Components
{
    public class ShowRingCategory : ViewComponent
    {
        private readonly VipersSite.Data.AppDbContext _db;

        public ShowRingCategory(VipersSite.Data.AppDbContext context)
        {
            _db = context;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _db.RingCategories.ToList();
            return View(categories);
        }
    }
}