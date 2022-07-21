using DotNet6Crud.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet6Crud.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }

    }
}
