using System;

namespace Chick
{
    class Program
    {
        static void Main(string[] args)
        {
            int q, w, u;
            for (q = 0; q <= 20; q++)
            {
                for (w = 0; w <= 33; w++)
                {
                    u = 100 - q - w; if (3 * w + 5 * q + u / 3.0 == 100)
                        Console.WriteLine("公鸡{0}只,母鸡{1}只,小鸡{2}只\n", q, w, u);
                }
            }
            Console.ReadKey();
        }
    }
}
