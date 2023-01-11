// B01 delegates https://metanit.com/sharp/tutorial/3.13.php
// delegate - it's a pointer onto method or few methods
// delegate can't be declare inside a method

/*
namespace Metanit_06_Delegates
{
    internal class B01_Delegates
    {

        delegate void MyDelegate(); //declare delegate

        delegate int Operation(int x, int y); //declare delegat with RETURNED TYPE and TAKE TYPES



        delegate void SomeDel(ref int x, double y); //fluence of modificators "ref\in\out"
        void SomeMeth1(ref int x, int y) { } //don't match  by SECOND INT
        double SomeMeth2(ref int x, double y) { return x/y; } //don't match  by RETURNED TYPE
        void SomeMeth3(out int x, int y) { x = 4; } //don't match  by FIRST OUT


        delegate void MyMultiDelegate(); // for add FEW methods to ONE delegate

        delegate T GenericOperation<T, K>(K val); // GENERIC delegate
                                                    // here T - for returned value
                                                    //      K - for taking value
                                                    // both <T+K> after delegate's name


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            Console.WriteLine("___ call delegate ___");

            MyDelegate del1;
            del1 = meth1; // meth1 without ()
            del1(); // call delegate WITH ()

            MyDelegate del2 = A.Method2; //delegate of method in another class
            del2();

            Console.WriteLine("\n");
            Console.WriteLine("2) Delegate with parameters"); //int Operation(int x, int y);
            Console.WriteLine();
            //few methods
            int Add(int x, int y)
            {
                return x + y;
            }
            
            int Multiply(int x, int y) => x * y;

            //using delegat "Operation" with take "int, int" and return "int" 
            Operation del3 = Add; // del3 POINT TO Add
            int result;
            result = del3(4, 5);
            Console.WriteLine("del3 take 4, 5 and return: " + result);

            del3 = Multiply; // del3 POINT TO Multiply
            result = del3(4, 5);
            Console.WriteLine("Now del3 take same 4, 5 and multiply. Rreturn: " + result);

            Console.WriteLine("\n");
            Console.WriteLine("3) Declare delegate with CONSTRUCTOR");
            Console.WriteLine();
            Operation del4 = new Operation(Add);
            Console.WriteLine("Del 3 return: " + del4(2, 3));

            Console.WriteLine("\n");
            Console.WriteLine("4) Add few methods to ONE delegate \"del5\" \n"); // MyMultiDelegate();
            MyMultiDelegate del5 = meth3; // store first method to delegate
            del5 += meth4; // add second method
            Console.WriteLine("\n Call both of methods in ONE delegate: ");
                del5();
            
            Console.WriteLine("\n Call few SAME methods in ONE delegate: ");
            del5 += meth4;
            del5 += meth4;
                del5();

            Console.WriteLine("\n Or can exclude meths from delegate: ");
            del5 -= meth3;
            del5 -= meth3;
            del5 -= meth4;
                del5();

            Console.WriteLine("\n5) UNION delegates in delegates\n"); // MyMultiDelegate();
            MyMultiDelegate del6 = meth1;
            MyMultiDelegate del7 = meth3;
            MyMultiDelegate del8 = del6 + del7; // here is SUM of delegates
            Console.WriteLine("Call UNION of two delegates: ");
                del8();

            Console.WriteLine("\n6) Call delegate with INVOKE()\n"); // delegate int Operation(int x, int y);
            Operation del9 = Add;
            int n = del9.Invoke(5, 3);
            Console.WriteLine(n);

            Console.WriteLine("\n7) Use check for NULL before call delegate\n"); // MyMultiDelegate();
            MyMultiDelegate? del10;
            del10 = meth4;
            del10 -= meth4;
            //call with check "?."
            del10?.Invoke();

            Console.WriteLine("\n8) Return LAST VALUE from list of methods\n"); // delegate int Operation(int x, int y);
            Operation del11;
            del11 = Add;
            del11 += Multiply; // last meth in list
            Console.WriteLine(del11(3, 4)); // will return "Multiply" because this is last


            Console.WriteLine("\n9) GENERIC DELEGATE\n"); //   delegate T GenericOperation<T, K>(K val);

            //few methods again
            decimal Square(int x) => x * x;
            int Twice(int x) => x + x;

            GenericOperation<decimal, int> del12 = Square; // return DECIMAL, take INT
            decimal res1 = Square(7);
            Console.WriteLine("delegate T-type, take 7 K-type: " + res1);
            
            GenericOperation<int, int> del13 = Twice; // return INT and take INT
            decimal res2 = Twice(7);
            Console.WriteLine("delegate T-type, take 7 K-type: " + res2);


            Console.WriteLine("\n10) delegate INSIDE METHOD\n"); // delegate int Operation(int x, int y);
            // meth with delegate-parameter
            void Method5WithDelegate(int a, int b, Operation del)
            {
                Console.WriteLine(del(a, b));
            }
            Method5WithDelegate(5, 4, Add);
            Method5WithDelegate(5, 4, Multiply);


            Console.WriteLine("\n11) return delegate FROM METHOD\n"); // delegate int Operation(int x, int y);








        }


        static void meth1()
        {
            Console.WriteLine("This is method #1");
        } 
        
        static void meth3()
        {
            Console.WriteLine("This is method #3");
        } 
        
        static void meth4()
        {
            Console.WriteLine("This is method #4");
        }





    }


    class A
    {
        public static void Method2()
        {
            Console.WriteLine("This is in meth2");
        }
    }
}

*/