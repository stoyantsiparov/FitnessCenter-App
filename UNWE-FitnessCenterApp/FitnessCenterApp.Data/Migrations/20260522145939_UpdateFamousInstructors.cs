using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessCenterApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFamousInstructors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "InstructorId", "ModifiedOn_22180022", "Price" },
                values: new object[] { "Спокойна и хармонична йога сесия, идеална за рестарт на деня и подобряване на фокуса. Водена лично от холивудската звезда.", 10, new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1243), 25.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "InstructorId", "ModifiedOn_22180022", "Price" },
                values: new object[] { "Интензивна интервална тренировка и спринтове, създадена да изгори максимален брой калории за кратко време.", 4, new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1253), 30.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "InstructorId", "ModifiedOn_22180022", "Price" },
                values: new object[] { "Забавен и енергичен зумба клас, подходящ за всички нива. Танцувайте и отслабвайте в ритъма на 80-те!", 9, new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1259), 20.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "InstructorId", "ModifiedOn_22180022", "Price" },
                values: new object[] { "Тренировка за заздравяване на коремните мускули, подобряване на стойката и екстремна гъвкавост.", 6, new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1265), 25.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "InstructorId", "ModifiedOn_22180022", "Price" },
                values: new object[] { "Въвеждащ клас в силовите тренировки с акцент върху правилната техника за вдигане на тежести и безопасност.", 3, new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1270), 40.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "InstructorId", "ModifiedOn_22180022", "Price" },
                values: new object[] { "Научете основните техники на смесените бойни изкуства в сигурна и мотивираща среда с шампиона на UFC.", 1, new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1276), 50.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ModifiedOn_22180022", "Price" },
                values: new object[] { "Изключително тежка комплексна тренировка с тежести и кардио. Препоръчва се само за напреднали и психически подготвени!", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1281), 35.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "InstructorId", "ModifiedOn_22180022", "Name", "Price" },
                values: new object[] { "Тренировка в олимпийския басейн, фокусирана върху изчистване на стила и увеличаване на скоростта във водата.", "https://images.unsplash.com/photo-1519315901367-f34f9c5714dc?auto=format&fit=crop&w=800&q=80", 2, new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1287), "Спортно Плуване", 45.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "InstructorId", "ModifiedOn_22180022", "Price" },
                values: new object[] { "Клас, насочен към базови боксови комбинации, движение с крака и кардио издръжливост на ринга.", 5, new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1292), 35.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "InstructorId", "ModifiedOn_22180022", "Price" },
                values: new object[] { "Интензивно колоездене на закрито с изключително високо темпо. Изгорете до 800 калории за една сесия!", 8, new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1298), 25.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1488));

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
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1514));

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
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1532));

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
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Ирландски професионален ММА боец и бивш двоен шампион на UFC. Тренировките с Конър ще ви научат на безкомпромисна дисциплина, експлозивна сила и елитни бойни техники.", "Конър", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Conor_McGregor_2018.jpg/800px-Conor_McGregor_2018.jpg", "Макгрегър", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1600), "ММА" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Най-успешният олимпиец на всички времена с 28 медала. В неговите класове ще изградите техника, бързина и издръжливост във водата, напълно достойни за шампиони.", "Майкъл", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/Michael_Phelps_Rio_Olympics_2016.jpg/800px-Michael_Phelps_Rio_Olympics_2016.jpg", "Фелпс", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1602), "Спортно плуване" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Живата легенда в бодибилдинга и 7-кратен Мистър Олимпия. Арнолд ще ви покаже как да изградите перфектната физика с правилна техника и \"желязна\" воля.", "Арнолд", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/Arnold_Schwarzenegger_by_Gage_Skidmore_4_%28cropped%29.jpg/800px-Arnold_Schwarzenegger_by_Gage_Skidmore_4_%28cropped%29.jpg", "Шварценегер", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1604), "Силови тренировки" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Най-бързият човек на планетата. Неговите високоинтензивни тренировки и спринтове ще ви помогнат да развиете експлозивна скорост и ненадминато кардио.", "Юсейн", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/Usain_Bolt_2012_Olympics.jpg/800px-Usain_Bolt_2012_Olympics.jpg", "Болт", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1605), "HIIT / Спринт" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "\"Железният\" Майк е един от най-великите боксьори в тежка категория за всички времена. Тренировките с него изискват пълно раздаване, 100% фокус и сурова сила.", "Майк", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Mike_Tyson_2019_by_Glenn_Francis.jpg/800px-Mike_Tyson_2019_by_Glenn_Francis.jpg", "Тайсън", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1607), "Бокс" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Майстор на бойните изкуства и кино звезда, световноизвестен със своята невероятна гъвкавост. Ще ви помогне да изградите силно ядро, перфектен баланс и контрол над тялото.", "Жан-Клод", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/23/Jean-Claude_Van_Damme_2012.jpg/800px-Jean-Claude_Van_Damme_2012.jpg", "Ван Дам", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1609), "Гъвкавост / Пилатес" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Бивш \"Тюлен\" (Navy SEAL) и ултрамаратонец. Гогинс няма да ви позволи да се откажете. Готови ли сте да надскочите границите на човешките си възможности?", "Дейвид", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/David_Goggins_-_10.22.18.jpg/800px-David_Goggins_-_10.22.18.jpg", "Гогинс", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1610), "Кросфит / Издръжливост" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Световноизвестен колоездач, който отлично знае какво означава да въртиш педалите до край. Подгответе се за най-тежките и мотивиращи спининг маратони в живота си.", "Ланс", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/Lance_Armstrong_in_2009.jpg/800px-Lance_Armstrong_in_2009.jpg", "Армстронг", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1612), "Спининг / Колоездене" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Иконата на фитнес революцията. Нейната заразителна енергия и чувство за ритъм ще превърнат всяка кардио и зумба тренировка в истинско забавление.", "Джейн", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Jane_Fonda_2014.jpg/800px-Jane_Fonda_2014.jpg", "Фонда", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1614), "Зумба / Аеробика" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Освен холивудска звезда, тя е отдаден практик на йога от десетилетия. Нейните сесии ще ви донесат нужното спокойствие, гъвкавост и дълбок вътрешен мир.", "Дженифър", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b5/Jennifer_Aniston_2012.jpg/800px-Jennifer_Aniston_2012.jpg", "Анистън", new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1615), "Йога" });

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
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1695));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1699));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1738));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 14, 59, 37, 385, DateTimeKind.Utc).AddTicks(1742));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "InstructorId", "ModifiedOn_22180022", "Price" },
                values: new object[] { "Спокойна и хармонична йога сесия, идеална за рестарт на деня и подобряване на фокуса.", 1, new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8061), 15.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "InstructorId", "ModifiedOn_22180022", "Price" },
                values: new object[] { "Интензивна интервална тренировка, създадена да изгори максимален брой калории за кратко време.", 2, new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8072), 20.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "InstructorId", "ModifiedOn_22180022", "Price" },
                values: new object[] { "Забавен и енергичен зумба клас, подходящ за всички нива. Танцувайте и отслабвайте!", 3, new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8078), 15.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "InstructorId", "ModifiedOn_22180022", "Price" },
                values: new object[] { "Тренировка за заздравяване на коремните мускули, подобряване на стойката и гъвкавостта.", 4, new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8084), 18.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "InstructorId", "ModifiedOn_22180022", "Price" },
                values: new object[] { "Въвеждащ клас в силовите тренировки с акцент върху правилната техника и безопасност.", 5, new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8089), 25.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "InstructorId", "ModifiedOn_22180022", "Price" },
                values: new object[] { "Научете основните техники на смесените бойни изкуства в сигурна и мотивираща среда.", 6, new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8095), 30.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ModifiedOn_22180022", "Price" },
                values: new object[] { "Тежка комплексна тренировка с тежести, гимнастика и кардио. Само за напреднали!", new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8100), 25.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "InstructorId", "ModifiedOn_22180022", "Name", "Price" },
                values: new object[] { "Освежаваща водна тренировка в басейна. Идеална за раздвижване без натоварване на ставите.", "https://images.unsplash.com/photo-1530549387789-4c1017266635?auto=format&fit=crop&w=800&q=80", 8, new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8105), "Аква Аеробика", 20.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "InstructorId", "ModifiedOn_22180022", "Price" },
                values: new object[] { "Клас, насочен към базови боксови комбинации, движение с крака и кардио издръжливост.", 9, new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8113), 25.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "InstructorId", "ModifiedOn_22180022", "Price" },
                values: new object[] { "Интензивно колоездене на закрито с мотивираща музика. Изгорете до 600 калории!", 10, new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8119), 18.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8348));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8363));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8377));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8383));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8397));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Натали е сертифициран йога инструктор с над 10 години опит. Тя е посветена на това да помага на хората да постигнат хармония между тяло и дух.", "Натали", "https://images.unsplash.com/photo-1544005313-94ddf0286df2?auto=format&fit=crop&w=800&q=80", "Асатрян", new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8437), "Йога" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Уорън е фитнес треньор, специализиран във високоинтензивни интервални тренировки (HIIT). Обича да мотивира клиентите си да надскачат собствените си граници.", "Уорън", "https://images.unsplash.com/photo-1570295999919-56ceb5ecca61?auto=format&fit=crop&w=800&q=80", "Скот", new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8439), "HIIT" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Емили е инструктор по Зумба с богат опит в танците. Тя създава забавна и енергична атмосфера, в която тренировката се усеща като парти.", "Емили", "https://images.unsplash.com/photo-1518611012118-696072aa579a?auto=format&fit=crop&w=800&q=80", "Джонсън", new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8441), "Зумба" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Оливия е сертифициран Пилатес инструктор. Нейната страст е да помага на хората да подобрят стойката си, гъвкавостта и силата на ядрото.", "Оливия", "https://images.unsplash.com/photo-1594381898411-846e7d193883?auto=format&fit=crop&w=800&q=80", "Уилямс", new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8443), "Пилатес" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Улф е треньор по силови тренировки и вдигане на тежести. Специализира в изграждането на мускулна маса и правилна техника на изпълнение.", "Улф", "https://images.unsplash.com/photo-1567598508481-65985588e295?auto=format&fit=crop&w=800&q=80", "Джеймисън", new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8445), "Силови тренировки" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Конър е професионален ММА боец и мотиватор. В неговите класове ще научите основите на бойните изкуства и ще изградите желязна дисциплина.", "Конър", "https://images.unsplash.com/photo-1509967419530-da38b4704bc6?auto=format&fit=crop&w=800&q=80", "Макгрегър", new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8446), "ММА" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Митко е бивш състезател по Кросфит. Тренировките му са интензивни, комплексни и гарантират бързи резултати за издръжливост и сила.", "Димитър", "https://images.unsplash.com/photo-1534438327276-14e5300c3a48?auto=format&fit=crop&w=800&q=80", "Петров", new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8448), "Кросфит" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Мария е инструктор по водна аеробика. Нейните тренировки са щадящи за ставите, но изключително ефективни за изгаряне на калории.", "Мария", "https://images.unsplash.com/photo-1571019614242-c5c5dee9f50b?auto=format&fit=crop&w=800&q=80", "Иванова", new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8450), "Аква Аеробика" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Георги е треньор по бокс с дългогодишен опит. Подходящ както за начинаещи, така и за напреднали, желаещи да подобрят техниката си.", "Георги", "https://images.unsplash.com/photo-1517836357463-d25dfeac3438?auto=format&fit=crop&w=800&q=80", "Георгиев", new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8451), "Бокс" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Елена води едни от най-енергичните спининг класове в центъра. Музиката ѝ е мотивираща, а натоварването - гарантирано.", "Елена", "https://images.unsplash.com/photo-1548690312-e3b507d8c110?auto=format&fit=crop&w=800&q=80", "Стоянова", new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8453), "Спининг" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8488));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8492));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8496));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8592));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8594));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedOn_22180022",
                value: new DateTime(2026, 5, 22, 10, 42, 12, 55, DateTimeKind.Utc).AddTicks(8599));
        }
    }
}
