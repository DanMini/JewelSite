using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VipersSite.Data.Repository;

namespace VipersSite.Controllers
{
    public class BraceletsController : Controller
    {
        private IRepository _repo;

        public BraceletsController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index(string category)
        {
            var vm = _repo.GetAllJewelries(category);
            return View(vm);
        }

        public IActionResult Jewelry(int id)
        {
            var jewelry = _repo.GetJewelry(id);
            return View(jewelry);
        }
    }
}