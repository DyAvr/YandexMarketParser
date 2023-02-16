using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YandexMarketParser.Migrations
{
    /// <inheritdoc />
    public partial class InitialUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Available",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Bid",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Cbid",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "CountryOfOrigin",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Delivery",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "LocalDeliveryCost",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "ManufacturerWarranty",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "VendorCode",
                table: "Offers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Available",
                table: "Offers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Bid",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Cbid",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CountryOfOrigin",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Delivery",
                table: "Offers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LocalDeliveryCost",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ManufacturerWarranty",
                table: "Offers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VendorCode",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
