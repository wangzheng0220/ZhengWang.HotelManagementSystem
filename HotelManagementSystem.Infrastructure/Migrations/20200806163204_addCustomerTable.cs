using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagementSystem.Infrastructure.Migrations
{
    public partial class addCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Roomno = table.Column<int>(nullable: false),
                    Cname = table.Column<string>(maxLength: 20, nullable: true),
                    Address = table.Column<string>(maxLength: 100, nullable: true),
                    Phone = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 40, nullable: true),
                    Checkin = table.Column<DateTime>(nullable: false),
                    TotalPersons = table.Column<int>(nullable: false),
                    Bookingdays = table.Column<int>(nullable: false),
                    Advance = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
