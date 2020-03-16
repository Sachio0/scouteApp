using DataLayer.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
                
        }
        public DbSet<Page> Page { get; set; }
    }
}
