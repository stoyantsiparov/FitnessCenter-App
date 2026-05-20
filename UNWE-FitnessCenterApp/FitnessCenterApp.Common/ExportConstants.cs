namespace FitnessCenterApp.Common;

public static class ExportConstants
{
    public const string CsvContentType = "text/csv";

    public static class FitnessClass
    {
        public const string ExportFileName = "FitnessClasses_Export.csv";
        public const string ExportHeader = "Име на клас,График,Продължителност (мин),Капацитет (места),Записани участници";
    }

    public static class FitnessEvent
    {
        public const string ExportFileName = "FitnessEvents_Export.csv";
        public const string ExportHeader = "Заглавие,Локация,Начало,Край,Капацитет (места),Записани участници";
    }

    public static class SpaProcedure
    {
        public const string ExportFileName = "SpaProcedures_Export.csv";
        public const string ExportHeader = "Име на процедура,Капацитет (места),Записани участници";
    }

    public static class Reports
    {
        public const string ClassesReportFileName = "Classes_Period_Report.csv";
        public const string ClassesReportHeader = "Име на клас,Дата и час,Капацитет,Записани,Генериран приход";

        public const string EventsReportFileName = "Events_Period_Report.csv";
        public const string EventsReportHeader = "Заглавие,Начало,Капацитет,Записани";

        public const string SpaReportFileName = "Spa_Period_Report.csv";
        public const string SpaReportHeader = "Процедура,Капацитет,Общ брой резервации,Генериран приход";
    }
}