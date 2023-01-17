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


        }
    }
}
