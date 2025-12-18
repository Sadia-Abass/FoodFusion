using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodFusion.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "165c0148-ed80-49c8-8421-30c7a4c56b37");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6655e44b-9f2e-49ce-b8c0-61d6d93d25b7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7c8fc6f7-4815-4951-a0bb-096a09bb7adb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "879c8c8a-a28d-40ac-91bd-ff4aa3021462");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                schema: "dbo",
                table: "MenuItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3794));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3797));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3966));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3968));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourses",
                keyColumn: "MealCourseId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourses",
                keyColumn: "MealCourseId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourses",
                keyColumn: "MealCourseId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourses",
                keyColumn: "MealCourseId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourses",
                keyColumn: "MealCourseId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(4009));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourses",
                keyColumn: "MealCourseId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 16, 25, 24, 271, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "73684d2e-f20a-407a-9398-db2fda23fb60", null, "Admin", "ADMIN" },
                    { "79309048-91e3-421b-8df9-3061dacd8995", null, "Customer", "CUSTOMER" },
                    { "d8b98652-1f84-45f1-b291-fc79494a29e4", null, "Super Admin", "SUPER ADMIN" },
                    { "ddc38a15-5140-47fd-a3a4-95b463b88130", null, "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "73684d2e-f20a-407a-9398-db2fda23fb60");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "79309048-91e3-421b-8df9-3061dacd8995");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d8b98652-1f84-45f1-b291-fc79494a29e4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ddc38a15-5140-47fd-a3a4-95b463b88130");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                schema: "dbo",
                table: "MenuItems");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5591));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5593));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5594));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5595));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5596));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5597));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5598));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5736));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourses",
                keyColumn: "MealCourseId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourses",
                keyColumn: "MealCourseId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourses",
                keyColumn: "MealCourseId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourses",
                keyColumn: "MealCourseId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5763));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourses",
                keyColumn: "MealCourseId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5764));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourses",
                keyColumn: "MealCourseId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5765));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5702));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5704));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5704));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "165c0148-ed80-49c8-8421-30c7a4c56b37", null, "Manager", "MANAGER" },
                    { "6655e44b-9f2e-49ce-b8c0-61d6d93d25b7", null, "Admin", "ADMIN" },
                    { "7c8fc6f7-4815-4951-a0bb-096a09bb7adb", null, "Super Admin", "SUPER ADMIN" },
                    { "879c8c8a-a28d-40ac-91bd-ff4aa3021462", null, "Customer", "CUSTOMER" }
                });
        }
    }
}
