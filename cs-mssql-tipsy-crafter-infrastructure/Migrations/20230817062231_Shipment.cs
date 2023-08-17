using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmritaDb.Tipsy.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Shipment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "shipment",
                schema: "retail",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "shipment_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    receipt_id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "shipment_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    shipper_id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "shipment_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    date = table.Column<DateTime>(type: "datetime2(7)", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "shipment_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    tracking_id = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "shipment_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    is_delivered = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "shipment_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    valid_from = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "shipment_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    valid_to = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "shipment_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shipment", x => x.id);
                    table.ForeignKey(
                        name: "FK_shipment_receipt_receipt_id",
                        column: x => x.receipt_id,
                        principalSchema: "retail",
                        principalTable: "receipt",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_shipment_shipper_shipper_id",
                        column: x => x.shipper_id,
                        principalSchema: "universal",
                        principalTable: "shipper",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "shipment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.CreateIndex(
                name: "IX_shipment_receipt_id",
                schema: "retail",
                table: "shipment",
                column: "receipt_id");

            migrationBuilder.CreateIndex(
                name: "IX_shipment_shipper_id",
                schema: "retail",
                table: "shipment",
                column: "shipper_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shipment",
                schema: "retail")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "shipment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");
        }
    }
}
