using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChashkovTA.Sprint5.Task0.V23.Lib
{
    public class DataService : ISprint5Task0V23
    {
        public string SaveToFileTextData(int x)
        {
            double result = (1 + Math.Pow(x, 3)) / x;

            result = Math.Round(result, 3);

            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            File.WriteAllText(filePath, result.ToString());

            return $"Результат: {result}\nРезультат сохранен в файл: {filePath}";
        }
    }
}
