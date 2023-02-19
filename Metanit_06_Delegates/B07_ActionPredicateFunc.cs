
/*
namespace Metanit_06_Delegates
{
    internal class B07_ActionPredicateFunc
    {


        static void Main(string[] args)
        {
            Console.WriteLine("07 - builtin delegates");

            // built-in delegate "Action"   public delegate void Action()
            // public delegate void Action<in T1, in T2, in T3... in T16>(T obj) - up to 16 parameters 

            //Meth for adding two numbers
            void Add(int x, int y)
            {
                Console.WriteLine($"{x} + {y} = {x + y}");
            }

            //Meth for multiply
            void Multiply(int x, int y)
            {
                Console.WriteLine($"{x} * {y} = {x * y}");
            }


            //meth with built-in delegate "Action"
            void DoOperation(int a, int b, Action<int, int> op)
            {
                op(a, b);
            }

            Console.WriteLine("\n Action");
            DoOperation(10, 6, Add);
            DoOperation(10, 6, Multiply);

            //Predicate  delegate bool Predicate<in T>(T obj)
            Console.WriteLine("\n \n Predicate");

            Predicate<int> isPositive = (int x) => x > 0;
            Console.WriteLine(isPositive(20));
            Console.WriteLine(isPositive(-5));

            //Func delegate TResult Func<out TResult>()
            // TResult Func<in T, in T2, out TResult>(T1 arg1, T2 arg2)
            Console.WriteLine("\n \n Func");

            //meth1
            int DoubleNum(int n)
            {
                return n * 2;
            }

            //meth2
            int SquareNum(int n)
            {
                return n * n;
            }

            //meth with delegate Func
            int DoOper(int n, Func<int, int> oper) => oper(n);
            

            int result1 = DoOper(7, DoubleNum);
            Console.WriteLine(result1);

            int result2 = DoOper(7, SquareNum);
            Console.WriteLine(result2);


            //one more Func
            Func<int, int, string> createString = (int a, int b) => $"{a}{b}";

            Console.WriteLine(createString(1, 3));
            Console.WriteLine(createString(7, 8));

        }
    }
}

*/