using blazorLabWebutveckling.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace blazorLabWebutveckling.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Car>().HasData(
                            new Car { Id = 1, Name = "Blå bil", DescriptionShort = "Mycket blå och cool bil", DescriptionLong = "", ImgUrl = "Images/blue.png", PriceEUR = 15000, Qty = 10 },
                            new Car { Id = 2, Name = "Grön bil", DescriptionShort = "Mycket grön och skön bil", DescriptionLong = "", ImgUrl = "Images/green.png", PriceEUR = 18000, Qty = 8 },
                            new Car { Id = 3, Name = "Gul bil", DescriptionShort = "Snabb gul bil", DescriptionLong = "", ImgUrl = "Images/yellow.png", PriceEUR = 43000, Qty = 5 },
                            new Car { Id = 4, Name = "Rosa bil", DescriptionShort = "Jättefin rosa bil", DescriptionLong = "", ImgUrl = "Images/pink.png", PriceEUR = 35000, Qty = 4 },
                            new Car { Id = 5, Name = "Röd bil", DescriptionShort = "Bästa röda bilen", DescriptionLong = "", ImgUrl = "Images/red.png", PriceEUR = 28000, Qty = 6 }


           );

          
        }

    }
}
