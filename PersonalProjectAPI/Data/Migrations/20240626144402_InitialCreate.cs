using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalProjectAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stands",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Power = table.Column<char>(type: "TEXT", nullable: false),
                    Speed = table.Column<char>(type: "TEXT", nullable: false),
                    Range = table.Column<char>(type: "TEXT", nullable: false),
                    Persistence = table.Column<char>(type: "TEXT", nullable: false),
                    Precision = table.Column<char>(type: "TEXT", nullable: false),
                    Potential = table.Column<char>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stands", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stands");
        }
    }
}
