using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StellarTalentSearch.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobDescriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DescriptionItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JobDescriptionId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JobDescriptionId2 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JobDescriptionId3 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescriptionItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DescriptionItems_JobDescriptions_JobDescriptionId",
                        column: x => x.JobDescriptionId,
                        principalTable: "JobDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DescriptionItems_JobDescriptions_JobDescriptionId1",
                        column: x => x.JobDescriptionId1,
                        principalTable: "JobDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DescriptionItems_JobDescriptions_JobDescriptionId2",
                        column: x => x.JobDescriptionId2,
                        principalTable: "JobDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DescriptionItems_JobDescriptions_JobDescriptionId3",
                        column: x => x.JobDescriptionId3,
                        principalTable: "JobDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positions_JobDescriptions_JobDescriptionId",
                        column: x => x.JobDescriptionId,
                        principalTable: "JobDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobVacancies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobVacancies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobVacancies_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DescriptionItems_JobDescriptionId",
                table: "DescriptionItems",
                column: "JobDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_DescriptionItems_JobDescriptionId1",
                table: "DescriptionItems",
                column: "JobDescriptionId1");

            migrationBuilder.CreateIndex(
                name: "IX_DescriptionItems_JobDescriptionId2",
                table: "DescriptionItems",
                column: "JobDescriptionId2");

            migrationBuilder.CreateIndex(
                name: "IX_DescriptionItems_JobDescriptionId3",
                table: "DescriptionItems",
                column: "JobDescriptionId3");

            migrationBuilder.CreateIndex(
                name: "IX_JobVacancies_PositionId",
                table: "JobVacancies",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_JobDescriptionId",
                table: "Positions",
                column: "JobDescriptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DescriptionItems");

            migrationBuilder.DropTable(
                name: "JobVacancies");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "JobDescriptions");
        }
    }
}
