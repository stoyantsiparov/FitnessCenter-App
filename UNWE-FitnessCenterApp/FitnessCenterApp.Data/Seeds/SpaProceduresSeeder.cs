using FitnessCenterApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessCenterApp.Data.Seeds;

public static class SpaProceduresSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SpaProcedure>().HasData(
            new SpaProcedure
            {
                Id = 1,
                Name = "Релаксиращ Масаж",
                Description = "Успокояващ масаж с бавни и плавни движения за облекчаване на напрежението и стреса.",
                Duration = 60,
                Price = 50.00m,
                ImageUrl = "https://osoba.bg/sites/default/files/2023-01/relax-masaj2.png",
                Capacity = 5,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new SpaProcedure
            {
                Id = 2,
                Name = "Терапия за Лице",
                Description = "Подмладяваща процедура за лице, която подхранва, хидратира и освежава кожата.",
                Duration = 45,
                Price = 45.00m,
                ImageUrl = "https://www.puls.bg/cache/5/f/4/e/f/5f4ef5eae5984d5b0f78d3292fffd48a68d17d73.jpeg",
                Capacity = 2,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new SpaProcedure
            {
                Id = 3,
                Name = "Ароматерапия",
                Description = "Сесия с етерични масла, която стимулира сетивата и насърчава пълното отпускане.",
                Duration = 30,
                Price = 35.00m,
                ImageUrl = "https://www.estespa.bg/wp-content/uploads/2017/08/%D0%BC%D0%B0%D1%81%D0%B0%D0%B6-%D0%B0%D1%80%D0%BE%D0%BC%D0%B0%D1%82%D0%B5%D1%80%D0%B0%D0%BF%D0%B8%D1%8F.jpg",
                Capacity = 3,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new SpaProcedure
            {
                Id = 4,
                Name = "Масаж с Горещи Камъни",
                Description = "Терапевтичен масаж, използващ гладки, нагряти камъни за дълбоко отпускане на мускулите.",
                Duration = 75,
                Price = 75.00m,
                ImageUrl = "https://www.estespa.bg/wp-content/uploads/2020/01/600-2-1200x600.jpg",
                Capacity = 3,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new SpaProcedure
            {
                Id = 5,
                Name = "Дълбокотъканен Масаж",
                Description = "Масаж, насочен към по-дълбоките слоеве на мускулната тъкан за освобождаване на хронично напрежение.",
                Duration = 60,
                Price = 65.00m,
                ImageUrl = "https://studio24.bg/gallery/picture/1/1126/tehnika-pri-dalbokotakanen-masazh-1738515226.jpg",
                Capacity = 4,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new SpaProcedure
            {
                Id = 6,
                Name = "Обвиване с Водорасли",
                Description = "Детоксикираща процедура за тяло с богати на хранителни вещества водорасли за стягане на кожата.",
                Duration = 90,
                Price = 85.00m,
                ImageUrl = "https://www.thefountainspa.com/wp-content/uploads/2025/01/seaweed-wrap-460x320-1.webp",
                Capacity = 2,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new SpaProcedure
            {
                Id = 7,
                Name = "Инфрачервена Сауна",
                Description = "Дълбоко проникваща топлина, която подпомага детоксикацията, отслабването и релаксацията.",
                Duration = 45,
                Price = 25.00m,
                ImageUrl = "https://honuhousehawaii.com/wp-content/uploads/2024/11/Infrared-sauna-.png",
                Capacity = 6,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new SpaProcedure
            {
                Id = 8,
                Name = "Парна Баня с Билкови Екстракти",
                Description = "Пречистваща парна баня, обогатена с лечебни билки за отваряне на порите и дихателните пътища.",
                Duration = 30,
                Price = 20.00m,
                ImageUrl = "https://ruskovets.com/wp-content/uploads/2025/06/parna-banq-polzi-1.jpg",
                Capacity = 8,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new SpaProcedure
            {
                Id = 9,
                Name = "Криотерапия за Възстановяване",
                Description = "Студова терапия, изключително ефективна за бързо възстановяване на мускулите след тежка тренировка.",
                Duration = 15,
                Price = 40.00m,
                ImageUrl = "https://img1.wsimg.com/isteam/ip/267c7f02-971c-448a-ace3-5d2ce5803d75/%D0%9A%D1%80%D0%B8%D0%BE%D1%82%D0%B5%D1%80%D0%B0%D0%BF%D0%B8%D1%8F.jpg",
                Capacity = 1,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new SpaProcedure
            {
                Id = 10,
                Name = "Спортен Масаж с Бамбукови Пръчки",
                Description = "Специализиран енергичен масаж, който използва бамбукови пръчки за дълбок дренаж на тъканите.",
                Duration = 60,
                Price = 60.00m,
                ImageUrl = "https://funstarter.bg/uploads/2024/11/detail-hands-massaging-human-calf-muscle_155003-5895.webp",
                Capacity = 2,
                ModifiedOn_22180022 = DateTime.UtcNow
            }
        );
    }
}