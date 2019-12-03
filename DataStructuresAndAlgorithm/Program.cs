using System;

namespace DataStructuresAndAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cock, Hen, Chick;
            for (Cock = 0; Cock <= 20; Cock++)
            {
                for (Hen = 0; Hen <= 33; Hen++)
                {
                    Chick = 100 - Cock - Hen; 
                    if (3 * Hen + 5 * Cock + Chick / 3.0 == 100)
                        Console.WriteLine("公鸡{0}只,母鸡{1}只,小鸡{2}只\n", Cock, Hen, Chick);
                }
                count++;
            }
            
            Console.ReadKey();

        }
    }
}
