using LePlug.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LePlug.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }

		public DbSet<Company> Companies { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
		public DbSet<OrderHeader> OrderHeaders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
			base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category {Id = 1, Name = "Apparels", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Equipment", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Accessories", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Technology", DisplayOrder = 4 }
                );


			modelBuilder.Entity<Company>().HasData(
				new Company { 
					Id = 1, 
					Name = "TrailBlazers", 
					StreetAddress = "123 Ruaraka",
					City = "Nairobi", 
					Country = "Kenya", 
					PhoneNumber ="+254719276623", 
					PostalCode = "0200" 
				},
				new Company { Id = 2,
					Name = "General Service Unit", 
					StreetAddress = "124 Drive Inn", 
					City = "Nairobi", 
					Country = "Kenya", 
					PhoneNumber = "+254726276623", 
					PostalCode = "0200" 
				},

				new Company
				{
					Id = 3,
					Name = "The Dockers",
					StreetAddress = "Makupa Docks",
					City = "Mombasa",
					Country = "Kenya",
					PhoneNumber = "+254726276623",
					PostalCode = "0200"
				}
				);

			modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    ProductName = "Mikasa MVA330 Composite Volleyball",
                    Description = "Designed with a unique 8-panel swirl design, this ball offers superior visibility when in flight. This in turn improves accuracy during bumps, sets, and spikes. Composite leather cover provides low sting on wrists and arms and stands up to rough, routine play indoors. Nylon-wound center and composite bladder retain air and ball shape. Official size.",
                    Manufacturer = "Mikasa Inc",
                    ListPrice = 5999,
                    Price = 5799,
                    Price50 = 5299,
                    Price100 = 4999,
					CategoryId = 1,
					ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.jumia.co.ke%2Fmikasa-official-match-ball-for-volleyball-size-4-mva330-218656549.html&psig=AOvVaw2FvZh5_7AiwHZu9TkzjqQE&ust=1724322979806000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCLj05fHxhYgDFQAAAAAdAAAAABAI"
				},
				new Product
				{
					Id = 2,
					ProductName = "High Quality Hoodie",
					Description = "The hoodie is made of thick cotton fabric which keeps in body heat so you can stay warm and comfortable.This drawstring double fabric hoodie with self-coloured",
					Manufacturer = "Urban Volleyball",
					ListPrice = 2500,
					Price = 2299,
					Price50 = 2199,
					Price100 = 1999,
					CategoryId = 1,
					ImageUrl = "https://s.turbifycdn.com/aah/q-sport/volleyball-rising-hooded-sweatshirt-in-20-colors-54.jpg"
				},
				new Product
				{
					Id = 3,
					ProductName = "Sport Shoes",
					Description = "Explore our wide selection of men's volleyball shoes and sneakers! We carry the top-of-the-line brands like Nike, Mizuno, Adidas, and so much more",
					Manufacturer = "Asics",
					ListPrice = 2500,
					Price = 2299,
					Price50 = 2199,
					Price100 = 1999,
					CategoryId = 3,
					ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.indiamart.com%2Fproddetail%2Fasics-sky-elite-ff-mt-2-tokyo-volleyball-shoes-24668676662.html&psig=AOvVaw0dekzg2sWyQmvS8saFN_rM&ust=1724323289252000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCIDu0IHzhYgDFQAAAAAdAAAAABAE"
				},
				new Product
				{
					Id = 4,
					ProductName = "Knee Pads",
					Description = "Keep your eyes on the net, not the floor. These adidas volleyball kneepads are made to fit the contours of your knee for a comfortable wear.",
					Manufacturer = "Addidas",
					ListPrice = 2500,
					Price = 2299,
					Price50 = 2199,
					Price100 = 1999,
					CategoryId = 2,
					ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.walmart.com%2Fip%2FMizuno-Volleyball-Elite-Kneepads-White%2F192436285&psig=AOvVaw0HWRoHS3u0rQ6irT8lg5A0&ust=1724323365841000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCIi8_sHzhYgDFQAAAAAdAAAAABAE"
				}
			);
		}
    }
}
