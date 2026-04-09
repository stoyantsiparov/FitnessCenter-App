using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessCenterApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRegistrationDateToMembershipRegistration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                schema: "22180022",
                table: "MembershipRegistrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(7980));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(7990));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(7996));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8001));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8186));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8231));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8253));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8293));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8295));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8337));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8339));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8341));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8343));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8378));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8384));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8392));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 16, 16, 2, 540, DateTimeKind.Utc).AddTicks(8408));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                schema: "22180022",
                table: "MembershipRegistrations");

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6474));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6498));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6504));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6736));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6776));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6778));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6783));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6878));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 4, 9, 13, 35, 24, 74, DateTimeKind.Utc).AddTicks(6887));
        }
    }
}
