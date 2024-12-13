using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChashkovTA.Sprint5.Task2.V29.Lib
{
    public class DataService : ISprint5Task2V29
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                StringBuilder resultString = new StringBuilder();

                for (int i = 0; i < matrix.GetLength(0); i++) 
                {
                    for (int j = 0; j < matrix.GetLength(1); j++) 
                    {
                        if (matrix[i, j] % 2 != 0)
                        {
                            matrix[i, j] = 0;
                        }

                        resultString.Append(matrix[i, j]);

                        if (j < matrix.GetLength(1) - 1)
                        {
                            resultString.Append(";");
                        }
                    }

                    resultString.AppendLine();
                }

                writer.Write(resultString.ToString());

                Console.WriteLine(resultString.ToString());
            }

            return filePath;
        }
    }
}
