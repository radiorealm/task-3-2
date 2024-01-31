using System;

namespace inheritance
{
    class Program
    {
        static void Main()
        {
            Parent[] arr = new Parent[3];

            Console.WriteLine("Выберите способ ввода для всех массивов (false, если случайно, true, если вручную)");
            bool entry = bool.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Введите n для одномерного массива:");
            int n1 = int.Parse(Console.ReadLine());
            OneDim onedim = new(n1, entry);

            Console.WriteLine();

            Console.WriteLine("Введите n для двумерного массива:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите m для двумерного массива:");
            int m = int.Parse(Console.ReadLine());
            TwoDim twodim = new(n2, m, entry);
            
            Console.WriteLine();

            Console.WriteLine("Введите n для ступенчатого массива:");
            int n3 = int.Parse(Console.ReadLine());
            JaggedDim jaggeddim = new(n3, entry);

            arr[0] = onedim;
            arr[1] = twodim;
            arr[2] = jaggeddim;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Массив {arr[i].GetType()}:");
                arr[i].Print();
                Console.WriteLine();

                Console.WriteLine($"Его среднее значение: {arr[i].AverageValue()}");
                Console.WriteLine();
            }
        }
    }
}
