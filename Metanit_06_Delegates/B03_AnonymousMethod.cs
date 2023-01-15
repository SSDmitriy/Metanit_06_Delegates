// anonimous methods https://metanit.com/sharp/tutorial/3.15.php



namespace Metanit_06_Delegates
{
    internal class B03_AnonymousMethod
    {

        delegate void Del1(string mesage);

        delegate void Del2(string message);

        delegate void Del3(string message);

        delegate int Del4(int x, int y);

        static int justGlobalZ = 10;

        static void Main(string[] args)
        {
       

            Console.WriteLine("___ Anonymous ___");

            Del1 del1 = delegate (string mes) { Console.WriteLine("1st in anonymous meth"); };

            del1("Message for delegate1");


            Console.WriteLine("\n");
            Console.WriteLine("2nd anonymous meth with delegate like an parameter");
            Meth1("str to meth", delegate (string mes1) { Console.WriteLine(mes1); });

            Console.WriteLine("\n");
            Console.WriteLine("3rd anonymous meth WITHOUT parameters");
            Del3 del3 = delegate //here is delegate WITHOUT parameters
            {
                Console.WriteLine("in anonymous meth 3");
            };
            del3("string outside anonymous meth"); //here will type "in anonymous meth 3"


            Console.WriteLine("\n");
            Console.WriteLine("4rd anonymous meth WITH RETURN parameters");
            Del4 del4 = delegate (int x, int y)
            {
                return x + y;
            };
            int res4 = del4(5, 3);
            Console.WriteLine("result of anonymous del4: " + res4);

            Console.WriteLine("\n");
            Console.WriteLine("5rd anonymous meth use GLOBAL VARIABLE");
            Del4 del5 = delegate (int x, int y)
            {
                return x + y + justGlobalZ; //here is anonymous meth use var from outside they signature
            };

            int res5 = del5(5, 3);
            Console.WriteLine("result of anonymous del4 with GLOBAL VAR: " + res5);


        }



        static void Meth1 (string mes, Del2 del2){
            del2(mes);
            }

    }
}
