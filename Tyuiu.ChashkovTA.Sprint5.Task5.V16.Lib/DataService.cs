using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChashkovTA.Sprint5.Task5.V16.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {
            double maxDivisibleByTen = double.MinValue;

            try
            {
                // Читаем все строки из файла
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    // Пробуем преобразовать строку в число
                    if (double.TryParse(line, out double number))
                    {
                        // Округляем вещественные значения до 3 знаков после запятой
                        number = Math.Round(number, 3);

                        // Проверяем, является ли число делится на 10
                        if (number % 10 == 0 && number > maxDivisibleByTen)
                        {
                            maxDivisibleByTen = number;
                        }
                    }
                }

                // Если не найдено подходящее число, возвращаем 0
                if (maxDivisibleByTen == double.MinValue)
                {
                    maxDivisibleByTen = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
                return 0;
            }

            // Возвращаем максимальное число, которое делится на 10
            return maxDivisibleByTen;
        }

        public static void Main()
        {
            // Создаём объект класса
            DataService finder = new DataService();

            // Указываем путь к файлу
            string path = Path.Combine("C:\\DataSprint5", "InPutDataFileTask5V16.txt");

            // Вызываем метод для поиска результата
            double result = finder.LoadFromDataFile(path);

            // Выводим результат на консоль
            Console.WriteLine($"Максимальное число, делящееся на 10: {result}");
        }
    }
}
