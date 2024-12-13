﻿using tyuiu.cources.programming.interfaces.Sprint5;

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

                        // Проверяем, является ли число целым и делится ли на 10
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
    }
}