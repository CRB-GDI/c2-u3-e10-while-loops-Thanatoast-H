namespace Excercise_10__While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 4)
            {
                //print menu
                Console.WriteLine("**************");
                Console.WriteLine("Menu:   ");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Load Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - Quit");
                Console.WriteLine("**************");
                Console.WriteLine();

                //ASK USER A CHOICE
                Console.WriteLine("Please choose a number from the Menu. (1,2,3,4)");
                choice = int.Parse(Console.ReadLine());
                //Console.WriteLine(choice);

                //print message using if statements
                if (choice == 1)
                {
                    Console.WriteLine("Creating New Game...");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Loading Game...");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Option Menu Loading...");
                }
                else if (choice > 4 || choice < 1)
                    Console.WriteLine("Please select a Valid Option");

            }




        }
    }
}

