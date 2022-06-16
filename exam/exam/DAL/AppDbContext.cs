using exam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Breakfast> Breakfasts { get; set; }
        public DbSet<Brunch> Brunches { get; set; }
        public DbSet<Dinner> Dinners { get; set; }
    }
}
