using Microsoft.EntityFrameworkCore;
using store_api.Src.Models;

namespace store_api.Src.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
