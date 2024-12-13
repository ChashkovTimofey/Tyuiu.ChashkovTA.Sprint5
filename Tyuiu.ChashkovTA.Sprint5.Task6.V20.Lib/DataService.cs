using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChashkovTA.Sprint5.Task6.V20.Lib
{
    public class DataService : ISprint5Task6V20
    {
        public int LoadFromDataFile(string path)
        {
            try
            {
                // Проверка существования файла
                if (!File.Exists(path))
                {
                    Console.WriteLine("Файл не найден.");
                    return 0;
                }

                // Чтение всех строк из файла
                string[] lines = File.ReadAllLines(path);

                // Переменная для подсчета количества слов длиной 6 символов
                int wordCount = 0;

                // Процесс обработки каждой строки
                foreach (var line in lines)
                {
                    // Разделение строки на слова
                    var words = line.Split(new[] { ' ', '\t', '.', ',', ';', ':', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                    // Подсчет слов длиной 6 символов
                    wordCount += words.Count(word => word.Length == 6);
                }

                return wordCount;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return 0;
            }
        }
    }
}
