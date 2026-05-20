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
}