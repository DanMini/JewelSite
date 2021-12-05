using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VipersSite.Data.Repository;

namespace VipersSite.Controllers
{
    public class EarringsController : Controller
    {
        private IRepository _repo;

        public EarringsController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index(string category)
        {
            var vm = _repo.GetAllEarrings(category);
            return View(vm);
        }

        public IActionResult Earring(int id)
        {
            var earring = _repo.GetEarring(id);
            return View(earring);
        }
    }
}