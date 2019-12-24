﻿using SolarLunarName.Standard.Models;
using System;
using System.Linq;
using SolarLunarName.Standard.RestServices.LocalJson;

namespace SolarLunarName.Standard.ApplicationServices
{
    public class DateTransformer
    {
        public DateTransformer(){
            di = new DateInstantiator();

        }
        public DateTransformer(DateInstantiator dateInstantiator){
            di = dateInstantiator;

        }
        private DateInstantiator di;

         public Models.SolarLunarName AddDays(Models.SolarLunarName solarLunarName, double value){
            
            return di.GetRemoteSolarLunarName(solarLunarName.SolarDateTime.AddDays(value));

        }

        public Models.SolarLunarName AddMonths(Models.SolarLunarName solarLunarName, int value){

            return di.GetRemoteSolarLunarName(solarLunarName.SolarDateTime.AddMonths(value));
            
        }

        public Models.SolarLunarName AddYears(Models.SolarLunarName solarLunarName, int value){

            return di.GetRemoteSolarLunarName(solarLunarName.SolarDateTime.AddYears(value));
            
        }

    }
    
}

