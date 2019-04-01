using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BankForms
{
    public partial class Form1 : Form
    {



        StreamReader sr;

        // Створюємо два списки LinkedList
        // Список студентів коледжу
        LinkedList<Current_account> Current = new LinkedList<Current_account>();

        // Список студентів університету
        LinkedList<Deposit_account> Deposit = new LinkedList<Deposit_account>();

        // Змінна, що зберігає вузол зі списку студентів коледжу
        LinkedListNode<Current_account> NodeCurrent = null;

        // Змінна, що зберігає вузол зі списку студентів університету 
        LinkedListNode<Deposit_account> NodeDeposit = null;

        public Form1()
        {
            InitializeComponent();
            ReadFile();
        }


        private void ReadFile()
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

                // Якщо на початку рядка сказано "с" то данні про студента преба додати до списку studColl
                // Якщо на початку рядка сказано "u" то данні про студента преба додати до списку studUni
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

        // Відкриває вікно AddClient

        private void button1_Click(object sender, EventArgs e)
        {
            AddClient myForm2 = new AddClient();

            AddClient();
        }

       // Метод додавання клієнта в LinkedList
        private void AddClient()
        {
            AddClient myform2 = new AddClient();
            myform2.ShowDialog();
            if (myform2.Account == "current")

            {

                Deposit.AddFirst(new Deposit_account
                {
                    PIN = myform2.PIN_CODE,
                    FullName = myform2.FullName,
                    Date = myform2.Date,
                    Interestrate = myform2.InterestRate,
                    Score = myform2.Score,

                });
            }

            else if (myform2.Account == "deposit")
            {
                Current.AddFirst(new Current_account
                {
                    PIN = myform2.PIN_CODE,
                    FullName = myform2.FullName,
                    Date = myform2.Date,
                    Interestrate = myform2.InterestRate,
                    Score = myform2.Score,
                });
            }
        }

        //Метод додавання клієнтів якіх Закінчився срок депозиту.
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            var sp1 = Deposit.Where(operation => operation.Date < 2016);

            if (sp1 != null)
            {
                foreach (Deposit_account operation in sp1)
                {
                    richTextBox1.AppendText("FullName: " + operation.FullName + ", Дата Открытия:  " + operation.Date + ", Счёт: " + operation.Score + ", Процент за год: " + operation.Interestrateee());
                }
            }
        }
        //метод пошуку
        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            try
            {

                string clientReadLine = textBox1.Text;

                int disReadLine = int.Parse(textBox2.Text);

                var sp1 = Current.Where(operation => operation.FullName == clientReadLine && operation.PIN == disReadLine);
                var sp2 = Deposit.Where(operation => operation.FullName == clientReadLine && operation.PIN == disReadLine);


                if (sp1 != null)
                {
                    foreach (Current_account operation in sp1)
                    {
                        textBox3.Text = operation.FullName;
                        textBox4.Text = operation.Date.ToString();
                        textBox5.Text = operation.Score.ToString();
                        textBox6.Text = operation.Interestrate.ToString();
                    }
                }

                if (sp2 != null)
                {
                    foreach (Deposit_account operation in sp2)
                    {
                        textBox7.Text = operation.FullName;
                        textBox8.Text = operation.Date.ToString();
                        textBox9.Text = operation.Score.ToString();
                        textBox10.Text = operation.Interestrate.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

        }
        // Метод додавання поповнення
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string clientReadLine = textBox16.Text;

                int disReadLine = int.Parse(textBox17.Text);

                NodeCurrent = Current.First;
                NodeDeposit = Deposit.First;


                while (NodeCurrent != null)
                {
                    if (NodeCurrent.Value.FullName == clientReadLine && NodeCurrent.Value.PIN == disReadLine)
                    {
                        NodeCurrent.Value.Score += int.Parse(textBox18.Text);
                    }
                    NodeCurrent = NodeCurrent.Next;
                }


                while (NodeDeposit != null)
                {
                    if (NodeDeposit.Value.FullName == clientReadLine && NodeDeposit.Value.PIN == disReadLine)
                    {
                        NodeDeposit.Value.Score += int.Parse(textBox18.Text);
                    }
                    NodeDeposit = NodeDeposit.Next;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }
        //Метод показуе баланс на рахунку 
        private void Баланс_Click(object sender, EventArgs e)
        {
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();

            string clientReadLine = textBox11.Text;

            Console.WriteLine();


            var sp1 = Current.Where(operation => operation.FullName == clientReadLine);
            var sp2 = Deposit.Where(operation => operation.FullName == clientReadLine);


            if (sp1 != null)
            {
                foreach (Current_account operation in sp1)
                {
                    textBox12.Text = operation.FullName;
                    textBox13.Text = operation.Score.ToString();
                }
            }


            if (sp2 != null)
            {
                foreach (Deposit_account operation in sp2)
                {
                    textBox14.Text = operation.FullName;
                    textBox15.Text = operation.Score.ToString();
                }
            }
        }
        // Метод виходу
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

