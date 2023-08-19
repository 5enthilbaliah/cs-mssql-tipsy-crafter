using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmritaDb.Tipsy.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Stock_Lastmodified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "stock",
                table: "product_type",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "product_type_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "stock",
                table: "product_image",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "product_image_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "stock",
                table: "product",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "product_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "stock",
                table: "inventory",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "inventory_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "stock",
                table: "category",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "SYSTEM")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "category_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "stock",
                table: "product_type")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "product_type_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "stock",
                table: "product_image")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "product_image_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "stock",
                table: "product")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "product_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "stock",
                table: "inventory")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "inventory_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "stock",
                table: "category")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "category_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "stock")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");
        }
    }
}
