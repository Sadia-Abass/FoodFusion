using FoodFusion.Server.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FoodFusion.Server.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin,
        ApplicationRoleClaim, ApplicationUserToken>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {           
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<Cancellation> Cancellation { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartItem> CartItem { get; set; }
        public DbSet<MealType> MealCategory { get; set; }
        public DbSet<Cuisine> Cuisine { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }   
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<MenuItemImage> MenuItemImage { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Refund> Refund { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<DishType> SubCategory { get; set; }

        // Configuring model properties and relationships
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("dbo");

            builder.Entity<ApplicationUser>(e =>
            {
                // Each User can have many UserClaims
                e.HasMany(e => e.Claims)
                    .WithOne(e => e.User)
                    .HasForeignKey(uc => uc.UserId)
                    .IsRequired();

                // Each User can have many UserLogins
                e.HasMany(e => e.Logins)
                    .WithOne(e => e.User)
                    .HasForeignKey(ul => ul.UserId)
                    .IsRequired();

                // Each User can have many UserTokens
                e.HasMany(e => e.Tokens)
                    .WithOne(e => e.User)
                    .HasForeignKey(ut => ut.UserId)
                    .IsRequired();

                // Each User can have many entries in the UserRole join table
                e.HasMany(e => e.UserRoles)
                    .WithOne(e => e.User)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();

                // 
                e.ToTable(name: "Users");
            });

            builder.Entity<ApplicationRole>(e =>
            {
                // Each Role can have many entries in the UserRole join table
                e.HasMany(e => e.UserRoles)
                    .WithOne(e => e.Role)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                // Each Role can have many associated RoleClaims
                e.HasMany(e => e.RoleClaims)
                    .WithOne(e => e.Role)
                    .HasForeignKey(rc => rc.RoleId)
                    .IsRequired();

                e.ToTable(name: "Roles");
            });

            builder.Entity<ApplicationUserClaim>(e =>
            {
                e.ToTable(name: "UserClaims");
            });

            builder.Entity<ApplicationUserLogin>(e =>
            {
                e.ToTable(name: "UserLogins");
            });

            builder.Entity<ApplicationRoleClaim>(e =>
            {
                e.ToTable(name: "RoleClaims");
            });

            builder.Entity<ApplicationUserToken>(e =>
            {
                e.ToTable(name: "UserTokens");
            });

            builder.Entity<ApplicationUserRole>(e =>
            {
                e.ToTable(name: "UserRoles");
            });

            // Configure one-to-one relationship for Customer with ApplicationUser
            builder.Entity<ApplicationUser>()
                .HasOne(au => au.Customer)
                .WithOne(c => c.ApplicationUser)
                .HasForeignKey<Customer>(c => c.ApplicationUserId);

            // Configure one-to-one relationship for Employee with ApplicationUser
            builder.Entity<ApplicationUser>()
                .HasOne(au => au.Employee)
                .WithOne(e => e.ApplicationUser)
                .HasForeignKey<Employee>(e => e.ApplicationUserId);

            // Configure Customer relationship
            builder.Entity<Customer>(c =>
            {
                // Each customer can have many orders
                c.HasMany(o => o.Orders)
                 .WithOne(c => c.Customer)
                 .HasForeignKey(o => o.CustomerID);

                // Each customer can have many feedbacks
                c.HasMany(f => f.Feedbacks)
                 .WithOne(c => c.Customer)
                 .HasForeignKey(f => f.CustomerId);

                // Each customer can have many reservations
                c.HasMany(r => r.Reservation)
                 .WithOne(c => c.Customer)
                 .HasForeignKey(r => r.ReservationID);

            });
                

            // Configure one-to-one relationship for MenuItem with MenuItemImage
            builder.Entity<MenuItemImage>()
                .HasOne(m => m.MenuItem)
                .WithOne(i => i.MenuItemImage)
                .HasForeignKey<MenuItem>(i => i.MenuItemID);

            // Configure one-to-one relationship for MenuItem with MenuItemImage
            builder.Entity<Cuisine>()
                .HasMany(m => m.MenuItem)
                .WithOne(c => c.Cuisine)
                .HasForeignKey(i => i.CuisineId);

            // Configure one-to-many relationship for Cuisine with Category
            //builder.Entity<Cuisine>()
            //    .HasMany(c => c.MealType)
            //    .WithOne(c => c.Cuisine)
            //    .HasForeignKey(c => c.MealTypeId);

            // Configure one-to-many relationship for Category with Subcategory
            //builder.Entity<MealType>()
            //    .HasMany(c => c.DishType)
            //    .WithOne(s => s.MealType)
            //    .HasForeignKey(s => s.MealTypeId);

            // Configure one-to-many relationship for Subcategory with MenuItem
            builder.Entity<DishType>()
                .HasMany(s => s.MenuItem)
                .WithOne(m => m.DishType)
                .HasForeignKey(m => m.DishTypeId);

            // Configure one-to-many relationship for Order with BillingAddress 
            builder.Entity<Order>()
                .HasOne(o => o.BillingAddress)
                .WithMany()
                .HasForeignKey(o => o.BillingAddressID)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure one-to-many relationship for Order with ShippingAddress 
            builder.Entity<Order>()
                .HasOne(o => o.ShippingAddress)
                .WithMany()
                .HasForeignKey(o =>o.ShippingAddressID)
                .OnDelete(DeleteBehavior.Restrict); 

            // Configure one-to-many relationship for Order with Cancellation
            builder.Entity<Order>()
                .HasOne(o => o.Cancellation)
                .WithOne(c => c.Order)
                .HasForeignKey<Cancellation>(c => c.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure many-to-one relationship for Payment with Refund
            builder.Entity<Payment>()
                .HasOne(p => p.Refund)
                .WithOne(r => r.Payment)
                .HasForeignKey<Refund>(r => r.PaymentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure many-to-one relationship for Feedback with Customer
            builder.Entity<Feedback>()
                .HasOne(f => f.Customer)
                .WithMany(c => c.Feedbacks)
                .HasForeignKey(c => c.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure many-to-one relationship for Feedback with MenuItem
            builder.Entity<Feedback>()
                .HasOne(f => f.Restaurant)
                .WithMany(p => p.Feedback)
                .HasForeignKey(f => f.RestaurantId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure one-to-many relationship for Restaurant with Employee
            builder.Entity<Restaurant>()
                .HasMany(r => r.Employee)
                .WithOne(e => e.Restaurant)
                .HasForeignKey(e =>  e.RestaurantId);

            // Configure one-to-many relationship for Restaurant with Reservation
            builder.Entity<Restaurant>()
                .HasMany(r => r.Reservation)
                .WithOne(r => r.Restaurant)
                .HasForeignKey(r => r.ReservationID);

            // Configure one-to-many relationship for Resaurant with MenuItem
            builder.Entity<Restaurant>()
                .HasMany(r => r.MenuItem)
                .WithOne(m => m.Restaurant)
                .HasForeignKey(m => m.RestaurantId);

            // Configure one-to-many relationship for Reservation with Customer
            builder.Entity<Reservation>()
                .HasOne(r => r.Customer)
                .WithMany(c => c.Reservation)
                .HasForeignKey(c => c.ReservationID);

            // Configure one-to-many relationship for Restaurant with Cuisine
            builder.Entity<Restaurant>()
                .HasMany(r => r.Cuisine)
                .WithMany(c => c.Restaurant);

            builder.Seed();
        }
    }
}
