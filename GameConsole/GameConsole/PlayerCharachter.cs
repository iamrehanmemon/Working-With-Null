using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerCharachter
    {
        public string Name { get; set; } 
        public Nullable<int> DaysSinceLastLogin { get; set; } 
        public Nullable<DateTime> DateOfBirth { get; set; }

        public PlayerCharachter()
        {
            DaysSinceLastLogin = null; 
            DateOfBirth = null;
        }



    }
}
