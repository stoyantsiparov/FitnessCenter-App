using FitnessCenterApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessCenterApp.Data.Seeds;

public static class FitnessClassesSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FitnessClass>().HasData(
            new FitnessClass
            {
                Id = 1,
                Name = "Сутрешна Йога",
                InstructorId = 10,
                ScheduleDateTime = DateTime.Parse("2026-07-15T07:00:00"),
                Duration = 60,
                Description = "Спокойна и хармонична йога сесия, идеална за рестарт на деня и подобряване на фокуса. Водена лично от холивудската звезда.",
                Price = 25.00m,
                ImageUrl = "https://images.unsplash.com/photo-1544367567-0f2fcb009e0b?auto=format&fit=crop&w=800&q=80",
                Capacity = 20,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new FitnessClass
            {
                Id = 2,
                Name = "HIIT Предизвикателство",
                InstructorId = 4,
                ScheduleDateTime = DateTime.Parse("2026-07-16T18:00:00"),
                Duration = 45,
                Description = "Интензивна интервална тренировка и спринтове, създадена да изгори максимален брой калории за кратко време.",
                Price = 30.00m,
                ImageUrl = "https://images.unsplash.com/photo-1517836357463-d25dfeac3438?auto=format&fit=crop&w=800&q=80",
                Capacity = 15,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new FitnessClass
            {
                Id = 3,
                Name = "Зумба Танци",
                InstructorId = 9,
                ScheduleDateTime = DateTime.Parse("2026-07-17T10:00:00"),
                Duration = 60,
                Description = "Забавен и енергичен зумба клас, подходящ за всички нива. Танцувайте и отслабвайте в ритъма на 80-те!",
                Price = 20.00m,
                ImageUrl = "https://images.unsplash.com/photo-1522898467493-49726bf28798?auto=format&fit=crop&w=800&q=80",
                Capacity = 25,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new FitnessClass
            {
                Id = 4,
                Name = "Пилатес",
                InstructorId = 6,
                ScheduleDateTime = DateTime.Parse("2026-07-18T08:30:00"),
                Duration = 60,
                Description = "Тренировка за заздравяване на коремните мускули, подобряване на стойката и екстремна гъвкавост.",
                Price = 25.00m,
                ImageUrl = "https://images.unsplash.com/photo-1518310383802-640c2de311b2?auto=format&fit=crop&w=800&q=80",
                Capacity = 15,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new FitnessClass
            {
                Id = 5,
                Name = "Основи на Силовите Тренировки",
                InstructorId = 3,
                ScheduleDateTime = DateTime.Parse("2026-07-19T17:00:00"),
                Duration = 45,
                Description = "Въвеждащ клас в силовите тренировки с акцент върху правилната техника за вдигане на тежести и безопасност.",
                Price = 40.00m,
                ImageUrl = "https://images.unsplash.com/photo-1534438327276-14e5300c3a48?auto=format&fit=crop&w=800&q=80",
                Capacity = 10,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new FitnessClass
            {
                Id = 6,
                Name = "ММА Основи",
                InstructorId = 1,
                ScheduleDateTime = DateTime.Parse("2026-07-20T20:00:00"),
                Duration = 60,
                Description = "Научете основните техники на смесените бойни изкуства в сигурна и мотивираща среда с шампиона на UFC.",
                Price = 50.00m,
                ImageUrl = "https://images.unsplash.com/photo-1555597673-b21d5c935865?auto=format&fit=crop&w=800&q=80",
                Capacity = 12,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new FitnessClass
            {
                Id = 7,
                Name = "Кросфит за Напреднали",
                InstructorId = 7,
                ScheduleDateTime = DateTime.Parse("2026-07-21T18:30:00"),
                Duration = 60,
                Description = "Изключително тежка комплексна тренировка с тежести и кардио. Препоръчва се само за напреднали и психически подготвени!",
                Price = 35.00m,
                ImageUrl = "https://images.unsplash.com/photo-1541534741688-6078c6bfb5c5?auto=format&fit=crop&w=800&q=80",
                Capacity = 15,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new FitnessClass
            {
                Id = 8,
                Name = "Спортно Плуване",
                InstructorId = 2,
                ScheduleDateTime = DateTime.Parse("2026-07-22T09:00:00"),
                Duration = 50,
                Description = "Тренировка в олимпийския басейн, фокусирана върху изчистване на стила и увеличаване на скоростта във водата.",
                Price = 45.00m,
                ImageUrl = "https://m5.netinfo.bg/media/images/30960/30960313/960-600-plovdivskoto-sportno-uchilishte.jpg",
                Capacity = 12,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new FitnessClass
            {
                Id = 9,
                Name = "Бокс за Начинаещи",
                InstructorId = 5,
                ScheduleDateTime = DateTime.Parse("2026-07-23T19:00:00"),
                Duration = 60,
                Description = "Клас, насочен към базови боксови комбинации, движение с крака и кардио издръжливост на ринга.",
                Price = 35.00m,
                ImageUrl = "https://images.unsplash.com/photo-1549719386-74dfcbf7dbed?auto=format&fit=crop&w=800&q=80",
                Capacity = 16,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new FitnessClass
            {
                Id = 10,
                Name = "Маратон",
                InstructorId = 8,
                ScheduleDateTime = DateTime.Parse("2026-07-24T18:00:00"),
                Duration = 45,
                Description = "Интензивно колоездене на закрито с изключително високо темпо. Изгорете до 800 калории за една сесия!",
                Price = 25.00m,
                ImageUrl = "https://sofiamarathon.bg/wp-content/uploads/2026/01/wa-sof-mar_1025_0763-scaled.jpg",
                Capacity = 20,
                ModifiedOn_22180022 = DateTime.UtcNow
            }
        );
    }
}