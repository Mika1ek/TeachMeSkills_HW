namespace task_1
{
    class Program
    {
        static void Main()
        {
            Calculator();
            PredictNumber();
            Translator();
            EvenNumber();
        }

        /// <summary>
        /// Напишите программу - консольный калькулятор. В терминале предлагается ввести число номер 1 0 пользователь вводит число номер 1. В терминале предлагается ввести допустимую операцию (+, -, *, /) - пользователь вводит операцию
        /// В терминале предлагается ввести число номер 2 - пользователь вводит число номер 2. В терминал выводится результат выбранной операции
        /// ** Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch. В случае использования операции деления, организуйте проверку попытки деления на ноль с выводом соответсвующего сообщения
        /// </summary>
        private static void Calculator()
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToByte(Console.ReadLine());

            Console.Write("Введите допустимую операцию (+, -, *, /): ");
            string operation = Console.ReadLine();

            Console.Write("Введите второе число: ");
            int b = Convert.ToByte(Console.ReadLine());

            int result = 0;

            switch (operation)
            {
                case "+":
                    {
                        result = a + b;
                        break;
                    }
                case "-":
                    {
                        result = a - b;
                        break;
                    }
                case "*":
                    {
                        result = a * b;
                        break;
                    }
                case "/":
                    {
                        if (b == 0)
                        {
                            Console.WriteLine($"На ноль делить нельзя!");
                        }
                        else
                        {
                            result = a / b;
                            Console.WriteLine($"Результат: {result}");
                        }
                        break;
                    }
            }
        }


        /// <summary>
        /// Напишите программу определения, попадает ли указанное пользователем число от -50 до 50 в числовой промежуток [-40 - 10] [-9  0] [1 10][11 40]. Если да, то укажите, в какой именно промежуток. Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение.
        /// </summary>
        private static void PredictNumber()
        {
            Console.Write($"Enter your number from -50 to 50: ");
            int number = Int32.Parse(Console.ReadLine());
            if (number < -50 && number > 50)
            {
                Console.WriteLine($"Incorrect number. Read instruction.");
            }
            else if (number >= -40 && number <= -10)
            {
                Console.WriteLine($"Your number {number} exists in [-40; -10]");
            }
            else if (number >= -9 && number <= 0)
            {
                Console.WriteLine($"Your number {number} exists in [-9; -0]");
            }
            else if (number >= 1 && number <= 10)
            {
                Console.WriteLine($"Your number {number} exists in [1; 10]");
            }
            else if (number >= 11 && number <= 40)
            {
                Console.WriteLine($"Your number {number} exists in [11; 40]");
            }
            else
            {
                Console.WriteLine($"Your number {number} does not exists in any of periods");
            }
        }

        /// <summary>
        /// Напишите программу русско-английский переводчик. Программа знает 10 слов о погоде. Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке. Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет.
        /// </summary>
        private static void Translator()
        {
            Console.WriteLine("Введите слово о погоде на русском языке: ");
            var weather = Convert.ToString(Console.ReadLine());

            switch (weather.ToLower())
            {
                case "погода":
                    Console.WriteLine("weather");
                    break;

                case "холодно":
                    Console.WriteLine("cold");
                    break;

                case "жарко":
                    Console.WriteLine("hot");
                    break;

                case "солнечно":
                    Console.WriteLine("hot");
                    break;

                case "дождливо":
                    Console.WriteLine("rainy");
                    break;

                case "облачно":
                    Console.WriteLine("cloudy");
                    break;

                case "ветрено":
                    Console.WriteLine("windy");
                    break;

                case "снежно":
                    Console.WriteLine("snowy");
                    break;

                case "туманно":
                    Console.WriteLine("foggy");
                    break;

                case "пасмурно":
                    Console.WriteLine("overcast");
                    break;

                default:
                    Console.WriteLine("Такого слова нет в словаре.");
                    break;
            }
            Console.ReadKey();
        }


        /// <summary>
        /// Напишите программу, которая будет выполнять проверку чисел на четность. Предложите два варианта решения поставленной задачи.
        /// </summary>
        private static void EvenNumber()
        {
            Console.Write("Write a number: ");
            int number = Int32.Parse(Console.ReadLine().Trim());

            ///первый вариант
            if (number % 2 == 0)
            {
                Console.WriteLine($"Это {number} четное число");
            }
            else
            {
                Console.WriteLine($"Это {number} нечетное число");
            }

            /// второй вариант
            switch (number % 2 == 0)
            {
                case true:
                    Console.WriteLine($"Это {number} четное число");
                    break;
                default:
                    Console.WriteLine($"Это {number} нечетное число");
                    break;
            }
        }

    }
}

