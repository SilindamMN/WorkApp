using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 417, DateTimeKind.Local).AddTicks(4648), new DateTime(2026, 1, 24, 20, 20, 13, 418, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(2665), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(2795), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(2834), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(2854), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(2881), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(2899), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(2917), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(2934), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(2954), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4164), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4363), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4385), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4402), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4420), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4440), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4457), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4474), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4490), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4523), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6099), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6287), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6310), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6326), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6342), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6363), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6378), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6395), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6411), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6428), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3570), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3785), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3804), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3820), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3835), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3865), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3881), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3896), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3912), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3928), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(7511), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(7518), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(7521), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(1866), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(2074), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(2099), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(2120), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(2138), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(2162), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(2181), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(2200), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(2218), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(2240), new DateTime(2026, 1, 24, 20, 20, 13, 420, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(8919), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(9350), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(9374), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(9393), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(9411), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(9445), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(9465), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(9484), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(9502), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(9523), new DateTime(2026, 1, 24, 20, 20, 13, 419, DateTimeKind.Local).AddTicks(9524) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 91, DateTimeKind.Local).AddTicks(6670), new DateTime(2026, 1, 24, 20, 13, 15, 92, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(3660), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(3797), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(3817), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(3837), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(3864), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(3885), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(3904), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(3923), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(3943), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5153), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5344), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5388), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5408), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5425), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5446), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5463), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5480), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5496), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5518), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7159), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7347), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7371), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7388), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7404), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7424), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7440), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7455), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7471), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7489), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4255), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4427), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4448), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4463), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4478), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4497), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4498) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4513), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4529), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4544), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4545) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4561), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(8598), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(8604), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(8606), new DateTime(2026, 1, 24, 20, 13, 15, 93, DateTimeKind.Local).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(2635), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(2835), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(2860), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(2879), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(2898), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(2922), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(2942), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(2973), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(2992), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(3014), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(106), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(297), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(321), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(340), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(359), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(382), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(399), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(417), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(435), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(456), new DateTime(2026, 1, 24, 20, 13, 15, 94, DateTimeKind.Local).AddTicks(457) });
        }
    }
}
