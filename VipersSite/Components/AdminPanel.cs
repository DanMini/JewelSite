using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VipersSite.Components
{
    public class AdminPanel : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
