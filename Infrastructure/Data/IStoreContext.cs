using Microsoft.EntityFrameworkCore;
using AppCore.Entities;

namespace Infrastructure.Data
{
    public interface IStoreContext
    {
        DbSet<Product> Products { get; set; }
    }
}