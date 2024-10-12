// Основний клас Program
using System;
using System.Collections.Generic;
using System.IO;

namespace Lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Читання даних з файлу INPUT.TXT
            string[] lines = File.ReadAllLines(@"C:\Users\Elijah Soul\Desktop\KNU MATERAL\3курс 1сем\кросплатформа\Lab1\Lab1\INPUT.txt");
            int N = int.Parse(lines[0]); // кількість тестів

            // Проходимо по всіх тестах
            for (int i = 1; i <= N; i++)
            {
                int k = int.Parse(lines[i]); // номер пари для пошуку

                var result = GetLosingPair(k);
                Console.WriteLine($"{result.Item1} {result.Item2}");
            }
        }

        // Метод GetLosingPair
        public static (int, int) GetLosingPair(int index)
        {
            var losingPairs = new List<(int, int)>();

            for (int a = 0; a <= 109; a++)
            {
                for (int b = a; b <= 109; b++)
                {
                    if ((a ^ b) == 0)
                    {
                        losingPairs.Add((a, b));
                    }
                }
            }

            losingPairs.Sort();
            return losingPairs[index];
        }
    }
}
