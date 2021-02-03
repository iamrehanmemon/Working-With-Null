using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharachter();
            player.Name = "Rehan";
            //player.Name = "";
            //player.Name = null;

            player.DaysSinceLastLogin = 42;

            PlayerDisplayer.Write(player);
            Console.ReadLine();
        }
    }
}
