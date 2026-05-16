using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessCenterApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixSpaRegistrationPrimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SpaRegistrations",
                schema: "22180022",
                table: "SpaRegistrations");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                schema: "22180022",
                table: "SpaRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Primary key for the registration")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpaRegistrations",
                schema: "22180022",
                table: "SpaRegistrations",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_SpaRegistrations_MemberId",
                schema: "22180022",
                table: "SpaRegistrations",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SpaRegistrations",
                schema: "22180022",
                table: "SpaRegistrations");

            migrationBuilder.DropIndex(
                name: "IX_SpaRegistrations_MemberId",
                schema: "22180022",
                table: "SpaRegistrations");

            migrationBuilder.DropColumn(
                name: "Id",
                schema: "22180022",
                table: "SpaRegistrations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpaRegistrations",
                schema: "22180022",
                table: "SpaRegistrations",
                columns: new[] { "MemberId", "SpaProcedureId" });

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
    }
}
