using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {
        }

        public DbSet<Books> Candies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShopppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fiction" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "History" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Science & Technology" });


            modelBuilder.Entity<Books>().HasData(new Books
            {
                BookId = 1,
                Name = "The Goldfinch",
                Price = 14.23M,
                Description = "A young New Yorker grieving his mother\'s death is pulled into a gritty underworld of art and wealth in this \"extraordinary\" and beloved Pulitzer Prize winner that \"connects with the heart as well as the mind.",
                CategoryId = 1,
                ImageUrl= "\\Images\\book01.jpg",
                ImageThumbnailUrl= "\\Images\\thumbnails\\tn-book01.jpg",
                IsInStock=true,
                IsOnSale=false
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                BookId = 2,
                Name = "The Argument",
                Price = 10.99M,
                Description = "It happens to every mother. One day, the daughter whose whole world you once were, becomes someone you barely know. And you don’t know the secrets she’s hiding.",
                CategoryId = 1,
                ImageUrl = "\\Images\\book02.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\tn-book02.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                BookId = 3,
                Name = "My Name is Eva",
                Price = 9.54M,
                Description = "A gripping, haunting and compelling read about love, courage and betrayal set in the war-battered landscape of Germany. Fans of The Letter, The Alice Network and The Nightingale will be hooked.",
                CategoryId = 1,
                ImageUrl = "\\Images\\book03.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\tn-book03.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                BookId = 4,
                Name = "Music: A Subversive History",
                Price = 26.99M,
                Description = "Histories of music overwhelmingly suppress stories of the outsiders and rebels who created musical revolutions and instead celebrate the mainstream assimilators who borrowed innovations, diluted their impact, and disguised their sources. In Music: A Subversive History, Ted Gioia reclaims the story of music for the riffraff, insurgents, and provocateurs.",
                CategoryId = 2,
                ImageUrl = "\\Images\\book04.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\tn-book04.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                BookId = 5,
                Name = "The Invisible Rainbow: A History of Electricity and Life",
                Price = 18.38M,
                Description = "Over the last 220 years, society has evolved a universal belief that electricity is ‘safe’ for humanity and the planet. Scientist and journalist Arthur Firstenberg disrupts this conviction by telling the story of electricity in a way it has never been told before―from an environmental point of view―by detailing the effects that this fundamental societal building block has had on our health and our planet.",
                CategoryId = 2,
                ImageUrl = "\\Images\\book05.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\tn-book05.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                BookId = 6,
                Name = "The History Book: Big Ideas Simply Explained",
                Price = 17.03M,
                Description = "From the dawn of civilization to the lightning-paced culture of today, take a fascinating journey through the most significant events in history and the big ideas behind each one. Bring history to life as you explore the Law Code of Hammurabi, the Renaissance, the American Revolution, World War II, and much more.",
                CategoryId = 2,
                ImageUrl = "\\Images\\book06.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\tn-book06.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                BookId = 7,
                Name = "Inferential Models for Logic, Language, Cognition and Computation",
                Price = 161.89M,
                Description = "This book discusses how scientific and other types of cognition make use of models, abduction, and explanatory reasoning in order to produce important and innovative changes in theories and concepts.",
                CategoryId = 3,
                ImageUrl = "\\Images\\book07.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\tn-book07.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                BookId = 8,
                Name = "Fundamentals of Thermal-Fluid Sciences",
                Price = 25.94M,
                Description = "The objective of this text is to cover the basic principles of thermodynamics, fluid mechanics, and heat transfer. Diverse real-world engineering examples are presented to give students a feel for how thermal-fluid sciences are applied in engineering practice.",
                CategoryId = 3,
                ImageUrl = "\\Images\\book08.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\tn-book08.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                BookId = 9,
                Name = "Statistical Machine Learning: A Unified Framework",
                Price = 120.00M,
                Description = "The recent rapid growth in the variety and complexity of new machine learning architectures requires the development of improved methods for designing, analyzing, evaluating, and communicating machine learning technologies.",
                CategoryId = 3,
                ImageUrl = "\\Images\\book09.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\tn-book09.jpg",
                IsInStock = true,
                IsOnSale = false
            });
        }
    }
}
