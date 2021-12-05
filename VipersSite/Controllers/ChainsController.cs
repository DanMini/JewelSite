using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VipersSite.Data.Repository;

namespace VipersSite.Controllers
{
    public class ChainsController : Controller
    {
        private IRepository _repo;

        public ChainsController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index(string category)
        {
            var vm = _repo.GetAllChains(category);
            return View(vm);
        }

        public IActionResult Chain(int id)
        {
            var chain = _repo.GetChain(id);
            return View(chain);
        }
    }
}