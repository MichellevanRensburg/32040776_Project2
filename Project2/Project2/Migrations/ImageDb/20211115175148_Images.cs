using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Migrations.ImageDb
{
    public partial class Images : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    imageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imageName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    imageFileName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    geoloaction = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    tag = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    capturedDate = table.Column<DateTime>(type: "date", nullable: false),
                    capturedBy = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.imageId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
