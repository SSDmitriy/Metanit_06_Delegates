// B04 Lambdas https://metanit.com/sharp/tutorial/3.16.php

namespace Metanit_06_Delegates
{
    internal class B04_Lambdas
    {

        //simple delegate
        delegate void Del1();

        // delegate with parameters for lambda
        delegate void Del2(int x, int y);

        //delegate with one parameter
        delegate void Del3(string mes_);

        //delegate with RETURN parameter. Must specify returned type
        delegate int Del4(int x, int y);

        //delegate for lambda like an parameter in method
        delegate bool IsEqual(int x);

        //delegate for last sample - labda like an return expression from method
        delegate int Operation(int x, int y);
        //enum for operations
        enum OperType
        {
            Add, Substract, Multiply
        }

        static void Main(string[] args)
        {
            Console.WriteLine("B04");

            Del1 lambda1 = () => Console.WriteLine("This is LAMBDA1");

            lambda1();
            lambda1();


            Console.WriteLine("\n lambda with few strings");
            Del1 lambda2 = () =>
            {
                Console.Write("This IS ...");
                Console.WriteLine("LaMbDa2");
            };
            lambda2();
            lambda2();

            Console.WriteLine("\n lambda with few strings");
            var lambda3 = () => Console.WriteLine("LAMBDA 3 with type var");
            lambda3();


            Console.WriteLine("\n lambda with parameters");
            Del2 lambda4 = (x, y) =>
            {
                Console.WriteLine($"X + Y = {x = y}");
            }; //here is semicolon

            lambda4(5, 3);
            lambda4(6, 7);


            Console.WriteLine("\n lambda with ONE parameter (without specify type)");
            Del3 lambda5 = mess => Console.WriteLine(mess);
            lambda5("lamda5 without specify parameters");

            Console.WriteLine("\n return result from lambda");
            Del4 lambda6 = (x, y) => x + y;
            int result = lambda6(3, 4); //7
            Console.WriteLine($"lamda6 returns result = {result}");

            Console.WriteLine("\n return result. But lambda with few instructions in brackets");
            var lambda7 = (int x, int y) =>
            {
                if (x > y) return x - y;
                else return y - x;
            };
            int res1 = lambda7(10, 7);
            Console.WriteLine($"lamda7 returns res1 = {res1}");
            int res2 = lambda7(-10, 7);
            Console.WriteLine($"lamda7 returns res2 = {res2}");

            Console.WriteLine("\n add and remove actions in lambda");
            void Print() => Console.WriteLine("in meth Print()"); //anonimous method
            var hello = () => Console.WriteLine("Just in lambda"); // first lambda
            var message = () => Console.WriteLine("Mess1"); //second lambda
            message += () => Console.WriteLine("Message2"); // add to second lambda
            message += hello; //add first lambda from hello
            message += Print; //add anonimous method

            message(); //call lambda "message"
            Console.WriteLine("---separator----");
            //now remove from lambda "message"
            message -= hello; // remove from lambda
            message -= Print; // and one more remove

            message();
            message?.Invoke(); // this a safe call lamda (if it's contains null)


            Console.WriteLine("\n LAMBDA like an ARGUMENT");
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int Sum(int[] nums, IsEqual func) // lambda "IsEqual" here is PARAMETER of method Sum()
            {
                int result = 0;
                foreach (int i in nums)
                {
                    if (func(i)) result += i; //adding only for numbers for which func(i)=true
                }
                return result;
            }

            int res3 = Sum(array, x => x > 5); // x=>x>5 - this is lambda (method)
            Console.WriteLine("res3 = " + res3);

            int res4 = Sum(array, x => x % 2 == 0);
            Console.WriteLine("re4 = " + res4);

            Console.WriteLine("\n LAMBDA like an RESULT of method");
            
            Operation SelectOper(OperType operType)
            {
                switch (operType)
                {
                    //enum is above Main()
                    case OperType.Add: return (x, y) => x + y; // return LAMBDA x+y
                    case OperType.Substract: return (x, y) => x - y; // return LAMBDA x-y
                    default: return (x, y) => x * y; //return LAMBDA x*y
                }
            }

            Operation op1 = SelectOper(OperType.Add);
            Console.WriteLine(op1(10, 4));
                      
            Operation op2 = SelectOper(OperType.Substract);
            Console.WriteLine(op2(10, 4));

            Operation op3 = SelectOper(OperType.Multiply);
            Console.WriteLine(op3(10, 4));




        }


    }
}
