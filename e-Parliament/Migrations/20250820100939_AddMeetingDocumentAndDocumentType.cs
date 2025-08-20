using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace e_Parliament.Migrations
{
    /// <inheritdoc />
    public partial class AddMeetingDocumentAndDocumentType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "type_name",
                table: "account_types",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "document_types",
                columns: table => new
                {
                    document_type_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    document_type = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_document_types", x => x.document_type_id);
                });

            migrationBuilder.CreateTable(
                name: "meeting_documents",
                columns: table => new
                {
                    meeting_document_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    commission_id = table.Column<int>(type: "integer", nullable: false),
                    meeting_id = table.Column<int>(type: "integer", nullable: false),
                    document_name = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    is_shared = table.Column<bool>(type: "boolean", nullable: false),
                    document_type_id = table.Column<int>(type: "integer", nullable: false),
                    DocumentTypeNavigationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_meeting_documents", x => x.meeting_document_id);
                    table.ForeignKey(
                        name: "FK_meeting_documents_document_types_DocumentTypeNavigationId",
                        column: x => x.DocumentTypeNavigationId,
                        principalTable: "document_types",
                        principalColumn: "document_type_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_meeting_documents_DocumentTypeNavigationId",
                table: "meeting_documents",
                column: "DocumentTypeNavigationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "meeting_documents");

            migrationBuilder.DropTable(
                name: "document_types");

            migrationBuilder.AlterColumn<string>(
                name: "type_name",
                table: "account_types",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
