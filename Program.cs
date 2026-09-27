namespace Lab_3_Felsökning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Case 1 – if-sats fel
             
             int number = 2;

             if (number > 3)
             {
                 Console.WriteLine("Talet är större än tre");
             }
             else if (number < 3)
             {
                 Console.WriteLine("Talet är mindre än tre");
             }

             // Fel: saknade ; och elseif är fel
            */

            /* Case 2 – loop går bara till 99

             for (int i = 1; i < 100; i++)
             {
                 Console.WriteLine(i);
             }

             // Fel: < 100 stoppar innan 100
            */

            /* Case 3 –  loop fel

             for (int i = 1; i <= 5; i++)
             {
                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write(j + " ");
                 }
                 Console.WriteLine();
             }

             // Rätt: j++ fanns med
            */

            /* Case 4 – ingen output

             int i = 1;
             while (i <= 5)
             {
                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write(); // skriver inget
                 }

                 Console.WriteLine();
                 i++;
             }

             // Fel: Console.Write() utan text
            */

            /* Case 5 – switch skriver Two fast i = 1

             int i = 1;

             switch (i)
             {
                 case 1:
                 case 2:
                     Console.WriteLine("Two");
                     break;

                 default:
                     Console.WriteLine("Other");
                     break;
             }

             //  case 1 faller ner till case 2
            */

            /* Case 6 – fel på jämförelse

             int i = 10;

             if (i == 5)
             {
                 Console.WriteLine("i är 5");
             }

             // Fel tidigare: det var = istället för ==
            */
        }
    }
}
