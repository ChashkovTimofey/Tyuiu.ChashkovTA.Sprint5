using System.Globalization;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChashkovTA.Sprint5.Task1.V6.Lib
{
    public class DataService : ISprint5Task1V6
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {

                // Используем StringBuilder для формирования строки с результатами
                StringBuilder resultString = new StringBuilder();

                // Используем культуру с запятой в качестве десятичного разделителя
                var cultureInfo = new CultureInfo("ru-RU");

                // Массив для хранения значений x и F(x)
                for (int x = startValue; x <= stopValue; x++)
                {
                    // Вычисляем функцию
                    double result;

                    try
                    {
                        result = Math.Cos(x) + (4 * x) / 2 - Math.Sin(x) * 3 * x;
                        result = Math.Round(result, 2); // Округляем до 2 знаков после запятой
                    }
                    catch (DivideByZeroException)
                    {
                        result = 0; // Если деление на ноль, возвращаем 0
                    }

                    // Добавляем результат в строку, используя нужный формат
                    resultString.Append(result.ToString(cultureInfo));

                    // Добавляем разделитель новой строки, если это не последний элемент
                    if (x < stopValue)
                    {
                        resultString.AppendLine();
                    }
                }

                // Возвращаем строку с результатами
                return resultString.ToString();
            }

    }
}
