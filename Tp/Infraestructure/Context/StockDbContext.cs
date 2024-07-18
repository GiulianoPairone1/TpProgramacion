using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Context
{
    public class StockDbContext:DbContext
    {
        public StockDbContext(DbContextOptions<StockDbContext>options):base(options) { }

        public DbSet<Producto>Productos { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
