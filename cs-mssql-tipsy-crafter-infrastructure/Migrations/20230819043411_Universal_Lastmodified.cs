using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmritaDb.Tipsy.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Universal_Lastmodified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "universal",
                table: "state",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "state_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "universal")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "universal",
                table: "shipper",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "shipper_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "universal")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "universal",
                table: "payment_mode",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_mode_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "universal")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "universal",
                table: "country",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "country_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "universal")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "universal",
                table: "contact_type",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "contact_type_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "universal")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.UpdateData(
                schema: "universal",
                table: "contact_type",
                keyColumn: "id",
                keyValue: "01H7PBQ3MBB6ZX1Y39TV6KPM5T",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "universal",
                table: "contact_type",
                keyColumn: "id",
                keyValue: "01H7PBQ3MQ33DF64P8FDZJ6CCG",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "universal",
                table: "contact_type",
                keyColumn: "id",
                keyValue: "01H7PBQ3MQRT5Q538QR2VCQZZT",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "universal",
                table: "country",
                keyColumn: "id",
                keyValue: "01H7PBQ3MQX3EBSHD7QPVZJ0H9",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "universal",
                table: "country",
                keyColumn: "id",
                keyValue: "01H7PBQ3MR64WY2NKZH42K6YNX",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "universal",
                table: "country",
                keyColumn: "id",
                keyValue: "01H7PBQ3MRE96CH0CHH0T5VESH",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "universal",
                table: "country",
                keyColumn: "id",
                keyValue: "01H7PBQ3MRF96R5ES7EYPWDTYX",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "universal",
                table: "payment_mode",
                keyColumn: "id",
                keyValue: "01H7PCVP1HGHM93SX4HSW8EM2B",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "universal",
                table: "payment_mode",
                keyColumn: "id",
                keyValue: "01H7PCVQ1ERMXJJND16HKKHTKQ",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "universal",
                table: "payment_mode",
                keyColumn: "id",
                keyValue: "01H7PCVR0R9723KKDRKGSRPRYS",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "universal",
                table: "payment_mode",
                keyColumn: "id",
                keyValue: "01H7PCVS01J4ZANSQHEKV658H1",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "universal",
                table: "shipper",
                keyColumn: "id",
                keyValue: "01H7Y9WKT6KVNRRP0H8SF139DK",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "universal",
                table: "shipper",
                keyColumn: "id",
                keyValue: "01H7Y9WMT5PCJ8TQ6QDTPDAT4D",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "universal",
                table: "shipper",
                keyColumn: "id",
                keyValue: "01H7Y9WNSKG2KF6WKJ98CY015P",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "universal",
                table: "shipper",
                keyColumn: "id",
                keyValue: "01H7Y9WPSBYTQ1SHVFF82H2553",
                column: "modified_by",
                value: "SYSTEM");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "universal",
                table: "state")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "state_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "universal")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "universal",
                table: "shipper")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "shipper_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "universal")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "universal",
                table: "payment_mode")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_mode_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "universal")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "universal",
                table: "country")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "country_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "universal")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "universal",
                table: "contact_type")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "contact_type_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "universal")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");
        }
    }
}
