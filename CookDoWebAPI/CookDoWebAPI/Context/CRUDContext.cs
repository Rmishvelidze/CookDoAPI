
using CookDoWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CookDoWebAPI.Context
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
