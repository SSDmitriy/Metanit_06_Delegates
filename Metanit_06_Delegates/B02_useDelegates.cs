// B02 Delegates in use https://metanit.com/sharp/tutorial/3.43.php

namespace Metanit_06_Delegates
{
    class B02_useDelegates
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___Delegates in USE___");

            Console.WriteLine("\nCreate a new account");
            Account acc1 = new Account(0);
            acc1.RegisterHandler(SomeMethod); // send SomeMethod into acc1 object to delegate


            Console.WriteLine($"\nOn account now {acc1.sum} dollars");
            Console.WriteLine($"Adding 200$");
            acc1.Add(200);
            Console.WriteLine($"\nOn account now {acc1.sum} dollars");

            // try take money two times
            acc1.Take(120);
            acc1.Take(130);



        }

        //ANY method which will be called by delegate in acc1 object
        private static void SomeMethod(string message)
        {
            Console.WriteLine("\n-->Operation in progress..." + message);
        }
    }

    //declare delegate
    public delegate void AccountHandler(string msg); //take string and return nothing


    public class Account
    {
        public int sum; //sum on account

        AccountHandler? taken; //variable of deegate "AccountHandler"

        //start sum
        public Account(int sum) => this.sum = sum;

        public void RegisterHandler(AccountHandler del) // "del" takes any external method
        {
            taken = del; // register our delegate in this class
        }

        //add mobey
        public int Add(int sum) => this.sum += sum;

        //take money
        public void Take(int sum)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;

                taken?.Invoke($"{sum} was take from your account"); //here CALL DELEGATE with message
            }
            else
            {
                taken?.Invoke($"Not enought money! {sum} can't take from your account"); //here CALL DELEGATE with message
            }
        }

    }

}
