using FoodFusion.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodFusion.Server.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Cuisine>().HasData(
                new Cuisine { CuisineID = 1, Name = "Chinese", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new Cuisine { CuisineID = 2, Name = "Indian", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new Cuisine { CuisineID = 3, Name = "Italian", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new Cuisine { CuisineID = 4, Name = "Jamaican", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new Cuisine { CuisineID = 5, Name = "Korean", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new Cuisine { CuisineID = 6, Name = "English", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new Cuisine { CuisineID = 7, Name = "American", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new Cuisine { CuisineID = 8, Name = "Greek", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new Cuisine { CuisineID = 9, Name = "Turkish", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new Cuisine { CuisineID = 10, Name = "Japanese", CreatedDate = DateTime.UtcNow, IsDeleted = false }
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
                new DishType { DishTypeId = 10, Name = "Kebab", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new DishType { DishTypeId = 11, Name = "Vegetarian", Description = "No meat or fish", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new DishType { DishTypeId = 12, Name = "Vegan", Description = "No animal products", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new DishType {DishTypeId = 13, Name = "Gluten-Free", Description = "Contains no gluten", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new DishType {DishTypeId = 14, Name = "Spicy", Description = "Contains hot spices", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new DishType {DishTypeId = 15, Name = "Dairy-Free", Description = "No dairy products", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new DishType {DishTypeId = 16, Name = "Nut-Free", Description = "No nuts", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new DishType {DishTypeId = 17, Name = "Low-Carb", Description = "Low carbohydrate content", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new DishType {DishTypeId = 18, Name = "Keto-Friendly", Description = "Suitable for ketogenic diet", CreatedDate = DateTime.UtcNow, IsDeleted = false }
                );

            modelBuilder.Entity<MealCourse>().HasData(
                new MealCourse { MealCourseId = 1, Name = "Appertizers/Starters", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new MealCourse { MealCourseId = 2, Name = "Main Course", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new MealCourse { MealCourseId = 3, Name = "Sides", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new MealCourse { MealCourseId = 4, Name = "Desserts", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new MealCourse { MealCourseId = 5, Name = "Sauces", CreatedDate = DateTime.UtcNow, IsDeleted = false },
                new MealCourse { MealCourseId = 6, Name = "Extras", CreatedDate = DateTime.UtcNow, IsDeleted = false }
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
