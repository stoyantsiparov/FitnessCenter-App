using FitnessCenterApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessCenterApp.Data.Seeds;

public static class FitnessEventsSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FitnessEvent>().HasData(
            new FitnessEvent
            {
                Id = 1,
                Title = "Пролетен Градски Маратон",
                Description = "Присъединете се към вълнуващ 10 км маратон през централните улици на града.",
                Location = "Площад Център",
                StartDate = DateTime.Parse("2026-08-12T09:00:00"),
                EndDate = DateTime.Parse("2026-08-12T12:00:00"),
                ImageUrl = "https://novinar.bg/wp-content/uploads/2026/04/maraton1.webp",
                Capacity = 500,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new FitnessEvent
            {
                Id = 2,
                Title = "Планински Поход Витоша",
                Description = "Предизвикателен поход до върха с група от ентусиасти и професионални водачи.",
                Location = "Хижа Алеко",
                StartDate = DateTime.Parse("2026-08-20T06:00:00"),
                EndDate = DateTime.Parse("2026-08-20T15:00:00"),
                ImageUrl = "https://images.unsplash.com/photo-1551632811-561732d1e306?auto=format&fit=crop&w=800&q=80",
                Capacity = 50,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new FitnessEvent
            {
                Id = 3,
                Title = "Есенна Разходка край Езерото",
                Description = "Живописна разходка около езерото. Перфектна възможност за лека кардио активност на чист въздух.",
                Location = "Геопарк 'Искър-Панега'",
                StartDate = DateTime.Parse("2026-10-08T10:00:00"),
                EndDate = DateTime.Parse("2026-10-08T12:00:00"),
                ImageUrl = "https://static.dir.bg/uploads/images/2024/10/25/2817113/1366x768.jpg?_=1729836290",
                Capacity = 100,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new FitnessEvent
            {
                Id = 4,
                Title = "Зимно Благотворително Бягане",
                Description = "Празнично 5 км бягане през снежния парк, средствата от което отиват за благотворителност.",
                Location = "Витоша",
                StartDate = DateTime.Parse("2026-12-15T09:00:00"),
                EndDate = DateTime.Parse("2026-12-15T11:00:00"),
                ImageUrl = "https://360mag.bg/wp-content/uploads/2023/01/Winter_running_myhealth-org.webp",
                Capacity = 200,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new FitnessEvent
            {
                Id = 5,
                Title = "Лятна Йога на Плажа",
                Description = "Отпуснете се с ранна йога сесия под звуците на морските вълни.",
                Location = "Слънчев Бряг",
                StartDate = DateTime.Parse("2026-07-25T07:00:00"),
                EndDate = DateTime.Parse("2026-07-25T09:00:00"),
                ImageUrl = "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?auto=format&fit=crop&w=800&q=80",
                Capacity = 40,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new FitnessEvent
            {
                Id = 6,
                Title = "Курс по Гмуркане",
                Description = "Основи на водолазното гмуркане. Научете се да дишате под вода с професионални инструктори.",
                Location = "Черно море",
                StartDate = DateTime.Parse("2026-09-05T12:00:00"),
                EndDate = DateTime.Parse("2026-09-05T16:00:00"),
                ImageUrl = "https://images.unsplash.com/photo-1544551763-46a013bb70d5?auto=format&fit=crop&w=800&q=80",
                Capacity = 20,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new FitnessEvent
            {
                Id = 7,
                Title = "Турнир по Вдигане на Тежести",
                Description = "Вътрешен клубен турнир по вдигане на тежести. Елате да премерите сили с най-добрите!",
                Location = "Главна Фитнес Зала",
                StartDate = DateTime.Parse("2026-10-20T10:00:00"),
                EndDate = DateTime.Parse("2026-10-20T14:00:00"),
                ImageUrl = "https://images.unsplash.com/photo-1517836357463-d25dfeac3438?auto=format&fit=crop&w=800&q=80",
                Capacity = 50,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new FitnessEvent
            {
                Id = 8,
                Title = "Уикенд Йога Ретрийт",
                Description = "Двудневно бягство от града, изпълнено с медитация, йога и здравословна храна.",
                Location = "Еко Комплекс 'Балкан'",
                StartDate = DateTime.Parse("2026-09-12T08:00:00"),
                EndDate = DateTime.Parse("2026-09-13T18:00:00"),
                ImageUrl = "https://images.unsplash.com/photo-1545205597-3d9d02c29597?auto=format&fit=crop&w=800&q=80",
                Capacity = 30,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new FitnessEvent
            {
                Id = 9,
                Title = "Фитнес Буткемп на Открито",
                Description = "Интензивен фитнес лагер на открито. Комбинация от военна подготовка и кардио.",
                Location = "Борисова Градина",
                StartDate = DateTime.Parse("2026-08-05T08:30:00"),
                EndDate = DateTime.Parse("2026-08-05T12:00:00"),
                ImageUrl = "https://images.unsplash.com/photo-1571019613454-1cb2f99b2d8b?auto=format&fit=crop&w=800&q=80",
                Capacity = 60,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new FitnessEvent
            {
                Id = 10,
                Title = "Мастърклас по Здравословно Хранене",
                Description = "Семинар за изготвяне на хранителен режим, воден от топ диетолози.",
                Location = "Конферентна Зала",
                StartDate = DateTime.Parse("2026-11-10T18:00:00"),
                EndDate = DateTime.Parse("2026-11-10T20:00:00"),
                ImageUrl = "https://images.unsplash.com/photo-1490645935967-10de6ba17061?auto=format&fit=crop&w=800&q=80",
                Capacity = 100,
                ModifiedOn_22180022 = DateTime.UtcNow
            }
        );
    }
}