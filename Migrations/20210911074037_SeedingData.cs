using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace book_store.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "BookCategoryId", "Name" },
                values: new object[] { new Guid("1eab193f-a3ed-cab0-43af-094bb24f24ce"), "Fiction" });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "BookCategoryId", "Name" },
                values: new object[] { new Guid("2efa4bdf-35ad-cdab-42da-ed09edc1aecb"), "Thriller" });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "BookCategoryId", "Name" },
                values: new object[] { new Guid("3d04ccba-9eac-b2ea-bcf3-95feaaedabc4"), "Sci-Fi" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "BookCategoryId", "Description", "ISBN", "Name", "ReleaseDate" },
                values: new object[] { new Guid("3d04ccba-9eac-b2ea-bcf3-95feaaedabc9"), new Guid("1eab193f-a3ed-cab0-43af-094bb24f24ce"), "dfsdpasdad", "8429825", "The Other Book", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "BookCategoryId", "Description", "ISBN", "Name", "ReleaseDate" },
                values: new object[] { new Guid("3d04ccba-9eac-b2ea-bcf3-85feaaedabc0"), new Guid("2efa4bdf-35ad-cdab-42da-ed09edc1aecb"), "dkjvbksdvlansdl", "123456", "The New Book", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "BookCategoryId", "Description", "ISBN", "Name", "ReleaseDate" },
                values: new object[] { new Guid("3d04ccba-9eac-b2ea-bcf3-95feaaedabc6"), new Guid("3d04ccba-9eac-b2ea-bcf3-95feaaedabc4"), "sdaknvsdioa", "25764587", "The Life Book", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("3d04ccba-9eac-b2ea-bcf3-85feaaedabc0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("3d04ccba-9eac-b2ea-bcf3-95feaaedabc6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("3d04ccba-9eac-b2ea-bcf3-95feaaedabc9"));

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "BookCategoryId",
                keyValue: new Guid("1eab193f-a3ed-cab0-43af-094bb24f24ce"));

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "BookCategoryId",
                keyValue: new Guid("2efa4bdf-35ad-cdab-42da-ed09edc1aecb"));

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "BookCategoryId",
                keyValue: new Guid("3d04ccba-9eac-b2ea-bcf3-95feaaedabc4"));
        }
    }
}
