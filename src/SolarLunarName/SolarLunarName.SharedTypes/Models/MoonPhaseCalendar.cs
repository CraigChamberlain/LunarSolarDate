﻿using System.Collections.Generic;

namespace SolarLunarName.SharedTypes.Models
{
    public class MoonPhaseCalendar
    {
        public int Year { get; set; }
        public List<Moon.MoonPhase> MoonPhaseList { get; set; }       

    }
}
