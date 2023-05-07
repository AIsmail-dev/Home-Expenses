using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AI.HomeExpenses.Migrations
{
    /// <inheritdoc />
    public partial class Create_Initial_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppIncomingCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppIncomingCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppOccuenceTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppOccuenceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppOutcomingCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppOutcomingCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppIncomingItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IncomingCategoryId = table.Column<int>(type: "int", nullable: false),
                    IncomingCategoryId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OccuranceTypeId = table.Column<int>(type: "int", nullable: false),
                    OccurenceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WeekDay = table.Column<int>(type: "int", nullable: false),
                    OccurenceDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppIncomingItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppIncomingItems_AppIncomingCategories_Id",
                        column: x => x.Id,
                        principalTable: "AppIncomingCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppIncomingItems_AppIncomingCategories_IncomingCategoryId1",
                        column: x => x.IncomingCategoryId1,
                        principalTable: "AppIncomingCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppIncomingItems_AppOccuenceTypes_Id",
                        column: x => x.Id,
                        principalTable: "AppOccuenceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppIncomingItems_AppOccuenceTypes_OccurenceTypeId",
                        column: x => x.OccurenceTypeId,
                        principalTable: "AppOccuenceTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppOutcomingItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    OutcomingCategoryId = table.Column<int>(type: "int", nullable: false),
                    OutcomingCategoryId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OccuranceTypeId = table.Column<int>(type: "int", nullable: false),
                    OccurenceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WeekDay = table.Column<int>(type: "int", nullable: false),
                    OccurenceDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppOutcomingItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppOutcomingItems_AppOccuenceTypes_Id",
                        column: x => x.Id,
                        principalTable: "AppOccuenceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppOutcomingItems_AppOccuenceTypes_OccurenceTypeId",
                        column: x => x.OccurenceTypeId,
                        principalTable: "AppOccuenceTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppOutcomingItems_AppOutcomingCategories_Id",
                        column: x => x.Id,
                        principalTable: "AppOutcomingCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppOutcomingItems_AppOutcomingCategories_OutcomingCategoryId1",
                        column: x => x.OutcomingCategoryId1,
                        principalTable: "AppOutcomingCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppIncomingBills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IncomingItemId = table.Column<int>(type: "int", nullable: false),
                    IncomingItemId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OccurenceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OccurenceValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsCancelled = table.Column<bool>(type: "bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppIncomingBills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppIncomingBills_AppIncomingItems_IncomingItemId1",
                        column: x => x.IncomingItemId1,
                        principalTable: "AppIncomingItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppOutcomingBills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OutcomingItemId = table.Column<int>(type: "int", nullable: false),
                    OutcomingItemId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OccurenceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OccurenceValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsCancelled = table.Column<bool>(type: "bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppOutcomingBills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppOutcomingBills_AppOutcomingItems_OutcomingItemId1",
                        column: x => x.OutcomingItemId1,
                        principalTable: "AppOutcomingItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppIncomingBills_IncomingItemId1",
                table: "AppIncomingBills",
                column: "IncomingItemId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppIncomingItems_IncomingCategoryId1",
                table: "AppIncomingItems",
                column: "IncomingCategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppIncomingItems_OccurenceTypeId",
                table: "AppIncomingItems",
                column: "OccurenceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppOutcomingBills_OutcomingItemId1",
                table: "AppOutcomingBills",
                column: "OutcomingItemId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppOutcomingItems_OccurenceTypeId",
                table: "AppOutcomingItems",
                column: "OccurenceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppOutcomingItems_OutcomingCategoryId1",
                table: "AppOutcomingItems",
                column: "OutcomingCategoryId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppIncomingBills");

            migrationBuilder.DropTable(
                name: "AppOutcomingBills");

            migrationBuilder.DropTable(
                name: "AppIncomingItems");

            migrationBuilder.DropTable(
                name: "AppOutcomingItems");

            migrationBuilder.DropTable(
                name: "AppIncomingCategories");

            migrationBuilder.DropTable(
                name: "AppOccuenceTypes");

            migrationBuilder.DropTable(
                name: "AppOutcomingCategories");
        }
    }
}
