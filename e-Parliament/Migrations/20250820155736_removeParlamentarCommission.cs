using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace e_Parliament.Migrations
{
    /// <inheritdoc />
    public partial class removeParlamentarCommission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_parliamentarians_members_commission_members_commissionMembe~",
                table: "parliamentarians_members");

            migrationBuilder.DropForeignKey(
                name: "FK_parliamentarians_members_parliamentarians_parliamentarianId",
                table: "parliamentarians_members");

            migrationBuilder.DropTable(
                name: "parliament_members");

            migrationBuilder.RenameColumn(
                name: "parliamentarianId",
                table: "parliamentarians_members",
                newName: "ParliamentarianId");

            migrationBuilder.RenameColumn(
                name: "commissionMemberId",
                table: "parliamentarians_members",
                newName: "CommissionMemberId");

            migrationBuilder.RenameIndex(
                name: "IX_parliamentarians_members_parliamentarianId",
                table: "parliamentarians_members",
                newName: "IX_parliamentarians_members_ParliamentarianId");

            migrationBuilder.RenameIndex(
                name: "IX_parliamentarians_members_commissionMemberId",
                table: "parliamentarians_members",
                newName: "IX_parliamentarians_members_CommissionMemberId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_parliamentarians_members_commission_members_CommissionMembe~",
                table: "parliamentarians_members");

            migrationBuilder.DropForeignKey(
                name: "FK_parliamentarians_members_parliamentarians_ParliamentarianId",
                table: "parliamentarians_members");

            migrationBuilder.RenameColumn(
                name: "ParliamentarianId",
                table: "parliamentarians_members",
                newName: "parliamentarianId");

            migrationBuilder.RenameColumn(
                name: "CommissionMemberId",
                table: "parliamentarians_members",
                newName: "commissionMemberId");

            migrationBuilder.RenameIndex(
                name: "IX_parliamentarians_members_ParliamentarianId",
                table: "parliamentarians_members",
                newName: "IX_parliamentarians_members_parliamentarianId");

            migrationBuilder.RenameIndex(
                name: "IX_parliamentarians_members_CommissionMemberId",
                table: "parliamentarians_members",
                newName: "IX_parliamentarians_members_commissionMemberId");

            migrationBuilder.CreateTable(
                name: "parliament_members",
                columns: table => new
                {
                    parlamentar_commission_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    commissionId = table.Column<int>(type: "integer", nullable: false),
                    end_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    id_commission = table.Column<int>(type: "integer", nullable: false),
                    role = table.Column<string>(type: "text", nullable: false),
                    start_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    id_parlamentar = table.Column<int>(type: "integer", nullable: false),
                    id_parlamentar_group = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parliament_members", x => x.parlamentar_commission_id);
                    table.ForeignKey(
                        name: "FK_parliament_members_commissions_commissionId",
                        column: x => x.commissionId,
                        principalTable: "commissions",
                        principalColumn: "commission_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_parliament_members_commissionId",
                table: "parliament_members",
                column: "commissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_parliamentarians_members_commission_members_commissionMembe~",
                table: "parliamentarians_members",
                column: "commissionMemberId",
                principalTable: "commission_members",
                principalColumn: "commission_member_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_parliamentarians_members_parliamentarians_parliamentarianId",
                table: "parliamentarians_members",
                column: "parliamentarianId",
                principalTable: "parliamentarians",
                principalColumn: "parliamentarian_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
