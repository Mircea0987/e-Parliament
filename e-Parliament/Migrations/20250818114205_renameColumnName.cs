using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Parliament.Migrations
{
    /// <inheritdoc />
    public partial class renameColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_account_types_AccountTypeId",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "AccountTypeId",
                table: "users",
                newName: "account_type_id");

            migrationBuilder.RenameIndex(
                name: "IX_users_AccountTypeId",
                table: "users",
                newName: "IX_users_account_type_id");

            migrationBuilder.AddForeignKey(
                name: "FK_users_account_types_account_type_id",
                table: "users",
                column: "account_type_id",
                principalTable: "account_types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_account_types_account_type_id",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "account_type_id",
                table: "users",
                newName: "AccountTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_users_account_type_id",
                table: "users",
                newName: "IX_users_AccountTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_account_types_AccountTypeId",
                table: "users",
                column: "AccountTypeId",
                principalTable: "account_types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
