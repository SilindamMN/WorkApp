using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkApp.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 731, DateTimeKind.Local).AddTicks(8545), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(8105), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(8223), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(8241), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(8257), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(8281), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(8296), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(8296) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(8315), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(8331), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(8348), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9462), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9628), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9646), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9661), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9676), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9802), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9817), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9831), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9845), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9864), new DateTime(2026, 4, 1, 22, 24, 22, 733, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1139), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1294), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1312), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1327), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1341), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1357), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1371), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1384), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1398), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1414), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7005), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7153), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7169), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7183), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7197), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7214), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7226), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7240), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7253), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7267), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(2283), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(2289), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(2290), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5508), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5689), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5711), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5729), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5746), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5766), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5783), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5800), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5882), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5905), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3399), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3618), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3640), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3656), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3672), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3691), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3706), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3721), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3737), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3754), new DateTime(2026, 4, 1, 22, 24, 22, 734, DateTimeKind.Local).AddTicks(3755) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 49, 997, DateTimeKind.Local).AddTicks(7190), new DateTime(2026, 4, 1, 22, 16, 49, 999, DateTimeKind.Local).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(1751), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(1869), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(1961), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(1980), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(2003), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(2019), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(2034), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(2049), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(2066), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3057), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3212), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3231), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3246), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3261), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3278), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3292), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3307), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3321), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3404), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4651), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4801), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4819), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4834), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4847), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4863), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4877), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4890), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4904), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4919), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(406), new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(549), new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(566), new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(580), new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(657), new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(675), new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(688), new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(701), new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(713), new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(727), new DateTime(2026, 4, 1, 22, 16, 50, 1, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(5775), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(5780), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(5782), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(8985), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(9146), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(9168), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(9185), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(9202), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(9222), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(9239), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(9256), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(9272), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(9291), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(9291) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(6871), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(6874) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(7042), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(7062), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(7078), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(7095), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(7172), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(7192), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(7208), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(7224), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(7241), new DateTime(2026, 4, 1, 22, 16, 50, 0, DateTimeKind.Local).AddTicks(7241) });
        }
    }
}
