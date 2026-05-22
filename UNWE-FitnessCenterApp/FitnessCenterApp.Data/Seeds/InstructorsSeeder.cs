using FitnessCenterApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessCenterApp.Data.Seeds;

public static class InstructorsSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Instructor>().HasData(
            new Instructor
            {
                Id = 1,
                FirstName = "Конър",
                LastName = "Макгрегър",
                Bio = "Ирландски професионален ММА боец и бивш двоен шампион на UFC. Тренировките с Конър ще ви научат на безкомпромисна дисциплина, експлозивна сила и елитни бойни техники.",
                Specialization = "ММА",
                ImageUrl = "https://dsport.bg/media/234/gettyimages-1399254105~2.l.webp",
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new Instructor
            {
                Id = 2,
                FirstName = "Майкъл",
                LastName = "Фелпс",
                Bio = "Най-успешният олимпиец на всички времена с 28 медала. В неговите класове ще изградите техника, бързина и издръжливост във водата, напълно достойни за шампиони.",
                Specialization = "Спортно плуване",
                ImageUrl = "https://lira.bg/wp-content/uploads/2016/08/michaelphelps.jpg",
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new Instructor
            {
                Id = 3,
                FirstName = "Арнолд",
                LastName = "Шварценегер",
                Bio = "Живата легенда в бодибилдинга и 7-кратен Мистър Олимпия. Арнолд ще ви покаже как да изградите перфектната физика с правилна техника и \"желязна\" воля.",
                Specialization = "Силови тренировки",
                ImageUrl = "https://www.flashnews.bg/wp-content/uploads/2018/07/DIY-frame-Arnold-Schwarzenegger-Terminator-Great-Muscle-Poster-Bodybuilding-Gym-Decor.jpg_640x640.jpg",
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new Instructor
            {
                Id = 4,
                FirstName = "Юсейн",
                LastName = "Болт",
                Bio = "Най-бързият човек на планетата. Неговите високоинтензивни тренировки и спринтове ще ви помогнат да развиете експлозивна скорост и ненадминато кардио.",
                Specialization = "HIIT / Спринт",
                ImageUrl = "https://bntnews.bg/f/news/b/1279/77b161de7a82fb079a287346551c5c74.jpg",
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new Instructor
            {
                Id = 5,
                FirstName = "Майк",
                LastName = "Тайсън",
                Bio = "\"Железният\" Майк е един от най-великите боксьори в тежка категория за всички времена. Тренировките с него изискват пълно раздаване, 100% фокус и сурова сила.",
                Specialization = "Бокс",
                ImageUrl = "https://s0.rbk.ru/v6_top_pics/media/img/9/24/347098230779249.jpeg",
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new Instructor
            {
                Id = 6,
                FirstName = "Жан-Клод",
                LastName = "Ван Дам",
                Bio = "Майстор на бойните изкуства и кино звезда, световноизвестен със своята невероятна гъвкавост. Ще ви помогне да изградите силно ядро, перфектен баланс и контрол над тялото.",
                Specialization = "Гъвкавост / Пилатес",
                ImageUrl = "https://www.menslife.com/upload/iblock/51b/orig.jpg",
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new Instructor
            {
                Id = 7,
                FirstName = "Дейвид",
                LastName = "Гогинс",
                Bio = "Бивш \"Тюлен\" (Navy SEAL) и ултрамаратонец. Гогинс няма да ви позволи да се откажете. Готови ли сте да надскочите границите на човешките си възможности?",
                Specialization = "Кросфит / Издръжливост",
                ImageUrl = "https://knigomania.bg/media/attributesplash/david-goggins-portait.jpg",
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new Instructor
            {
                Id = 8,
                FirstName = "Ланс",
                LastName = "Армстронг",
                Bio = "Световноизвестен колоездач, който отлично знае какво означава да въртиш педалите до край. Подгответе се за най-тежките и мотивиращи спининг маратони в живота си.",
                Specialization = "Спининг / Колоездене",
                ImageUrl = "https://radiofresh.bg/uploads/images/51085959.jpg",
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new Instructor
            {
                Id = 9,
                FirstName = "Джейн",
                LastName = "Фонда",
                Bio = "Иконата на фитнес революцията. Нейната заразителна енергия и чувство за ритъм ще превърнат всяка кардио и зумба тренировка в истинско забавление.",
                Specialization = "Зумба / Аеробика",
                ImageUrl = "https://trud.bg/storage/media/2021-02/1111396/32fonda_2266406737285834814_original.jpg",
                ModifiedOn_22180022 = DateTime.UtcNow
            },
            new Instructor
            {
                Id = 10,
                FirstName = "Дженифър",
                LastName = "Анистън",
                Bio = "Освен холивудска звезда, тя е отдаден практик на йога от десетилетия. Нейните сесии ще ви донесат нужното спокойствие, гъвкавост и дълбок вътрешен мир.",
                Specialization = "Йога",
                ImageUrl = "https://eva.bg/media/cache/article_photo_above_text/media/ZVEZDI/Novini/hijklmno/J-Aniston/2023/jen5cecac1f3.jpg",
                ModifiedOn_22180022 = DateTime.UtcNow
            }
        );
    }
}