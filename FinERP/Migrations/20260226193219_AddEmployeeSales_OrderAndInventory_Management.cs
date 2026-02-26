using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinERP.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeSales_OrderAndInventory_Management : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Department = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    HireDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SalaryUSD = table.Column<int>(type: "INTEGER", nullable: false),
                    Region = table.Column<string>(type: "TEXT", nullable: false),
                    Employment_Status = table.Column<bool>(type: "INTEGER", nullable: false),
                    Manager_ID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventoryManagements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    WarehouseID = table.Column<int>(type: "INTEGER", nullable: false),
                    ShelfLocation = table.Column<string>(type: "TEXT", nullable: false),
                    QtyOnHand = table.Column<int>(type: "INTEGER", nullable: false),
                    ReorderPoint = table.Column<int>(type: "INTEGER", nullable: false),
                    LeadTimeDays = table.Column<int>(type: "INTEGER", nullable: false),
                    UnitCost = table.Column<int>(type: "INTEGER", nullable: false),
                    LastAuditDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryManagements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: false),
                    ProductSKU = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    TaxRate = table.Column<decimal>(type: "TEXT", nullable: false),
                    TotalAmount = table.Column<int>(type: "INTEGER", nullable: false),
                    status = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrders", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "InventoryManagements");

            migrationBuilder.DropTable(
                name: "SalesOrders");
        }
    }
}
