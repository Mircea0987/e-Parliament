using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace e_Parliament.Migrations
{
    /// <inheritdoc />
    public partial class addActionsMM2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountTypeAction_account_types_AccountTypeId",
                table: "AccountTypeAction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountTypeAction",
                table: "AccountTypeAction");

            migrationBuilder.RenameTable(
                name: "AccountTypeAction",
                newName: "account_type_actions");

            migrationBuilder.RenameIndex(
                name: "IX_AccountTypeAction_AccountTypeId",
                table: "account_type_actions",
                newName: "IX_account_type_actions_AccountTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_account_type_actions",
                table: "account_type_actions",
                columns: new[] { "IdAccountType", "IdAction" });

            migrationBuilder.CreateTable(
                name: "actions",
                columns: table => new
                {
                    action_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    action_type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actions", x => x.action_id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_account_type_actions_account_types_AccountTypeId",
                table: "account_type_actions",
                column: "AccountTypeId",
                principalTable: "account_types",
                principalColumn: "account_type_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_account_type_actions_account_types_AccountTypeId",
                table: "account_type_actions");

            migrationBuilder.DropTable(
                name: "actions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_account_type_actions",
                table: "account_type_actions");

            migrationBuilder.RenameTable(
                name: "account_type_actions",
                newName: "AccountTypeAction");

            migrationBuilder.RenameIndex(
                name: "IX_account_type_actions_AccountTypeId",
                table: "AccountTypeAction",
                newName: "IX_AccountTypeAction_AccountTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountTypeAction",
                table: "AccountTypeAction",
                columns: new[] { "IdAccountType", "IdAction" });

            migrationBuilder.AddForeignKey(
                name: "FK_AccountTypeAction_account_types_AccountTypeId",
                table: "AccountTypeAction",
                column: "AccountTypeId",
                principalTable: "account_types",
                principalColumn: "account_type_id");
        }
    }
}
