using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessCenterApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCapacityAndAuditFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3076));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3249));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3266));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3281));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3330));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3335));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3338));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3430));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 28, 9, 706, DateTimeKind.Utc).AddTicks(3441));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5144));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5151));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5168));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5386));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5394));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5467));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5471));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5473));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5474));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5476));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5515));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5517));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5568));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5621));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5626));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 10, 12, 45, 21, 760, DateTimeKind.Utc).AddTicks(5633));
        }
    }
}
