using CookDoWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CookDoWebAPI.Context
{
    public class CDContext : DbContext
    {
        public CDContext(DbContextOptions<CDContext> options) : base(options)
        {

        }

        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
