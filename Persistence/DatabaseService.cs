using Application.Interfaces;
using Domain.Customers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(@"User ID=awc; Password=awc; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=DAS)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));");
            //base.OnConfiguring(optionsBuilder);
        }

        public void Save()
        {
            this.SaveChanges();
        }


    }
}
