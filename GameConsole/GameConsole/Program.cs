using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharachter[] players = new PlayerCharachter[3]
            {
                new PlayerCharachter {Name = "Rehan"},
                new PlayerCharachter(), //Name = Null
                null //PlayerCharachter = null

            };

            //PlayerCharachter[] players = null;

            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;

            //player.DaysSinceLastLogin = 42;

            //PlayerDisplayer.Write(players);

            //int days = player.DaysSinceLastLogin.Value;
            //int days = player ?. DaysSinceLastLogin ?? -1;
                 
            //Console.WriteLine(days);

            Console.ReadLine();
        }
    }
}
