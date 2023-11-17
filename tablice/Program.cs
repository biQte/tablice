using System.Collections;

namespace tablice
{
    internal class Program
    {
        static void printTable(int[] table)
        {
            Console.Write("[");
            for (int i = 0; i < table.Length; i++)
            {
                Console.Write(table[i]);
                if (i != table.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]\n");
        }

        static void printArrayList(ArrayList array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write(array[i]);
                if (i != array.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]\n");
        }

        static void getAndPrintTenIntegers()
        {
            Console.WriteLine("Podaj dziesięć liczb całkowitych a program je później wypisze");
            int[] table = new int[10];
            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = int.Parse(Console.ReadLine());
            }
            printTable(table);
        }

        static void getTenIntegersAndPrintThemInReverse()
        {
            Console.WriteLine("Podaj dziesięć liczb całkowitych a program je później wypisze w odwrotnej kolejności");
            int[] table = new int[10];
            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = int.Parse(Console.ReadLine());
            }

            int[] reversedTable = new int[10];

            int currentIndex = 0;

            for (int j = table.Length - 1; j >= 0; j--)
            {
                reversedTable[currentIndex] = table[j];
                currentIndex++;
            }
            printTable(reversedTable);
        }

        static void getAndPrintNIntegers()
        {
            Console.Write("Podaj ilość liczb jaką chcesz wpisać z zakresu [1; 30]: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 30)
            {
                Console.WriteLine("Podana liczba nie jest w zakresie [1; 30]");
                return;
            }

            int[] table = new int[n];

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = int.Parse(Console.ReadLine());
            }
            printTable(table);
        }

        static void getnintegersandprintmax()
        {
            Console.Write("Podaj ilość liczb jaką chcesz wpisać z zakresu [1; 30]: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 30)
            {
                Console.WriteLine("Podana liczba nie jest w zakresie [1; 30]");
                return;
            }

            int[] table = new int[n];

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Największa z podanych wartości to: " + table.Max());
        }

        static void getNIntegersAndPrintMin()
        {
            Console.Write("Podaj ilość liczb jaką chcesz wpisać z zakresu [1; 30]: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 30)
            {
                Console.WriteLine("Podana liczba nie jest w zakresie [1; 30]");
                return;
            }

            int[] table = new int[n];

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Najmniejsza z podanych wartości to: " + table.Min());
        }

        static void getNIntegersFindMaxAndCount()
        {
            Console.Write("Podaj ilość liczb jaką chcesz wpisać z zakresu [1; 30]: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 30)
            {
                Console.WriteLine("Podana liczba nie jest w zakresie [1; 30]");
                return;
            }

            int[] table = new int[n];

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = int.Parse(Console.ReadLine());
            }

            int max = table.Max();
            int count = table.Count(i => i == max);

            Console.WriteLine($"Największa z podanych wartości to: {max}, występuje ona {count} razy");
        }

        static void getNIntegersFindMinAndCount()
        {
            Console.Write("Podaj ilość liczb jaką chcesz wpisać z zakresu [1; 30]: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 30)
            {
                Console.WriteLine("Podana liczba nie jest w zakresie [1; 30]");
                return;
            }

            int[] table = new int[n];

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = int.Parse(Console.ReadLine());
            }

            int min = table.Min();
            int count = table.Count(i => i == min);

            Console.WriteLine($"Najmniejsza z podanych wartości to: {min}, występuje ona {count} razy");
        }

        static void getNIntegersFindSecondMax()
        {
            Console.Write("Podaj ilość liczb jaką chcesz wpisać z zakresu [1; 30]: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 30)
            {
                Console.WriteLine("Podana liczba nie jest w zakresie [1; 30]");
                return;
            }

            int[] table = new int[n];

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = int.Parse(Console.ReadLine());
            }

            int max = table.Max();
            int secondMax = table[0];

            for (int j = 0; j < table.Length; j++)
            {
                if(max == secondMax)
                {
                    secondMax = table[j + 1];
                }

                if (table[j] < max && table[j] > secondMax)
                {
                    secondMax = table[j];
                }
            }

            Console.WriteLine($"Druga największa wartość to: {secondMax}");
        }

        static void getNIntegersFindSecondMin()
        {
            Console.Write("Podaj ilość liczb jaką chcesz wpisać z zakresu [1; 30]: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 30)
            {
                Console.WriteLine("Podana liczba nie jest w zakresie [1; 30]");
                return;
            }

            int[] table = new int[n];

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = int.Parse(Console.ReadLine());
            }

            int min = table.Min();
            int secondMin = table[0];

            for (int j = 0; j < table.Length; j++)
            {
                if(secondMin == min)
                {
                    secondMin = table[j + 1];
                }

                if (table[j] > min && table[j] < secondMin)
                {
                    secondMin = table[j];
                }
            }

            Console.WriteLine($"Druga najmniejsza wartość to: {secondMin}");
        }

        static void getNIntegersFindSecondMaxAndCount()
        {
            Console.Write("Podaj ilość liczb jaką chcesz wpisać z zakresu [1; 30]: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 30)
            {
                Console.WriteLine("Podana liczba nie jest w zakresie [1; 30]");
                return;
            }

            int[] table = new int[n];

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = int.Parse(Console.ReadLine());
            }

            int max = table.Max();
            int secondMax = table[0];

            for (int j = 0; j < table.Length; j++)
            {
                if (max == secondMax)
                {
                    secondMax = table[j + 1];
                }

                if (table[j] < max && table[j] > secondMax)
                {
                    secondMax = table[j];
                }
            }

            int count = table.Count(i => i == secondMax);

            Console.WriteLine($"Druga największa wartość to: {secondMax}, występuje ona {count} razy");
        }

        static void getNIntegersFindSecondMinAndCount()
        {
            Console.Write("Podaj ilość liczb jaką chcesz wpisać z zakresu [1; 30]: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 30)
            {
                Console.WriteLine("Podana liczba nie jest w zakresie [1; 30]");
                return;
            }

            int[] table = new int[n];

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = int.Parse(Console.ReadLine());
            }

            int min = table.Min();
            int secondMin = table[0];

            for (int j = 0; j < table.Length; j++)
            {
                if (secondMin == min)
                {
                    secondMin = table[j + 1];
                }

                if (table[j] > min && table[j] < secondMin)
                {
                    secondMin = table[j];
                }
            }

            int count = table.Count(i => i == secondMin);

            Console.WriteLine($"Druga najmniejsza wartość to: {secondMin}, występuje ona {count} razy");
        }

        static void getNumbersAndPowerThem()
        {
            Console.Write("Podaj ilość liczb jaką chcesz wpisać z zakresu [1; 30]: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 30)
            {
                Console.WriteLine("Podana liczba nie jest w zakresie [1; 30]");
                return;
            }

            double[] table = new double[n];

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Podane przez ciebie liczby podniesione do kwadratu: ");

            foreach(double number in table)
            {
                Console.Write(Math.Pow(number, 2) + ", ");
            }
        }

        static void getNumbersAndPowerThemToThird()
        {
            Console.Write("Podaj ilość liczb jaką chcesz wpisać z zakresu [1; 30]: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 30)
            {
                Console.WriteLine("Podana liczba nie jest w zakresie [1; 30]");
                return;
            }

            double[] table = new double[n];

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Podane przez ciebie liczby podniesione do sześcianu: ");

            foreach (double number in table)
            {
                Console.Write(Math.Pow(number, 3) + ", ");
            }
        }

        static void getNumbersAndAddOneToThem()
        {
            Console.Write("Podaj ilość liczb jaką chcesz wpisać z zakresu [1; 30]: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 30)
            {
                Console.WriteLine("Podana liczba nie jest w zakresie [1; 30]");
                return;
            }

            double[] table = new double[n];

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Podane przez ciebie liczby zwiększone o 1: ");

            foreach (double number in table)
            {
                Console.Write((number + 1) + ", ");
            }
        }

        static void getNumbersAndMultiplyThemByTwo()
        {
            Console.Write("Podaj ilość liczb jaką chcesz wpisać z zakresu [1; 30]: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 30)
            {
                Console.WriteLine("Podana liczba nie jest w zakresie [1; 30]");
                return;
            }

            double[] table = new double[n];

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Podane przez ciebie liczby pomnożone przez 2: ");

            foreach (double number in table)
            {
                Console.Write((number * 2) + ", ");
            }
        }

        static void getIntegersAndPrintEven() 
        {
            Console.Write("Podaj ilość liczb jaką chcesz wpisać z zakresu [1; 30]: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 30)
            {
                Console.WriteLine("Podana liczba nie jest w zakresie [1; 30]");
                return;
            }

            int[] table = new int[n];

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = int.Parse(Console.ReadLine());
            }

            ArrayList even = new ArrayList();

            foreach(int number in table)
            {
                if(number % 2 == 0)
                {
                    even.Add(number);
                }
            }

            printArrayList(even);
        }

        static void getIntegersAndPrintUneven()
        {
            Console.Write("Podaj ilość liczb jaką chcesz wpisać z zakresu [1; 30]: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 30)
            {
                Console.WriteLine("Podana liczba nie jest w zakresie [1; 30]");
                return;
            }

            int[] table = new int[n];

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = int.Parse(Console.ReadLine());
            }

            ArrayList uneven = new ArrayList();

            foreach (int number in table)
            {
                if (number % 2 == 1)
                {
                    uneven.Add(number);
                }
            }

            printArrayList(uneven);
        }

        static void getIntegersAndPrintDividableByThree()
        {
            Console.Write("Podaj ilość liczb jaką chcesz wpisać z zakresu [1; 30]: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 30)
            {
                Console.WriteLine("Podana liczba nie jest w zakresie [1; 30]");
                return;
            }

            int[] table = new int[n];

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = int.Parse(Console.ReadLine());
            }

            ArrayList dividable = new ArrayList();

            foreach (int number in table)
            {
                if (number % 3 == 0)
                {
                    dividable.Add(number);
                }
            }

            printArrayList(dividable);
        }

        static void getNumbersAndPrintGreaterOrEqualFourAndLessThanFifteen()
        {
            Console.Write("Podaj ilość liczb jaką chcesz wpisać z zakresu [1; 30]: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 30)
            {
                Console.WriteLine("Podana liczba nie jest w zakresie [1; 30]");
                return;
            }

            double[] table = new double[n];

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                table[i] = double.Parse(Console.ReadLine());
            }

            ArrayList inBetween = new ArrayList();

            foreach(double number in table)
            {
                if(number >= 4 && number < 15)
                {
                    inBetween.Add(number);
                }
            }

            printArrayList(inBetween);
        }



        static void Main(string[] args)
        {
            //getAndPrintTenIntegers();
            Console.WriteLine();
            //getTenIntegersAndPrintThemInReverse();
            Console.WriteLine();
            //getAndPrintNIntegers();
            Console.WriteLine();
            //getNIntegersAndPrintMax();
            Console.WriteLine();
            //getNIntegersAndPrintMin();
            Console.WriteLine();
            //getNIntegersFindMaxAndCount();
            Console.WriteLine();
            //getNIntegersFindMinAndCount();
            Console.WriteLine();
            //getNIntegersFindSecondMax();
            Console.WriteLine();
            //getNIntegersFindSecondMin();
            Console.WriteLine();
            //getNIntegersFindSecondMaxAndCount();
            Console.WriteLine();
            //getNIntegersFindSecondMinAndCount();
            Console.WriteLine();
            //getNumbersAndPowerThem();
            Console.WriteLine();
            //getNumbersAndPowerThemToThird();
            Console.WriteLine();
            //getNumbersAndAddOneToThem();
            Console.WriteLine();
            //getNumbersAndMultiplyThemByTwo();
            Console.WriteLine();
            //getIntegersAndPrintEven();
            Console.WriteLine();
            //getIntegersAndPrintUneven();
            Console.WriteLine();
            //getIntegersAndPrintDividableByThree();
            Console.WriteLine();
            //getNumbersAndPrintGreaterOrEqualFourAndLessThanFifteen(); // 8.4.4
            Console.WriteLine();

        }
    }
}
