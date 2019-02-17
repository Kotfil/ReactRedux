using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class accounts
    {
        public int acno;


        public int useracno
        {
            get { return acno; }
            set { acno = value; }
        }
        protected string name;
        internal int deposit;
        protected internal char type;

        private void create_account()
        {
            Console.Write("\nEnter The Account No. : ");
            useracno = int.Parse(Console.ReadLine());
            Console.Write("Enter The Name pf The account Holder:");
            name = Console.ReadLine();
            Console.Write("nEnter Type of The account (C/S) : ");
            type = char.Parse(Console.ReadLine());
            Console.Write("Enter The Initail amount(>=500 for Saving and >=1000 for current")
            deposit = int.Parse(Console.ReadLine());
            Console.Write("\n\n\nAccount Created..");
        }
        public void createaccount()
        {
            Console.Write("\nAccount No. :{0} ", useracno);
            Console.Write("Account Holder Name : {0}", name);
            Console.Write("Type of Account : {0}", type);
            Console.Write("Balance amount : {0}", deposit);
        }
        public void showAccount()
        {
            show_Account();
        }
        internal void modifyaccount()
        {
            Console.Write("\nAccount No. : {0}", acno);
            Console.Write("Modify Account Holder Name : ");
            name = Console.ReadLine();
            Console.Write("Modify Type of Account : ");
            type = char.Parse(Console.ReadLine());
            Console.Write("Modify Balance amount : ");
            deposit = int.Parse(Console.ReadLine());
        }
        public void modify_account()
        {
            modifyaccount();
        }
        public void accountdep()
        {
            int x;
            Console.Write("Enter the amount u want to Deposit::");
            x = int.Parse(Console.ReadLine());
            deposit += x;
        }
    } public void accountdraw()
    {
        int x;
        Console.Write("Enter the amount u want to withdraw::");
        x = int.Parse(Console.ReadLine());
        deposit -= x;
    }
    public void account_report()
    {
        Console.Write("Acno ::{0} \nName::{1} \nType::{2} \nDeposit::{3}\n", acno, name, type, deposit);

    }
    public int retacno()
        {
        return acno;
        }
    public int retdeposit()
    {
        return deposit;
    }
    public char rettype()
    {
        return type;
    }
        
    }
}

