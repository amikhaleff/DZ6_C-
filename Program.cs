internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите номер порядковый номер задачи ");
        int Task = int.Parse(Console.ReadLine() ?? "0");

        if (Task == 1) ZADACHA_41();
        else if (Task == 2) ZADACHA_43();
        else Console.WriteLine("Такой задачи нет в списке");


        void ZADACHA_41()//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 

        {
            Console.Clear();

            string ReadData(string msg)// получение данных пользователя
            {
                Console.Write(msg);
                string number = Console.ReadLine() ?? "0";
                return number;
            }

            int CountPositiveNumbers(int[] array)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0) count++;
                }
                return count;

            }

            void Print1DArray(int[] array) //вывод данных в консоль
            {
                Console.Write("[");
                for (int i = 0; i < array.Length - 1; i++)
                {
                    Console.Write(array[i] + ", ");
                }
                Console.WriteLine(array[array.Length - 1] + "]");

            }

            string numbers = ReadData("Введите M целых чисел через запятую: ");
            int[] array = Array.ConvertAll(numbers.Split(',', StringSplitOptions.RemoveEmptyEntries), int.Parse);
            Print1DArray(array);
            Console.WriteLine($" Количество чисел больше нуля : {CountPositiveNumbers(array)}");

        }


        void ZADACHA_43() //Напишите программу, которая найдёт точку пересечения двух прямых,
                          //  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
                          // значения b1, k1, b2 и k2 задаются пользователем

        {
            Console.Clear();

            double ReadData(string msg)
            {
                Console.Write(msg);
                int number = int.Parse(Console.ReadLine() ?? "0");
                return number;
            }


            double b1 = ReadData("Введите значение b1: ");
            double k1 = ReadData("Введите значение k1: ");
            double b2 = ReadData("Введите значение b2: ");
            double k2 = ReadData("Введите значение k2: ");
            if (k1 == k2 && b1 == b2) Console.WriteLine(" Прямые совпадают");
            else if (k1 == k2 && b1 != b2) Console.WriteLine(" Прямые параллельные");
            else
            {
                double x = (b1 - b2) / (k2 - k1);
                double y = (k2 * b1 - k1 * b2) / (k2 - k1);
                Console.WriteLine($" Точка пересечения (x={Math.Round(x, 1)} ; y={Math.Round(y, 1)})");
            }

        }
    }
}