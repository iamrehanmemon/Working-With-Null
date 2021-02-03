﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerCharachter
    { 
        public string Name { get; set; } 
        public int? DaysSinceLastLogin { get; set; } 
        public DateTime? DateOfBirth { get; set; }
        public bool? IsNoob { get; set; }

        public PlayerCharachter()
        {
            DaysSinceLastLogin = null; 
            DateOfBirth = null;
        }



    }
}
