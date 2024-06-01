using System.Diagnostics;

namespace Task_1_var_2
{
    internal class Program
    {

        // Задача. Дан двумерный массив. { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        // Необходимо отсортировать данные в нем по возрастанию.

        static void Main(string[] args)
        {
            int[,] array =
       {
                { 7, 3, 2 },
                { 4, 9, 6 },
                { 1, 8, 5 }
            };
            
            var sw = new Stopwatch();

            sw.Start();

            // Проходимся по массиву циклами, выполняя проверку на min для каждого элемента массива.
           
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int IndexRow = i;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int IndexColumn = j;
                    for (int k = IndexRow;  k < array.GetLength(0);k++)
                    {
                        for (int l = IndexColumn; l < array.GetLength(1); l++)
                        {
                            if (array[k,l] < array[i,j])
                            {
                                int temp = array[i,j];
                                array[i, j] = array[k, l];
                                array[k, l] = temp;
                            }
                        }
                        IndexColumn = 0;
                    }
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
