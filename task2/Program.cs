namespace task_2
{
    class Program
    {
        static void Main()
        {
            Task_1();
            Task_2();
            Task_3();
            Task_4();
            Task_7();
        }

        /// <summary>
        /// Создайте массив целых чисел. Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет.  Пусть число для поиска задается с консоли.
        /// </summary>
        private static void Task_1()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            Console.Write("Write a number: ");
            int inputNumber = Int32.Parse(Console.ReadLine().Trim());
            GetResult(numbers, inputNumber);
        }
        private static void GetResult(int[] numbers, int inputNumber)
        {
            if (numbers.Contains(inputNumber))
            {
                Console.WriteLine($"Ваше число {inputNumber} входит в массив");
            }
            else
            {
                Console.WriteLine($"Ваше число {inputNumber} не входит в массив");
            }
        }

        /// <summary>
        /// Создайте массив целых чисел. Удалите все вхождения заданного числа из массива. Пусть число задается с консоли.Если такого числа нет - выведите сообщения об этом. В результате должен быть новый массив без указанного числа.  
        /// </summary>
        private static void Task_2()
        {
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.Write("Задайте число: ");
            int numberToDelete = Int32.Parse(Console.ReadLine().Trim());
            Console.WriteLine($"Новый массив");
            DeleteNumber(numberToDelete, numbers);
        }
        private static void DeleteNumber(int numberToDelete, int[] numbers)
        {
            if (numbers.Contains(numberToDelete))
            {
                int[] newNumbers = numbers.Where(number => number != numberToDelete).ToArray();
                newNumbers.ToList().ForEach(number => Console.Write($"{number} "));
            }
            else
            {
                Console.WriteLine($"Ваше число {numberToDelete} не входит в массив");
            }
        }

        /// <summary>
        /// Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение. Для генерации случайного числа используйте метод Random() .  Пусть будет возможность создавать массив произвольного размера.Пусть размер массива вводится с консоли.
        /// </summary>
        private static void Task_3()
        {
            Console.Write("Напишите размер массива: ");
            int length = Int32.Parse(Console.ReadLine().Trim());
            int[] arrayNumbers = GetRandomArray(length);
            Console.WriteLine($"Максимальное число из массива - {arrayNumbers.Max()}");
            Console.WriteLine($"Минимальное число из массива - {arrayNumbers.Min()}");
            Console.WriteLine($"Среднее число из массива - {arrayNumbers.Average()}");
        }
        private static int[] GetRandomArray(int length)
        {
            int[] numbers = new int[length];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next();
            }

            return numbers;
        }

        /// <summary>
        /// Создайте 2 массива из 5 чисел. Выведите массивы на консоль в двух отдельных строках. Посчитайте среднее арифметическое элементов каждого массива и сообщите, для какого из массивов это значение оказалось больше (либо сообщите, что их средние арифметические равны).  
        /// </summary>
        private static void Task_4()
        {
            int[] firstArray = new int[] { 1, 2, 3, 4, 5 };
            Random random = new Random();
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = random.Next();
            }

            int[] secondArray = new int[] { 6, 7, 8, 9, 10 };
            random = new Random();
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = random.Next();
            }
            Console.WriteLine($"Первый массив: ");
            foreach (int i in firstArray)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine($"Второй массив: ");

            foreach (int i in secondArray)
            {
                Console.Write($"{i}");
            }

            double averagefirstarray = firstArray.Average();
            double averagesecondarray = secondArray.Average();

            if (averagefirstarray > averagesecondarray)
            {
                Console.WriteLine($"Среднее арифметическое значение первого массива ({averagefirstarray}) больше.");
            }
            else if (averagesecondarray > averagefirstarray)
            {
                Console.WriteLine($"Среднее арифметическое значение второго массива ({averagesecondarray}) больше.");
            }
            else
            {
                Console.WriteLine("Средние арифметические значение массивов равны");
            }

            Console.ReadLine();
        }



        /// <summary>
        /// Создайте массив строк. Заполните его произвольными именами людей. Отсортируйте массив. Результат выведите на консоль.
        /// </summary>
        private static void Task_7()
        {
            string[] names = new string[] { "Tom", "Nina", "Bob", "Eliza", "James", "Lili", "Benedict", "Luchiya" };
            Array.Sort(names);
            names.ToList().ForEach(name => Console.Write($"{name} "));
        }
    }
}
