using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmritaDb.Tipsy.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Payment_schema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "payment",
                schema: "purchase",
                newName: "payment",
                newSchema: "retail")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase");

            migrationBuilder.AlterTable(
                name: "payment",
                schema: "retail")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AlterColumn<DateTime>(
                name: "valid_to",
                schema: "retail",
                table: "payment",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AlterColumn<DateTime>(
                name: "valid_from",
                schema: "retail",
                table: "payment",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AlterColumn<string>(
                name: "receipt_id",
                schema: "retail",
                table: "payment",
                type: "varchar(26)",
                maxLength: 26,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(26)",
                oldMaxLength: 26)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AlterColumn<string>(
                name: "payment_mode_id",
                schema: "retail",
                table: "payment",
                type: "varchar(26)",
                maxLength: 26,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(26)",
                oldMaxLength: 26)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AlterColumn<string>(
                name: "memo",
                schema: "retail",
                table: "payment",
                type: "varchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AlterColumn<decimal>(
                name: "amount",
                schema: "retail",
                table: "payment",
                type: "money",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldDefaultValue: 0m)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                schema: "retail",
                table: "payment",
                type: "varchar(26)",
                maxLength: 26,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(26)",
                oldMaxLength: 26)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "payment",
                schema: "retail",
                newName: "payment",
                newSchema: "purchase")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail");

            migrationBuilder.AlterTable(
                name: "payment",
                schema: "purchase")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AlterColumn<DateTime>(
                name: "valid_to",
                schema: "purchase",
                table: "payment",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AlterColumn<DateTime>(
                name: "valid_from",
                schema: "purchase",
                table: "payment",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AlterColumn<string>(
                name: "receipt_id",
                schema: "purchase",
                table: "payment",
                type: "varchar(26)",
                maxLength: 26,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(26)",
                oldMaxLength: 26)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AlterColumn<string>(
                name: "payment_mode_id",
                schema: "purchase",
                table: "payment",
                type: "varchar(26)",
                maxLength: 26,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(26)",
                oldMaxLength: 26)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AlterColumn<string>(
                name: "memo",
                schema: "purchase",
                table: "payment",
                type: "varchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AlterColumn<decimal>(
                name: "amount",
                schema: "purchase",
                table: "payment",
                type: "money",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldDefaultValue: 0m)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                schema: "purchase",
                table: "payment",
                type: "varchar(26)",
                maxLength: 26,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(26)",
                oldMaxLength: 26)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "purchase")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "payment_history")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");
        }
    }
}
