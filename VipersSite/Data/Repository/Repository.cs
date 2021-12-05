using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipersSite.Models;
using VipersSite.ViewModels;

namespace VipersSite.Data.Repository
{
    public class Repository : IRepository
    {
        private AppDbContext _ctx;

        public Repository(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        // Раздел "О нас"

        public Abo GetAbo(int id)
        {
            return _ctx.About.FirstOrDefault(p => p.Id == id);
        }

        public List<Abo> GetAllAbout()
        {
            return _ctx.About.ToList();
        }

        public void AddAbo(Abo abo)
        {
            _ctx.About.Add(abo);
        }

        public void UpdateAbo(Abo abo)
        {
            _ctx.About.Update(abo);
        }

        public void RemoveAbo(int id)
        {
            _ctx.About.Remove(GetAbo(id));
        }

        // Раздел "Обратный звонок"

        public Feedback GetFeedback(int id)
        {
            return _ctx.Feedbacks.FirstOrDefault(p => p.Id == id);
        }

        public List<Feedback> GetAllFeedbacks()
        {
           return _ctx.Feedbacks.OrderBy(feedback => feedback.Status).ThenByDescending(feedback => feedback.Created).ToList();
        }

        public void AddFeedback(Feedback feedback)
        {
            _ctx.Feedbacks.Add(feedback);
        }

        public void UpdateFeedback(Feedback feedback)
        {
            _ctx.Feedbacks.Update(feedback);
        }

        public void RemoveFeedback(int id)
        {
            _ctx.Feedbacks.Remove(GetFeedback(id));
        }

        // Раздел "Категории"


        public Category GetCategory(int id)
        {
            return _ctx.Categories.FirstOrDefault(c => c.Id == id);
        }

        public List<Category> GetAllCategories()
        {
            return _ctx.Categories.ToList();
        }

        public void AddCategory(Category category)
        {
            _ctx.Categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            _ctx.Categories.Update(category);
        }

        public void RemoveCategory(int id)
        {
            _ctx.Categories.Remove(GetCategory(id));
        }

        // Раздел "Товары"

        public Jewelry GetJewelry(int id)
        {
            return _ctx.Jewelries.FirstOrDefault(g => g.Id == id);
        }

        public List<Jewelry> GetAllJewelries()
        {
            return _ctx.Jewelries.OrderBy(jewelry => jewelry.Category).ThenBy(jewelry => jewelry.Name).ToList();
        }

        public JewelryViewModel GetAllJewelries(string category)
        {
            Func<Jewelry, bool> InCategory = (jewelry) =>
            {
                return jewelry.Category.ToLower().Equals(category.ToLower());
            };

            var query = _ctx.Jewelries.AsQueryable();

            if (!String.IsNullOrEmpty(category))
                query = query.Where(x => InCategory(x));

            return new JewelryViewModel
            {
                Category = category,
                Jewelries = query.OrderBy(jewelry => jewelry.Availability).ThenBy(jewelry => jewelry.Price).ToList()
            };
        }

        public void AddJewelry(Jewelry jewelry)
        {
            _ctx.Jewelries.Add(jewelry);
        }

        public void UpdateJewelry(Jewelry jewelry)
        {
            _ctx.Jewelries.Update(jewelry);
        }

        public void RemoveJewelry(int id)
        {
            _ctx.Jewelries.Remove(GetJewelry(id));
        }

        // прочее 
        public async Task<bool> SaveChangesAsync()
        {
            if (await _ctx.SaveChangesAsync() > 0)
            {
                return true;
            }

            return false;
        }
    }
}
