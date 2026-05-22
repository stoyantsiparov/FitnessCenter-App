using FitnessCenterApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessCenterApp.Data.Seeds;

public static class MembershipTypeSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MembershipType>().HasData(
            new MembershipType
            {
                Id = 1,
                Name = "Основен план",
                Price = 59.99m,
                Duration = 30,
                ImageUrl = "/img/membership/Basic.png",
                Description = "Стандартен месечен абонамент. Включва неограничен достъп до фитнес залата и всички групови класове. Този план не включва право на записване за СПА процедури.",
                AllowedSpaProceduresPerWeek = 0,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new MembershipType
            {
                Id = 2,
                Name = "Елитен план",
                Price = 99.99m,
                Duration = 60,
                ImageUrl = "/img/membership/Elite.png",
                Description = "Двумесечен абонамент за активни трениращи. Включва пълен достъп до фитнес залата, всички класове и право на 1 резервация за СПА процедура на седмица.",
                AllowedSpaProceduresPerWeek = 1,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new MembershipType
            {
                Id = 3,
                Name = "Премиум план",
                Price = 299.99m,
                Duration = 180,
                ImageUrl = "/img/membership/Premium.png",
                Description = "Шестмесечен абонамент с висока добавена стойност. Гарантира достъп до всички съоръжения и ви дава право на до 5 резервации за СПА процедури на седмица.",
                AllowedSpaProceduresPerWeek = 5,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new MembershipType
            {
                Id = 4,
                Name = "ВИП план",
                Price = 499.99m,
                Duration = 365,
                ImageUrl = "/img/membership/Vip.png",
                Description = "Ексклузивен годишен абонамент за най-отдадените. Включва пълен достъп до фитнес залата, всички класове и най-високия възможен седмичен лимит за резервация на СПА процедури.",
                AllowedSpaProceduresPerWeek = 99,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new MembershipType
            {
                Id = 5,
                Name = "Студентски план",
                Price = 39.99m,
                Duration = 30,
                ImageUrl = "/img/membership/UNWE.png",
                Description = "Специално предложение за студенти на УНСС. Осигурява пълен достъп до фитнес залата и всички тренировъчни класове. Планът не включва право на резервации за СПА процедури.",
                AllowedSpaProceduresPerWeek = 0,
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new MembershipType
            {
                Id = 6,
                Name = "Дневен план",
                Price = 45.99m,
                Duration = 30,
                ImageUrl = "/img/membership/Daytime.png",
                Description = "Месечен абонамент с достъп до фитнес залата всеки ден, валиден за посещения в часовия интервал от 08:00 до 16:00 ч. Планът не включва право на резервации за СПА процедури.",
                AllowedSpaProceduresPerWeek = 0,
                ModifiedOn_22180022 = DateTime.UtcNow
            }
        );
    }
}