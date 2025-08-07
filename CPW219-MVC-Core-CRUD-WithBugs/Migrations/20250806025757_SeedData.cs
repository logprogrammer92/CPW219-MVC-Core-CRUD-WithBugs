using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CPW219_MVC_Core_CRUD_WithBugs.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateOnly(2000, 1, 15), "Alice", "Smith" },
                    { 2, new DateOnly(2001, 2, 20), "Bob", "Johnson" },
                    { 3, new DateOnly(2002, 3, 10), "Carol", "Williams" },
                    { 4, new DateOnly(2000, 4, 5), "David", "Brown" },
                    { 5, new DateOnly(2001, 5, 25), "Eve", "Jones" },
                    { 6, new DateOnly(2002, 6, 30), "Frank", "Garcia" },
                    { 7, new DateOnly(2000, 7, 12), "Grace", "Martinez" },
                    { 8, new DateOnly(2001, 8, 18), "Hank", "Rodriguez" },
                    { 9, new DateOnly(2002, 9, 22), "Ivy", "Lee" },
                    { 10, new DateOnly(2000, 10, 8), "Jack", "Walker" },
                    { 11, new DateOnly(2001, 11, 14), "Kara", "Hall" },
                    { 12, new DateOnly(2002, 12, 19), "Leo", "Allen" },
                    { 13, new DateOnly(2000, 1, 3), "Mona", "Young" },
                    { 14, new DateOnly(2001, 2, 9), "Nate", "Hernandez" },
                    { 15, new DateOnly(2002, 3, 15), "Olive", "King" },
                    { 16, new DateOnly(2000, 4, 21), "Paul", "Wright" },
                    { 17, new DateOnly(2001, 5, 27), "Quinn", "Lopez" },
                    { 18, new DateOnly(2002, 6, 2), "Rita", "Hill" },
                    { 19, new DateOnly(2000, 7, 7), "Sam", "Scott" },
                    { 20, new DateOnly(2001, 8, 13), "Tina", "Green" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 20);
        }
    }
}
