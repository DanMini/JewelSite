using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipersSite.Models;
using VipersSite.ViewModels;

namespace VipersSite.Data.Repository
{
    public interface IRepository
    {
        Abo GetAbo(int id);
        List<Abo> GetAllAbout();
        void AddAbo(Abo abo);
        void UpdateAbo(Abo abo);
        void RemoveAbo(int id);

        Feedback GetFeedback(int id);
        List<Feedback> GetAllFeedbacks();
        void AddFeedback(Feedback feedback);
        void UpdateFeedback(Feedback feedback);
        void RemoveFeedback(int id);

        Jewelry GetJewelry(int id);
        List<Jewelry> GetAllJewelries();
        JewelryViewModel GetAllJewelries(string category);
        void AddJewelry(Jewelry jewelry);
        void UpdateJewelry(Jewelry jewelry);
        void RemoveJewelry(int id);

        Category GetCategory(int id);
        List<Category> GetAllCategories();
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void RemoveCategory(int id);

        Task<bool> SaveChangesAsync();
    }
}
