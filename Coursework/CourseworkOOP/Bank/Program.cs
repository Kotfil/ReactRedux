using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        // Створюємо потоки зчитування з файлу та запису у файл
        static StreamReader sr;

        // Створюємо два списки LinkedList
        // Список Поточний рахунок
        static LinkedList<Current_account> Current = new LinkedList<Current_account>();

        // Список Депозитний рахунок
        static LinkedList<Deposit_account> Deposit = new LinkedList<Deposit_account>();

        // Змінна, що зберігає вузол зі списку Поточний рахунок
        static LinkedListNode<Current_account> NodeCurrent = null;

        // Змінна, що зберігає вузол зі списку Депозитний рахунок
        static LinkedListNode<Deposit_account> NodeDeposit = null;


        static void Main(string[] args)
        {

            ReadFile();
            Console.WriteLine("command:");
            Console.WriteLine("Registration(1)");
            Console.WriteLine("Expired deposit(2)");
            Console.WriteLine("Find customer by name(3)");
            Console.WriteLine("View customer(4)");
            Console.WriteLine("Refill(5)");
            Console.WriteLine("Withdrawals(6)");
            Console.WriteLine("Clear(7)");
            Console.WriteLine("Finish(8)");


            string command = "";

      

                while (command != "End console")
                {
                    command = Console.ReadLine();

                    switch (command)
                    {
                        case "1":
                            AddClient();
                            Console.WriteLine(" ");
                            break;
                        case "2":
                            DepositOf();
                            Console.WriteLine(" ");
                            break;
                        case "3":
                            WriteFullNameCliente();
                            Console.WriteLine(" ");
                            break;
                        case "4":
                            AccountBalance();
                            Console.WriteLine(" ");
                            break;
                        case "5":
                            TopUp();
                            Console.WriteLine(" ");
                            break;
                        case "6":
                            Withdrawals();
                            Console.WriteLine(" ");
                            break;
                        case "7":
                            Gros1();
                            break;
                        case "8":
                            Environment.Exit(0);
                            break;
                    }
                }
        }

        // Зчитуємо інформацію про студентів з файлу та заповнюємо список
        private static void ReadFile()
        {
            // Запускаємо потік зчитування з файлу
            sr = new StreamReader("Bank1.txt");

            // Зчитуємо рядок з файлу Student.txt
            string line = sr.ReadLine();
            string[] mass;

            // Цикл працює доки sr.ReadLine() не поверне null
            while (line != null)
            {
                // Розділяємо зчитаний рядок на складові по символу ";" за допомогою методу Split()
                mass = line.Split('*');

                // Якщо на початку рядка сказано "current" то данні про студента преба додати до списку Current
                // Якщо на початку рядка сказано "deposit" то данні про студента преба додати до списку Deposit
                if (mass[0] == "current")
                {
                    Current.AddFirst(new Current_account { PIN = int.Parse(mass[1]), FullName = mass[2], Date = int.Parse(mass[3]), Interestrate = double.Parse(mass[4]), Score = int.Parse(mass[5]) });
                }
                else if (mass[0] == "deposit")
                {
                    Deposit.AddFirst(new Deposit_account { PIN = int.Parse(mass[1]), FullName = mass[2], Date = int.Parse(mass[3]), Interestrate = double.Parse(mass[4]), Score = int.Parse(mass[5]) });
                }

                line = sr.ReadLine();
            }
            sr.Close();
        }

        // Додавання до списку
        private static void AddClient()
        {
            try
            {
                string p, fn, dao, ins, s, d;

                Console.Write("\nPin_Code: ");
                p = Console.ReadLine();

                Console.Write("\nFullName: ");
                fn = Console.ReadLine();

                Console.Write("\nDateo: ");
                dao = Console.ReadLine();

                Console.Write("\nInterest Rate: ");
                ins = Console.ReadLine();

                Console.Write("\nScore: ");
                s = Console.ReadLine();

                Console.Write("\nAccount: ");
                d = Console.ReadLine();

                if (d.Trim().ToLower() == "deposit")
                {

                    Deposit.AddFirst(new Deposit_account
                    {
                        PIN = int.Parse(p),
                        FullName = fn,
                        Date = int.Parse(dao),
                        Interestrate = double.Parse(ins),
                        Score = int.Parse(s),

                    });
                    Console.Clear();
                    Gros();
                }
                else if (d.Trim().ToLower() == "current")
                {

                    Current.AddFirst(new Current_account
                    {
                        PIN = int.Parse(p),
                        FullName = fn,
                        Date = int.Parse(dao),
                        Interestrate = double.Parse(ins),
                        Score = int.Parse(s),

                    });
                    Console.Clear();
                    Gros();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("try agein ");
                AddClient();
            }
        }



        private static void WriteFullNameCliente()
        {
            // Вводимо назву групи в змінну groupReadLine
            try
            {
                Console.Write("Введіть прізвище: ");
                string clientReadLine = Console.ReadLine();

                Console.Write("Введіть PIN_CODE: ");
                int disReadLine = int.Parse(Console.ReadLine());

                Console.WriteLine();

                // Формуємо списки клієнтів згідно вказаного имени та пинкода за подомогою Linq

                var sp1 = Current.Where(operation => operation.FullName == clientReadLine && operation.PIN == disReadLine);
                var sp2 = Deposit.Where(operation => operation.FullName == clientReadLine && operation.PIN == disReadLine);

                // Виводимо у консоль інформацію про клієнтів зі сформованих списків
                if (sp1 != null)
                {
                    foreach (Current_account operation in sp1)
                    {
                        Console.WriteLine("FullName: " + operation.FullName + ", Дата Открытия:  " + operation.Date + ", Счёт: " + operation.Score + ", Процент за год: " + operation.Interestrateee());
                    }
                }



                // Виводимо у консоль інформацію про клієнтів зі сформованих списків
                if (sp2 != null)
                {
                    foreach (Deposit_account operation in sp2)
                    {
                        Console.WriteLine("FullName: " + operation.FullName + ", Дата Открытия:  " + operation.Date + ", Счёт: " + operation.Score + ", Процент за год: " + operation.Interestrateee());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }


        private static void DepositOf()
        {
            var sp1 = Deposit.Where(operation => operation.Date > 2015);

            if (sp1 != null)
            {
                foreach (Deposit_account operation in sp1)
                {
                    Console.WriteLine("FullName: " + operation.FullName + ", Дата Открытия:  " + operation.Date + ", Счёт: " + operation.Score + ", Процент за год: " + operation.Interestrateee());
                }
            }
        }

        // баланс людини по прізвищу
        private static void AccountBalance()
        {
            Console.Write("Введіть прізвище: ");
            string clientReadLine = Console.ReadLine();

            Console.WriteLine();


            var sp1 = Current.Where(operation => operation.FullName == clientReadLine);
            var sp2 = Deposit.Where(operation => operation.FullName == clientReadLine);


            if (sp1 != null)
            {
                foreach (Current_account operation in sp1)
                {
                    Console.WriteLine("FullName: " + operation.FullName + ", Счёт: " + operation.Score);
                }
            }


            if (sp2 != null)
            {
                foreach (Deposit_account operation in sp2)
                {
                    Console.WriteLine("FullName: " + operation.FullName + ", Счёт: " + operation.Score);
                }
            }
        }

        private static void TopUp()
        {
            // Вводимо FullName та PIN_CODE
            try
            {
                Console.Write("Введіть прізвище: ");
                string clientReadLine = Console.ReadLine();

                Console.Write("Введіть PIN_CODE: ");
                int disReadLine = int.Parse(Console.ReadLine());

                Console.WriteLine();


                NodeCurrent = Current.First;
                NodeDeposit = Deposit.First;


                while (NodeCurrent != null)
                {
                    if (NodeCurrent.Value.FullName == clientReadLine && NodeCurrent.Value.PIN == disReadLine)
                    {
                        Console.Write("Введите сумму пополнения: ");
                        NodeCurrent.Value.Score += int.Parse(Console.ReadLine());
                    }
                    NodeCurrent = NodeCurrent.Next;
                }


                while (NodeDeposit != null)
                {
                    if (NodeDeposit.Value.FullName == clientReadLine && NodeDeposit.Value.PIN == disReadLine)
                    {
                        Console.Write("Введите сумму пополнения: ");
                        NodeDeposit.Value.Score += int.Parse(Console.ReadLine());
                    }
                    NodeDeposit = NodeDeposit.Next;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        // Зняти гроші
        private static void Withdrawals()
        {

            try
            {
                Console.Write("Введіть прізвище: ");
                string clientReadLine = Console.ReadLine();

                Console.Write("Введіть PIN_CODE: ");
                int disReadLine = int.Parse(Console.ReadLine());

                Console.WriteLine();


                NodeCurrent = Current.First;
                NodeDeposit = Deposit.First;


                while (NodeCurrent != null)
                {
                    if (NodeCurrent.Value.FullName == clientReadLine && NodeCurrent.Value.PIN == disReadLine)
                    {
                        Console.Write("Зняти :");
                        NodeCurrent.Value.Score -= int.Parse(Console.ReadLine());
                    }
                    NodeCurrent = NodeCurrent.Next;
                }


                while (NodeDeposit != null)
                {
                    if (NodeDeposit.Value.FullName == clientReadLine && NodeDeposit.Value.PIN == disReadLine)
                    {
                        Console.Write("Знаяти :");
                        NodeDeposit.Value.Score -= int.Parse(Console.ReadLine());
                    }
                    NodeDeposit = NodeDeposit.Next;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }
        // Метод очищення консолі для методу AddClient
        private static void Gros()
        {
            Console.Clear();
            Console.WriteLine("command:");
            Console.WriteLine("Registration(1)");
            Console.WriteLine("Expired deposit(2)");
            Console.WriteLine("Find customer by name(3)");
            Console.WriteLine("View customer(4)");
            Console.WriteLine("Refill(5)");
            Console.WriteLine("Withdrawals(6)");
            Console.WriteLine("Clear(7)");
            Console.WriteLine("Finish(8)");
            Console.WriteLine("Удачно добавлено!");
        }
        // Метод очищення консолі
        private static void Gros1()
        {
            Console.Clear();
            Console.WriteLine("command:");
            Console.WriteLine("Registration(1)");
            Console.WriteLine("Expired deposit(2)");
            Console.WriteLine("Find customer by name(3)");
            Console.WriteLine("View customer(4)");
            Console.WriteLine("Refill(5)");
            Console.WriteLine("Withdrawals(6)");
            Console.WriteLine("Clear(7)");
            Console.WriteLine("Finish(8)");
        }




    }
}