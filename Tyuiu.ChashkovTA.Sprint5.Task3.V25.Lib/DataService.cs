using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChashkovTA.Sprint5.Task3.V25.Lib
{
    public class DataService : ISprint5Task3V25
    {
        public string SaveToFileTextData(int x)
        {
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            double result;

            try
            {
                result = (3 * Math.Pow(x, 4) + 1) / (3 * x);
                result = Math.Round(result, 3); 
            }
            catch (DivideByZeroException)
            {
                result = 0; 
            }

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(result);
            }

            Console.WriteLine($"Результат: {result}");

            return filePath;
        }
    }
}
