using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 785, DateTimeKind.Local).AddTicks(4834), new DateTime(2026, 1, 24, 20, 2, 47, 786, DateTimeKind.Local).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(1397), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(1534), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(1558), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(1579), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(1609), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(1630), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(1649), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(1668), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(1709), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(2967), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(3178), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(3202), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(3223), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(3241), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(3263), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(3282), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(3300), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(3318), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(3342), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5068), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5287), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5310), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5329), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5348), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5371), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5389), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5423), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5442), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5464), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(2896), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(3076), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(3097), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(3113), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(3129), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(3149), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(3165), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(3182), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(3198), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(3215), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(6627), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(6634), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(6637), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1121), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1327), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1355), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1377), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1413), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1438), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1458), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1479), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1500), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1523), new DateTime(2026, 1, 24, 20, 2, 47, 788, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8262), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8478), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8590), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8610), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8629), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8653), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8670), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8688), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8706), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8728), new DateTime(2026, 1, 24, 20, 2, 47, 787, DateTimeKind.Local).AddTicks(8728) });
        }
    }
}
