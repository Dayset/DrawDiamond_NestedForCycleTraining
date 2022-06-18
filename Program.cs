using System;

namespace SoloLearn // Based on SoloLearn homework 'to draw a pyramid'.
{
    internal class Program
    {
        private static void DrawDiamond(int TotalRows, char Brick)
        {
            for (int CurrentRow = 1; CurrentRow <= TotalRows; CurrentRow++)
            {
                for (int Spaces = CurrentRow; Spaces <= TotalRows; Spaces++)
                {
                    //Two spaces are used here
                    Console.Write("  ");
                }
                //2*i-1 math construction will give you an odd order (non even e.g. 1 3 5 7 9..)
                for (int Stars = 1; Stars <= 2 * CurrentRow - 1; Stars++)
                {
                    Console.Write(Brick + " ");
                }
                Console.WriteLine();
            }

            //Pyramid top is completed, now let's draw inverted pyramid below.
            for (int CurrentRow = 2; CurrentRow <= TotalRows; CurrentRow++)
            {
                for (int Spaces = 1; Spaces <= CurrentRow; Spaces++)
                {
                    //Two spaces are used here
                    Console.Write("  ");
                }
                for (int Stars = 2 * TotalRows; Stars >= 2 * CurrentRow; Stars--)
                {
                    Console.Write(Brick + " ");
                }
                Console.WriteLine();
            }
        }

        // Diamond can be drawn much faster in a single call using StringBuilder.

        private static void Main()
        {
            while (true)
            {
                //Define a look of the rhombus here.
                char Brick = '*';

                Console.WriteLine("# Please Enter any positive number in range [2-60]:\n");
                string line = Console.ReadLine();

                if (int.TryParse(line, out int value))
                {
                    // Min is 0 and Max is 60 defined here.
                    if (value >= 2 && value <= 60)
                    {
                        // Place in code where the Rhombus is created.
                        DrawDiamond(value, Brick);
                        Console.WriteLine();
                    }
                    else
                        Console.WriteLine("# Sorry your input is incorrect.");
                }
                else
                {
                    Console.WriteLine("\n# Not a valid or an integer number.");
                }

                Console.WriteLine("# Press Enter key to repeat.\n# Or type Quit to exit.\n");
                string quit = Console.ReadLine();

                // Looking for a non case sensitive "Quit" word here to quit.
                // Typing quit method is funky but i am learning this way.
                if ((quit.IndexOf("quit", 0, StringComparison.CurrentCultureIgnoreCase) != -1)
                    && (quit.Length == 4))
                {
                    break;
                }

                Console.Clear();
            }
        }
    }
}