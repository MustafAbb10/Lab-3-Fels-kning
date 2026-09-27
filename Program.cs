
namespace Lab_3_Felsökning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Case 1: Jag la till ett semikolon och ändrade elseif till else if. */
            int number = 2;

            if (number > 3)
            {
                Console.WriteLine("Talet är större än tre");
            }
            else if (number < 3)
            {
                Console.WriteLine("Talet är mindre än tre");
            }

            /* Case 2: Jag ändrade < 100 till <= 100 så att den även skriver ut 100. */
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            /* Case 3: Jag la till i++ och j++ så att siffrorna ökar och looparna avslutas. */
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            /* Case 4: Jag la till "*" så att programmet har något att skriva ut. */
            int x = 1;

            while (x <= 5)
            {
                for (int j = 1; j <= x; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                x++;
            }

            /* Case 5: Jag la till break efter case 1 så att den inte skriver ut Two när värdet är 1. */
            int y = 1;

            switch (y)
            {
                case 1:
                    break;

                case 2:
                    Console.WriteLine("Two");
                    break;

                default:
                    Console.WriteLine("Other");
                    break;
            }

            /* Case 6: Jag ändrade = till == så att den kontrollerar om värdena är lika. */
            int z = 10;

            if (z == 5)
            {
                Console.WriteLine("i är 5");
            }
        }
    }
}

