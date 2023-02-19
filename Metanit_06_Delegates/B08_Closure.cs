

namespace Metanit_06_Delegates
{
    internal class B08_Closure
    {

        static void Main(string[] args)
        {
            Console.WriteLine("08 - Closure");

            //closure with local functions
            Action Outer()
            {
                int x = 5; //lexic surround for INNER()

                void Inner()
                {
                    x++;
                    Console.WriteLine(x);
                }
                return Inner;
            }

            var fn = Outer();

            fn();
            fn();


            //closure with lambda
            Console.WriteLine("\n");
            Console.WriteLine("Closure with LAMBDAS \n");
            var OuterFn = () =>
            {
                int x = 10;
                var InnerFn = () => Console.WriteLine(++x);
                return InnerFn;

            };

            var fn2 = OuterFn();

            fn2();
            fn2();

            //closure with parameters
            Console.WriteLine("\n\n");
            Console.WriteLine("Closure with PARAMETERS\n");

            Operation Subsdtract(int n)
            {
                int InnerInSubs(int m)
                {
                    return n - m;
                }
                return InnerInSubs;
            }

            var fn3 = Subsdtract(5);

            Console.WriteLine(fn3(1));
            Console.WriteLine(fn3(2));


            //closure with parameters and lambdas
            Console.WriteLine("\n\n");
            Console.WriteLine("Closure with PARAMETERS and LAMBDAS\n");
            var subst = (int n) => (int m) => n - m;

            var fn4 = subst(7);
            Console.WriteLine(fn4(2));
            Console.WriteLine(fn4(3));


        }

        delegate int Operation(int n);

    }
}
