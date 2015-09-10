﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforge.Diablo3Info
{
    /// <summary>
    /// Contains request parameters used for making API calls
    /// </summary>
    public static class RequestParameters
    {
        //personal API key
        public static string APIKEY = "&apikey=";
        public static string LOCALE = "?locale=";

        //list of available followers
        public enum FOLLOWERS
        {
            TEMPLAR,
            ENCHANTRESS,
            SCOUNDREL
        }

        //list of available artisans
        public enum ARTISANS
        {
            MYSTIC,
            BLACKSMITH,
            JEWELER
        }

        //list of available regions
        public enum REGIONS
        {
            EU,
            US,
            CHINA,
            TAIWAN,
            KOREA,
            SEA
        }
    }
}
