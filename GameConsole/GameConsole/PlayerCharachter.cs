using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerCharachter
    {
        public string Name { get; set; } 
        public int DaysSinceLastLogin { get; set; } 
        public DateTime DateOfBirth { get; set; }

        public PlayerCharachter()
        {
            DaysSinceLastLogin = -1;            //Magic Number
            DateOfBirth = DateTime.MinValue;    //Magic Number
        }



    }
}
