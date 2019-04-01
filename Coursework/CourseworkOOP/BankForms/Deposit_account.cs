using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForms
{
    class Deposit_account : ICliente
    {
            private double interestrate;
            private double score;
            private string fullName;
            private int date;
            private int pin;

            public double Interestrate
            {
                get { return interestrate; }
                set { interestrate = value; }
            }

            public double Score
            {
                get { return score; }
                set { score = value; }
            }

            public string FullName
            {
                get { return fullName; }
                set { fullName = value; }
            }

            public int Date
            {
                get { return date; }
                set { date = value; }
            }

            public int PIN
            {
                get { return pin; }
                set { pin = value; }
            }

            public double Interestrateee()
            {
                return score * interestrate;
            }

            public string Result()
            {
                return "ФИ: " + FullName + ", Дата Открытия:  " + Date + ", Счёт: " + Score + ", Процент за год: " + Interestrateee();

            }
        }
    }
