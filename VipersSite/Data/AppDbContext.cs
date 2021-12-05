using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipersSite.Models;

namespace VipersSite.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }
        public DbSet<Abo> About { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<BraceletCategory> BraceletCategories { get; set; }
        public DbSet<ChainCategory> ChainCategories { get; set; }
        public DbSet<EarringCategory> EarringCategories { get; set; }
        public DbSet<RingCategory> RingCategories { get; set; }
        public DbSet<Bracelet> Bracelets { get; set; }
        public DbSet<Chain> Chains { get; set; }
        public DbSet<Earring> Earrings { get; set; }
        public DbSet<Ring> Rings { get; set; }   
    }
}
