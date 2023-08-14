using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AmritaDb.Tipsy.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "universal",
                table: "contact_type",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { "01H7PBQ3MBB6ZX1Y39TV6KPM5T", "Phone Number", "Phone" },
                    { "01H7PBQ3MQ33DF64P8FDZJ6CCG", "Email Address", "Email" },
                    { "01H7PBQ3MQRT5Q538QR2VCQZZT", "Fax Number", "Fax" }
                });

            migrationBuilder.InsertData(
                schema: "universal",
                table: "country",
                columns: new[] { "id", "currency_code", "iso3", "iso", "name", "num_code", "phone_code" },
                values: new object[,]
                {
                    { "01H7PBQ3MQX3EBSHD7QPVZJ0H9", "USD", "USA", "US", "United States of America", (short)840, (short)1 },
                    { "01H7PBQ3MR64WY2NKZH42K6YNX", "GBP", "GBR", "GB", "United Kingdom", (short)826, (short)44 },
                    { "01H7PBQ3MRE96CH0CHH0T5VESH", "EUR", "FRA", "FR", "France", (short)250, (short)33 },
                    { "01H7PBQ3MRF96R5ES7EYPWDTYX", "MXN", "MEX", "MX", "Mexico", (short)484, (short)52 }
                });

            migrationBuilder.InsertData(
                schema: "purchase",
                table: "order_status",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { "01H7PKMMPRCGB7D65EYPKVAYMH", "New", "New" },
                    { "01H7PKMNPMC0F7FD77DHK13T0V", "Pending Approval", "Pending Approval" },
                    { "01H7PKMPP7608Q953DWESMTB14", "Approved", "Approved" },
                    { "01H7PKMQNYMDYZBD9ANEWFHHHV", "Rejected", "Rejected" },
                    { "01H7PKMRNJA9VKTX6B684F7WXK", "Paid", "Paid" },
                    { "01H7PKMSMY139E73SAJ1VASE2X", "Cancelled", "Cancelled" },
                    { "01H7PKMTMKVK40YGYDE7AHBDAP", "In Transit", "In Transit" },
                    { "01H7PKMVM9XNS6Y2V76DBCVG8G", "Received", "Received" },
                    { "01H7PKMWKKP76KPDYZW5N5K6KZ", "Partially fulfilled", "Partially fulfilled" },
                    { "01H7PKMXK8XT413F2P2HPSPNP5", "Completed", "Completed" },
                    { "01H7PKYCSPBKNQXNKPSY2B6BJG", "Returned", "Returned" }
                });

            migrationBuilder.InsertData(
                schema: "universal",
                table: "payment_mode",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { "01H7PCVP1HGHM93SX4HSW8EM2B", "Cash", "Cash" },
                    { "01H7PCVQ1ERMXJJND16HKKHTKQ", "Cheque / Check", "Cheque" },
                    { "01H7PCVR0R9723KKDRKGSRPRYS", "Wire Transfer", "Wire Transfer" },
                    { "01H7PCVS01J4ZANSQHEKV658H1", "Credit Card", "Credit Card" }
                });

            migrationBuilder.InsertData(
                schema: "retail",
                table: "sale_status",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { "01H7PKYDSN6HR02HNNJZQ2SEVF", "In Scan", "In Scan" },
                    { "01H7PKYES5MB6TSXVNWGHY05M8", "Paid", "Paid" },
                    { "01H7PKYFRXQHKA0MEH3WWNB3GG", "Ready for shipment", "Ready for shipment" },
                    { "01H7PKYGR6C0YJC0RA9YYZ6JMG", "Shipped", "Shipped" },
                    { "01H7PKYHQGXTAXYW6WMXB2QCR1", "Delivered", "Delivered" },
                    { "01H7PKYJQ2A3PQ5QJ33DWB0ZFX", "Cancelled", "Cancelled" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "universal",
                table: "contact_type",
                keyColumn: "id",
                keyValue: "01H7PBQ3MBB6ZX1Y39TV6KPM5T");

            migrationBuilder.DeleteData(
                schema: "universal",
                table: "contact_type",
                keyColumn: "id",
                keyValue: "01H7PBQ3MQ33DF64P8FDZJ6CCG");

            migrationBuilder.DeleteData(
                schema: "universal",
                table: "contact_type",
                keyColumn: "id",
                keyValue: "01H7PBQ3MQRT5Q538QR2VCQZZT");

            migrationBuilder.DeleteData(
                schema: "universal",
                table: "country",
                keyColumn: "id",
                keyValue: "01H7PBQ3MQX3EBSHD7QPVZJ0H9");

            migrationBuilder.DeleteData(
                schema: "universal",
                table: "country",
                keyColumn: "id",
                keyValue: "01H7PBQ3MR64WY2NKZH42K6YNX");

            migrationBuilder.DeleteData(
                schema: "universal",
                table: "country",
                keyColumn: "id",
                keyValue: "01H7PBQ3MRE96CH0CHH0T5VESH");

            migrationBuilder.DeleteData(
                schema: "universal",
                table: "country",
                keyColumn: "id",
                keyValue: "01H7PBQ3MRF96R5ES7EYPWDTYX");

            migrationBuilder.DeleteData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMMPRCGB7D65EYPKVAYMH");

            migrationBuilder.DeleteData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMNPMC0F7FD77DHK13T0V");

            migrationBuilder.DeleteData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMPP7608Q953DWESMTB14");

            migrationBuilder.DeleteData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMQNYMDYZBD9ANEWFHHHV");

            migrationBuilder.DeleteData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMRNJA9VKTX6B684F7WXK");

            migrationBuilder.DeleteData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMSMY139E73SAJ1VASE2X");

            migrationBuilder.DeleteData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMTMKVK40YGYDE7AHBDAP");

            migrationBuilder.DeleteData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMVM9XNS6Y2V76DBCVG8G");

            migrationBuilder.DeleteData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMWKKP76KPDYZW5N5K6KZ");

            migrationBuilder.DeleteData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKMXK8XT413F2P2HPSPNP5");

            migrationBuilder.DeleteData(
                schema: "purchase",
                table: "order_status",
                keyColumn: "id",
                keyValue: "01H7PKYCSPBKNQXNKPSY2B6BJG");

            migrationBuilder.DeleteData(
                schema: "universal",
                table: "payment_mode",
                keyColumn: "id",
                keyValue: "01H7PCVP1HGHM93SX4HSW8EM2B");

            migrationBuilder.DeleteData(
                schema: "universal",
                table: "payment_mode",
                keyColumn: "id",
                keyValue: "01H7PCVQ1ERMXJJND16HKKHTKQ");

            migrationBuilder.DeleteData(
                schema: "universal",
                table: "payment_mode",
                keyColumn: "id",
                keyValue: "01H7PCVR0R9723KKDRKGSRPRYS");

            migrationBuilder.DeleteData(
                schema: "universal",
                table: "payment_mode",
                keyColumn: "id",
                keyValue: "01H7PCVS01J4ZANSQHEKV658H1");

            migrationBuilder.DeleteData(
                schema: "retail",
                table: "sale_status",
                keyColumn: "id",
                keyValue: "01H7PKYDSN6HR02HNNJZQ2SEVF");

            migrationBuilder.DeleteData(
                schema: "retail",
                table: "sale_status",
                keyColumn: "id",
                keyValue: "01H7PKYES5MB6TSXVNWGHY05M8");

            migrationBuilder.DeleteData(
                schema: "retail",
                table: "sale_status",
                keyColumn: "id",
                keyValue: "01H7PKYFRXQHKA0MEH3WWNB3GG");

            migrationBuilder.DeleteData(
                schema: "retail",
                table: "sale_status",
                keyColumn: "id",
                keyValue: "01H7PKYGR6C0YJC0RA9YYZ6JMG");

            migrationBuilder.DeleteData(
                schema: "retail",
                table: "sale_status",
                keyColumn: "id",
                keyValue: "01H7PKYHQGXTAXYW6WMXB2QCR1");

            migrationBuilder.DeleteData(
                schema: "retail",
                table: "sale_status",
                keyColumn: "id",
                keyValue: "01H7PKYJQ2A3PQ5QJ33DWB0ZFX");
        }
    }
}
