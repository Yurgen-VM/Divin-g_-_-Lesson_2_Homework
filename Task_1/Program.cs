using System.Text;
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
                { 7, 3, 2 },
                { 4, 9, 6 },
                { 1, 8, 5 }
            };

            var sw = new Stopwatch();

            Console.WriteLine("Первая реализация решения. \n");

            // Преобразуем массив в строку

            sw.Start();
            StringBuilder stringArray = new StringBuilder(); 

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    stringArray.Append(array[i, j]);
                }
            }
           
            // Выполняем сортировку однострочного массива символов

            for (int i = 0; i < stringArray.Length; i++)
            {
                for (int j = 0; j < stringArray.Length; j++)
                {
                    if (stringArray[j] > stringArray[i])
                    {
                        char temp = stringArray[i];
                        stringArray[i] = stringArray[j];
                        stringArray[j] = temp;
                    }
                }
            }
           
            // Заполняем двумерный массив новыми данными

            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    string strDigit = stringArray[count].ToString();
                    int Digit = int.Parse(strDigit); 
                    array[i,j] = Digit;
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
