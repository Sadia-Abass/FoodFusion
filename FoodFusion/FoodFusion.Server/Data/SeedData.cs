using FoodFusion.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodFusion.Server.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Cuisine>().HasData(
                new Cuisine { CuisineID = 1, Type = "Chinese", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new Cuisine { CuisineID = 2, Type = "Indian", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new Cuisine { CuisineID = 3, Type = "Italian", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new Cuisine { CuisineID = 4, Type = "Jamaican", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new Cuisine { CuisineID = 5, Type = "Korean", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new Cuisine { CuisineID = 6, Type = "English", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new Cuisine { CuisineID = 7, Type = "American", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new Cuisine { CuisineID = 8, Type = "Greek", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new Cuisine { CuisineID = 9, Type = "Turkish", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new Cuisine { CuisineID = 10, Type = "Japanese", CreatedDate = DateTime.UtcNow, IsDeleted = false }
                );

            modelBuilder.Entity<MealType>().HasData(
                new MealType { MealTypeId = 1, Name = "Beakfast", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new MealType { MealTypeId = 2, Name = "Lunch", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new MealType { MealTypeId = 3, Name = "Dinner", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new MealType { MealTypeId = 4, Name = "All Day", CreatedDate = DateTime.UtcNow, IsDeleted = false }
                );

            modelBuilder.Entity<DishType>().HasData(
                new DishType { DishTypeId = 1, Name = "Curry", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new DishType { DishTypeId = 2, Name = "Pasta", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new DishType { DishTypeId = 3, Name = "Cakes", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new DishType { DishTypeId = 4, Name = "Rice", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new DishType { DishTypeId = 5, Name = "Soups", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new DishType { DishTypeId = 6, Name = "Chicken", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new DishType { DishTypeId = 7, Name = "Bread"   , CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new DishType { DishTypeId = 8, Name = "Coffee", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new DishType { DishTypeId = 9, Name = "Tea", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new DishType { DishTypeId = 10, Name = "Kebab", CreatedDate = DateTime.UtcNow, IsDeleted = false }
                );

            modelBuilder.Entity<MealCourse>().HasData(
                new MealCourse { MealCourseId = 1, MealType = "Appertizers/Starters", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new MealCourse { MealCourseId = 2, MealType = "Main Course", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new MealCourse { MealCourseId = 3, MealType = "Sides", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new MealCourse { MealCourseId = 4, MealType = "Desserts", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new MealCourse { MealCourseId = 5, MealType = "Sauces", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new MealCourse { MealCourseId = 6, MealType = "Extras", CreatedDate = DateTime.UtcNow, IsDeleted = false }
                );

            modelBuilder.Entity<Status>().HasData(
                new Status { Id = 1, Name = "Pending"},
                new Status { Id = 2, Name = "Processing" },
                new Status { Id = 3, Name = "Shipped" },
                new Status { Id = 4, Name = "Delivered" },
                new Status { Id = 5, Name = "Cancelled" },
                new Status { Id = 6, Name = "Completed" },
                new Status { Id = 7, Name = "Failed" },
                new Status { Id = 8, Name = "Aproved" },
                new Status { Id = 9, Name = "Rejected" },
                new Status { Id = 10, Name = "Refunded" }
                );

            List<ApplicationRole> roles = new List<ApplicationRole>
            {
                new ApplicationRole { Name = "Super Admin", NormalizedName = "SUPER ADMIN"},
                new ApplicationRole { Name = "Admin", NormalizedName = "ADMIN"},
                new ApplicationRole { Name = "Manager", NormalizedName = "MANAGER"},
                new ApplicationRole { Name = "Customer", NormalizedName = "CUSTOMER"}
            };
            modelBuilder.Entity<ApplicationRole>().HasData(roles);

            //modelBuilder.Entity<Restaurant>().HasData(
            //    new Restaurant { RestaurantId = 1, Name = "The Empire's Kitchen", AddressLineOne = "26 Green Street", AddressLineTwo = "", City = "London", PostCode = "N1C 6TR", PhoneNumber = "02089236945", CuisineId = 1},
            //    new Restaurant { RestaurantId = 2, Name = "", AddressLineOne = "", AddressLineTwo = "", City = "", PostCode = "", PhoneNumber = "" },
            //    new Restaurant { RestaurantId = 3, Name = "", AddressLineOne = "", AddressLineTwo = "", City = "", PostCode = "", PhoneNumber = "" },
            //    new Restaurant { RestaurantId = 4, Name = "", AddressLineOne = "", AddressLineTwo = "", City = "", PostCode = "", PhoneNumber = "" },
            //    new Restaurant { RestaurantId = 5, Name = "", AddressLineOne = "", AddressLineTwo = "", City = "", PostCode = "", PhoneNumber = "" },
            //    new Restaurant { RestaurantId = 6, Name = "", AddressLineOne = "", AddressLineTwo = "", City = "", PostCode = "", PhoneNumber = "" },
            //    new Restaurant { RestaurantId = 7, Name = "", AddressLineOne = "", AddressLineTwo = "", City = "", PostCode = "", PhoneNumber = "" },
            //    new Restaurant { RestaurantId = 8, Name = "", AddressLineOne = "", AddressLineTwo = "", City = "", PostCode = "", PhoneNumber = "" },
            //    new Restaurant { RestaurantId = 9, Name = "", AddressLineOne = "", AddressLineTwo = "", City = "", PostCode = "", PhoneNumber = "" },
            //    new Restaurant { RestaurantId = 10, Name = "", AddressLineOne = "", AddressLineTwo = "", City = "", PostCode = "", PhoneNumber = "" }
            //    );
        }
    }
}
