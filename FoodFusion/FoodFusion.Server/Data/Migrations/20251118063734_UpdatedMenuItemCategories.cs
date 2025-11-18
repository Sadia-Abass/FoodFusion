using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodFusion.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedMenuItemCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Customer_CustomerID",
                schema: "dbo",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Cancellation_Order_OrderId",
                schema: "dbo",
                table: "Cancellation");

            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Customer_CustomerId",
                schema: "dbo",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Cart_CartId",
                schema: "dbo",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_MenuItem_MenuItemId",
                schema: "dbo",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CuisineRestaurant_Cuisine_CuisineID",
                schema: "dbo",
                table: "CuisineRestaurant");

            migrationBuilder.DropForeignKey(
                name: "FK_CuisineRestaurant_Restaurant_RestaurantId",
                schema: "dbo",
                table: "CuisineRestaurant");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Users_ApplicationUserId",
                schema: "dbo",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Restaurant_RestaurantId",
                schema: "dbo",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Users_ApplicationUserId",
                schema: "dbo",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Customer_CustomerId",
                schema: "dbo",
                table: "Feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Restaurant_RestaurantId",
                schema: "dbo",
                table: "Feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_Cuisine_CuisineId",
                schema: "dbo",
                table: "MenuItem");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_MealCategory_MealTypeId",
                schema: "dbo",
                table: "MenuItem");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_MealCourse_MealCourseId",
                schema: "dbo",
                table: "MenuItem");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_MenuItemImage_MenuItemID",
                schema: "dbo",
                table: "MenuItem");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_Restaurant_RestaurantId",
                schema: "dbo",
                table: "MenuItem");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_SubCategory_DishTypeId",
                schema: "dbo",
                table: "MenuItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Address_BillingAddressID",
                schema: "dbo",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Address_ShippingAddressID",
                schema: "dbo",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_CustomerID",
                schema: "dbo",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_MenuItem_MenuItemID",
                schema: "dbo",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderID",
                schema: "dbo",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Order_OrderID",
                schema: "dbo",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Refund_Cancellation_CancellationId",
                schema: "dbo",
                table: "Refund");

            migrationBuilder.DropForeignKey(
                name: "FK_Refund_Payment_PaymentId",
                schema: "dbo",
                table: "Refund");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Customer_ReservationID",
                schema: "dbo",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Restaurant_ReservationID",
                schema: "dbo",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategory",
                schema: "dbo",
                table: "SubCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Restaurant",
                schema: "dbo",
                table: "Restaurant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                schema: "dbo",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Refund",
                schema: "dbo",
                table: "Refund");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                schema: "dbo",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItem",
                schema: "dbo",
                table: "OrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                schema: "dbo",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MenuItemImage",
                schema: "dbo",
                table: "MenuItemImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MenuItem",
                schema: "dbo",
                table: "MenuItem");

            migrationBuilder.DropIndex(
                name: "IX_MenuItem_DishTypeId",
                schema: "dbo",
                table: "MenuItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealCourse",
                schema: "dbo",
                table: "MealCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealCategory",
                schema: "dbo",
                table: "MealCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Feedback",
                schema: "dbo",
                table: "Feedback");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                schema: "dbo",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                schema: "dbo",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cuisine",
                schema: "dbo",
                table: "Cuisine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItem",
                schema: "dbo",
                table: "CartItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                schema: "dbo",
                table: "Cart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cancellation",
                schema: "dbo",
                table: "Cancellation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                schema: "dbo",
                table: "Address");

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

            migrationBuilder.DropColumn(
                name: "DishTypeId",
                schema: "dbo",
                table: "MenuItem");

            migrationBuilder.RenameTable(
                name: "SubCategory",
                schema: "dbo",
                newName: "DishTypes",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Restaurant",
                schema: "dbo",
                newName: "Restaurants",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Reservation",
                schema: "dbo",
                newName: "Reservations",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Refund",
                schema: "dbo",
                newName: "Refunds",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Payment",
                schema: "dbo",
                newName: "Payments",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "OrderItem",
                schema: "dbo",
                newName: "OrderItems",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Order",
                schema: "dbo",
                newName: "Orders",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "MenuItemImage",
                schema: "dbo",
                newName: "MenuItemImages",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "MenuItem",
                schema: "dbo",
                newName: "MenuItems",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "MealCourse",
                schema: "dbo",
                newName: "MealCourses",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "MealCategory",
                schema: "dbo",
                newName: "MealTypes",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Feedback",
                schema: "dbo",
                newName: "Feedbacks",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Employee",
                schema: "dbo",
                newName: "Employees",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Customer",
                schema: "dbo",
                newName: "Customers",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Cuisine",
                schema: "dbo",
                newName: "Cuisines",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "CartItem",
                schema: "dbo",
                newName: "CartItems",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Cart",
                schema: "dbo",
                newName: "Carts",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Cancellation",
                schema: "dbo",
                newName: "Cancellations",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Address",
                schema: "dbo",
                newName: "Addresses",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "RestaurantId",
                schema: "dbo",
                table: "CuisineRestaurant",
                newName: "RestaurantsRestaurantId");

            migrationBuilder.RenameIndex(
                name: "IX_CuisineRestaurant_RestaurantId",
                schema: "dbo",
                table: "CuisineRestaurant",
                newName: "IX_CuisineRestaurant_RestaurantsRestaurantId");

            migrationBuilder.RenameIndex(
                name: "IX_Refund_PaymentId",
                schema: "dbo",
                table: "Refunds",
                newName: "IX_Refunds_PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_Refund_CancellationId",
                schema: "dbo",
                table: "Refunds",
                newName: "IX_Refunds_CancellationId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_OrderID",
                schema: "dbo",
                table: "Payments",
                newName: "IX_Payments_OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_OrderID",
                schema: "dbo",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_MenuItemID",
                schema: "dbo",
                table: "OrderItems",
                newName: "IX_OrderItems_MenuItemID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_ShippingAddressID",
                schema: "dbo",
                table: "Orders",
                newName: "IX_Orders_ShippingAddressID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CustomerID",
                schema: "dbo",
                table: "Orders",
                newName: "IX_Orders_CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_BillingAddressID",
                schema: "dbo",
                table: "Orders",
                newName: "IX_Orders_BillingAddressID");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItem_RestaurantId",
                schema: "dbo",
                table: "MenuItems",
                newName: "IX_MenuItems_RestaurantId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItem_MealTypeId",
                schema: "dbo",
                table: "MenuItems",
                newName: "IX_MenuItems_MealTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItem_MealCourseId",
                schema: "dbo",
                table: "MenuItems",
                newName: "IX_MenuItems_MealCourseId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItem_CuisineId",
                schema: "dbo",
                table: "MenuItems",
                newName: "IX_MenuItems_CuisineId");

            migrationBuilder.RenameColumn(
                name: "MealType",
                schema: "dbo",
                table: "MealCourses",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Feedback_RestaurantId",
                schema: "dbo",
                table: "Feedbacks",
                newName: "IX_Feedbacks_RestaurantId");

            migrationBuilder.RenameIndex(
                name: "IX_Feedback_CustomerId",
                schema: "dbo",
                table: "Feedbacks",
                newName: "IX_Feedbacks_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_RestaurantId",
                schema: "dbo",
                table: "Employees",
                newName: "IX_Employees_RestaurantId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_ApplicationUserId",
                schema: "dbo",
                table: "Employees",
                newName: "IX_Employees_ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "Password",
                schema: "dbo",
                table: "Customers",
                newName: "PhoneNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_ApplicationUserId",
                schema: "dbo",
                table: "Customers",
                newName: "IX_Customers_ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "Type",
                schema: "dbo",
                table: "Cuisines",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_CartItem_MenuItemId",
                schema: "dbo",
                table: "CartItems",
                newName: "IX_CartItems_MenuItemId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItem_CartId",
                schema: "dbo",
                table: "CartItems",
                newName: "IX_CartItems_CartId");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_CustomerId",
                schema: "dbo",
                table: "Carts",
                newName: "IX_Carts_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Cancellation_OrderId",
                schema: "dbo",
                table: "Cancellations",
                newName: "IX_Cancellations_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_CustomerID",
                schema: "dbo",
                table: "Addresses",
                newName: "IX_Addresses_CustomerID");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "dbo",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "dbo",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                schema: "dbo",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiry",
                schema: "dbo",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "DishTypes",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Allergens",
                schema: "dbo",
                table: "MenuItems",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Calories",
                schema: "dbo",
                table: "MenuItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "MenuItems",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                schema: "dbo",
                table: "MenuItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PreparationTimeInMinutes",
                schema: "dbo",
                table: "MenuItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "MealCourses",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                schema: "dbo",
                table: "MealCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "MealTypes",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "Cuisines",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Region",
                schema: "dbo",
                table: "Cuisines",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DishTypes",
                schema: "dbo",
                table: "DishTypes",
                column: "DishTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Restaurants",
                schema: "dbo",
                table: "Restaurants",
                column: "RestaurantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservations",
                schema: "dbo",
                table: "Reservations",
                column: "ReservationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Refunds",
                schema: "dbo",
                table: "Refunds",
                column: "RefundId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                schema: "dbo",
                table: "Payments",
                column: "PaymentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                schema: "dbo",
                table: "OrderItems",
                column: "OrderItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                schema: "dbo",
                table: "Orders",
                column: "OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MenuItemImages",
                schema: "dbo",
                table: "MenuItemImages",
                column: "MenuItemImageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MenuItems",
                schema: "dbo",
                table: "MenuItems",
                column: "MenuItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealCourses",
                schema: "dbo",
                table: "MealCourses",
                column: "MealCourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealTypes",
                schema: "dbo",
                table: "MealTypes",
                column: "MealTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feedbacks",
                schema: "dbo",
                table: "Feedbacks",
                column: "FeedbackId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                schema: "dbo",
                table: "Employees",
                column: "EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                schema: "dbo",
                table: "Customers",
                column: "CustomerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cuisines",
                schema: "dbo",
                table: "Cuisines",
                column: "CuisineID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItems",
                schema: "dbo",
                table: "CartItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                schema: "dbo",
                table: "Carts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cancellations",
                schema: "dbo",
                table: "Cancellations",
                column: "CancellationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                schema: "dbo",
                table: "Addresses",
                column: "AddressID");

            migrationBuilder.CreateTable(
                name: "MenuItemDishTypes",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DishTypeId = table.Column<long>(type: "bigint", nullable: false),
                    MenuItemId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItemDishTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItemDishTypes_DishTypes_DishTypeId",
                        column: x => x.DishTypeId,
                        principalSchema: "dbo",
                        principalTable: "DishTypes",
                        principalColumn: "DishTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuItemDishTypes_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalSchema: "dbo",
                        principalTable: "MenuItems",
                        principalColumn: "MenuItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Description", "Region" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5539), "", "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Description", "Region" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5591), "", "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Description", "Region" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5592), "", "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Description", "Region" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5593), "", "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Description", "Region" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5594), "", "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "Description", "Region" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5595), "", "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "Description", "Region" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5596), "", "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "Description", "Region" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5597), "", "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "Description", "Region" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5598), "", "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Cuisines",
                keyColumn: "CuisineID",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "Description", "Region" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5599), "", "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5721), "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5723), "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5724), "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5725), "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5726), "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5727), "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5728), "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5728), "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5729), "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5730), "" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "DishTypes",
                columns: new[] { "DishTypeId", "CreatedDate", "Description", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 11L, new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5731), "No meat or fish", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vegetarian" },
                    { 12L, new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5732), "No animal products", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vegan" },
                    { 13L, new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5733), "Contains no gluten", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gluten-Free" },
                    { 14L, new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5733), "Contains hot spices", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spicy" },
                    { 15L, new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5734), "No dairy products", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dairy-Free" },
                    { 16L, new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5735), "No nuts", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nut-Free" },
                    { 17L, new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5736), "Low carbohydrate content", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low-Carb" },
                    { 18L, new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5737), "Suitable for ketogenic diet", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keto-Friendly" }
                });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourses",
                keyColumn: "MealCourseId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Description", "DisplayOrder" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5759), "", 0 });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourses",
                keyColumn: "MealCourseId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Description", "DisplayOrder" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5761), "", 0 });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourses",
                keyColumn: "MealCourseId",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Description", "DisplayOrder" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5762), "", 0 });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourses",
                keyColumn: "MealCourseId",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Description", "DisplayOrder" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5763), "", 0 });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourses",
                keyColumn: "MealCourseId",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Description", "DisplayOrder" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5764), "", 0 });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealCourses",
                keyColumn: "MealCourseId",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "Description", "DisplayOrder" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5765), "", 0 });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5702), "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5704), "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5704), "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 11, 18, 6, 37, 32, 335, DateTimeKind.Utc).AddTicks(5705), "" });

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

            migrationBuilder.CreateIndex(
                name: "IX_MenuItemDishTypes_DishTypeId",
                schema: "dbo",
                table: "MenuItemDishTypes",
                column: "DishTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItemDishTypes_MenuItemId_DishTypeId",
                schema: "dbo",
                table: "MenuItemDishTypes",
                columns: new[] { "MenuItemId", "DishTypeId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Customers_CustomerID",
                schema: "dbo",
                table: "Addresses",
                column: "CustomerID",
                principalSchema: "dbo",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cancellations_Orders_OrderId",
                schema: "dbo",
                table: "Cancellations",
                column: "OrderId",
                principalSchema: "dbo",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Carts_CartId",
                schema: "dbo",
                table: "CartItems",
                column: "CartId",
                principalSchema: "dbo",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_MenuItems_MenuItemId",
                schema: "dbo",
                table: "CartItems",
                column: "MenuItemId",
                principalSchema: "dbo",
                principalTable: "MenuItems",
                principalColumn: "MenuItemID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Customers_CustomerId",
                schema: "dbo",
                table: "Carts",
                column: "CustomerId",
                principalSchema: "dbo",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CuisineRestaurant_Cuisines_CuisineID",
                schema: "dbo",
                table: "CuisineRestaurant",
                column: "CuisineID",
                principalSchema: "dbo",
                principalTable: "Cuisines",
                principalColumn: "CuisineID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CuisineRestaurant_Restaurants_RestaurantsRestaurantId",
                schema: "dbo",
                table: "CuisineRestaurant",
                column: "RestaurantsRestaurantId",
                principalSchema: "dbo",
                principalTable: "Restaurants",
                principalColumn: "RestaurantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Users_ApplicationUserId",
                schema: "dbo",
                table: "Customers",
                column: "ApplicationUserId",
                principalSchema: "dbo",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Restaurants_RestaurantId",
                schema: "dbo",
                table: "Employees",
                column: "RestaurantId",
                principalSchema: "dbo",
                principalTable: "Restaurants",
                principalColumn: "RestaurantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Users_ApplicationUserId",
                schema: "dbo",
                table: "Employees",
                column: "ApplicationUserId",
                principalSchema: "dbo",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Customers_CustomerId",
                schema: "dbo",
                table: "Feedbacks",
                column: "CustomerId",
                principalSchema: "dbo",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Restaurants_RestaurantId",
                schema: "dbo",
                table: "Feedbacks",
                column: "RestaurantId",
                principalSchema: "dbo",
                principalTable: "Restaurants",
                principalColumn: "RestaurantId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_Cuisines_CuisineId",
                schema: "dbo",
                table: "MenuItems",
                column: "CuisineId",
                principalSchema: "dbo",
                principalTable: "Cuisines",
                principalColumn: "CuisineID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_MealCourses_MealCourseId",
                schema: "dbo",
                table: "MenuItems",
                column: "MealCourseId",
                principalSchema: "dbo",
                principalTable: "MealCourses",
                principalColumn: "MealCourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_MealTypes_MealTypeId",
                schema: "dbo",
                table: "MenuItems",
                column: "MealTypeId",
                principalSchema: "dbo",
                principalTable: "MealTypes",
                principalColumn: "MealTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_MenuItemImages_MenuItemID",
                schema: "dbo",
                table: "MenuItems",
                column: "MenuItemID",
                principalSchema: "dbo",
                principalTable: "MenuItemImages",
                principalColumn: "MenuItemImageID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_Restaurants_RestaurantId",
                schema: "dbo",
                table: "MenuItems",
                column: "RestaurantId",
                principalSchema: "dbo",
                principalTable: "Restaurants",
                principalColumn: "RestaurantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_MenuItems_MenuItemID",
                schema: "dbo",
                table: "OrderItems",
                column: "MenuItemID",
                principalSchema: "dbo",
                principalTable: "MenuItems",
                principalColumn: "MenuItemID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderID",
                schema: "dbo",
                table: "OrderItems",
                column: "OrderID",
                principalSchema: "dbo",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Addresses_BillingAddressID",
                schema: "dbo",
                table: "Orders",
                column: "BillingAddressID",
                principalSchema: "dbo",
                principalTable: "Addresses",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Addresses_ShippingAddressID",
                schema: "dbo",
                table: "Orders",
                column: "ShippingAddressID",
                principalSchema: "dbo",
                principalTable: "Addresses",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                schema: "dbo",
                table: "Orders",
                column: "CustomerID",
                principalSchema: "dbo",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Orders_OrderID",
                schema: "dbo",
                table: "Payments",
                column: "OrderID",
                principalSchema: "dbo",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refunds_Cancellations_CancellationId",
                schema: "dbo",
                table: "Refunds",
                column: "CancellationId",
                principalSchema: "dbo",
                principalTable: "Cancellations",
                principalColumn: "CancellationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refunds_Payments_PaymentId",
                schema: "dbo",
                table: "Refunds",
                column: "PaymentId",
                principalSchema: "dbo",
                principalTable: "Payments",
                principalColumn: "PaymentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Customers_ReservationID",
                schema: "dbo",
                table: "Reservations",
                column: "ReservationID",
                principalSchema: "dbo",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Restaurants_ReservationID",
                schema: "dbo",
                table: "Reservations",
                column: "ReservationID",
                principalSchema: "dbo",
                principalTable: "Restaurants",
                principalColumn: "RestaurantId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Customers_CustomerID",
                schema: "dbo",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Cancellations_Orders_OrderId",
                schema: "dbo",
                table: "Cancellations");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Carts_CartId",
                schema: "dbo",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_MenuItems_MenuItemId",
                schema: "dbo",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Customers_CustomerId",
                schema: "dbo",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_CuisineRestaurant_Cuisines_CuisineID",
                schema: "dbo",
                table: "CuisineRestaurant");

            migrationBuilder.DropForeignKey(
                name: "FK_CuisineRestaurant_Restaurants_RestaurantsRestaurantId",
                schema: "dbo",
                table: "CuisineRestaurant");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Users_ApplicationUserId",
                schema: "dbo",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Restaurants_RestaurantId",
                schema: "dbo",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Users_ApplicationUserId",
                schema: "dbo",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Customers_CustomerId",
                schema: "dbo",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Restaurants_RestaurantId",
                schema: "dbo",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_Cuisines_CuisineId",
                schema: "dbo",
                table: "MenuItems");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_MealCourses_MealCourseId",
                schema: "dbo",
                table: "MenuItems");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_MealTypes_MealTypeId",
                schema: "dbo",
                table: "MenuItems");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_MenuItemImages_MenuItemID",
                schema: "dbo",
                table: "MenuItems");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_Restaurants_RestaurantId",
                schema: "dbo",
                table: "MenuItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_MenuItems_MenuItemID",
                schema: "dbo",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderID",
                schema: "dbo",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Addresses_BillingAddressID",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Addresses_ShippingAddressID",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Orders_OrderID",
                schema: "dbo",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Refunds_Cancellations_CancellationId",
                schema: "dbo",
                table: "Refunds");

            migrationBuilder.DropForeignKey(
                name: "FK_Refunds_Payments_PaymentId",
                schema: "dbo",
                table: "Refunds");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Customers_ReservationID",
                schema: "dbo",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Restaurants_ReservationID",
                schema: "dbo",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "MenuItemDishTypes",
                schema: "dbo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Restaurants",
                schema: "dbo",
                table: "Restaurants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservations",
                schema: "dbo",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Refunds",
                schema: "dbo",
                table: "Refunds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                schema: "dbo",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                schema: "dbo",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MenuItems",
                schema: "dbo",
                table: "MenuItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MenuItemImages",
                schema: "dbo",
                table: "MenuItemImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealTypes",
                schema: "dbo",
                table: "MealTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealCourses",
                schema: "dbo",
                table: "MealCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Feedbacks",
                schema: "dbo",
                table: "Feedbacks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                schema: "dbo",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DishTypes",
                schema: "dbo",
                table: "DishTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                schema: "dbo",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cuisines",
                schema: "dbo",
                table: "Cuisines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                schema: "dbo",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItems",
                schema: "dbo",
                table: "CartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cancellations",
                schema: "dbo",
                table: "Cancellations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                schema: "dbo",
                table: "Addresses");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "DishTypes",
                keyColumn: "DishTypeId",
                keyValue: 18L);

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

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "dbo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "dbo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "dbo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                schema: "dbo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiry",
                schema: "dbo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Allergens",
                schema: "dbo",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "Calories",
                schema: "dbo",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "dbo",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                schema: "dbo",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "PreparationTimeInMinutes",
                schema: "dbo",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "dbo",
                table: "MealTypes");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "dbo",
                table: "MealCourses");

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                schema: "dbo",
                table: "MealCourses");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "dbo",
                table: "DishTypes");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "dbo",
                table: "Cuisines");

            migrationBuilder.DropColumn(
                name: "Region",
                schema: "dbo",
                table: "Cuisines");

            migrationBuilder.RenameTable(
                name: "Restaurants",
                schema: "dbo",
                newName: "Restaurant",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Reservations",
                schema: "dbo",
                newName: "Reservation",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Refunds",
                schema: "dbo",
                newName: "Refund",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Payments",
                schema: "dbo",
                newName: "Payment",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Orders",
                schema: "dbo",
                newName: "Order",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                schema: "dbo",
                newName: "OrderItem",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "MenuItems",
                schema: "dbo",
                newName: "MenuItem",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "MenuItemImages",
                schema: "dbo",
                newName: "MenuItemImage",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "MealTypes",
                schema: "dbo",
                newName: "MealCategory",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "MealCourses",
                schema: "dbo",
                newName: "MealCourse",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Feedbacks",
                schema: "dbo",
                newName: "Feedback",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Employees",
                schema: "dbo",
                newName: "Employee",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "DishTypes",
                schema: "dbo",
                newName: "SubCategory",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Customers",
                schema: "dbo",
                newName: "Customer",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Cuisines",
                schema: "dbo",
                newName: "Cuisine",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Carts",
                schema: "dbo",
                newName: "Cart",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "CartItems",
                schema: "dbo",
                newName: "CartItem",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Cancellations",
                schema: "dbo",
                newName: "Cancellation",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Addresses",
                schema: "dbo",
                newName: "Address",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "RestaurantsRestaurantId",
                schema: "dbo",
                table: "CuisineRestaurant",
                newName: "RestaurantId");

            migrationBuilder.RenameIndex(
                name: "IX_CuisineRestaurant_RestaurantsRestaurantId",
                schema: "dbo",
                table: "CuisineRestaurant",
                newName: "IX_CuisineRestaurant_RestaurantId");

            migrationBuilder.RenameIndex(
                name: "IX_Refunds_PaymentId",
                schema: "dbo",
                table: "Refund",
                newName: "IX_Refund_PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_Refunds_CancellationId",
                schema: "dbo",
                table: "Refund",
                newName: "IX_Refund_CancellationId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_OrderID",
                schema: "dbo",
                table: "Payment",
                newName: "IX_Payment_OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ShippingAddressID",
                schema: "dbo",
                table: "Order",
                newName: "IX_Order_ShippingAddressID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerID",
                schema: "dbo",
                table: "Order",
                newName: "IX_Order_CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_BillingAddressID",
                schema: "dbo",
                table: "Order",
                newName: "IX_Order_BillingAddressID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderID",
                schema: "dbo",
                table: "OrderItem",
                newName: "IX_OrderItem_OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_MenuItemID",
                schema: "dbo",
                table: "OrderItem",
                newName: "IX_OrderItem_MenuItemID");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItems_RestaurantId",
                schema: "dbo",
                table: "MenuItem",
                newName: "IX_MenuItem_RestaurantId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItems_MealTypeId",
                schema: "dbo",
                table: "MenuItem",
                newName: "IX_MenuItem_MealTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItems_MealCourseId",
                schema: "dbo",
                table: "MenuItem",
                newName: "IX_MenuItem_MealCourseId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItems_CuisineId",
                schema: "dbo",
                table: "MenuItem",
                newName: "IX_MenuItem_CuisineId");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "dbo",
                table: "MealCourse",
                newName: "MealType");

            migrationBuilder.RenameIndex(
                name: "IX_Feedbacks_RestaurantId",
                schema: "dbo",
                table: "Feedback",
                newName: "IX_Feedback_RestaurantId");

            migrationBuilder.RenameIndex(
                name: "IX_Feedbacks_CustomerId",
                schema: "dbo",
                table: "Feedback",
                newName: "IX_Feedback_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_RestaurantId",
                schema: "dbo",
                table: "Employee",
                newName: "IX_Employee_RestaurantId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_ApplicationUserId",
                schema: "dbo",
                table: "Employee",
                newName: "IX_Employee_ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                schema: "dbo",
                table: "Customer",
                newName: "Password");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_ApplicationUserId",
                schema: "dbo",
                table: "Customer",
                newName: "IX_Customer_ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "dbo",
                table: "Cuisine",
                newName: "Type");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_CustomerId",
                schema: "dbo",
                table: "Cart",
                newName: "IX_Cart_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_MenuItemId",
                schema: "dbo",
                table: "CartItem",
                newName: "IX_CartItem_MenuItemId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_CartId",
                schema: "dbo",
                table: "CartItem",
                newName: "IX_CartItem_CartId");

            migrationBuilder.RenameIndex(
                name: "IX_Cancellations_OrderId",
                schema: "dbo",
                table: "Cancellation",
                newName: "IX_Cancellation_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_CustomerID",
                schema: "dbo",
                table: "Address",
                newName: "IX_Address_CustomerID");

            migrationBuilder.AddColumn<long>(
                name: "DishTypeId",
                schema: "dbo",
                table: "MenuItem",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Restaurant",
                schema: "dbo",
                table: "Restaurant",
                column: "RestaurantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                schema: "dbo",
                table: "Reservation",
                column: "ReservationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Refund",
                schema: "dbo",
                table: "Refund",
                column: "RefundId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                schema: "dbo",
                table: "Payment",
                column: "PaymentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                schema: "dbo",
                table: "Order",
                column: "OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItem",
                schema: "dbo",
                table: "OrderItem",
                column: "OrderItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MenuItem",
                schema: "dbo",
                table: "MenuItem",
                column: "MenuItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MenuItemImage",
                schema: "dbo",
                table: "MenuItemImage",
                column: "MenuItemImageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealCategory",
                schema: "dbo",
                table: "MealCategory",
                column: "MealTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealCourse",
                schema: "dbo",
                table: "MealCourse",
                column: "MealCourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feedback",
                schema: "dbo",
                table: "Feedback",
                column: "FeedbackId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                schema: "dbo",
                table: "Employee",
                column: "EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategory",
                schema: "dbo",
                table: "SubCategory",
                column: "DishTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                schema: "dbo",
                table: "Customer",
                column: "CustomerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cuisine",
                schema: "dbo",
                table: "Cuisine",
                column: "CuisineID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                schema: "dbo",
                table: "Cart",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItem",
                schema: "dbo",
                table: "CartItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cancellation",
                schema: "dbo",
                table: "Cancellation",
                column: "CancellationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                schema: "dbo",
                table: "Address",
                column: "AddressID");

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

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_DishTypeId",
                schema: "dbo",
                table: "MenuItem",
                column: "DishTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Customer_CustomerID",
                schema: "dbo",
                table: "Address",
                column: "CustomerID",
                principalSchema: "dbo",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cancellation_Order_OrderId",
                schema: "dbo",
                table: "Cancellation",
                column: "OrderId",
                principalSchema: "dbo",
                principalTable: "Order",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Customer_CustomerId",
                schema: "dbo",
                table: "Cart",
                column: "CustomerId",
                principalSchema: "dbo",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Cart_CartId",
                schema: "dbo",
                table: "CartItem",
                column: "CartId",
                principalSchema: "dbo",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_MenuItem_MenuItemId",
                schema: "dbo",
                table: "CartItem",
                column: "MenuItemId",
                principalSchema: "dbo",
                principalTable: "MenuItem",
                principalColumn: "MenuItemID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CuisineRestaurant_Cuisine_CuisineID",
                schema: "dbo",
                table: "CuisineRestaurant",
                column: "CuisineID",
                principalSchema: "dbo",
                principalTable: "Cuisine",
                principalColumn: "CuisineID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CuisineRestaurant_Restaurant_RestaurantId",
                schema: "dbo",
                table: "CuisineRestaurant",
                column: "RestaurantId",
                principalSchema: "dbo",
                principalTable: "Restaurant",
                principalColumn: "RestaurantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Users_ApplicationUserId",
                schema: "dbo",
                table: "Customer",
                column: "ApplicationUserId",
                principalSchema: "dbo",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Restaurant_RestaurantId",
                schema: "dbo",
                table: "Employee",
                column: "RestaurantId",
                principalSchema: "dbo",
                principalTable: "Restaurant",
                principalColumn: "RestaurantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Users_ApplicationUserId",
                schema: "dbo",
                table: "Employee",
                column: "ApplicationUserId",
                principalSchema: "dbo",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Customer_CustomerId",
                schema: "dbo",
                table: "Feedback",
                column: "CustomerId",
                principalSchema: "dbo",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Restaurant_RestaurantId",
                schema: "dbo",
                table: "Feedback",
                column: "RestaurantId",
                principalSchema: "dbo",
                principalTable: "Restaurant",
                principalColumn: "RestaurantId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_Cuisine_CuisineId",
                schema: "dbo",
                table: "MenuItem",
                column: "CuisineId",
                principalSchema: "dbo",
                principalTable: "Cuisine",
                principalColumn: "CuisineID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_MealCategory_MealTypeId",
                schema: "dbo",
                table: "MenuItem",
                column: "MealTypeId",
                principalSchema: "dbo",
                principalTable: "MealCategory",
                principalColumn: "MealTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_MealCourse_MealCourseId",
                schema: "dbo",
                table: "MenuItem",
                column: "MealCourseId",
                principalSchema: "dbo",
                principalTable: "MealCourse",
                principalColumn: "MealCourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_MenuItemImage_MenuItemID",
                schema: "dbo",
                table: "MenuItem",
                column: "MenuItemID",
                principalSchema: "dbo",
                principalTable: "MenuItemImage",
                principalColumn: "MenuItemImageID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_Restaurant_RestaurantId",
                schema: "dbo",
                table: "MenuItem",
                column: "RestaurantId",
                principalSchema: "dbo",
                principalTable: "Restaurant",
                principalColumn: "RestaurantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_SubCategory_DishTypeId",
                schema: "dbo",
                table: "MenuItem",
                column: "DishTypeId",
                principalSchema: "dbo",
                principalTable: "SubCategory",
                principalColumn: "DishTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Address_BillingAddressID",
                schema: "dbo",
                table: "Order",
                column: "BillingAddressID",
                principalSchema: "dbo",
                principalTable: "Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Address_ShippingAddressID",
                schema: "dbo",
                table: "Order",
                column: "ShippingAddressID",
                principalSchema: "dbo",
                principalTable: "Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_CustomerID",
                schema: "dbo",
                table: "Order",
                column: "CustomerID",
                principalSchema: "dbo",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_MenuItem_MenuItemID",
                schema: "dbo",
                table: "OrderItem",
                column: "MenuItemID",
                principalSchema: "dbo",
                principalTable: "MenuItem",
                principalColumn: "MenuItemID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderID",
                schema: "dbo",
                table: "OrderItem",
                column: "OrderID",
                principalSchema: "dbo",
                principalTable: "Order",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Order_OrderID",
                schema: "dbo",
                table: "Payment",
                column: "OrderID",
                principalSchema: "dbo",
                principalTable: "Order",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refund_Cancellation_CancellationId",
                schema: "dbo",
                table: "Refund",
                column: "CancellationId",
                principalSchema: "dbo",
                principalTable: "Cancellation",
                principalColumn: "CancellationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refund_Payment_PaymentId",
                schema: "dbo",
                table: "Refund",
                column: "PaymentId",
                principalSchema: "dbo",
                principalTable: "Payment",
                principalColumn: "PaymentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Customer_ReservationID",
                schema: "dbo",
                table: "Reservation",
                column: "ReservationID",
                principalSchema: "dbo",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Restaurant_ReservationID",
                schema: "dbo",
                table: "Reservation",
                column: "ReservationID",
                principalSchema: "dbo",
                principalTable: "Restaurant",
                principalColumn: "RestaurantId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
