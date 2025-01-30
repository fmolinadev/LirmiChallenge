using MudBlazor;
using LirmiChallenge.Client.Models;

namespace LirmiChallenge.Client.Utilities
{
    public static class ChartSeriesFactory
    {
        public static List<ChartSeries> GetStudentStatusSeries() =>
            new List<ChartSeries>
            {
                new ChartSeries { Name = "Regulares", Data = Array.ConvertAll(new[] { 40, 20, 25, 27, 46, 60, 48, 60, 15, 20 }, x => (double)x) },
                new ChartSeries { Name = "Libres", Data = Array.ConvertAll(new[] { 1, 3, 0, 0, 1, 0, 4, 0, 1, 0 }, x => (double)x) },
                new ChartSeries { Name = "Traslado", Data = Array.ConvertAll(new[] { 0, 0, 0, 0, 0, 2, 0, 1, 0, 0 }, x => (double)x) },
                new ChartSeries { Name = "Deserción", Data = Array.ConvertAll(new[] { 4, 6, 2, 5, 4, 2, 3, 8, 1, 0 }, x => (double)x) },
                new ChartSeries { Name = "Expulsión", Data = Array.ConvertAll(new[] { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 }, x => (double)x) }
            };

        public static List<ChartSeries> GetAverageExamSeries()
        {
            double[] examData1 = { 65, 68, 70, 74, 74, 72, 44, 45, 78, 77 };
            double[] examData2 = { 88, 90, 91, 92, 91, 90, 90, 78, 54, 67 };
            double[] examData3 = { 89, 91, 72, 62, 92, 92, 61, 76, 98, 44 };
            double[] examData4 = { 85, 86, 90, 90, 92, 99, 10, 65, 78, 54 };
            double[] examData5 = { 45, 36, 45, 70, 52, 79, 14, 67, 54, 78 };

            return new List<ChartSeries>
            {
                new ChartSeries { Name = "Primaria 1", Data = examData1 },
                new ChartSeries { Name = "Primaria 2", Data = examData2 },
                new ChartSeries { Name = "Primaria 3", Data = examData3 },
                new ChartSeries { Name = "Primaria 4", Data = examData4 },
                new ChartSeries { Name = "Primaria 5", Data = examData5 }
            };
        }
    }
}
