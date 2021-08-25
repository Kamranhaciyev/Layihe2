using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalLayihesi.Migrations
{
    public partial class _11223344 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Gallery_GalleryId",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gallery",
                table: "Gallery");

            migrationBuilder.RenameTable(
                name: "Gallery",
                newName: "Galleries");

            migrationBuilder.AddColumn<string>(
                name: "MainImage",
                table: "Blogs",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Galleries",
                table: "Galleries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Galleries_GalleryId",
                table: "Blogs",
                column: "GalleryId",
                principalTable: "Galleries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Galleries_GalleryId",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Galleries",
                table: "Galleries");

            migrationBuilder.DropColumn(
                name: "MainImage",
                table: "Blogs");

            migrationBuilder.RenameTable(
                name: "Galleries",
                newName: "Gallery");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gallery",
                table: "Gallery",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Gallery_GalleryId",
                table: "Blogs",
                column: "GalleryId",
                principalTable: "Gallery",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
