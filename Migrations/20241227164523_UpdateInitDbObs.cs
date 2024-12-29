using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ObsApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateInitDbObs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
                name: "PK_OgrenciDersler",
                table: "OgrenciDersler",
                column: "TempKey");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OgrenciDersler",
                table: "OgrenciDersler");
        }
    }
}
