using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestEfCoreProject.Migrations
{
    /// <inheritdoc />
    public partial class RenameContentToDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Posts",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Posts",
                newName: "Content");
        }
    }
}
