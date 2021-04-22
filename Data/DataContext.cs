using Microsoft.EntityFrameworkCore;
using webapiprojeto.Models;

namespace webapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}

        public DbSet<Product> Products {get; set;}
        public DbSet<Category> Categories {get; set;}
        public DbSet<User> Users {get; set;}

    }
}