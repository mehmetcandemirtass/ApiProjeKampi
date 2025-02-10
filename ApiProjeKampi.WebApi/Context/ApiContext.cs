using ApiProjeKampi.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProjeKampi.WebApi.Context
{
    public class ApiContext: DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-I2E1T9B\\MSSQLSERVER01;initial catalog=ApiYummyDb;TrustServerCertificate=True;Integrated Security=True;");
        }
        public DbSet <Category> Categories { get; set; }
        public DbSet <Chef> Chefs { get; set; }
        public DbSet <Contact> Contacts { get; set; }
        public DbSet <Feature> Features { get; set; }
        public DbSet <Category> Cat { get; set; }
        public DbSet <Image> Images { get; set; }
        public DbSet <Message> Messages { get; set; }
        public DbSet <Product> Products { get; set; }
        public DbSet <Reservation> Reservations { get; set; }
        public DbSet <Service> Services { get; set; }
        public DbSet <Testimonial> Testimonials { get; set; }
    }
}
