using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessCenterApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSpaLimitToMembership : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AllowedSpaProceduresPerWeek",
                schema: "22180022",
                table: "MembershipTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Number of allowed spa procedures per week. 0 means no access.");

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3336));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3342));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3347));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3609));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3614));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3617));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AllowedSpaProceduresPerWeek", "ModifiedOn_22180022" },
                values: new object[] { 0, new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3651) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AllowedSpaProceduresPerWeek", "ModifiedOn_22180022" },
                values: new object[] { 0, new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3654) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AllowedSpaProceduresPerWeek", "ModifiedOn_22180022" },
                values: new object[] { 0, new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3656) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AllowedSpaProceduresPerWeek", "ModifiedOn_22180022" },
                values: new object[] { 0, new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3658) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 17, 7, 40, 18, 299, DateTimeKind.Utc).AddTicks(3701));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllowedSpaProceduresPerWeek",
                schema: "22180022",
                table: "MembershipTypes");

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1358));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1368));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1374));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1385));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1391));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1568));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1576));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1583));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1589));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1596));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1604));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1640));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1642));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1644));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1647));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1649));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1721));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1723));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1725));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 14, 45, 939, DateTimeKind.Utc).AddTicks(1727));
        }
    }
}
