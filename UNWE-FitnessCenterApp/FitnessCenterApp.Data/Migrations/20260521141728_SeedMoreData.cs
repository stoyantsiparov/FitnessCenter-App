using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitnessCenterApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name", "Price", "ScheduleDateTime" },
                values: new object[] { "Спокойна и хармонична йога сесия, идеална за рестарт на деня и подобряване на фокуса.", "https://images.unsplash.com/photo-1544367567-0f2fcb009e0b?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3054), "Сутрешна Йога", 15.00m, new DateTime(2026, 7, 15, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name", "Price", "ScheduleDateTime" },
                values: new object[] { "Интензивна интервална тренировка, създадена да изгори максимален брой калории за кратко време.", "https://images.unsplash.com/photo-1517836357463-d25dfeac3438?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3064), "HIIT Предизвикателство", 20.00m, new DateTime(2026, 7, 16, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name", "Price", "ScheduleDateTime" },
                values: new object[] { "Забавен и енергичен зумба клас, подходящ за всички нива. Танцувайте и отслабвайте!", "https://images.unsplash.com/photo-1522898467493-49726bf28798?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3071), "Зумба Танци", 15.00m, new DateTime(2026, 7, 17, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name", "Price", "ScheduleDateTime" },
                values: new object[] { "Тренировка за заздравяване на коремните мускули, подобряване на стойката и гъвкавостта.", "https://images.unsplash.com/photo-1518310383802-640c2de311b2?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3077), "Пилатес за Ядрото", 18.00m, new DateTime(2026, 7, 18, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name", "Price", "ScheduleDateTime" },
                values: new object[] { "Въвеждащ клас в силовите тренировки с акцент върху правилната техника и безопасност.", "https://images.unsplash.com/photo-1534438327276-14e5300c3a48?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3082), "Основи на Силовите Тренировки", 25.00m, new DateTime(2026, 7, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Duration", "ImageUrl", "ModifiedOn_22180022", "Name", "Price", "ScheduleDateTime" },
                values: new object[] { "Научете основните техники на смесените бойни изкуства в сигурна и мотивираща среда.", 60, "https://images.unsplash.com/photo-1555597673-b21d5c935865?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3088), "ММА Основи", 30.00m, new DateTime(2026, 7, 20, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EndDate", "ImageUrl", "Location", "ModifiedOn_22180022", "StartDate", "Title" },
                values: new object[] { "Присъединете се към вълнуващ 10 км маратон през централните улици на града.", new DateTime(2026, 8, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1530143311094-34d807799e8f?auto=format&fit=crop&w=800&q=80", "Площад Център", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3282), new DateTime(2026, 8, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), "Пролетен Градски Маратон" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EndDate", "ImageUrl", "Location", "ModifiedOn_22180022", "StartDate", "Title" },
                values: new object[] { "Предизвикателен поход до върха с група от ентусиасти и професионални водачи.", new DateTime(2026, 8, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1551632811-561732d1e306?auto=format&fit=crop&w=800&q=80", "Хижа Алеко", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3290), new DateTime(2026, 8, 20, 6, 0, 0, 0, DateTimeKind.Unspecified), "Планински Поход Витоша" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EndDate", "ImageUrl", "Location", "ModifiedOn_22180022", "StartDate", "Title" },
                values: new object[] { "Живописна разходка около езерото. Перфектна възможност за лека кардио активност на чист въздух.", new DateTime(2026, 10, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1506535995048-63737b794f83?auto=format&fit=crop&w=800&q=80", "Панчарево", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3296), new DateTime(2026, 10, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "Есенна Разходка край Езерото" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EndDate", "ImageUrl", "Location", "ModifiedOn_22180022", "StartDate", "Title" },
                values: new object[] { "Празнично 5 км бягане през снежния парк, средствата от което отиват за благотворителност.", new DateTime(2026, 12, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1512361436605-a484fc5e943c?auto=format&fit=crop&w=800&q=80", "Южен Парк", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3303), new DateTime(2026, 12, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), "Зимно Благотворително Бягане" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "EndDate", "ImageUrl", "Location", "ModifiedOn_22180022", "StartDate", "Title" },
                values: new object[] { "Отпуснете се с ранна йога сесия под звуците на морските вълни.", new DateTime(2026, 7, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?auto=format&fit=crop&w=800&q=80", "Слънчев Бряг", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3310), new DateTime(2026, 7, 25, 7, 0, 0, 0, DateTimeKind.Unspecified), "Лятна Йога на Плажа" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "EndDate", "ImageUrl", "Location", "ModifiedOn_22180022", "StartDate", "Title" },
                values: new object[] { "Основи на водолазното гмуркане. Научете се да дишате под вода с професионални инструктори.", new DateTime(2026, 9, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1544551763-46a013bb70d5?auto=format&fit=crop&w=800&q=80", "Спортен Басейн", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3316), new DateTime(2026, 9, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), "Курс по Гмуркане" });

            migrationBuilder.InsertData(
                schema: "22180022",
                table: "FitnessEvents",
                columns: new[] { "Id", "Capacity", "Description", "EndDate", "ImageUrl", "Location", "ModifiedOn_22180022", "StartDate", "Title" },
                values: new object[,]
                {
                    { 7, 50, "Вътрешен клубен турнир по вдигане на тежести. Елате да премерите сили с най-добрите!", new DateTime(2026, 10, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1517836357463-d25dfeac3438?auto=format&fit=crop&w=800&q=80", "Главна Фитнес Зала", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3322), new DateTime(2026, 10, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), "Турнир по Вдигане на Тежести" },
                    { 8, 30, "Двудневно бягство от града, изпълнено с медитация, йога и здравословна храна.", new DateTime(2026, 9, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1545205597-3d9d02c29597?auto=format&fit=crop&w=800&q=80", "Еко Комплекс 'Балкан'", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3328), new DateTime(2026, 9, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), "Уикенд Йога Ретрийт" },
                    { 9, 60, "Интензивен фитнес лагер на открито. Комбинация от военна подготовка и кардио.", new DateTime(2026, 8, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1571019613454-1cb2f99b2d8b?auto=format&fit=crop&w=800&q=80", "Борисова Градина", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3335), new DateTime(2026, 8, 5, 8, 30, 0, 0, DateTimeKind.Unspecified), "Фитнес Буткемп на Открито" },
                    { 10, 100, "Семинар за изготвяне на хранителен режим, воден от топ диетолози.", new DateTime(2026, 11, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1490645935967-10de6ba17061?auto=format&fit=crop&w=800&q=80", "Конферентна Зала", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3341), new DateTime(2026, 11, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "Мастърклас по Здравословно Хранене" }
                });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Натали е сертифициран йога инструктор с над 10 години опит. Тя е посветена на това да помага на хората да постигнат хармония между тяло и дух.", "Натали", "https://images.unsplash.com/photo-1544005313-94ddf0286df2?auto=format&fit=crop&w=800&q=80", "Асатрян", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3384), "Йога" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022" },
                values: new object[] { "Уорън е фитнес треньор, специализиран във високоинтензивни интервални тренировки (HIIT). Обича да мотивира клиентите си да надскачат собствените си граници.", "Уорън", "https://images.unsplash.com/photo-1570295999919-56ceb5ecca61?auto=format&fit=crop&w=800&q=80", "Скот", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3386) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Емили е инструктор по Зумба с богат опит в танците. Тя създава забавна и енергична атмосфера, в която тренировката се усеща като парти.", "Емили", "https://images.unsplash.com/photo-1518611012118-696072aa579a?auto=format&fit=crop&w=800&q=80", "Джонсън", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3388), "Зумба" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Оливия е сертифициран Пилатес инструктор. Нейната страст е да помага на хората да подобрят стойката си, гъвкавостта и силата на ядрото.", "Оливия", "https://images.unsplash.com/photo-1594381898411-846e7d193883?auto=format&fit=crop&w=800&q=80", "Уилямс", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3389), "Пилатес" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Улф е треньор по силови тренировки и вдигане на тежести. Специализира в изграждането на мускулна маса и правилна техника на изпълнение.", "Улф", "https://images.unsplash.com/photo-1567598508481-65985588e295?auto=format&fit=crop&w=800&q=80", "Джеймисън", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3391), "Силови тренировки" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022" },
                values: new object[] { "Конър е професионален ММА боец и мотиватор. В неговите класове ще научите основите на бойните изкуства и ще изградите желязна дисциплина.", "Конър", "https://images.unsplash.com/photo-1509967419530-da38b4704bc6?auto=format&fit=crop&w=800&q=80", "Макгрегър", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3392) });

            migrationBuilder.InsertData(
                schema: "22180022",
                table: "Instructors",
                columns: new[] { "Id", "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[,]
                {
                    { 7, "Митко е бивш състезател по Кросфит. Тренировките му са интензивни, комплексни и гарантират бързи резултати за издръжливост и сила.", "Димитър", "https://images.unsplash.com/photo-1534438327276-14e5300c3a48?auto=format&fit=crop&w=800&q=80", "Петров", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3448), "Кросфит" },
                    { 8, "Мария е инструктор по водна аеробика. Нейните тренировки са щадящи за ставите, но изключително ефективни за изгаряне на калории.", "Мария", "https://images.unsplash.com/photo-1571019614242-c5c5dee9f50b?auto=format&fit=crop&w=800&q=80", "Иванова", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3449), "Аква Аеробика" },
                    { 9, "Георги е треньор по бокс с дългогодишен опит. Подходящ както за начинаещи, така и за напреднали, желаещи да подобрят техниката си.", "Георги", "https://images.unsplash.com/photo-1517836357463-d25dfeac3438?auto=format&fit=crop&w=800&q=80", "Георгиев", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3451), "Бокс" },
                    { 10, "Елена води едни от най-енергичните спининг класове в центъра. Музиката ѝ е мотивираща, а натоварването - гарантирано.", "Елена", "https://images.unsplash.com/photo-1548690312-e3b507d8c110?auto=format&fit=crop&w=800&q=80", "Стоянова", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3453), "Спининг" }
                });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name" },
                values: new object[] { "Стандартен месечен абонамент. Дава неограничен достъп до фитнес залата и груповите класове. Не включва достъп до безплатни СПА процедури.", "https://images.unsplash.com/photo-1534438327276-14e5300c3a48?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3486), "Основен (Basic)" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name" },
                values: new object[] { "Двумесечен абонамент за сериозно трениращи. Включва достъп до залата, класовете и право на 1 безплатна СПА процедура всяка седмица за възстановяване.", "https://images.unsplash.com/photo-1517836357463-d25dfeac3438?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3488), "Елитен (Elite)" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name" },
                values: new object[] { "Шестмесечен абонамент с висока добавена стойност. Гарантира достъп до всички съоръжения и ви дава право на цели 5 безплатни СПА процедури на седмица.", "https://images.unsplash.com/photo-1555597673-b21d5c935865?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3490), "Премиум (Premium)" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name" },
                values: new object[] { "Ексклузивен едногодишен абонамент за най-отдадените. Получавате приоритетно записване и неограничен достъп до всички СПА процедури.", "https://images.unsplash.com/photo-1541534741688-6078c6bfb5c5?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3492), "VIP Годишен" });

            migrationBuilder.InsertData(
                schema: "22180022",
                table: "MembershipTypes",
                columns: new[] { "Id", "AllowedSpaProceduresPerWeek", "Description", "Duration", "ImageUrl", "ModifiedOn_22180022", "Name", "Price" },
                values: new object[,]
                {
                    { 5, 0, "Специално намаление за студенти на УНСС. Дава пълен достъп до фитнес залата и тренировките. Не включва СПА процедури.", 30, "https://images.unsplash.com/photo-1571019614242-c5c5dee9f50b?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3494), "Студентски (UNWE)", 39.99m },
                    { 6, 0, "Месечен абонамент с достъп до фитнес залата всеки ден, но само до 16:00 ч. Отличен избор за хора с гъвкаво работно време.", 30, "https://images.unsplash.com/photo-1574680096145-d05b474e2155?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3495), "Дневен (Daytime)", 45.99m }
                });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name" },
                values: new object[] { "Успокояващ масаж с бавни и плавни движения за облекчаване на напрежението и стреса.", "https://images.unsplash.com/photo-1544161515-4ab6ce6db874?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3528), "Релаксиращ Масаж" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "ImageUrl", "ModifiedOn_22180022", "Name", "Price" },
                values: new object[] { 2, "Подмладяваща процедура за лице, която подхранва, хидратира и освежава кожата.", "https://images.unsplash.com/photo-1515377905703-c4788e51af15?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3530), "Терапия за Лице", 45.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "ImageUrl", "ModifiedOn_22180022", "Name", "Price" },
                values: new object[] { 3, "Сесия с етерични масла, която стимулира сетивата и насърчава пълното отпускане.", "https://images.unsplash.com/photo-1600334089648-b0d9d3028eb2?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3532), "Ароматерапия", 35.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name", "Price" },
                values: new object[] { "Терапевтичен масаж, използващ гладки, нагряти камъни за дълбоко отпускане на мускулите.", "https://images.unsplash.com/photo-1519823551278-64ac92734fb1?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3534), "Масаж с Горещи Камъни", 75.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Description", "ImageUrl", "ModifiedOn_22180022", "Name", "Price" },
                values: new object[] { 4, "Масаж, насочен към по-дълбоките слоеве на мускулната тъкан за освобождаване на хронично напрежение.", "https://images.unsplash.com/photo-1519824145371-29681b328e11?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3535), "Дълбокотъканен Масаж", 65.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Description", "ImageUrl", "ModifiedOn_22180022", "Name" },
                values: new object[] { 2, "Детоксикираща процедура за тяло с богати на хранителни вещества водорасли за стягане на кожата.", "https://images.unsplash.com/photo-1544161514-93c68383a542?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3537), "Обвиване с Водорасли" });

            migrationBuilder.InsertData(
                schema: "22180022",
                table: "SpaProcedures",
                columns: new[] { "Id", "Capacity", "Description", "Duration", "ImageUrl", "ModifiedOn_22180022", "Name", "Price" },
                values: new object[,]
                {
                    { 7, 6, "Дълбоко проникваща топлина, която подпомага детоксикацията, отслабването и релаксацията.", 45, "https://images.unsplash.com/photo-1583416750470-965b2707b355?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3539), "Инфрачервена Сауна", 25.00m },
                    { 8, 8, "Пречистваща парна баня, обогатена с лечебни билки за отваряне на порите и дихателните пътища.", 30, "https://images.unsplash.com/photo-1552693673-1bf958298935?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3541), "Парна Баня с Билкови Екстракти", 20.00m },
                    { 9, 1, "Студова терапия, изключително ефективна за бързо възстановяване на мускулите след тежка тренировка.", 15, "https://images.unsplash.com/photo-1583416750470-965b2707b355?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3542), "Криотерапия за Възстановяване", 40.00m },
                    { 10, 2, "Специализиран енергичен масаж, който използва бамбукови пръчки за дълбок дренаж на тъканите.", 60, "https://images.unsplash.com/photo-1519823551278-64ac92734fb1?auto=format&fit=crop&w=800&q=80", new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3544), "Спортен Масаж с Бамбукови Пръчки", 60.00m }
                });

            migrationBuilder.InsertData(
                schema: "22180022",
                table: "FitnessClasses",
                columns: new[] { "Id", "Capacity", "Description", "Duration", "ImageUrl", "InstructorId", "ModifiedOn_22180022", "Name", "Price", "ScheduleDateTime" },
                values: new object[,]
                {
                    { 7, 15, "Тежка комплексна тренировка с тежести, гимнастика и кардио. Само за напреднали!", 60, "https://images.unsplash.com/photo-1541534741688-6078c6bfb5c5?auto=format&fit=crop&w=800&q=80", 7, new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3093), "Кросфит за Напреднали", 25.00m, new DateTime(2026, 7, 21, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 12, "Освежаваща водна тренировка в басейна. Идеална за раздвижване без натоварване на ставите.", 50, "https://images.unsplash.com/photo-1530549387789-4c1017266635?auto=format&fit=crop&w=800&q=80", 8, new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3098), "Аква Аеробика", 20.00m, new DateTime(2026, 7, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 16, "Клас, насочен към базови боксови комбинации, движение с крака и кардио издръжливост.", 60, "https://images.unsplash.com/photo-1549719386-74dfcbf7dbed?auto=format&fit=crop&w=800&q=80", 9, new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3103), "Бокс за Начинаещи", 25.00m, new DateTime(2026, 7, 23, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 20, "Интензивно колоездене на закрито с мотивираща музика. Изгорете до 600 калории!", 45, "https://images.unsplash.com/photo-1534438097545-a2c22c57f2df?auto=format&fit=crop&w=800&q=80", 10, new DateTime(2026, 5, 21, 14, 17, 27, 673, DateTimeKind.Utc).AddTicks(3108), "Спининг Маратон", 18.00m, new DateTime(2026, 7, 24, 18, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name", "Price", "ScheduleDateTime" },
                values: new object[] { "A calm and peaceful yoga session to start your day.", "https://yogajala.com/wp-content/uploads/8-Benefits-Of-Morning-Yoga.jpg", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(373), "Morning Yoga", 50.00m, new DateTime(2024, 12, 5, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name", "Price", "ScheduleDateTime" },
                values: new object[] { "An intense, high-energy interval training session.", "https://i.ytimg.com/vi/66_hHeSUrzU/hq720.jpg?sqp=-oaymwEhCK4FEIIDSFryq4qpAxMIARUAAAAAGAElAADIQjZQw/2.jpg", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(383), "HIIT Challenge", 50.00m, new DateTime(2024, 12, 5, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name", "Price", "ScheduleDateTime" },
                values: new object[] { "A fun and energetic Zumba dance class for all levels.", "https://i.ytimg.com/vi/N3wBXogMYfM/hq720.jpg?sqp=-oaymwE7CK4FEIIDSFryq4qpAy0IARUAAAAAGAElAADIQj0AgKJD8AEB-AH-CYAC0AWKAgwIABABGGUgUihUMA8=&rs=AOn4CLD9yvCPKa7mHvL_lLUQr-TvnlNYRw", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(389), "Zumba Dance", 90.00m, new DateTime(2024, 12, 6, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name", "Price", "ScheduleDateTime" },
                values: new object[] { "Strengthen your core and improve posture with this Pilates class.", "https://media.self.com/photos/5b9c24c208e0b96633983ce8/2:1/w_2580,c_limit/pilates-butt-core-workout.jpg", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(395), "Pilates Core", 85.00m, new DateTime(2024, 12, 7, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name", "Price", "ScheduleDateTime" },
                values: new object[] { "An introductory strength training session focusing on weightlifting techniques.", "https://www.jefit.com/_next/image?url=https%3A%2F%2Fcdn.jefit.com%2Fuc%2Ffile%2Fc34238b8cd6e3cf7%2F1.jpg&w=3840&q=75", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(401), "Strength Training Basics", 95.00m, new DateTime(2024, 12, 7, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Duration", "ImageUrl", "ModifiedOn_22180022", "Name", "Price", "ScheduleDateTime" },
                values: new object[] { "Learn the basics of ММА in this high-energy and engaging class.", 30, "https://mf.b37mrtl.ru/rbthmedia/images/2018.02/article/5a93bf3385600a57b0096f7e.jpg", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(406), "ММА Essentials", 150.00m, new DateTime(2024, 12, 8, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EndDate", "ImageUrl", "Location", "ModifiedOn_22180022", "StartDate", "Title" },
                values: new object[] { "Join us for a thrilling 10K spring marathon through the city streets.", new DateTime(2025, 4, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://www.chicagospringhalf.com/wp-content/uploads/sites/32/2023/05/2022_SPRCHI_RaceDay_Ali_282-1024x683.jpg", "Downtown City Center", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 4, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), "Spring City Marathon" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EndDate", "ImageUrl", "Location", "ModifiedOn_22180022", "StartDate", "Title" },
                values: new object[] { "A challenging hike to the top of the mountain with stunning views.", new DateTime(2025, 7, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "https://www.reserveamerica.com/articles/wp-content/uploads/2024/07/11174967-1e85-45df-8097-ac30b3bb1c34.jpg", "Rocky Mountain Trail", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(589), new DateTime(2025, 7, 15, 6, 0, 0, 0, DateTimeKind.Unspecified), "Mountain Peak Hike" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EndDate", "ImageUrl", "Location", "ModifiedOn_22180022", "StartDate", "Title" },
                values: new object[] { "A scenic walk around the beautiful autumn lake. Perfect for relaxation and exercise.", new DateTime(2025, 10, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://images.stockcake.com/public/c/a/0/ca09354d-17f0-4693-b9d3-fb2d399a07c1_large/autumn-lakeside-walk-stockcake.jpg", "Autumn Lake Park", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(598), new DateTime(2025, 10, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "Autumn Lake Walk" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EndDate", "ImageUrl", "Location", "ModifiedOn_22180022", "StartDate", "Title" },
                values: new object[] { "A festive 5K run through a snowy winter park.", new DateTime(2025, 12, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), "https://cdn.shopify.com/s/files/1/0203/9788/3467/files/Craft_AW22_ADV_SubZ_Wool-LS-Tee_4_1024x1024.jpg?v=1695349527", "Snowy Pines Park", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(605), new DateTime(2025, 12, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), "Winter Wonderland Run" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "EndDate", "ImageUrl", "Location", "ModifiedOn_22180022", "StartDate", "Title" },
                values: new object[] { "Relax and stretch with a peaceful yoga session on the beach.", new DateTime(2025, 6, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), "https://www.townofbethanybeach.com/ImageRepository/Document?documentID=7156", "Golden Sands Beach", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(614), new DateTime(2025, 6, 20, 7, 0, 0, 0, DateTimeKind.Unspecified), "Summer Beach Yoga" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "FitnessEvents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "EndDate", "ImageUrl", "Location", "ModifiedOn_22180022", "StartDate", "Title" },
                values: new object[] { "Diving is the sport of jumping or falling into water from a platform or springboard, often with acrobatics. It is part of the Olympic Games and also enjoyed recreationally as a non-competitive activity.", new DateTime(2025, 9, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), "https://daysym.com/wp-content/uploads/2024/01/dream-about-scuba-diving.jpg", "Blue hole", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(622), new DateTime(2025, 9, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "Diving" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Natalie is a certified yoga instructor with over 10 years of experience. She is passionate about helping others achieve their fitness goals and improve their overall well-being.", "Natalie", "https://horizonweekly.ca/wp-content/uploads/2021/01/Nat-2.jpg", "Asatryan", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(661), "Yoga" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022" },
                values: new object[] { "Warren is a certified personal trainer and fitness coach. He specializes in high-intensity interval training (HIIT) and enjoys helping clients push their limits and reach their full potential.", "Warren", "https://images.squarespace-cdn.com/content/v1/651489d366d19e59b7bbf9cf/a68428a6-992f-45a4-adfc-1b5a75e5cfda/Warren_square500.jpg", "Scott", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(663) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Emily is a certified Zumba instructor with a background in dance and fitness. She loves creating a fun and inclusive environment where everyone can enjoy the benefits of Zumba.", "Emily", "https://d29za44huniau5.cloudfront.net/uploads/2023/11/first-class-mobile.png", "Johnson", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(665), "Zumba" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Olivia is a certified Pilates instructor with a passion for helping individuals improve their core strength and flexibility.", "Olivia", "https://www.clubpilates.com/hubfs/Leah-Pfrommer-Club-Pilates-instructor-exclusive-interview-with-Athletech-News-1.jpg", "Williams", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(666), "Pilates" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022", "Specialization" },
                values: new object[] { "Wolff is a certified strength training coach. He specializes in weightlifting and conditioning, helping clients build muscle and endurance.", "Wolff", "https://jwfitnesssystems.com/wp-content/uploads/2023/02/CW1_7335-scaled.jpg", "Jameson", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(668), "Strength Training" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Bio", "FirstName", "ImageUrl", "LastName", "ModifiedOn_22180022" },
                values: new object[] { "Conor Anthony McGregor is an Irish professional mixed martial artist, professional boxer, businessman and actor.", "Conor", "https://a.espncdn.com/i/headshots/mma/players/full/3022677.png", "McGregor", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(669) });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name" },
                values: new object[] { "A basic membership that grants access to all regular classes and gym facilities.", "https://i0.wp.com/poolstats.co/wp-content/uploads/2019/01/Basic-Membership.png?fit=400%2C327&ssl=1", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(743), "Basic" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name" },
                values: new object[] { "An elite membership offering access to all classes, gym facilities, and spa treatments.", "https://cdn.vectorstock.com/i/500p/49/16/elite-gold-label-vector-2944916.jpg", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(745), "Elite" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name" },
                values: new object[] { "A premium membership offering access to all classes, gym facilities, and spa treatments.", "https://thumbs.dreamstime.com/b/premium-membership-badge-stamp-golden-red-ribbon-text-30827692.jpg", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(747), "Premium" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name" },
                values: new object[] { "An exclusive membership with additional perks including priority booking for events and personal training.", "https://cdn11.bigcommerce.com/s-2ooutu2zpl/images/stencil/original/products/35315/51564/VIP_Badge_2__62906.1641934958.png?c=2", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(749), "VIP" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name" },
                values: new object[] { "A soothing massage to relieve tension and stress.", "https://www.dshieldsusa.com/wp-content/uploads/2021/05/relaxing-massage-slide.jpg", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(779), "Relaxing Massage" });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "ImageUrl", "ModifiedOn_22180022", "Name", "Price" },
                values: new object[] { 1, "A rejuvenating facial to nourish and hydrate your skin.", "https://spamd.net/wp-content/uploads/2022/03/medications-facial-treatments.jpg", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(781), "Facial Treatment", 40.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "ImageUrl", "ModifiedOn_22180022", "Name", "Price" },
                values: new object[] { 2, "A session using essential oils to promote relaxation and well-being.", "https://elementsmassage.com/files/shared/AZ%20-%20Elements%20Massage%205-1864269.jpg", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(783), "Aromatherapy Session", 30.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "ModifiedOn_22180022", "Name", "Price" },
                values: new object[] { "A therapeutic massage using smooth, heated stones to ease tension.", "https://images-prod.healthline.com/hlcmsresource/images/topic_centers/1296x728_HEADER_benefits-of-hot-stone-massage.jpg", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(785), "Hot Stone Massage", 70.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Description", "ImageUrl", "ModifiedOn_22180022", "Name", "Price" },
                values: new object[] { 3, "A massage targeting deeper layers of muscle tissue to release chronic tension.", "https://propelphysiotherapy.com/wp-content/uploads/2023/08/what-is-deep-tissue-massage-therapy-propel-physiotherapy.jpg", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(787), "Deep Tissue Massage", 60.00m });

            migrationBuilder.UpdateData(
                schema: "22180022",
                table: "SpaProcedures",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Description", "ImageUrl", "ModifiedOn_22180022", "Name" },
                values: new object[] { 3, "A detoxifying wrap using nutrient-rich seaweed to revitalize your skin.", "https://s3.amazonaws.com/salonclouds-uploads/blog/blog_1605466361125864114.png", new DateTime(2026, 5, 21, 10, 45, 35, 278, DateTimeKind.Utc).AddTicks(789), "Seaweed Body Wrap" });
        }
    }
}
