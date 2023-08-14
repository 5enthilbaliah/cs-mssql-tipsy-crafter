using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmritaDb.Tipsy.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "stock");

            migrationBuilder.CreateTable(
                name: "category",
                schema: "stock",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "category_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    name = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "category_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    description = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "category_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    slug = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "category_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    parent_id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "category_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    valid_from = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "category_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    valid_to = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "category_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.id);
                    table.ForeignKey(
                        name: "FK_category_category_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "stock",
                        principalTable: "category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "category_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.CreateIndex(
                name: "IX_category_parent_id",
                schema: "stock",
                table: "category",
                column: "parent_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "category",
                schema: "stock")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "category_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");
        }
    }
}
