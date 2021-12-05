using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VipersSite.Data.Repository;

namespace VipersSite.Controllers
{
    public class RingsController : Controller
    {
        private IRepository _repo;

        public RingsController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index(string category)
        {
            var vm = _repo.GetAllRings(category);
            return View(vm);
        }

        public IActionResult Ring(int id)
        {
            var ring = _repo.GetRing(id);
            return View(ring);
        }
    }
}