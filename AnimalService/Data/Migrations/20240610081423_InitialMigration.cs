using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimalService.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublicId = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "Breed", "Color", "CoverImageUrl", "CreatedAt", "Description", "Name", "PublicId", "Sex", "Status", "Type", "UpdatedAt", "Weight" },
                values: new object[,]
                {
                    { new Guid("3209988b-c0f2-4328-9b67-358f1028182d"), 5, "Bengal cat", "Beige", "https://placekitten.com/200/200", new DateTime(2024, 6, 10, 8, 14, 22, 728, DateTimeKind.Utc).AddTicks(2005), "lorem ipsum", "Buttercup", 2, "Male", 0, "Cat", new DateTime(2024, 6, 10, 8, 14, 22, 728, DateTimeKind.Utc).AddTicks(2007), 5 },
                    { new Guid("3ab0a2c9-8057-4ddb-b3c0-1d1309d8abf3"), 2, "Double doodle", "White", "https://placedog.net/500", new DateTime(2024, 6, 10, 8, 14, 22, 728, DateTimeKind.Utc).AddTicks(1553), "lorem ipsum", "Dee Dee", 1, "Female", 0, "Dog", new DateTime(2024, 6, 10, 8, 14, 22, 728, DateTimeKind.Utc).AddTicks(1555), 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
