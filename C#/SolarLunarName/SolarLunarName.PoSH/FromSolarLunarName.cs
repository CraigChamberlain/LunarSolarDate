﻿using System;
using System.Management.Automation;
using SolarLunarName.Standard.ApplicationServices;

namespace SolarLunarName.PoSH
{
    [Cmdlet(
        VerbsData.ConvertFrom, 
        "SolarLunarName",
        DefaultParameterSetName = "Object"
    )]
    public class ConvertFromSolarLunarName : PSCmdlet
    {   

        [Parameter(
            Position = 0, 
            Mandatory = true, 
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = "Object"
        )]
        [ValidateYear()]
        public int Year { get; set; }

        [Parameter(
            Position = 1, 
            Mandatory = true, 
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = "Object"
        )]
        [ValidateMonth()]
        public int Month  { get; set; }

        [Parameter(
            Position = 2, 
            Mandatory = true, 
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = "Object"
        )]
        [ValidateDay()]
        public int Day  { get; set; }

        [Parameter(
            Position = 0, 
            Mandatory = true, 
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = "String"
        )]
        public string SolarLunarDate  { get; set; }

        private SolarDateParser sdp;
        private DateTime gregorianCalendarDate;

        protected override void BeginProcessing(){

            sdp = new SolarDateParser();

        }

        protected override void ProcessRecord()
        {   
            if(ParameterSetName == "Object"){
                gregorianCalendarDate = 
                    sdp.ConvertRemoteSolarLunarName(Year, Month, Day);
            }
            else{
                gregorianCalendarDate = 
                    sdp.ConvertRemoteSolarLunarName(SolarLunarDate);
            }
            this.WriteObject(gregorianCalendarDate);
            base.EndProcessing();
        }
    }
}
    

