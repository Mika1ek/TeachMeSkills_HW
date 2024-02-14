namespace phone
{
    /// <summary>
    /// Создайте класс Phone, который содержит переменные number, model и weight. 
    /// Добавить конструкторы в класс Phone: 1.конструктор без параметров.
    /// 2.принимает на вход два параметра для инициализации переменных класса - number, model. 
    /// 3.принимает на вход три параметра для инициализации всех переменных класса Phone. Вызвать из этого конструктора конструктор с двумя параметрами.
    /// Добавить в класс Phone методы: 1.receiveCall, с одним параметром “имя звонящего”. Этот метод выводит на консоль сообщение “Звонит {name}”
    /// 2.getNumber Этот метод возвращает номер телефона.
    /// 3.sendMessage с аргументами переменной длины.Этот метод принимает на вход номера телефонов, которым будет отправлено сообщение. Метод выводит на консоль номера этих телефонов
    /// Создайте три экземпляра этого класса используя разные конструкторы.
    /// Выведите на консоль значения их переменных.Вызвать методы receiveCall и getNumber для каждого из объектов.
    /// Вызвать метод sendMessage с 2-мя и 5-ю номерами телефонов.
    /// </summary>

    using System;
    namespace PhoneClass
    {
        class Phone
        {
            private string number;
            private string model;
            public double weight;

            public Phone()
            {
                number = "unknown";
                model = "unknown";
                weight = 0.0;
            }

            public Phone(string number, string model)
            {
                this.number = number;
                this.model = model;
                weight = 1.0;
            }


            // Вызов конструктора с двумя параметрами
            public Phone(string number, string model, double weight) : this(number, model)
            {
                this.weight = weight;
            }


            public void ReceiveCall(string name)
            {
                Console.WriteLine($"Звонит {name}");
            }

            public string GetNumber()
            {
                return number;
            }

            public void SendMessage(params string[] phoneNumbers)
            {
                foreach (var number in phoneNumbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Phone firstPhone = new Phone();
                Phone secondPhone = new Phone("+79001234567", "Apple iPhone");
                Phone thirdPhone = new Phone("+79864562032", "Samsung Galaxy Note", 2.5);

                firstPhone.ReceiveCall("Kate");
                secondPhone.ReceiveCall("John");
                thirdPhone.ReceiveCall("Tom");

                Console.WriteLine($"{firstPhone.GetNumber()} {secondPhone.GetNumber()} {thirdPhone.GetNumber()}");

                thirdPhone.SendMessage("+7123456789", "+7912345678", "+781234567");
            }
        }
    }
}