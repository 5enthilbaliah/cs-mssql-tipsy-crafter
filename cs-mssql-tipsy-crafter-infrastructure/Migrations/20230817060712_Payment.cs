using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmritaDb.Tipsy.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Payment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "customer_grand_total_amount",
                schema: "retail",
                table: "receipt")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "receipt_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "customer_grand_total_currency",
                schema: "retail",
                table: "receipt")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "receipt_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.CreateTable(
                name: "payment",
                schema: "purchase",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    receipt_id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    payment_mode_id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    memo = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    amount = table.Column<decimal>(type: "money", nullable: false, defaultValue: 0m)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    valid_from = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    valid_to = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment", x => x.id);
                    table.ForeignKey(
                        name: "FK_payment_payment_mode_payment_mode_id",
                        column: x => x.payment_mode_id,
                        principalSchema: "universal",
                        principalTable: "payment_mode",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_payment_receipt_receipt_id",
                        column: x => x.receipt_id,
                        principalSchema: "retail",
                        principalTable: "receipt",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.CreateIndex(
                name: "IX_payment_payment_mode_id",
                schema: "purchase",
                table: "payment",
                column: "payment_mode_id");

            migrationBuilder.CreateIndex(
                name: "IX_payment_receipt_id",
                schema: "purchase",
                table: "payment",
                column: "receipt_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "payment",
                schema: "purchase")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<decimal>(
                name: "customer_grand_total_amount",
                schema: "retail",
                table: "receipt",
                type: "money",
                nullable: false,
                defaultValue: 0m)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "receipt_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "customer_grand_total_currency",
                schema: "retail",
                table: "receipt",
                type: "char(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "USD")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "receipt_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");
        }
    }
}
