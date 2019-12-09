using System;


namespace TennisGameSimulator
{
    class UIMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO A VERY SIMPLE TENNIS GAME SIMULATOR");
            Console.WriteLine("Today, and only today you will see 2 of the greetest tennis players play \n" +
                "If you wish to leave the simulator please type 'quit' to exit the simulator" + "\n");

            Console.WriteLine("Player one is : Roger Federer");
            Console.WriteLine("Player two is : Novak Djokovic");
            
            Game game = new Game("Roger Federer", "Novak Djokovic");
            Console.WriteLine("Press enter to start the simulation");
            while (!Console.ReadLine().Equals("quit"))
            {     
                game.StartGame();
            }
        }

    }
}
