using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmritaDb.Tipsy.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Purchase_Lastmodified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "purchase",
                table: "supplier_contact",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "supplier_contact_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "purchase",
                table: "supplier",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "supplier_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "purchase",
                table: "settlement",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "settlement_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "purchase",
                table: "order_status",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "order_status_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "purchase",
                table: "order_item",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "order_item_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "purchase",
                table: "delivery",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "delivery_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "purchase",
                table: "brand",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "brand_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.UpdateData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMMPRCGB7D65EYPKVAYMH",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMNPMC0F7FD77DHK13T0V",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMPP7608Q953DWESMTB14",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMQNYMDYZBD9ANEWFHHHV",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMRNJA9VKTX6B684F7WXK",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMSMY139E73SAJ1VASE2X",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMTMKVK40YGYDE7AHBDAP",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMVM9XNS6Y2V76DBCVG8G",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMWKKP76KPDYZW5N5K6KZ",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMXK8XT413F2P2HPSPNP5",
                column: "modified_by",
                value: "SYSTEM");

            migrationBuilder.UpdateData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKYCSPBKNQXNKPSY2B6BJG",
                column: "modified_by",
                value: "SYSTEM");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "purchase",
                table: "supplier_contact")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "supplier_contact_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "purchase",
                table: "supplier")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "supplier_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "purchase",
                table: "settlement")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "settlement_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "purchase",
                table: "order_status")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "order_status_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "purchase",
                table: "order_item")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "order_item_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "purchase",
                table: "delivery")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "delivery_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "purchase",
                table: "brand")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "brand_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");
        }
    }
}
