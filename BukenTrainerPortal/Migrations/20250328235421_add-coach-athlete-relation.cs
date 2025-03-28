using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BukenTrainerPortal.Migrations
{
    /// <inheritdoc />
    public partial class addcoachathleterelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "CoachId",
                table: "Athletes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Athletes_CoachId",
                table: "Athletes",
                column: "CoachId");

            migrationBuilder.AddForeignKey(
                name: "FK_Athletes_Coaches_CoachId",
                table: "Athletes",
                column: "CoachId",
                principalTable: "Coaches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Athletes_Coaches_CoachId",
                table: "Athletes");

            migrationBuilder.DropIndex(
                name: "IX_Athletes_CoachId",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "CoachId",
                table: "Athletes");

            migrationBuilder.InsertData(
                table: "Athletes",
                columns: new[] { "ID", "CreatedAt", "FirstName", "LastName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luken", "Buken", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Smith", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
