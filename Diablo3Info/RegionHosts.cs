using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforge.Diablo3Info
{
    /// <summary>
    /// Contains list of available region hosts
    /// Full list of supported region hosts can be found here: https://dev.battle.net/docs/read/community_apis
    /// </summary>
    internal static class RegionHosts
    {
        internal static string US = "https://us.api.battle.net";
        internal static string EUROPE = "https://eu.api.battle.net/";
        internal static string SEA = "https://sea.api.battle.net";
        internal static string KOREA = "https://kr.api.battle.net";
        internal static string TAIWAN = "https://tw.api.battle.net";
        internal static string CHINA = "https://api.battlenet.com.cn";
    }
}
