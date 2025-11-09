using Microsoft.EntityFrameworkCore;
using QUANLYKHO.Models;
using QUANLYKHO.Models;

namespace QUANLYKHO.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<ProductModel> Products { get; set; }

    }
}