using System;

namespace inheritance
{
    sealed class JaggedDim : Parent
    {
        private OneDim[] array;

        public JaggedDim(int n, bool entry = false) : base(entry)
        {
            array = new OneDim[n];

            if (!entry)
            {
                RndEntry();
            }
            else
            {
                UserEntry();
            }
        }

        public override void RndEntry()
        {
            OneDim massive;

            for (int i = 0; i < array.Length; i++)
            {
                massive = new OneDim(rnd.Next(1, 10));
                array[i] = massive;
            }

        }
        public override void UserEntry()
        {
            OneDim massive;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите m для массива {i + 1}");

                massive = new OneDim(int.Parse(Console.ReadLine()), true);
                array[i] = massive;
            }
        }

        public override void Print()
        {
            foreach (OneDim massive in array)
            {
                massive.Print();
            }
        }

        public override double AverageValue()
        {
            int num = 0;
            double summa = 0;

            foreach (OneDim el in array)
            {
                for (int j = 0; j < el.Length; j++)
                {
                    summa += el[j];
                    num++;
                }
            }

            return (summa / num);
        }

        public void AverageValueMassives()
        {
            foreach (OneDim el in array)
            {
                Console.WriteLine($"Среднее значение массива в массиве: {el.AverageValue()}");
            }
        }
    }

}