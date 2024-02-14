namespace CreditCard
{
    /// <summary>
    /// Создать класс CreditCard c полями:номер счета, текущая сумма на счету.
    /// Добавьте методы: который позволяет зачислять сумму на кредитную карту, который позволяет снимать некоторую сумму с карты,
    /// который выводит текущую информацию о карточке.
    /// Напишите программу, которая создает три объекта класса CreditCard у которых заданы номер счета и начальная сумма.
    /// Тестовый сценарий для проверки:
    /// Положите деньги на первые две карточки и снимите с третьей.
    /// Выведите на экран текущее состояние всех трех карточек.
    /// </summary>

    using System;

    class CreditCard
    {
        private string accountNumber;
        private double currentBalance;

        public CreditCard(string accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.currentBalance = initialBalance;
        }

        public void Deposit(double amount)
        {
            currentBalance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= currentBalance)
            {
                currentBalance -= amount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете.");
            }
        }

        public void GetCardInfo()
        {
            Console.WriteLine("Номер счета: " + accountNumber);
            Console.WriteLine("Текущая сумма на счету: " + currentBalance);
        }
    }

    class Program
    {
        private static void Main(string[] args)
        {
            // Создание трех объектов класса CreditCard
            CreditCard card1 = new CreditCard("1234 5678 9012 3456", 1000);
            CreditCard card2 = new CreditCard("9876 5432 1098 7654", 2000);
            CreditCard card3 = new CreditCard("1111 2222 3333 4444", 500);

            // Пополнение первых двух карточек
            card1.Deposit(500);
            card2.Deposit(1000);

            // Снятие суммы с третьей карточки
            card3.Withdraw(200);

            // Вывод информации о всех карточках
            card1.GetCardInfo();
            card2.GetCardInfo();
            card3.GetCardInfo();

            Console.ReadLine();
        }
    }
}