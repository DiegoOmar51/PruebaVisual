using Microsoft.EntityFrameworkCore;
using ModeloPrubea.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDBPrueba
{
    public class RentaDB:DbContext

    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        override protected void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "server=DESKTOP-FAR92HR; initial catalog=PRUEBA; trusted_connection=true;"
                );
        }
        public RentaDB(): base()
        {

        }
        public RentaDB(DbContextOptions<RentaDB> opciones)
            : base(opciones)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>()
                .HasOne<Customer>(s => s.Customer)
                .WithMany(g => g.Payments)
                .HasForeignKey(s => s.payment_id);
           
        }
    }
}
