using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChashkovTA.Sprint5.Task0.V23.Lib
{
    public class DataService : ISprint5Task0V23
    {
        public string SaveToFileTextData(int x)
        {
            if (x == 0)
            {
                return "Ошибка: деление на ноль!";
            }

            double result = Math.Pow(1 + x, 3) / Math.Pow(x, 2);

            result = Math.Round(result, 3);

            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            File.WriteAllText(filePath, result.ToString());

            return $"Результат: {result}\nРезультат сохранен в файл: {filePath}";
        }
    }
}
