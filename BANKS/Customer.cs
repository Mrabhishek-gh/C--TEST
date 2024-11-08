using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKS
{
    public class Customer
    {
        private string name;
        private int pin;
        private double balance;
        private long acc_no;
        protected internal Customer(string name,int pin,double balance,long acc_no) 
        {
            this.name = name;
            this.pin = pin; 
            this.balance = balance; 
            this.acc_no = acc_no; 

        }

        public string iname
        {
            get 
            { 
                return this.name;
            }
        }
        public string ipin
        {
            get
            {
                return this.pin.ToString();
            }
        }
        public string ibalance
        {
            get
            {
                return this.balance.ToString();
            }
        }
        public string iaccNo
        {
            get
            {
                return this.acc_no.ToString();
            }
        }

        public void Getbalance(int pin)

        {
            if (pin == this.pin)
            {
                Console.WriteLine("Your balance is " + balance + " Rs only");

            }
            else
            {
                Console.WriteLine("The given pin is wrong");
            }

            Console.ReadKey();

        }

        public void Setbalance(int pin,double deposit)
        {
            if (pin == this.pin) 
            {
                this.balance += deposit;
                Console.WriteLine("Rs " + deposit + " has been added to your account");
            }
            else 
            {
                Console.WriteLine("Wrong pin");
            }

            Console.ReadKey();


        }

        public void Withdrawbalance(int pin,double withdraw)
        {
            if (pin == this.pin)
            {
                if (withdraw > this.balance)
                {
                    Console.WriteLine("Rs " + withdraw + " cannot be withdrawn from your account due to insufficient funds");
                }
                else
                {
                    this.balance -= withdraw;
                    Console.WriteLine("Rs " + withdraw + " has been withdrawn from your account");
                }
            }
            else
            {
                Console.WriteLine("Wrong pin");
            }

            Console.ReadKey();
            

        }
    }
}
