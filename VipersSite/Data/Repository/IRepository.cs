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

        Bracelet GetBracelet(int id);
        List<Bracelet> GetAllBracelets();
        BraceletViewModel GetAllBracelets(string category);
        void AddBracelet(Bracelet bracelet);
        void UpdateBracelet(Bracelet bracelet);
        void RemoveBracelet(int id);

        Chain GetChain(int id);
        List<Chain> GetAllChains();
        ChainViewModel GetAllChains(string category);
        void AddChain(Chain chain);
        void UpdateChain(Chain chain);
        void RemoveChain(int id);

        Earring GetEarring(int id);
        List<Earring> GetAllEarrings();
        EarringViewModel GetAllEarrings(string category);
        void AddEarring(Earring earring);
        void UpdateEarring(Earring earring);
        void RemoveEarring(int id);
        
        Ring GetRing(int id);
        List<Ring> GetAllRings();
        RingViewModel GetAllRings(string category);
        void AddRing(Ring ring);
        void UpdateRing(Ring ring);
        void RemoveRing(int id);

        BraceletCategory GetBraceletCategory(int id);
        List<BraceletCategory> GetAllBraceletCategories();
        void AddBraceletCategory(BraceletCategory braceletCategory);
        void UpdateBraceletCategory(BraceletCategory braceletCategory);
        void RemoveBraceletCategory(int id);

        ChainCategory GetChainCategory(int id);
        List<ChainCategory> GetAllChainCategories();
        void AddChainCategory(ChainCategory ChainCategory);
        void UpdateChainCategory(ChainCategory ChainCategory);
        void RemoveChainCategory(int id);

        EarringCategory GetEarringCategory(int id);
        List<EarringCategory> GetAllEarringCategories();
        void AddEarringCategory(EarringCategory earringCategory);
        void UpdateEarringCategory(EarringCategory earringCategory);
        void RemoveEarringCategory(int id);
        
        RingCategory GetRingCategory(int id);
        List<RingCategory> GetAllRingCategories();
        void AddRingCategory(RingCategory ringcategory);
        void UpdateRingCategory(RingCategory ringcategory);
        void RemoveRingCategory(int id);      

        Feedback GetFeedback(int id);
        List<Feedback> GetAllFeedbacks();
        void AddFeedback(Feedback feedback);
        void UpdateFeedback(Feedback feedback);
        void RemoveFeedback(int id);

        Task<bool> SaveChangesAsync();
    }
}
