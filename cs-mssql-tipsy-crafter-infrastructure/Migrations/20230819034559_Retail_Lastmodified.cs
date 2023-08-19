using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmritaDb.Tipsy.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Retail_Lastmodified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "retail",
                table: "store_contact",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "store_contact_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "retail",
                table: "store",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "store_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "retail",
                table: "shipment",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "shipment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "retail",
                table: "sale_status",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "sale_status_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "retail",
                table: "receipt_line",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "receipt_line_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "retail",
                table: "payment",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "retail",
                table: "customer_contact",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "customer_contact_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "retail",
                table: "customer",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "customer_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.UpdateData(
                schema: "retail",
                table: "sale_status",
                keyColumn: "id",
                keyValue: "01H7PKYDSN6HR02HNNJZQ2SEVF",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "retail",
                table: "sale_status",
                keyColumn: "id",
                keyValue: "01H7PKYES5MB6TSXVNWGHY05M8",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "retail",
                table: "sale_status",
                keyColumn: "id",
                keyValue: "01H7PKYFRXQHKA0MEH3WWNB3GG",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "retail",
                table: "sale_status",
                keyColumn: "id",
                keyValue: "01H7PKYGR6C0YJC0RA9YYZ6JMG",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "retail",
                table: "sale_status",
                keyColumn: "id",
                keyValue: "01H7PKYHQGXTAXYW6WMXB2QCR1",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "retail",
                table: "sale_status",
                keyColumn: "id",
                keyValue: "01H7PKYJQ2A3PQ5QJ33DWB0ZFX",
                column: "modified_by",
                value: "SYSTEM");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "retail",
                table: "store_contact")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "store_contact_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "retail",
                table: "store")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "store_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "retail",
                table: "shipment")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "shipment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "retail",
                table: "sale_status")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "sale_status_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "retail",
                table: "receipt_line")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "receipt_line_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "retail",
                table: "payment")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "retail",
                table: "customer_contact")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "customer_contact_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "retail",
                table: "customer")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "customer_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");
        }
    }
}
