using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Parliament.Migrations
{
    /// <inheritdoc />
    public partial class renameMore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "users",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "users",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "users",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "HashPassword",
                table: "users",
                newName: "hash_password");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "users",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "users",
                newName: "date_of_birth");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "users",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "Actions",
                table: "account_types",
                newName: "actions");

            migrationBuilder.RenameColumn(
                name: "TypeName",
                table: "account_types",
                newName: "type_name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "account_types",
                newName: "account_type_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "email",
                table: "users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "users",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "users",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "hash_password",
                table: "users",
                newName: "HashPassword");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "date_of_birth",
                table: "users",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "actions",
                table: "account_types",
                newName: "Actions");

            migrationBuilder.RenameColumn(
                name: "type_name",
                table: "account_types",
                newName: "TypeName");

            migrationBuilder.RenameColumn(
                name: "account_type_id",
                table: "account_types",
                newName: "Id");
        }
    }
}
