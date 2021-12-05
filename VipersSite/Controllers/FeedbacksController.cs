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
    public class FeedbacksController : Controller
    {

        private IRepository _repo;

        public FeedbacksController(
            IRepository repo
            )
        {
            _repo = repo;
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
            {
                feedback.Created = DateTime.Now;
                _repo.AddFeedback(feedback);
            }
            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Message");
            else
                return View(feedback);
        }

        public IActionResult Message()
        {
            return View();
        }
    }
}
