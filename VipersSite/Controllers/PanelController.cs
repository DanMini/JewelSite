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

        // Ювелирные украшения

        public IActionResult Jewelries()
        {
            var jewelries = _repo.GetAllJewelries();
            return View(jewelries);
        }

        [HttpGet]
        public IActionResult EditJewelry(int? id)
        {
            var categories = _repo.GetAllCategories();
            ViewBag.Jewelries = new SelectList(categories, "Name", "Name");
            if (id == null)
                return View(new Jewelry());
            else
            {
                var jewelry = _repo.GetJewelry((int)id);
                return View(jewelry);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditJewelry(Jewelry jewelry)
        {
            if (jewelry.Id == 0)
            {
                _repo.AddJewelry(jewelry);
            }
            else
                _repo.UpdateJewelry(jewelry);
            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Jewelries");
            else
                return View(jewelry);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveJewelry(int id)
        {
            _repo.RemoveJewelry(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Jewelries");
        }

        // Управление "Категории"

        public IActionResult Categories()
        {
            var categories = _repo.GetAllCategories();
            return View(categories);
        }

        [HttpGet]
        public IActionResult EditCategory(int? id)
        {
            if (id == null)
                return View(new Category());
            else
            {
                var category = _repo.GetCategory((int)id);
                return View(category);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditCategory(Category category)
        {
            if (category.Id == 0)
                _repo.AddCategory(category);
            else
                _repo.UpdateCategory(category);
            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Categories");
            else
                return View(category);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveCategory(int id)
        {
            _repo.RemoveCategory(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Categories");
        }

    }
}
