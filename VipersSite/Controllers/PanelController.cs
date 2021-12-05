using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipersSite.Data.Repository;
using VipersSite.Models;
using VipersSite.ViewModels;

namespace VipersSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PanelController : Controller
    {

        private IRepository _repo;

        public PanelController(
            IRepository repo
            )
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }


        // Управление "О нас"

        public IActionResult About()
        {
            var about = _repo.GetAllAbout();
            return View(about);
        }


        [HttpGet]
        public IActionResult AboutEdit(int? id)
        {
            if (id == null)
                return View(new Abo());
            else
            {
                var abo = _repo.GetAbo((int)id);
                return View(abo);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AboutEdit(Abo abo)
        {
            if (abo.Id > 0)
                _repo.UpdateAbo(abo);
            else
                _repo.AddAbo(abo);
            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Index");
            else
                return View(abo);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveAbout(int id)
        {

            _repo.RemoveAbo(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // Управление "Звонки"

        public IActionResult Feedbacks()
        {
            var feedbacks = _repo.GetAllFeedbacks();
            return View(feedbacks);
        }

        [HttpGet]
        public IActionResult EditFeedback(int? id)
        {
            if (id == null)
                return View(new Feedback());
            else
            {
                var feedback = _repo.GetFeedback((int)id);
                return View(feedback);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditFeedback(Feedback feedback)
        {
            if (feedback.Id > 0)
                _repo.UpdateFeedback(feedback);
            else
                _repo.AddFeedback(feedback);
            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Feedbacks");
            else
                return View(feedback);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveFeedback(int id)
        {

            _repo.RemoveFeedback(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Feedbacks");
        }

        // Управление "Браслеты"

        public IActionResult Bracelets()
        {
            var bracelets = _repo.GetAllBracelets();
            return View(bracelets);
        }

        [HttpGet]
        public IActionResult EditBracelet(int? id)
        {
            var categories = _repo.GetAllBraceletCategories();
            ViewBag.Bracelets = new SelectList(categories, "Name", "Name");
            if (id == null)
                return View(new Bracelet());
            else
            {
                var bracelet = _repo.GetBracelet((int)id);
                return View(bracelet);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditBracelet(Bracelet bracelet)
        {
            if (bracelet.Id == 0)
            {
                _repo.AddBracelet(bracelet);
            }
            else
                _repo.UpdateBracelet(bracelet);
            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Bracelets");
            else
                return View(bracelet);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveBracelet(int id)
        {
            _repo.RemoveBracelet(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Bracelets");
        }

        // Управление "Категория браслетов"

        public IActionResult BraceletCategories()
        {
            var braceletCategories = _repo.GetAllBraceletCategories();
            return View(braceletCategories);
        }

        [HttpGet]
        public IActionResult EditBraceletCategory(int? id)
        {
            if (id == null)
                return View(new BraceletCategory());
            else
            {
                var braceletCategory = _repo.GetBraceletCategory((int)id);
                return View(braceletCategory);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditBraceletCategory(BraceletCategory braceletCategory)
        {
            if (braceletCategory.Id == 0)
                _repo.AddBraceletCategory(braceletCategory);
            else
                _repo.UpdateBraceletCategory(braceletCategory);
            if (await _repo.SaveChangesAsync())
                return RedirectToAction("BraceletCategories");
            else
                return View(braceletCategory);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveBraceletCategory(int id)
        {
            _repo.RemoveBraceletCategory(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("BraceletCategories");
        }

        // Управление "Цепи" 

        public IActionResult Chains()
        {
            var chains = _repo.GetAllChains();
            return View(chains);
        }

        [HttpGet]
        public IActionResult EditChain(int? id)
        {
            var categories = _repo.GetAllChainCategories();
            ViewBag.Chains = new SelectList(categories, "Name", "Name");
            if (id == null)
                return View(new Chain());
            else
            {
                var сhain = _repo.GetChain((int)id);
                return View(сhain);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditChain(Chain chain)
        {
            if (chain.Id == 0)
            {
                _repo.AddChain(chain);
            }
            else
                _repo.UpdateChain(chain);
            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Chains");
            else
                return View(chain);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveChain(int id)
        {
            _repo.RemoveChain(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Chains");
        }

        // Управление "Категория серьг"

        public IActionResult ChainCategories()
        {
            var chainCategories = _repo.GetAllChainCategories();
            return View(chainCategories);
        }

        [HttpGet]
        public IActionResult EditChainCategory(int? id)
        {
            if (id == null)
                return View(new ChainCategory());
            else
            {
                var chainCategory = _repo.GetChainCategory((int)id);
                return View(chainCategory);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditChainCategory(ChainCategory chainCategory)
        {
            if (chainCategory.Id == 0)
                _repo.AddChainCategory(chainCategory);
            else
                _repo.UpdateChainCategory(chainCategory);
            if (await _repo.SaveChangesAsync())
                return RedirectToAction("ChainCategories");
            else
                return View(chainCategory);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveChainCategory(int id)
        {
            _repo.RemoveChainCategory(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("ChainCategories");
        }

        // Управление "Серьги"

        public IActionResult Earrings()
        {
            var earrings = _repo.GetAllEarrings();
            return View(earrings);
        }

        [HttpGet]
        public IActionResult EditEarring(int? id)
        {
            var categories = _repo.GetAllEarringCategories();
            ViewBag.Earrings = new SelectList(categories, "Name", "Name");
            if (id == null)
                return View(new Earring());
            else
            {
                var earring = _repo.GetEarring((int)id);
                return View(earring);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditEarring(Earring earring)
        {
            if (earring.Id == 0)
            {
                _repo.AddEarring(earring);
            }
            else
                _repo.UpdateEarring(earring);
            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Earrings");
            else
                return View(earring);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveEarring(int id)
        {
            _repo.RemoveEarring(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Earrings");
        }

        // Управление "Категории серьг"

        public IActionResult EarringCategories()
        {
            var earringCategories = _repo.GetAllEarringCategories();
            return View(earringCategories);
        }

        [HttpGet]
        public IActionResult EditEarringCategory(int? id)
        {
            if (id == null)
                return View(new EarringCategory());
            else
            {
                var earringCategory = _repo.GetEarringCategory((int)id);
                return View(earringCategory);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditEarringCategory(EarringCategory earringCategory)
        {
            if (earringCategory.Id == 0)
                _repo.AddEarringCategory(earringCategory);
            else
                _repo.UpdateEarringCategory(earringCategory);
            if (await _repo.SaveChangesAsync())
                return RedirectToAction("EarringCategories");
            else
                return View(earringCategory);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveEarringCategory(int id)
        {
            _repo.RemoveEarringCategory(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("EarringCategories");
        }

        // Управление "Кольца"

        public IActionResult Rings()
        {
            var rings = _repo.GetAllRings();
            return View(rings);
        }


        [HttpGet]
        public IActionResult EditRing(int? id)
        {
            var categories = _repo.GetAllRingCategories();
            ViewBag.Rings = new SelectList(categories, "Name", "Name");
            if (id == null)
                return View(new Ring());
            else
            {
                var ring = _repo.GetRing((int)id);
                return View(ring);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditRing(Ring ring)
        {
            if (ring.Id == 0)
            {
                _repo.AddRing(ring);
            }
            else
                _repo.UpdateRing(ring);
            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Rings");
            else
                return View(ring);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveRing(int id)
        {
            _repo.RemoveRing(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Rings");
        }

        // Управление "Категории колец"

        public IActionResult RingCategories()
        {
            var ringCategories = _repo.GetAllRingCategories();
            return View(ringCategories);
        }

        [HttpGet]
        public IActionResult EditRingCategory(int? id)
        {
            if (id == null)
                return View(new RingCategory());
            else
            {
                var ringCategory = _repo.GetRingCategory((int)id);
                return View(ringCategory);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditRingCategory(RingCategory ringCategory)
        {
            if (ringCategory.Id == 0)
                _repo.AddRingCategory(ringCategory);
            else
                _repo.UpdateRingCategory(ringCategory);
            if (await _repo.SaveChangesAsync())
                return RedirectToAction("RingCategories");
            else
                return View(ringCategory);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveRingCategory(int id)
        {
            _repo.RemoveRingCategory(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("RingCategories");
        }

        
    }
}
