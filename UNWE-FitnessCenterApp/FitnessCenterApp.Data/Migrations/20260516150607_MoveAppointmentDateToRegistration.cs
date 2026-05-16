using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessCenterApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class MoveAppointmentDateToRegistration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentDateTime",
                schema: "22180022",
                table: "SpaProcedures");

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentDateTime",
                schema: "22180022",
                table: "SpaRegistrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "The specific date and time the user booked this procedure");

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(679));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(684));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(689));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(888));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(933));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(939));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(974));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(1013));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(1017));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 16, 15, 6, 4, 928, DateTimeKind.Utc).AddTicks(1020));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentDateTime",
                schema: "22180022",
                table: "SpaRegistrations");

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentDateTime",
                schema: "22180022",
                table: "SpaProcedures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Appointment date and time for the spa service");

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5506));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5521));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5535));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5781));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5791));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5812));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5862));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5921));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5923));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(5925));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentDateTime", "ModifiedOn_22180022" },
                values: new object[] { new DateTime(2024, 12, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(6018) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentDateTime", "ModifiedOn_22180022" },
                values: new object[] { new DateTime(2024, 12, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentDateTime", "ModifiedOn_22180022" },
                values: new object[] { new DateTime(2024, 12, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(6032) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentDateTime", "ModifiedOn_22180022" },
                values: new object[] { new DateTime(2024, 12, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(6040) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppointmentDateTime", "ModifiedOn_22180022" },
                values: new object[] { new DateTime(2024, 12, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(6047) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AppointmentDateTime", "ModifiedOn_22180022" },
                values: new object[] { new DateTime(2024, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 12, 14, 31, 11, 717, DateTimeKind.Utc).AddTicks(6054) });
        }
    }
}
