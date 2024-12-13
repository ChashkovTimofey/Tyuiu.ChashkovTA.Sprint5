using System.Globalization;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChashkovTA.Sprint5.Task1.V6.Lib
{
    public class DataService : ISprint5Task1V6
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            StringBuilder resultString = new StringBuilder();

            var cultureInfo = new CultureInfo("ru-RU");

            for (int x = startValue; x <= stopValue; x++)
            {

                double result;

                try
                {
                    result = Math.Cos(x) + (4 * x) / 2 - Math.Sin(x) * 3 * x;
                    result = Math.Round(result, 2); 
                }
                catch (DivideByZeroException)
                {
                    result = 0; 
                }

                resultString.AppendLine(result.ToString(cultureInfo));
            }

            return resultString.ToString();
        }

    }
}
