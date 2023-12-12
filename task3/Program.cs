using System.Text.RegularExpressions;

namespace task_3
{
    class Program
    {
        static void Main()
        {
            //Task_1();
            //Task_2();
            //Task_3();
            //Task_4();

        }

        /// <summary>
        /// Заменить в строке все вхождения 'test' на 'testing'. Удалить из текста все символы, являющиеся цифрами.
        /// </summary>
        private static void Task_1()
        {
            string text = "1 2 3 4 test 5 6 7 test";
            string newText = text.Replace("test", "testing");
            Console.WriteLine($"Current text: {text}");
            Console.WriteLine($"New text: {newText}");
        }

        /// <summary>
        /// Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:Welcome to the TMS lessons.
        /// Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова
        /// </summary>
        private static void Task_2()
        {
            string firstWord = "Welcome";
            string secondWord = "to";
            string thirdWord = "the";
            string fourthWord = "TMS";
            string fifth = "lessons";
            Console.WriteLine('"' + firstWord + '"' + " "
                + '"' + secondWord + '"' + " "
                + '"' + thirdWord + '"' + " "
                + '"' + fourthWord + '"' + " "
                + '"' + fifth + '"');
        }

        /// <summary>
        /// Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        /// Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную, а также всё, что после них во вторую.
        /// Результат вывести в консоль.
        /// </summary>
        private static void Task_3()
        {
            string text = "teamwithsomeofexcersicesabcwanttomakeitbetter.";
            string str = "abc";
            string firstPart = text.Remove(text.IndexOf(str));
            string secondPart = text.Substring(text.IndexOf(str) + str.Length);
            Console.WriteLine($"Current text: {text}");
            Console.WriteLine($"First part: {firstPart}");
            Console.WriteLine($"Second part: {secondPart}");
        }

        /// <summary>
        /// Дана строка: "Плохой день."
        /// Необходимо с помощью метода substring удалить слово "плохой". После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
        /// Заменить последний "!" на "?" и вывести результат на консоль.
        /// </summary>
        private static void Task_4()
        {
            string text = "Плохой день.";
            string word = "Хороший";
            string secondPartOfText = text.Substring(text.IndexOf(word) + word.Length).Trim();
            string firstWord = "Хороший";
            string secondWord = "!!!!!!!!!";
            string newText = secondPartOfText.Insert(0, $"{firstWord} ")
                .Insert(firstWord.Length + 1, $"{secondWord} ")
                .Insert(firstWord.Length + secondWord.Length + secondPartOfText.Length + 2, secondWord);
            string result = $"{newText.Remove(newText.Length - 1)}?";
            Console.WriteLine(result);
        }
    }
}
