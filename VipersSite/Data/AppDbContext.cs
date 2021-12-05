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
        public DbSet<Jewelry> Jewelries { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
