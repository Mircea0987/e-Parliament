using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace e_Parliament.Migrations
{
    /// <inheritdoc />
    public partial class AddAllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "legislatures",
                columns: table => new
                {
                    legislature_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    legislature_start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    legislature_end = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_legislatures", x => x.legislature_id);
                });

            migrationBuilder.CreateTable(
                name: "meetings",
                columns: table => new
                {
                    meeting_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    meeting_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    meeting_subject = table.Column<string>(type: "text", nullable: false),
                    meeting_location = table.Column<string>(type: "text", nullable: false),
                    commission_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_meetings", x => x.meeting_id);
                });

            migrationBuilder.CreateTable(
                name: "parlamentar_groups",
                columns: table => new
                {
                    parlamentar_group_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    parlamentar_group_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parlamentar_groups", x => x.parlamentar_group_id);
                });

            migrationBuilder.CreateTable(
                name: "room_types",
                columns: table => new
                {
                    room_type_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    room_type_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_types", x => x.room_type_id);
                });

            migrationBuilder.CreateTable(
                name: "commissions",
                columns: table => new
                {
                    commission_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    commission_name = table.Column<string>(type: "text", nullable: false),
                    legislature_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_commissions", x => x.commission_id);
                    table.ForeignKey(
                        name: "FK_commissions_legislatures_legislature_id",
                        column: x => x.legislature_id,
                        principalTable: "legislatures",
                        principalColumn: "legislature_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "meeting_attendaces",
                columns: table => new
                {
                    meeting_attendance_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    attendence_status = table.Column<bool>(type: "boolean", nullable: false),
                    parlamentar_id = table.Column<int>(type: "integer", nullable: false),
                    meeting_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_meeting_attendaces", x => x.meeting_attendance_id);
                    table.ForeignKey(
                        name: "FK_meeting_attendaces_meetings_meeting_id",
                        column: x => x.meeting_id,
                        principalTable: "meetings",
                        principalColumn: "meeting_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "parliamentarians",
                columns: table => new
                {
                    parliamentarian_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "text", nullable: false),
                    last_name = table.Column<string>(type: "text", nullable: false),
                    id_room_type = table.Column<int>(type: "integer", nullable: false),
                    RoomTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parliamentarians", x => x.parliamentarian_id);
                    table.ForeignKey(
                        name: "FK_parliamentarians_room_types_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "room_types",
                        principalColumn: "room_type_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "commission_members",
                columns: table => new
                {
                    commission_member_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    role = table.Column<string>(type: "text", nullable: false),
                    parliament_member_id = table.Column<int>(type: "integer", nullable: false),
                    id_commission = table.Column<int>(type: "integer", nullable: false),
                    date_start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    date_end = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_commission_members", x => x.commission_member_id);
                    table.ForeignKey(
                        name: "FK_commission_members_commissions_id_commission",
                        column: x => x.id_commission,
                        principalTable: "commissions",
                        principalColumn: "commission_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "parliament_members",
                columns: table => new
                {
                    parlamentar_commission_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_parlamentar = table.Column<int>(type: "integer", nullable: false),
                    id_commission = table.Column<int>(type: "integer", nullable: false),
                    role = table.Column<string>(type: "text", nullable: false),
                    start_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    end_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    id_parlamentar_group = table.Column<int>(type: "integer", nullable: false),
                    commissionId = table.Column<int>(type: "integer", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "parlamentar_group_members",
                columns: table => new
                {
                    id_parlamentar_group = table.Column<int>(type: "integer", nullable: false),
                    id_members = table.Column<int>(type: "integer", nullable: false),
                    Id_legislature = table.Column<int>(type: "integer", nullable: false),
                    CommissionMemberId = table.Column<int>(type: "integer", nullable: false),
                    MembersId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parlamentar_group_members", x => new { x.id_parlamentar_group, x.id_members });
                    table.ForeignKey(
                        name: "FK_parlamentar_group_members_commission_members_CommissionMemb~",
                        column: x => x.CommissionMemberId,
                        principalTable: "commission_members",
                        principalColumn: "commission_member_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_parlamentar_group_members_parlamentar_groups_MembersId",
                        column: x => x.MembersId,
                        principalTable: "parlamentar_groups",
                        principalColumn: "parlamentar_group_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "parliamentarians_members",
                columns: table => new
                {
                    id_parlamentar = table.Column<int>(type: "integer", nullable: false),
                    id_commission_members = table.Column<int>(type: "integer", nullable: false),
                    commissionMemberId = table.Column<int>(type: "integer", nullable: false),
                    parliamentarianId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parliamentarians_members", x => new { x.id_parlamentar, x.id_commission_members });
                    table.ForeignKey(
                        name: "FK_parliamentarians_members_commission_members_commissionMembe~",
                        column: x => x.commissionMemberId,
                        principalTable: "commission_members",
                        principalColumn: "commission_member_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_parliamentarians_members_parliamentarians_parliamentarianId",
                        column: x => x.parliamentarianId,
                        principalTable: "parliamentarians",
                        principalColumn: "parliamentarian_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_meeting_documents_meeting_id",
                table: "meeting_documents",
                column: "meeting_id");

            migrationBuilder.CreateIndex(
                name: "IX_commission_members_id_commission",
                table: "commission_members",
                column: "id_commission");

            migrationBuilder.CreateIndex(
                name: "IX_commissions_legislature_id",
                table: "commissions",
                column: "legislature_id");

            migrationBuilder.CreateIndex(
                name: "IX_meeting_attendaces_meeting_id",
                table: "meeting_attendaces",
                column: "meeting_id");

            migrationBuilder.CreateIndex(
                name: "IX_parlamentar_group_members_CommissionMemberId",
                table: "parlamentar_group_members",
                column: "CommissionMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_parlamentar_group_members_MembersId",
                table: "parlamentar_group_members",
                column: "MembersId");

            migrationBuilder.CreateIndex(
                name: "IX_parliament_members_commissionId",
                table: "parliament_members",
                column: "commissionId");

            migrationBuilder.CreateIndex(
                name: "IX_parliamentarians_RoomTypeId",
                table: "parliamentarians",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_parliamentarians_members_commissionMemberId",
                table: "parliamentarians_members",
                column: "commissionMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_parliamentarians_members_parliamentarianId",
                table: "parliamentarians_members",
                column: "parliamentarianId");

            migrationBuilder.AddForeignKey(
                name: "FK_meeting_documents_meetings_meeting_id",
                table: "meeting_documents",
                column: "meeting_id",
                principalTable: "meetings",
                principalColumn: "meeting_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_meeting_documents_meetings_meeting_id",
                table: "meeting_documents");

            migrationBuilder.DropTable(
                name: "meeting_attendaces");

            migrationBuilder.DropTable(
                name: "parlamentar_group_members");

            migrationBuilder.DropTable(
                name: "parliament_members");

            migrationBuilder.DropTable(
                name: "parliamentarians_members");

            migrationBuilder.DropTable(
                name: "meetings");

            migrationBuilder.DropTable(
                name: "parlamentar_groups");

            migrationBuilder.DropTable(
                name: "commission_members");

            migrationBuilder.DropTable(
                name: "parliamentarians");

            migrationBuilder.DropTable(
                name: "commissions");

            migrationBuilder.DropTable(
                name: "room_types");

            migrationBuilder.DropTable(
                name: "legislatures");

            migrationBuilder.DropIndex(
                name: "IX_meeting_documents_meeting_id",
                table: "meeting_documents");
        }
    }
}
