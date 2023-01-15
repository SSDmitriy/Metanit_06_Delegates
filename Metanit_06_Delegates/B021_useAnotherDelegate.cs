// here is delegate inside object (myAcc)
// delegate contain more than ONE method
// add and remove methods from delegate
/*
namespace Metanit_06_Delegates
{
    // declare delegate
    public delegate void AccountHandler_2(string message);

    internal class B021_useAnotherDelegate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Use delegates with more than one method ---\n");

            MyAccount myAccount = new MyAccount(200);
            myAccount.RegisterHandler_2(Meth_1_print);
            myAccount.RegisterHandler_2(Meth_2_printRED);

            //try to take money two times
            myAccount.Take_2(135);
            myAccount.Take_2(145);

            Console.WriteLine();
            myAccount.UnregisterHandler_2(Meth_2_printRED); // remove second "RED" method
            myAccount.Take_2(15);


        }


        // meth1 for print
        static void Meth_1_print(string message)
        {
            Console.WriteLine(message);
        }

        // meth2 for COLOR print
        static void Meth_2_printRED(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }


    }

   

    public class MyAccount
    {
        int sum;
        AccountHandler_2? taken; //variable of delegate

        public MyAccount(int sum) //constructor for object myAcc
        {
            this.sum = sum;
        }

        //method to add (to register) DELEGATE in OBJECT
        public void RegisterHandler_2(AccountHandler_2 del2)
        {
            taken += del2; // here += mean add some method "del" to list of methods of delegate "taken"
        }

        //method to remove (unregister) delegate FROM OBJECT
        public void UnregisterHandler_2(AccountHandler_2 del2)
        {
            taken -= del2;
        }

        public void Add_2(int sum) // meth to increase account's money
        {
            this.sum += sum;
        }

        // meth to decrease
        public void Take_2(int sum)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;
                taken?.Invoke($"===> from your acoount was taken {sum} dollars.");
            }
            else
            {
                taken?.Invoke($"XXX Not enough money! We can't take {sum} from your account." +
                    $"XXX Your balance is only {this.sum} dollars.");
            }
        }

    }


}

*/