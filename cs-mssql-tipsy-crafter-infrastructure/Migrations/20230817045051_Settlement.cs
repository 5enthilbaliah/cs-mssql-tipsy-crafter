using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmritaDb.Tipsy.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Settlement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "settlement",
                schema: "purchase",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "settlement_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    order_id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "settlement_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    payment_mode_id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "settlement_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    memo = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "settlement_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    paid_currency = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false, defaultValue: "USD")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "settlement_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    paid_amount = table.Column<decimal>(type: "money", nullable: false, defaultValue: 0m)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "settlement_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    valid_from = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "settlement_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    valid_to = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "settlement_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_settlement", x => x.id);
                    table.ForeignKey(
                        name: "FK_settlement_order_order_id",
                        column: x => x.order_id,
                        principalSchema: "purchase",
                        principalTable: "order",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_settlement_payment_mode_payment_mode_id",
                        column: x => x.payment_mode_id,
                        principalSchema: "universal",
                        principalTable: "payment_mode",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "settlement_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.CreateIndex(
                name: "IX_settlement_order_id",
                schema: "purchase",
                table: "settlement",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_settlement_payment_mode_id",
                schema: "purchase",
                table: "settlement",
                column: "payment_mode_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "settlement",
                schema: "purchase")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "settlement_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");
        }
    }
}
