using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NmcWbapi.Migrations
{
    /// <inheritdoc />
    public partial class dd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "nmcStudents");

            migrationBuilder.AddPrimaryKey(
                name: "PK_nmcStudents",
                table: "nmcStudents",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_nmcStudents",
                table: "nmcStudents");

            migrationBuilder.RenameTable(
                name: "nmcStudents",
                newName: "Students");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "id");
        }
    }
}
