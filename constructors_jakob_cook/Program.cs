using System;

namespace constructors_jakob_cook
{
    class Program
    {
        static void Main(string[] args)
        {
            game myGame = new game("Dead Island 2", "M for Mature");

            Console.WriteLine($"My favorite game is {myGame.title} and it is rated {myGame.genre}!");

            game myOtherGame = new game();

            Console.WriteLine($"My favorite game {myOtherGame.title} and it is rated {myOtherGame.genre }!");
        }
    }
}
