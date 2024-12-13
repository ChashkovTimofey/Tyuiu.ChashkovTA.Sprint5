using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChashkovTA.Sprint5.Task3.V25.Lib
{
    public class DataService : ISprint5Task3V25
    {
        public string SaveToFileTextData(int x)
        {
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            // Переменная для хранения результата
            double result;

            try
            {
                // Вычисление выражения: (3 * x^4 + 1) / (3 * x)
                result = (3 * Math.Pow(x, 4) + 1) / (3 * x);
                result = Math.Round(result, 3); // Округление до 3 знаков после запятой
            }
            catch (DivideByZeroException)
            {
                result = 0; // Если деление на 0, результат = 0
            }

            // Сохраняем результат в бинарный файл
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(result);
            }

            // Читаем файл и кодируем содержимое в Base64
            byte[] fileContent = File.ReadAllBytes(filePath);
            string base64String = Convert.ToBase64String(fileContent);

            // Вывод результата на консоль
            Console.WriteLine($"Результат (Base64): {base64String}");

            // Возвращаем строку Base64
            return base64String;
        }
    }
}
