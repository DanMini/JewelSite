using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipersSite.Data.Repository;

namespace VipersSite.Controllers
{
    public class AboutController : Controller
    {
        private IRepository _repo;

        public AboutController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var about = _repo.GetAllAbout();
            return View(about);
        }
    }
}
