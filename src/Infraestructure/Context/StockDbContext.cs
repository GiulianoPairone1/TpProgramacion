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
        public DbSet<Vendedor> Vendedors { get; set; }
        public DbSet<Gerente>Gerentes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasDiscriminator(u => u.UserType);
            modelBuilder.Entity<Vendedor>().HasData(CreateVendedorDataSeed());
            modelBuilder.Entity<Gerente>().HasData(CreateGerenteDataSeed());
        }

        private Vendedor[] CreateVendedorDataSeed()
        {
            Vendedor[] result;

            result = [
                new Vendedor
                {

                    Nombre = "carlos",
                    Email = "cbologna31@gmail.com",
                    Contraseña = "123456",
                    Id = 5
                },
                new Vendedor
                {
                    Nombre = "Gabriel",
                    Email = "gfurrer@gmail.com",
                    Contraseña = "123456",
                    Id = 6
                }];

            return result;
        }
        private Gerente[] CreateGerenteDataSeed()
        {
            Gerente[] result;

            result = [
                new Gerente
                {

                    Nombre = "Caetano",
                    Email = "Caetano1@gmail.com",
                    Contraseña = "1234",
                    Id = 7
                }];
            return result;
        }
    }
}
