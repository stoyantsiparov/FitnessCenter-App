using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessCenterApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "22180022");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "22180022",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "22180022",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FitnessEvents",
                schema: "22180022",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Title of the fitness event"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Image URL of the fitness event"),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false, comment: "Description of the fitness event"),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Location of the fitness event"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Start date of the fitness event"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "End date of the fitness event"),
                    Capacity = table.Column<int>(type: "int", nullable: false, comment: "Maximum capacity for the event"),
                    ModifiedOn_22180022 = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time of the last modification")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FitnessEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                schema: "22180022",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Instructor's first name"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Instructor's last name"),
                    Bio = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false, comment: "Instructor's biography"),
                    Specialization = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Instructor's primary specialization"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Image URL of the instructor"),
                    ModifiedOn_22180022 = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time of the last modification")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "log_22180022",
                schema: "22180022",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Name of the table where the operation occurred"),
                    OperationType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Type of operation performed (e.g., INSERT, UPDATE, DELETE)"),
                    OperationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time when the operation was performed")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_log_22180022", x => x.Id);
                },
                comment: "Log table for tracking database changes");

            migrationBuilder.CreateTable(
                name: "MembershipTypes",
                schema: "22180022",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Name of the membership plan"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Price of the membership"),
                    Duration = table.Column<int>(type: "int", nullable: false, comment: "Duration in days"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Image URL of the membership plan"),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false, comment: "Description of the plan benefits"),
                    ModifiedOn_22180022 = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time of the last modification")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpaProcedures",
                schema: "22180022",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Spa type"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Image URL of the spa procedure"),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false, comment: "Description of the spa procedure"),
                    Duration = table.Column<int>(type: "int", nullable: false, comment: "Duration of the spa procedure in minutes"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Price of the spa procedure"),
                    AppointmentDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Appointment date and time for the spa service"),
                    Capacity = table.Column<int>(type: "int", nullable: false, comment: "Maximum capacity for the procedure"),
                    ModifiedOn_22180022 = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time of the last modification")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpaProcedures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "22180022",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "22180022",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "22180022",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "22180022",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "22180022",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "22180022",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "22180022",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "22180022",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "22180022",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "22180022",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "22180022",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FitnessEventRegistrations",
                schema: "22180022",
                columns: table => new
                {
                    MemberId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn_22180022 = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time of the last modification")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FitnessEventRegistrations", x => new { x.MemberId, x.EventId });
                    table.ForeignKey(
                        name: "FK_FitnessEventRegistrations_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalSchema: "22180022",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FitnessEventRegistrations_FitnessEvents_EventId",
                        column: x => x.EventId,
                        principalSchema: "22180022",
                        principalTable: "FitnessEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FitnessClasses",
                schema: "22180022",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Name of the fitness class"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Image URL of the fitness class"),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false, comment: "Description of the fitness class"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Price of the fitness class"),
                    ScheduleDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Scheduled date and time of the fitness class"),
                    Duration = table.Column<int>(type: "int", nullable: false, comment: "Duration of the fitness class in minutes"),
                    Capacity = table.Column<int>(type: "int", nullable: false, comment: "Maximum capacity for the class"),
                    InstructorId = table.Column<int>(type: "int", nullable: false, comment: "Foreign key to the Instructor of the fitness class"),
                    ModifiedOn_22180022 = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time of the last modification")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FitnessClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FitnessClasses_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalSchema: "22180022",
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MembershipRegistrations",
                schema: "22180022",
                columns: table => new
                {
                    MemberId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MembershipTypeId = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn_22180022 = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time of the last modification")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipRegistrations", x => new { x.MemberId, x.MembershipTypeId });
                    table.ForeignKey(
                        name: "FK_MembershipRegistrations_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalSchema: "22180022",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MembershipRegistrations_MembershipTypes_MembershipTypeId",
                        column: x => x.MembershipTypeId,
                        principalSchema: "22180022",
                        principalTable: "MembershipTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpaRegistrations",
                schema: "22180022",
                columns: table => new
                {
                    MemberId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SpaProcedureId = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn_22180022 = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time of the last modification")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpaRegistrations", x => new { x.MemberId, x.SpaProcedureId });
                    table.ForeignKey(
                        name: "FK_SpaRegistrations_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalSchema: "22180022",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpaRegistrations_SpaProcedures_SpaProcedureId",
                        column: x => x.SpaProcedureId,
                        principalSchema: "22180022",
                        principalTable: "SpaProcedures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FitnessClassRegistrations",
                schema: "22180022",
                columns: table => new
                {
                    MemberId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FitnessClassId = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn_22180022 = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time of the last modification")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FitnessClassRegistrations", x => new { x.MemberId, x.FitnessClassId });
                    table.ForeignKey(
                        name: "FK_FitnessClassRegistrations_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalSchema: "22180022",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FitnessClassRegistrations_FitnessClasses_FitnessClassId",
                        column: x => x.FitnessClassId,
                        principalSchema: "22180022",
                        principalTable: "FitnessClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "22180022",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "22180022",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "22180022",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "22180022",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "22180022",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "22180022",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "22180022",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FitnessClasses_InstructorId",
                schema: "22180022",
                table: "FitnessClasses",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_FitnessClassRegistrations_FitnessClassId",
                schema: "22180022",
                table: "FitnessClassRegistrations",
                column: "FitnessClassId");

            migrationBuilder.CreateIndex(
                name: "IX_FitnessEventRegistrations_EventId",
                schema: "22180022",
                table: "FitnessEventRegistrations",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_MembershipRegistrations_MembershipTypeId",
                schema: "22180022",
                table: "MembershipRegistrations",
                column: "MembershipTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SpaRegistrations_SpaProcedureId",
                schema: "22180022",
                table: "SpaRegistrations",
                column: "SpaProcedureId");

            // Add triggers for logging changes to the specified tables

            var tablesToTrigger = new[]
            {
                "MembershipTypes", "MembershipRegistrations",
                "FitnessEvents", "FitnessEventRegistrations",
                "FitnessClasses", "FitnessClassRegistrations",
                "Instructors", "SpaProcedures", "SpaRegistrations"
            };

            foreach (var table in tablesToTrigger)
            {
                migrationBuilder.Sql($@"
                    CREATE TRIGGER [22180022].[TR_{table}_Log]
                    ON [22180022].[{table}]
                    AFTER INSERT, UPDATE
                    AS
                    BEGIN
                        SET NOCOUNT ON;
                        INSERT INTO [22180022].[log_22180022] (TableName, OperationType, OperationDateTime)
                        SELECT '{table}', 
                               CASE WHEN EXISTS(SELECT * FROM deleted) THEN 'UPDATE' ELSE 'INSERT' END,
                               GETUTCDATE()
                        FROM inserted
                    END
                ");
            }
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop triggers before dropping tables
            var tablesToTrigger = new[]
            {
                "MembershipTypes", "MembershipRegistrations",
                "FitnessEvents", "FitnessEventRegistrations",
                "FitnessClasses", "FitnessClassRegistrations",
                "Instructors", "SpaProcedures", "SpaRegistrations"
            };

            foreach (var table in tablesToTrigger)
            {
                migrationBuilder.Sql($"DROP TRIGGER IF EXISTS [22180022].[TR_{table}_Log]");
            }

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "22180022");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "22180022");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "22180022");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "22180022");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "22180022");

            migrationBuilder.DropTable(
                name: "FitnessClassRegistrations",
                schema: "22180022");

            migrationBuilder.DropTable(
                name: "FitnessEventRegistrations",
                schema: "22180022");

            migrationBuilder.DropTable(
                name: "log_22180022",
                schema: "22180022");

            migrationBuilder.DropTable(
                name: "MembershipRegistrations",
                schema: "22180022");

            migrationBuilder.DropTable(
                name: "SpaRegistrations",
                schema: "22180022");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "22180022");

            migrationBuilder.DropTable(
                name: "FitnessClasses",
                schema: "22180022");

            migrationBuilder.DropTable(
                name: "FitnessEvents",
                schema: "22180022");

            migrationBuilder.DropTable(
                name: "MembershipTypes",
                schema: "22180022");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "22180022");

            migrationBuilder.DropTable(
                name: "SpaProcedures",
                schema: "22180022");

            migrationBuilder.DropTable(
                name: "Instructors",
                schema: "22180022");
        }
    }
}