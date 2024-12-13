using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChashkovTA.Sprint5.Task7.V25.Lib
{
    public class DataService : ISprint5Task7V25
    {
        public string LoadDataAndSave(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    Console.WriteLine("Файл не найден.");
                    return "Ошибка: файл не найден";
                }

                string[] lines = File.ReadAllLines(path);
                var resultLines = new System.Collections.Generic.List<string>();
                var englishWordPattern = new Regex(@"\b[a-zA-Z]+\b");

                foreach (var line in lines)
                {
                    var modifiedLine = englishWordPattern.Replace(line, string.Empty);
                    modifiedLine = Regex.Replace(modifiedLine, @"\s+", " ").Trim(); // Убираем лишние пробелы
                    modifiedLine = Regex.Replace(modifiedLine, @"\s([?.!,;])", "$1"); // Убираем пробел перед знаками препинания
                    resultLines.Add(modifiedLine);
                }

                string tempDirectory = Path.GetTempPath();
                string outputFilePath = Path.Combine(tempDirectory, "OutPutDataFileTask7V25.txt");
                File.WriteAllLines(outputFilePath, resultLines);

                Console.WriteLine($"Результат успешно сохранен в файл: {outputFilePath}");
                return outputFilePath;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return "Ошибка при обработке файла";
            }
        }
    }
}
