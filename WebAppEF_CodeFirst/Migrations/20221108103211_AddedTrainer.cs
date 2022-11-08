using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppEF_CodeFirst.Migrations
{
    public partial class AddedTrainer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Trainer",
                table: "Batches",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Trainer",
                table: "Batches");
        }
    }
}
