using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagementSystem.Infrastructure.Migrations
{
    public partial class addRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Services",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomTypeId",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_RoomId",
                table: "Services",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RoomId",
                table: "Customers",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Rooms_RoomId",
                table: "Customers",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomTypes_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Rooms_RoomId",
                table: "Services",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Rooms_RoomId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomTypes_RoomTypeId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Rooms_RoomId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_RoomId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Customers_RoomId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "RoomTypeId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Customers");
        }
    }
}
