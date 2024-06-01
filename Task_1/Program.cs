using System.Diagnostics;

namespace Task_1
{
    // Задача. Дан двумерный массив. { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
    // Необходимо отсортировать данные в нем по возрастанию.



    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array =
            {
                { 7, 3, 2, 96 },
                { 4, 9, 6, -25 },
                { 1, -8, 5, 36 }
            };

            var sw = new Stopwatch();

            Console.WriteLine("Первая реализация решения \n");

            // Преобразуем двумерный массив в одномерынй

            sw.Start();
            int[] arrayLong = new int[array.GetLength(0) * array.GetLength(1)];

            int indexCount = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    arrayLong[indexCount] = array[i, j];
                    indexCount++;
                }
            }

            // Выполняем сортировку одномерного массива

            for (int i = 0; i < arrayLong.Length; i++)
            {
                for (int j = i; j < arrayLong.Length; j++)
                {
                    if (arrayLong[j] < arrayLong[i])
                    {
                        int temp = arrayLong[i];
                        arrayLong[i] = arrayLong[j];
                        arrayLong[j] = temp;
                    }
                }

            }

            // Заполняем двумерный массив данными мз одномерного массива


            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = arrayLong[count];
                    count++;
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
            sw.Stop();
            Console.WriteLine($"Время выполнения программы: {sw.ElapsedMilliseconds} мс.");
            Console.ReadLine();
        }
    }
}
