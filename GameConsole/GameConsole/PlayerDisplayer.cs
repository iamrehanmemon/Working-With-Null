using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerDisplayer
    {   
        public static void Write (PlayerCharachter player)
        {   
            if(string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player is Null Or all Whitespaces");
            }
            else
            {
                Console.WriteLine(player.Name);
            }
            
            if(player.DaysSinceLastLogin == null)
            {
                Console.WriteLine("No Value for DaysSinceLastLoagin");
            }
            else
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            }

            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No DOB has been specified.");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }

            if (player.IsNoob == null)
            {
                Console.WriteLine("Player newbie Status is unknown.");
            }
            else if (player.IsNoob == true)
            {
                Console.WriteLine("Player is newbie");
            }
            else
            {
                Console.WriteLine("Player is experienced");
            }
        }
    }
}
