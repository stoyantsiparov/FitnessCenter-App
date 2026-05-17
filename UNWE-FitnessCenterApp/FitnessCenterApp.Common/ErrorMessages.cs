namespace FitnessCenterApp.Common;

public static class ErrorMessages
{
    public static class General
    {
        public const string UserIdCannotBeEmpty = "Потребителският ID не може да бъде празен.";
    }

    public static class SpaProcedure
    {
        public const string PastAppointmentDate = "Датата и часът на резервацията не могат да бъдат в миналото.";
        public const string SpaAppointmentNotBooked = "Нямате резервирана спа процедура.";
        public const string SpaProcedureNotFound = "Спа процедурата не е намерена.";
        public const string OnlyMembersCanBookSpaProcedures = "Само членове могат да резервират спа процедури.";
        public const string CannotBookMoreThanOneWeekAhead = "Можете да резервирате часове само до 7 дни напред.";
        public const string OutsideWorkingHours = "Часовете трябва да бъдат в рамките на работното време (09:00 - 18:00).";
        public const string AlreadyBookedThisTypeForWeek = "Можете да резервирате този тип процедура само веднъж на 7 дни.";
        public const string OverlappingAppointmentWithBuffer = "Имате друга резервация около този час. Изисква се 30 минути почивка между процедурите.";
        public const string SpaProcedureFullAtThisTime = "Няма свободни места за тази процедура в избрания час.";
    }

    public static class FitnessEvent
    {
        public const string FitnessEventDoesNotExist = "Посоченото събитие не съществува.";
        public const string FitnessEventNotFound = "Фитнес събитието не е намерено.";
        public const string AlreadyRegisteredForEvent = "Вече сте записани за това събитие.";
        public const string UserNotRegisteredForEvent = "Не сте записани за това събитие.";
        public const string EndDateMustBeLaterThanStartDate = "Крайният срок трябва да е след началната дата.";
        public const string StartDateCannotBeInThePast = "Началната дата не може да бъде в миналото.";
        public const string OnlyMembersCanRegisterForThisEvent = "Само членове могат да се записват за фитнес събития.";
        public const string EventFull = "Няма повече свободни места за това събитие.";
    }

    public static class FitnessClass
    {
        public const string FitnessClassDoesNotExist = "Посоченият фитнес клас не съществува.";
        public const string ClassNotFound = "Фитнес класът не е намерен.";
        public const string AlreadyRegisteredForClass = "Вече сте записани за този фитнес клас.";
        public const string UserNotRegisteredForClass = "Не сте записани за този фитнес клас.";
        public const string ClassViewModelCannotBeNull = "Моделът на класа не може да бъде празен.";
        public const string ClassWithTheSameNameAndScheduleAlreadyExists = "Вече съществува фитнес клас със същото име и график.";
        public const string InvalidScheduleFormat = "Невалиден формат на графика.";
        public const string OnlyMembersCanRegisterForThisClass = "Само членове могат да се записват за фитнес класове.";
        public const string ClassNameAndScheduleAreRequired = "Името и графикът са задължителни.";
        public const string ClassFull = "Няма повече свободни места за този фитнес клас.";
    }

    public static class MembershipType
    {
        public const string MembershipTypeDoesNotExist = "Типът абонамент не съществува.";
        public const string MembershipNotFound = "Абонаментът не е намерен.";
        public const string OnlyOneMembershipTypeAllowed = "Можете да имате само един активен абонамент.";
        public const string MembershipNotPurchased = "Нямате закупен абонамент.";
        public const string FailedToAssignMemberRole = "Неуспешно добавяне на роля 'Член'.";
        public const string FailedToRemoveMemberRole = "Неуспешно премахване на роля 'Член'.";
    }

    public static class Instructor
    {
        public const string InstructorNotFound = "Инструкторът не е намерен.";
        public const string InstructorViewModelCannotBeNull = "Моделът на инструктора не може да бъде празен.";
        public const string InvalidInstructorId = "Невалиден идентификатор на инструктор.";
    }

    public static class Roles
    {
        public const string YouAreNotAuthorizedToAdd = "Нямате права да добавяте този елемент.";
        public const string YouAreNotAuthorizedToEdit = "Нямате права да редактирате този елемент.";
        public const string YouAreNotAuthorizedToDelete = "Нямате права да изтриете този елемент.";
    }

    public static class User
    {
        public const string UserIdOrRoleCannotBeEmpty = "Потребителският ID или ролята не могат да бъдат празни.";
        public const string UserDoesNotExist = "Потребителят не съществува.";
        public const string FailedToAssignRole = "Неуспешно задаване на роля. Моля, опитайте отново.";
        public const string FailedToRemoveRole = "Неуспешно премахване на роля. Моля, опитайте отново.";
        public const string FailedToDeleteRole = "Неуспешно изтриване на потребител. Моля, опитайте отново.";
    }

    public static class ConcurrencyControl
    {
        public const string ConcurrencyControlMessage = "Възникна грешка при обработката на заявката. Моля, опитайте по-късно.";
    }
}