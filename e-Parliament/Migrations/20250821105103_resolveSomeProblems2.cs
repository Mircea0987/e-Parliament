using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Parliament.Migrations
{
    /// <inheritdoc />
    public partial class resolveSomeProblems2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_parlamentar_group_members_commission_members_CommissionMemb~",
                table: "parlamentar_group_members");

            migrationBuilder.DropForeignKey(
                name: "FK_parlamentar_group_members_parlamentar_groups_MembersId",
                table: "parlamentar_group_members");

            migrationBuilder.DropIndex(
                name: "IX_parlamentar_group_members_CommissionMemberId",
                table: "parlamentar_group_members");

            migrationBuilder.DropIndex(
                name: "IX_parlamentar_group_members_MembersId",
                table: "parlamentar_group_members");

            migrationBuilder.DropColumn(
                name: "CommissionMemberId",
                table: "parlamentar_group_members");

            migrationBuilder.DropColumn(
                name: "MembersId",
                table: "parlamentar_group_members");

            migrationBuilder.RenameColumn(
                name: "Id_legislature",
                table: "parlamentar_group_members",
                newName: "legislature_id");

            migrationBuilder.RenameColumn(
                name: "id_members",
                table: "parlamentar_group_members",
                newName: "member_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_parlamentar_group_members_member_group_id",
                table: "parlamentar_group_members",
                column: "member_group_id");

            migrationBuilder.AddForeignKey(
                name: "FK_parlamentar_group_members_commission_members_member_group_id",
                table: "parlamentar_group_members",
                column: "member_group_id",
                principalTable: "commission_members",
                principalColumn: "commission_member_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_parlamentar_group_members_parlamentar_groups_id_parlamentar~",
                table: "parlamentar_group_members",
                column: "id_parlamentar_group",
                principalTable: "parlamentar_groups",
                principalColumn: "parlamentar_group_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_parlamentar_group_members_commission_members_member_group_id",
                table: "parlamentar_group_members");

            migrationBuilder.DropForeignKey(
                name: "FK_parlamentar_group_members_parlamentar_groups_id_parlamentar~",
                table: "parlamentar_group_members");

            migrationBuilder.DropIndex(
                name: "IX_parlamentar_group_members_member_group_id",
                table: "parlamentar_group_members");

            migrationBuilder.RenameColumn(
                name: "legislature_id",
                table: "parlamentar_group_members",
                newName: "Id_legislature");

            migrationBuilder.RenameColumn(
                name: "member_group_id",
                table: "parlamentar_group_members",
                newName: "id_members");

            migrationBuilder.AddColumn<int>(
                name: "CommissionMemberId",
                table: "parlamentar_group_members",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MembersId",
                table: "parlamentar_group_members",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_parlamentar_group_members_CommissionMemberId",
                table: "parlamentar_group_members",
                column: "CommissionMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_parlamentar_group_members_MembersId",
                table: "parlamentar_group_members",
                column: "MembersId");

            migrationBuilder.AddForeignKey(
                name: "FK_parlamentar_group_members_commission_members_CommissionMemb~",
                table: "parlamentar_group_members",
                column: "CommissionMemberId",
                principalTable: "commission_members",
                principalColumn: "commission_member_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_parlamentar_group_members_parlamentar_groups_MembersId",
                table: "parlamentar_group_members",
                column: "MembersId",
                principalTable: "parlamentar_groups",
                principalColumn: "parlamentar_group_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
