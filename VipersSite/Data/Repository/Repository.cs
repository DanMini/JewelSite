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

        // Раздел "Браслеты"

        public BraceletCategory GetBraceletCategory(int id)
        {
            return _ctx.BraceletCategories.FirstOrDefault(c => c.Id == id);
        }

        public List<BraceletCategory> GetAllBraceletCategories()
        {
            return _ctx.BraceletCategories.ToList();
        }

        public void AddBraceletCategory(BraceletCategory braceletCategory)
        {
            _ctx.BraceletCategories.Add(braceletCategory);
        }

        public void UpdateBraceletCategory(BraceletCategory braceletCategory)
        {
            _ctx.BraceletCategories.Update(braceletCategory);
        }

        public void RemoveBraceletCategory(int id)
        {
            _ctx.BraceletCategories.Remove(GetBraceletCategory(id));
        }

        public Bracelet GetBracelet(int id)
        {
            return _ctx.Bracelets.FirstOrDefault(g => g.Id == id);
        }

        public List<Bracelet> GetAllBracelets()
        {
            return _ctx.Bracelets.OrderBy(bracelet => bracelet.BraceletCategory).ThenBy(bracelet => bracelet.Name).ToList();
        }

        public BraceletViewModel GetAllBracelets(string category)
        {
            Func<Bracelet, bool> InCategory = (bracelet) => 
            { 
                return bracelet.BraceletCategory.ToLower().Equals(category.ToLower()); 
            };

            var query = _ctx.Bracelets.AsQueryable();

            if (!String.IsNullOrEmpty(category))
                query = query.Where(x => InCategory(x));

            return new BraceletViewModel
            {
                Category = category,
                Bracelets = query.OrderBy(bracelet => bracelet.Availability).ThenBy(bracelet => bracelet.Price).ToList()
            };
        }

        public void AddBracelet(Bracelet bracelet)
        {
            _ctx.Bracelets.Add(bracelet);
        }

        public void UpdateBracelet(Bracelet bracelet)
        {
            _ctx.Bracelets.Update(bracelet);
        }

        public void RemoveBracelet(int id)
        {
            _ctx.Bracelets.Remove(GetBracelet(id));
        }

        // Раздел "Цепи"

        public ChainCategory GetChainCategory(int id)
        {
            return _ctx.ChainCategories.FirstOrDefault(c => c.Id == id);
        }

        public List<ChainCategory> GetAllChainCategories()
        {
            return _ctx.ChainCategories.ToList();
        }

        public void AddChainCategory(ChainCategory chainCategory)
        {
            _ctx.ChainCategories.Add(chainCategory);
        }

        public void UpdateChainCategory(ChainCategory chainCategory)
        {
            _ctx.ChainCategories.Update(chainCategory);
        }

        public void RemoveChainCategory(int id)
        {
            _ctx.ChainCategories.Remove(GetChainCategory(id));
        }

        public Chain GetChain(int id)
        {
            return _ctx.Chains.FirstOrDefault(g => g.Id == id);
        }

        public List<Chain> GetAllChains()
        {
            return _ctx.Chains.OrderBy(chain => chain.ChainCategory).ThenBy(chain => chain.Name).ToList();
        }

        public ChainViewModel GetAllChains(string category)
        {
            Func<Chain, bool> InCategory = (chain) =>
            {
                return chain.ChainCategory.ToLower().Equals(category.ToLower());
            };

            var query = _ctx.Chains.AsQueryable();

            if (!String.IsNullOrEmpty(category))
                query = query.Where(x => InCategory(x));

            return new ChainViewModel
            {
                Category = category,
                Chains = query.OrderBy(chain => chain.Availability).ThenBy(chain => chain.Price).ToList()
            };
        }

        public void AddChain(Chain chain)
        {
            _ctx.Chains.Add(chain);
        }

        public void UpdateChain(Chain chain)
        {
            _ctx.Chains.Update(chain);
        }

        public void RemoveChain(int id)
        {
            _ctx.Chains.Remove(GetChain(id));
        }

        // Раздел "Серьги"

        public EarringCategory GetEarringCategory(int id)
        {
            return _ctx.EarringCategories.FirstOrDefault(c => c.Id == id);
        }

        public List<EarringCategory> GetAllEarringCategories()
        {
            return _ctx.EarringCategories.ToList();
        }

        public void AddEarringCategory(EarringCategory earringCategory)
        {
            _ctx.EarringCategories.Add(earringCategory);
        }

        public void UpdateEarringCategory(EarringCategory earringCategory)
        {
            _ctx.EarringCategories.Update(earringCategory);
        }

        public void RemoveEarringCategory(int id)
        {
            _ctx.EarringCategories.Remove(GetEarringCategory(id));
        }

        public Earring GetEarring(int id)
        {
            return _ctx.Earrings.FirstOrDefault(g => g.Id == id);
        }

        public List<Earring> GetAllEarrings()
        {
            return _ctx.Earrings.OrderBy(earring => earring.EarringCategory).ThenBy(earring => earring.Name).ToList();
        }

        public EarringViewModel GetAllEarrings(string category)
        {
            Func<Earring, bool> InCategory = (earring) =>
            {
                return earring.EarringCategory.ToLower().Equals(category.ToLower());
            };

            var query = _ctx.Earrings.AsQueryable();

            if (!String.IsNullOrEmpty(category))
                query = query.Where(x => InCategory(x));

            return new EarringViewModel
            {
                Category = category,
                Earrings = query.OrderBy(earring => earring.Availability).ThenBy(earring => earring.Price).ToList()
            };
        }

        public void AddEarring(Earring earring)
        {
            _ctx.Earrings.Add(earring);
        }

        public void UpdateEarring(Earring earring)
        {
            _ctx.Earrings.Update(earring);
        }

        public void RemoveEarring(int id)
        {
            _ctx.Earrings.Remove(GetEarring(id));
        }

        // Раздел "Кольца"

        public RingCategory GetRingCategory(int id)
        {
            return _ctx.RingCategories.FirstOrDefault(c => c.Id == id);
        }

        public List<RingCategory> GetAllRingCategories()
        {
            return _ctx.RingCategories.ToList();
        }

        public void AddRingCategory(RingCategory ringCategory)
        {
            _ctx.RingCategories.Add(ringCategory);
        }

        public void UpdateRingCategory(RingCategory ringCategory)
        {
            _ctx.RingCategories.Update(ringCategory);
        }

        public void RemoveRingCategory(int id)
        {
            _ctx.RingCategories.Remove(GetRingCategory(id));
        }

        public Ring GetRing(int id)
        {
            return _ctx.Rings.FirstOrDefault(g => g.Id == id);
        }

        public List<Ring> GetAllRings()
        {
            return _ctx.Rings.OrderBy(ring => ring.RingCategory).ThenBy(ring => ring.Price).ToList();
        }

        public RingViewModel GetAllRings(string category)
        {
            Func<Ring, bool> InCategory = (ring) =>
            {
                return ring.RingCategory.ToLower().Equals(category.ToLower());
            };

            var query = _ctx.Rings.AsQueryable();

            if (!String.IsNullOrEmpty(category))
                query = query.Where(x => InCategory(x));

            return new RingViewModel
            {
                Category = category,
                Rings = query.OrderBy(ring => ring.Availability).ThenBy(ring => ring.Price).ToList()
            };

        }

        public void AddRing(Ring ring)
        {
            _ctx.Rings.Add(ring);
        }

        public void UpdateRing(Ring ring)
        {
            _ctx.Rings.Update(ring);
        }

        public void RemoveRing(int id)
        {
            _ctx.Rings.Remove(GetRing(id));
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
