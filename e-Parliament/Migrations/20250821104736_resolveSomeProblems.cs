using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Parliament.Migrations
{
    /// <inheritdoc />
    public partial class resolveSomeProblems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_meeting_documents_document_types_DocumentTypeNavigationId",
                table: "meeting_documents");

            migrationBuilder.DropForeignKey(
                name: "FK_parliamentarians_room_types_RoomTypeId",
                table: "parliamentarians");

            migrationBuilder.DropForeignKey(
                name: "FK_parliamentarians_members_commission_members_CommissionMembe~",
                table: "parliamentarians_members");

            migrationBuilder.DropForeignKey(
                name: "FK_parliamentarians_members_parliamentarians_ParliamentarianId",
                table: "parliamentarians_members");

            migrationBuilder.DropIndex(
                name: "IX_parliamentarians_members_CommissionMemberId",
                table: "parliamentarians_members");

            migrationBuilder.DropIndex(
                name: "IX_parliamentarians_members_ParliamentarianId",
                table: "parliamentarians_members");

            migrationBuilder.DropIndex(
                name: "IX_parliamentarians_RoomTypeId",
                table: "parliamentarians");

            migrationBuilder.DropIndex(
                name: "IX_meeting_documents_DocumentTypeNavigationId",
                table: "meeting_documents");

            migrationBuilder.DropColumn(
                name: "CommissionMemberId",
                table: "parliamentarians_members");

            migrationBuilder.DropColumn(
                name: "ParliamentarianId",
                table: "parliamentarians_members");

            migrationBuilder.DropColumn(
                name: "RoomTypeId",
                table: "parliamentarians");

            migrationBuilder.DropColumn(
                name: "DocumentTypeNavigationId",
                table: "meeting_documents");

            migrationBuilder.RenameColumn(
                name: "id_commission_members",
                table: "parliamentarians_members",
                newName: "commission_members_id");

            migrationBuilder.RenameColumn(
                name: "id_parlamentar",
                table: "parliamentarians_members",
                newName: "parlamentar_id");

            migrationBuilder.CreateIndex(
                name: "IX_parliamentarians_members_commission_members_id",
                table: "parliamentarians_members",
                column: "commission_members_id");

            migrationBuilder.CreateIndex(
                name: "IX_parliamentarians_id_room_type",
                table: "parliamentarians",
                column: "id_room_type");

            migrationBuilder.CreateIndex(
                name: "IX_meeting_documents_document_type_id",
                table: "meeting_documents",
                column: "document_type_id");

            migrationBuilder.AddForeignKey(
                name: "FK_meeting_documents_document_types_document_type_id",
                table: "meeting_documents",
                column: "document_type_id",
                principalTable: "document_types",
                principalColumn: "document_type_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_parliamentarians_room_types_id_room_type",
                table: "parliamentarians",
                column: "id_room_type",
                principalTable: "room_types",
                principalColumn: "room_type_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_parliamentarians_members_commission_members_commission_memb~",
                table: "parliamentarians_members",
                column: "commission_members_id",
                principalTable: "commission_members",
                principalColumn: "commission_member_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_parliamentarians_members_parliamentarians_parlamentar_id",
                table: "parliamentarians_members",
                column: "parlamentar_id",
                principalTable: "parliamentarians",
                principalColumn: "parliamentarian_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_meeting_documents_document_types_document_type_id",
                table: "meeting_documents");

            migrationBuilder.DropForeignKey(
                name: "FK_parliamentarians_room_types_id_room_type",
                table: "parliamentarians");

            migrationBuilder.DropForeignKey(
                name: "FK_parliamentarians_members_commission_members_commission_memb~",
                table: "parliamentarians_members");

            migrationBuilder.DropForeignKey(
                name: "FK_parliamentarians_members_parliamentarians_parlamentar_id",
                table: "parliamentarians_members");

            migrationBuilder.DropIndex(
                name: "IX_parliamentarians_members_commission_members_id",
                table: "parliamentarians_members");

            migrationBuilder.DropIndex(
                name: "IX_parliamentarians_id_room_type",
                table: "parliamentarians");

            migrationBuilder.DropIndex(
                name: "IX_meeting_documents_document_type_id",
                table: "meeting_documents");

            migrationBuilder.RenameColumn(
                name: "commission_members_id",
                table: "parliamentarians_members",
                newName: "id_commission_members");

            migrationBuilder.RenameColumn(
                name: "parlamentar_id",
                table: "parliamentarians_members",
                newName: "id_parlamentar");

            migrationBuilder.AddColumn<int>(
                name: "CommissionMemberId",
                table: "parliamentarians_members",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParliamentarianId",
                table: "parliamentarians_members",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomTypeId",
                table: "parliamentarians",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DocumentTypeNavigationId",
                table: "meeting_documents",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_parliamentarians_members_CommissionMemberId",
                table: "parliamentarians_members",
                column: "CommissionMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_parliamentarians_members_ParliamentarianId",
                table: "parliamentarians_members",
                column: "ParliamentarianId");

            migrationBuilder.CreateIndex(
                name: "IX_parliamentarians_RoomTypeId",
                table: "parliamentarians",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_meeting_documents_DocumentTypeNavigationId",
                table: "meeting_documents",
                column: "DocumentTypeNavigationId");

            migrationBuilder.AddForeignKey(
                name: "FK_meeting_documents_document_types_DocumentTypeNavigationId",
                table: "meeting_documents",
                column: "DocumentTypeNavigationId",
                principalTable: "document_types",
                principalColumn: "document_type_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_parliamentarians_room_types_RoomTypeId",
                table: "parliamentarians",
                column: "RoomTypeId",
                principalTable: "room_types",
                principalColumn: "room_type_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_parliamentarians_members_commission_members_CommissionMembe~",
                table: "parliamentarians_members",
                column: "CommissionMemberId",
                principalTable: "commission_members",
                principalColumn: "commission_member_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_parliamentarians_members_parliamentarians_ParliamentarianId",
                table: "parliamentarians_members",
                column: "ParliamentarianId",
                principalTable: "parliamentarians",
                principalColumn: "parliamentarian_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
