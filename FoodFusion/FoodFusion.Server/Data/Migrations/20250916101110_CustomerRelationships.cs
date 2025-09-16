using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodFusion.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class CustomerRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "06fb7b60-212f-4bd7-b355-a9897941b098");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1ad173fc-a603-4aca-a3f9-f73cd8d1536f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "53e4be79-0abb-4338-b182-dc1bf219ec1b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e0bc0611-8932-4eaf-ab20-a167d177e7d5");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6759));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6759));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCategory",
                keyColumn: "MealTypeId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCategory",
                keyColumn: "MealTypeId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCategory",
                keyColumn: "MealTypeId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCategory",
                keyColumn: "MealTypeId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourse",
                keyColumn: "MealCourseId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourse",
                keyColumn: "MealCourseId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourse",
                keyColumn: "MealCourseId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourse",
                keyColumn: "MealCourseId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourse",
                keyColumn: "MealCourseId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6977));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourse",
                keyColumn: "MealCourseId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ea7ac88-6c72-4944-af34-48921ba04f6d", null, "Admin", "ADMIN" },
                    { "44542fdf-d5fd-4609-aef6-6bf7ca670a9d", null, "Manager", "MANAGER" },
                    { "b8364b56-d442-4b7d-b17e-a63d40a4bc11", null, "Super Admin", "SUPER ADMIN" },
                    { "c868f354-cf36-427b-8d99-56d21efa2395", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6947));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 10, 11, 7, 574, DateTimeKind.Utc).AddTicks(6951));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1ea7ac88-6c72-4944-af34-48921ba04f6d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "44542fdf-d5fd-4609-aef6-6bf7ca670a9d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b8364b56-d442-4b7d-b17e-a63d40a4bc11");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c868f354-cf36-427b-8d99-56d21efa2395");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8477));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8521));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisine",
                keyColumn: "CuisineID",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCategory",
                keyColumn: "MealTypeId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCategory",
                keyColumn: "MealTypeId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCategory",
                keyColumn: "MealTypeId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCategory",
                keyColumn: "MealTypeId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourse",
                keyColumn: "MealCourseId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourse",
                keyColumn: "MealCourseId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourse",
                keyColumn: "MealCourseId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourse",
                keyColumn: "MealCourseId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourse",
                keyColumn: "MealCourseId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourse",
                keyColumn: "MealCourseId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8721));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "06fb7b60-212f-4bd7-b355-a9897941b098", null, "Super Admin", "SUPER ADMIN" },
                    { "1ad173fc-a603-4aca-a3f9-f73cd8d1536f", null, "Manager", "MANAGER" },
                    { "53e4be79-0abb-4338-b182-dc1bf219ec1b", null, "Admin", "ADMIN" },
                    { "e0bc0611-8932-4eaf-ab20-a167d177e7d5", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "SubCategory",
                keyColumn: "DishTypeId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 20, 44, 10, 221, DateTimeKind.Utc).AddTicks(8690));
        }
    }
}
