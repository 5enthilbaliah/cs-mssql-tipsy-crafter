using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmritaDb.Tipsy.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Prefferd_Currency : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "preferred_currency_code",
                schema: "purchase",
                table: "supplier",
                newName: "preferred_currency")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "supplier_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.RenameColumn(
                name: "preferred_currency_code",
                schema: "retail",
                table: "store",
                newName: "preferred_currency")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "store_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "preferred_currency",
                schema: "purchase",
                table: "supplier",
                newName: "preferred_currency_code")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "supplier_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.RenameColumn(
                name: "preferred_currency",
                schema: "retail",
                table: "store",
                newName: "preferred_currency_code")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "store_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");
        }
    }
}
