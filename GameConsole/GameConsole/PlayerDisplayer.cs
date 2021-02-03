using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerDisplayer
    {   
        public static void Write (PlayerCharachter player)
        {
            Console.WriteLine(player.Name);
            
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
        }
    }
}
