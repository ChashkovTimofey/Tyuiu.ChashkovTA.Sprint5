using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChashkovTA.Sprint5.Task4.V27.Lib
{
    public class DataService : ISprint5Task4V27
    {
        public double LoadFromDataFile(string path)
        {
            double result = 0;

            try
            {
                // Читаем значение X из файла
                string fileContent = File.ReadAllText(path);
                double x = double.Parse(fileContent);

                // Вычисляем значение по формуле: y = (x^3 - 4x) / cos(x)
                result = (Math.Pow(x, 3) - 4 * x) / Math.Cos(x);

                // Округляем результат до трёх знаков после запятой
                result = Math.Round(result, 3);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Деление на ноль.");
                result = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            // Возвращаем результат
            return result;
        }
    }
}
