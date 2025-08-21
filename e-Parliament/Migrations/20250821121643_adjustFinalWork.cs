using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Parliament.Migrations
{
    /// <inheritdoc />
    public partial class adjustFinalWork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_meeting_attendaces_meetings_meeting_id",
                table: "meeting_attendaces");

            migrationBuilder.DropForeignKey(
                name: "FK_parlamentar_group_members_parlamentar_groups_id_parlamentar~",
                table: "parlamentar_group_members");

            migrationBuilder.DropForeignKey(
                name: "FK_parliamentarians_members_parliamentarians_parlamentar_id",
                table: "parliamentarians_members");

            migrationBuilder.DropPrimaryKey(
                name: "PK_meeting_attendaces",
                table: "meeting_attendaces");

            migrationBuilder.RenameTable(
                name: "meeting_attendaces",
                newName: "meeting_attendances");

            migrationBuilder.RenameColumn(
                name: "parlamentar_id",
                table: "parliamentarians_members",
                newName: "parliamentarian_id");

            migrationBuilder.RenameColumn(
                name: "id_parlamentar_group",
                table: "parlamentar_group_members",
                newName: "parlamentar_group_id");

            migrationBuilder.RenameIndex(
                name: "IX_meeting_attendaces_meeting_id",
                table: "meeting_attendances",
                newName: "IX_meeting_attendances_meeting_id");

            migrationBuilder.AddColumn<string>(
                name: "file_path",
                table: "document_types",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_meeting_attendances",
                table: "meeting_attendances",
                column: "meeting_attendance_id");

            migrationBuilder.AddForeignKey(
                name: "FK_meeting_attendances_meetings_meeting_id",
                table: "meeting_attendances",
                column: "meeting_id",
                principalTable: "meetings",
                principalColumn: "meeting_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_parlamentar_group_members_parlamentar_groups_parlamentar_gr~",
                table: "parlamentar_group_members",
                column: "parlamentar_group_id",
                principalTable: "parlamentar_groups",
                principalColumn: "parlamentar_group_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_parliamentarians_members_parliamentarians_parliamentarian_id",
                table: "parliamentarians_members",
                column: "parliamentarian_id",
                principalTable: "parliamentarians",
                principalColumn: "parliamentarian_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_meeting_attendances_meetings_meeting_id",
                table: "meeting_attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_parlamentar_group_members_parlamentar_groups_parlamentar_gr~",
                table: "parlamentar_group_members");

            migrationBuilder.DropForeignKey(
                name: "FK_parliamentarians_members_parliamentarians_parliamentarian_id",
                table: "parliamentarians_members");

            migrationBuilder.DropPrimaryKey(
                name: "PK_meeting_attendances",
                table: "meeting_attendances");

            migrationBuilder.DropColumn(
                name: "file_path",
                table: "document_types");

            migrationBuilder.RenameTable(
                name: "meeting_attendances",
                newName: "meeting_attendaces");

            migrationBuilder.RenameColumn(
                name: "parliamentarian_id",
                table: "parliamentarians_members",
                newName: "parlamentar_id");

            migrationBuilder.RenameColumn(
                name: "parlamentar_group_id",
                table: "parlamentar_group_members",
                newName: "id_parlamentar_group");

            migrationBuilder.RenameIndex(
                name: "IX_meeting_attendances_meeting_id",
                table: "meeting_attendaces",
                newName: "IX_meeting_attendaces_meeting_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_meeting_attendaces",
                table: "meeting_attendaces",
                column: "meeting_attendance_id");

            migrationBuilder.AddForeignKey(
                name: "FK_meeting_attendaces_meetings_meeting_id",
                table: "meeting_attendaces",
                column: "meeting_id",
                principalTable: "meetings",
                principalColumn: "meeting_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_parlamentar_group_members_parlamentar_groups_id_parlamentar~",
                table: "parlamentar_group_members",
                column: "id_parlamentar_group",
                principalTable: "parlamentar_groups",
                principalColumn: "parlamentar_group_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_parliamentarians_members_parliamentarians_parlamentar_id",
                table: "parliamentarians_members",
                column: "parlamentar_id",
                principalTable: "parliamentarians",
                principalColumn: "parliamentarian_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
