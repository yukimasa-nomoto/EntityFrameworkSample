
using ContosoPizza.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Data
{
    public class ContosoPizzaContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null;
        public DbSet<Order> Orders { get; set; } = null;
        public DbSet<Product> Products { get; set; } = null;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(@"User ID=awc; Password=awc; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=DAS)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));");
            //base.OnConfiguring(optionsBuilder);
        }

    }
}
