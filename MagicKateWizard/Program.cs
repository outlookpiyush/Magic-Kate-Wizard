using System;

namespace MagicKateWizard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MagicKateWizard());
            Console.ReadLine();
        }
        public static int MagicKateWizard()
        {
            int x, n, l, t;
            t = Convert.ToInt32(Console.ReadLine());

            while ((t--) != 0)
            {
                n = Convert.ToInt32(Console.ReadLine());
                l = Convert.ToInt32(Console.ReadLine());
                x = Convert.ToInt32(Console.ReadLine());

                if (n == 0) Console.WriteLine("0");
                else if (n > 59) Console.Write("{0:D}", x);
                else
                {
                    n = Convert.ToInt32(Math.Pow(2, n - 1));
                    n = l / n;
                    n = x - n;
                    if (n < 0)
                        Console.WriteLine("0");
                    else
                        Console.Write("{0:D}", n);
                }
                Console.Write("\n");
            }
            return 0;
        }
    }
}
