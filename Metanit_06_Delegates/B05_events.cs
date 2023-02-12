//B05 Events https://metanit.com/sharp/tutorial/3.14.php
/*
namespace Metanit_06_Delegates
{
    class B05_events
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Events");

            Console.WriteLine("\n 01 - Create an account");

            Account acc1 = new Account(100); //initial sum to account
            acc1.Ev1 += ShowMess; // add FIRST handler for Event
            acc1.Ev1 += ShowRedMess; // add SECOND handler for Event


            acc1.Put(20); //add 20$
            Console.WriteLine("Sum on acc1: " + acc1.Sum);

            acc1.Ev1 -= ShowRedMess; // remove SECOND handler


            //set LAMBDA to handler
            acc1.Ev1 += messLambda =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(messLambda);
                Console.ResetColor();
            };

            acc1.Take(70);
            Console.WriteLine("Sum on acc1: " + acc1.Sum);
            


            acc1.Take(70);
            Console.WriteLine("Sum on acc1: " + acc1.Sum);

            //method, which calls in event handler
            void ShowMess(string message)
            {
                Console.WriteLine(message);
            }
            
            //method, which calls in event handler
            void ShowRedMess(string message)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();

            }

        }

 

    }

    class Account
    {
        public delegate void AccHandler(string message);
        public event AccHandler? Ev1; // 1) init an event

        public int Sum { get; private set; } //sum on account
        public Account(int sum) => Sum = sum; //set initial sum
        public void Put(int sum)
        {
            Sum += sum; //add to account
            Ev1?.Invoke($">> to your account add: {sum}"); // 2) call an event
        }
        public void Take(int sum)
        {
            if (Sum > sum)
            {
                Sum -= sum;
                Ev1?.Invoke($"<< from your account taken: {sum}"); // 2) call event
            }
            else
            {
                Ev1?.Invoke($"||| you try to take: {sum}, but NOT ENOUGH money"); //  2)call event
            }
        }
    }
}

*/