using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Parliament.Migrations
{
    /// <inheritdoc />
    public partial class addActionsMM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountTypeAction",
                columns: table => new
                {
                    IdAccountType = table.Column<int>(type: "integer", nullable: false),
                    IdAction = table.Column<int>(type: "integer", nullable: false),
                    AccountTypeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTypeAction", x => new { x.IdAccountType, x.IdAction });
                    table.ForeignKey(
                        name: "FK_AccountTypeAction_account_types_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "account_types",
                        principalColumn: "account_type_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountTypeAction_AccountTypeId",
                table: "AccountTypeAction",
                column: "AccountTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountTypeAction");
        }
    }
}
