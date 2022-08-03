using Microsoft.EntityFrameworkCore;
using AppCore.Entities;
namespace Infrastructure.Data
{
    public class StoreContext : DbContext, IStoreContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
