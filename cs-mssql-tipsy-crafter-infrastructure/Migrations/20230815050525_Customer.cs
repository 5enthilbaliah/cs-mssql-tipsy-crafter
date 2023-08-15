using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmritaDb.Tipsy.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customer",
                schema: "retail",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    name = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    description = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    address_1 = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    address_2 = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    city = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    state = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    country = table.Column<string>(type: "char(2)", maxLength: 2, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    zip_code = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    valid_from = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    valid_to = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.id);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "customer_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.CreateTable(
                name: "customer_contact",
                schema: "retail",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_contact_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    name = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_contact_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    detail = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_contact_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    is_primary = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_contact_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    customer_id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_contact_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    contact_type_id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_contact_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    valid_from = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_contact_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from"),
                    valid_to = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "customer_contact_history")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_contact", x => x.id);
                    table.ForeignKey(
                        name: "FK_customer_contact_contact_type_contact_type_id",
                        column: x => x.contact_type_id,
                        principalSchema: "universal",
                        principalTable: "contact_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_customer_contact_customer_customer_id",
                        column: x => x.customer_id,
                        principalSchema: "retail",
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "customer_contact_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.CreateIndex(
                name: "IX_customer_contact_contact_type_id",
                schema: "retail",
                table: "customer_contact",
                column: "contact_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_contact_customer_id",
                schema: "retail",
                table: "customer_contact",
                column: "customer_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer_contact",
                schema: "retail")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "customer_contact_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");

            migrationBuilder.DropTable(
                name: "customer",
                schema: "retail")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "customer_history")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "retail")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "valid_to")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "valid_from");
        }
    }
}
