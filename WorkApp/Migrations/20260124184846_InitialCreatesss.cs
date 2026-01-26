using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatesss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 209, DateTimeKind.Local).AddTicks(4559), new DateTime(2026, 1, 24, 20, 48, 45, 210, DateTimeKind.Local).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(1838), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(1972), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(1994), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(2033), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(2063), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(2081), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(2082) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(2099), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(2118), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(2138), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3422), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3616), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3640), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3658), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3675), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3696), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3714), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3732), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3748), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3749) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3771), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5477), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5684), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5706), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5723), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5740), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5760), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5775), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5792), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5809), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5827), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3245), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3460), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3480), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3495), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3511), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3530), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3546), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3562), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3591), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3608), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(7013), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(7020), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(7023), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1418), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1628), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1656), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1677), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1697), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1721), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1741), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1760), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1781), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1802), new DateTime(2026, 1, 24, 20, 48, 45, 212, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8522), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8739), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8765), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8785), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8805), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8827), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8845), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8864), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8896), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8919), new DateTime(2026, 1, 24, 20, 48, 45, 211, DateTimeKind.Local).AddTicks(8919) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
