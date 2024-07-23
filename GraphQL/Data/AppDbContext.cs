using GraphQL_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_Project.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { 
                    Id=1, 
                    Name="Appetizer", 
                    //Menus = new() { new Menu { Id =1, Name="item1", CategoryId=1, Description="test1", ImageUrl="test1", Price=9.99m} }
                },
                new Category
                {
                    Id = 2,
                    Name = "Main Coarse",
                    //Menus = new() { new Menu { Id = 2, Name = "item2", CategoryId = 2, Description = "test2", ImageUrl = "test2", Price = 10.99m } }
                },
                new Category
                {
                    Id = 3,
                    Name = "Dessert",
                    //Menus = new() { new Menu { Id = 3, Name = "item3", CategoryId = 3, Description = "test3", ImageUrl = "test3", Price = 11.99m } }
                }
                );

            modelBuilder.Entity<Menu>().HasData(
                new Menu { Id = 1, Name = "item1", CategoryId = 1, Description = "test1", ImageUrl = "test1", Price = 9.99m },
                new Menu { Id = 2, Name = "item2", CategoryId = 2, Description = "test2", ImageUrl = "test2", Price = 10.99m },
                new Menu { Id = 3, Name = "item3", CategoryId = 3, Description = "test3", ImageUrl = "test3", Price = 11.99m }
                );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { Id = 1, CustomerName = "name1", Email = "email1", PhoneNumber = "ph1", PartySize = 4, SpecialRequest="none", ReservationDate = DateTime.UtcNow },
                new Reservation { Id = 2, CustomerName = "name2", Email = "email2", PhoneNumber = "ph2", PartySize = 5, SpecialRequest = "Something", ReservationDate = DateTime.UtcNow.AddHours(1) },
                new Reservation { Id = 3, CustomerName = "name3", Email = "email3", PhoneNumber = "ph3", PartySize = 6, SpecialRequest = "none", ReservationDate = DateTime.UtcNow.AddHours(2) }
                );
        }
    }
}
