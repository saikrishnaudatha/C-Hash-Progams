using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    
     class Accounts
    {
        static string bname = "SBI";
        public Accounts()
        { }
        public Accounts(int acno,string name,string actype,int amnt,int blnc)
        {
            Console.WriteLine("Enter Your Transaction Type (Deposit/Withdrawal) : ");
            Console.WriteLine("         Press d or c ? ");
            char transtype = char.Parse(Console.ReadLine());
            if (transtype == 'd')
            {
                Console.WriteLine("\nBank Name : " + bname);

                Console.WriteLine("Available Balance : " + debit(amnt, blnc));
            }
            else if (transtype == 'c')
            {
                Console.WriteLine("Bank Name : " + bname);
                Console.WriteLine("Available Balance : " + credit(amnt, blnc));
            }
            else
                Console.WriteLine("Enter correct option");


        }
        public int credit(int amount,int balance)
        {
            Console.WriteLine("Actual Balance: " + balance);
            Console.WriteLine("Amount (Credited) is : " + amount);
            balance = balance + amount;
            return balance;
        }

        public int debit(int amount,int balance)
        {
            Console.WriteLine("Actual Balance: " + balance);
            Console.WriteLine("Amount (Debited) is : " + amount);
            balance = balance - amount;
            return balance;
        }
        public void display(int acno, string name, string actype, int amnt, int blnc)
        {
            
            Console.WriteLine("Account Num : "+acno);
            Console.WriteLine("Account Holder Name : " + name);
            Console.WriteLine("Account Type : " + actype);
            
        }
    }
    

     
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Enter Account Num : ");
            int acno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Account Type : ");
            string actype = Console.ReadLine();
            Console.WriteLine("Enter Initial Amount : ");
            int blnc = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Amount you want to debit/credit : ");
            int amnt = int.Parse(Console.ReadLine());
            

            Accounts ac = new Accounts(acno,name,actype,amnt,blnc);
            ac.display(acno, name, actype, amnt, blnc);

    

            Console.ReadKey();
            }
        }
    
}
