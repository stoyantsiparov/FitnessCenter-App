using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessCenterApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeeds : Migration
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
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ModifiedOn_22180022", "Name" },
                values: new object[] { new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8235), "Пилатес" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8241));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://m5.netinfo.bg/media/images/30960/30960313/960-600-plovdivskoto-sportno-uchilishte.jpg", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8257) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022", "Name" },
                values: new object[] { "https://sofiamarathon.bg/wp-content/uploads/2026/01/wa-sof-mar_1025_0763-scaled.jpg", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8267), "Маратон" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://novinar.bg/wp-content/uploads/2026/04/maraton1.webp", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8464) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Location", "ModifiedOn_22180022" },
                values: new object[] { "https://static.dir.bg/uploads/images/2024/10/25/2817113/1366x768.jpg?_=1729836290", "Геопарк 'Искър-Панега'", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8511) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Location", "ModifiedOn_22180022" },
                values: new object[] { "https://360mag.bg/wp-content/uploads/2023/01/Winter_running_myhealth-org.webp", "Витоша", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8518) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8525));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Location", "ModifiedOn_22180022" },
                values: new object[] { "Черно море", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8531) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8549));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8554));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://dsport.bg/media/234/gettyimages-1399254105~2.l.webp", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8593) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://lira.bg/wp-content/uploads/2016/08/michaelphelps.jpg", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8595) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://www.flashnews.bg/wp-content/uploads/2018/07/DIY-frame-Arnold-Schwarzenegger-Terminator-Great-Muscle-Poster-Bodybuilding-Gym-Decor.jpg_640x640.jpg", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8597) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://bntnews.bg/f/news/b/1279/77b161de7a82fb079a287346551c5c74.jpg", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8599) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://s0.rbk.ru/v6_top_pics/media/img/9/24/347098230779249.jpeg", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8600) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://www.menslife.com/upload/iblock/51b/orig.jpg", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://knigomania.bg/media/attributesplash/david-goggins-portait.jpg", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8603) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://radiofresh.bg/uploads/images/51085959.jpg", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8605) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://trud.bg/storage/media/2021-02/1111396/32fonda_2266406737285834814_original.jpg", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8606) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://eva.bg/media/cache/article_photo_above_text/media/ZVEZDI/Novini/hijklmno/J-Aniston/2023/jen5cecac1f3.jpg", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8608) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8642));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8645));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8647));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8648));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8652));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://osoba.bg/sites/default/files/2023-01/relax-masaj2.png", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8685) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://www.puls.bg/cache/5/f/4/e/f/5f4ef5eae5984d5b0f78d3292fffd48a68d17d73.jpeg", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8687) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://www.estespa.bg/wp-content/uploads/2017/08/%D0%BC%D0%B0%D1%81%D0%B0%D0%B6-%D0%B0%D1%80%D0%BE%D0%BC%D0%B0%D1%82%D0%B5%D1%80%D0%B0%D0%BF%D0%B8%D1%8F.jpg", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8689) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://www.estespa.bg/wp-content/uploads/2020/01/600-2-1200x600.jpg", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8691) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://studio24.bg/gallery/picture/1/1126/tehnika-pri-dalbokotakanen-masazh-1738515226.jpg", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8693) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://www.thefountainspa.com/wp-content/uploads/2025/01/seaweed-wrap-460x320-1.webp", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8694) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://honuhousehawaii.com/wp-content/uploads/2024/11/Infrared-sauna-.png", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8696) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://ruskovets.com/wp-content/uploads/2025/06/parna-banq-polzi-1.jpg", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8698) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://img1.wsimg.com/isteam/ip/267c7f02-971c-448a-ace3-5d2ce5803d75/%D0%9A%D1%80%D0%B8%D0%BE%D1%82%D0%B5%D1%80%D0%B0%D0%BF%D0%B8%D1%8F.jpg", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8700) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://funstarter.bg/uploads/2024/11/detail-hands-massaging-human-calf-muscle_155003-5895.webp", new DateTime(2026, 5, 22, 15, 23, 27, 89, DateTimeKind.Utc).AddTicks(8701) });
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
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1243));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1253));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1259));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ModifiedOn_22180022", "Name" },
                values: new object[] { new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1265), "Пилатес за Ядрото" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1276));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1281));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://images.unsplash.com/photo-1519315901367-f34f9c5714dc?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1287) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1292));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022", "Name" },
                values: new object[] { "https://images.unsplash.com/photo-1534438097545-a2c22c57f2df?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1298), "Спининг Маратон" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://images.unsplash.com/photo-1530143311094-34d807799e8f?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1488) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1497));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Location", "ModifiedOn_22180022" },
                values: new object[] { "https://images.unsplash.com/photo-1506535995048-63737b794f83?auto=format&fit=crop&w=800&q=80", "Панчарево", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1505) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Location", "ModifiedOn_22180022" },
                values: new object[] { "https://images.unsplash.com/photo-1512361436605-a484fc5e943c?auto=format&fit=crop&w=800&q=80", "Южен Парк", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1514) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1523));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Location", "ModifiedOn_22180022" },
                values: new object[] { "Спортен Басейн", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1532) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1546));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Conor_McGregor_2018.jpg/800px-Conor_McGregor_2018.jpg", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/Michael_Phelps_Rio_Olympics_2016.jpg/800px-Michael_Phelps_Rio_Olympics_2016.jpg", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/Arnold_Schwarzenegger_by_Gage_Skidmore_4_%28cropped%29.jpg/800px-Arnold_Schwarzenegger_by_Gage_Skidmore_4_%28cropped%29.jpg", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1604) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/Usain_Bolt_2012_Olympics.jpg/800px-Usain_Bolt_2012_Olympics.jpg", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1605) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Mike_Tyson_2019_by_Glenn_Francis.jpg/800px-Mike_Tyson_2019_by_Glenn_Francis.jpg", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/23/Jean-Claude_Van_Damme_2012.jpg/800px-Jean-Claude_Van_Damme_2012.jpg", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1609) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/David_Goggins_-_10.22.18.jpg/800px-David_Goggins_-_10.22.18.jpg", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1610) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/Lance_Armstrong_in_2009.jpg/800px-Lance_Armstrong_in_2009.jpg", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Jane_Fonda_2014.jpg/800px-Jane_Fonda_2014.jpg", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b5/Jennifer_Aniston_2012.jpg/800px-Jennifer_Aniston_2012.jpg", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1615) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1649));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1655));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1657));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://images.unsplash.com/photo-1544161515-4ab6ce6db874?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1688) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://images.unsplash.com/photo-1515377905703-c4788e51af15?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1690) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://images.unsplash.com/photo-1600334089648-b0d9d3028eb2?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1692) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://images.unsplash.com/photo-1519823551278-64ac92734fb1?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1694) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://images.unsplash.com/photo-1519824145371-29681b328e11?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://images.unsplash.com/photo-1544161514-93c68383a542?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1697) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://images.unsplash.com/photo-1583416750470-965b2707b355?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1699) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://images.unsplash.com/photo-1552693673-1bf958298935?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1738) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://images.unsplash.com/photo-1583416750470-965b2707b355?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1740) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "ModifiedOn_22180022" },
                values: new object[] { "https://images.unsplash.com/photo-1519823551278-64ac92734fb1?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1742) });
        }
    }
}
