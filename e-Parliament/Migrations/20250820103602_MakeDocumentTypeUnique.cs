using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Parliament.Migrations
{
    /// <inheritdoc />
    public partial class MakeDocumentTypeUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_document_types_document_type",
                table: "document_types",
                column: "document_type",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_document_types_document_type",
                table: "document_types");
        }
    }
}
