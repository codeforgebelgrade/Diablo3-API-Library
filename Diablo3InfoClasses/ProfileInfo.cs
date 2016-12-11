using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Codeforge.Diablo3InfoClasses
{
    /// <summary>
    /// This class contains player's career profile information
    /// </summary>
    [DataContract]
    public class ProfileInfo
    {
        // The following properties (Code and Reason) are used only if the account is not found.
        // If the parameters used for this request are in proper format, but their values are wrong,
        // the service will still responde with 200OK, but the response will contain only these two fields.
        [DataMember(Name="code")]
        public String Code { get; set; }
        [DataMember(Name = "reason")]
        public String Reason { get; set; }
        
        [DataMember(Name = "battleTag")]
        public string BattleTag { get; set; }
        [DataMember(Name = "paragonLevel")]
        public int? ParagonLevel { get; set; }
        [DataMember(Name = "paragonLevelHardcore")]
        public int? ParagonLevelHardcore { get; set; }
        [DataMember(Name = "paragonLevelSeason")]
        public int? ParagonLevelSeason { get; set; }
        [DataMember(Name = "paragonLevelSeasonHardcore")]
        public int? ParagonLevelSeasonHardcore { get; set; }
        [DataMember(Name = "heroes")]
        public List<Hero> Heroes { get; set; }
        [DataMember(Name = "lastHeroPlayed")]
        public int? LastHeroPlayed { get; set; }
        [DataMember(Name = "lastUpdated")]
        public int? LastUpdated { get; set; }
        [DataMember(Name = "kills")]
        public Kills KillsInfo { get; set; }
        [DataMember(Name = "highestHardcoreLevel")]
        public int? HighestHardcoreLevel { get; set; }
        [DataMember(Name = "timePlayed")]
        public TimePlayed TimePlayedInfo { get; set; }
        [DataMember(Name = "progression")]
        public Progression ProgressionInfo { get; set; }
        [DataMember(Name = "fallenHeroes")]
        public List<object> FallenHeroes { get; set; }
        [DataMember(Name = "blacksmith")]
        public Blacksmith BlacksmithInfo { get; set; }
        [DataMember(Name = "jeweler")]
        public Jeweler JewelerInfo { get; set; }
        [DataMember(Name = "mystic")]
        public Mystic MysticInfo { get; set; }
        [DataMember(Name = "blacksmithHardcore")]
        public BlacksmithHardcore BlacksmithHardcoreInfo { get; set; }
        [DataMember(Name = "jewelerHardcore")]
        public JewelerHardcore JewelerHardcoreInfo { get; set; }
        [DataMember(Name = "mysticHardcore")]
        public MysticHardcore MysticHardcoreInfo { get; set; }
        [DataMember(Name = "seasonalProfiles")]
        public SeasonalProfiles SeasonalProfilesInfo { get; set; }

        [DataContract]
        public class Hero
        {
            [DataMember(Name = "paragonLevel")]
            public int ParagonLevel { get; set; }
            [DataMember(Name = "seasonal")]
            public bool Seasonal { get; set; }
            [DataMember(Name = "name")]
            public string Name { get; set; }
            [DataMember(Name = "id")]
            public int Id { get; set; }
            [DataMember(Name = "level")]
            public int Level { get; set; }
            [DataMember(Name = "hardcore")]
            public bool Hardcore { get; set; }
            [DataMember(Name = "nvalidNameLastUpdated")]
            public int InvalidNameLastUpdated { get; set; }
            [DataMember(Name = "gender")]
            public int Gender { get; set; }
            [DataMember(Name = "dead")]
            public bool Dead { get; set; }
            [DataMember(Name = "class")]
            public string CharacterClass { get; set; }
        }

        [DataContract]
        public class Kills
        {
            [DataMember(Name = "monsters")]
            public int Monsters { get; set; }
            [DataMember(Name = "elites")]
            public int Elites { get; set; }
            [DataMember(Name = "hardcoreMonsters")]
            public int HardcoreMonsters { get; set; }
        }

        [DataContract]
        public class TimePlayed
        {
            [DataMember(Name = "barbarian")]
            public double Barbarian { get; set; }
            [DataMember(Name = "crusader")]
            public double Crusader { get; set; }
            [DataMember(Name = "invalidNameDemonHunter")]
            public double InvalidNameDemonHunter { get; set; }
            [DataMember(Name = "monk")]
            public double Monk { get; set; }
            [DataMember(Name = "invalidNameWitchDoctor")]
            public double InvalidNameWitchDoctor { get; set; }
            [DataMember(Name = "wizard")]
            public double Wizard { get; set; }
        }

        [DataContract]
        public class Progression
        {
            [DataMember(Name = "act1")]
            public bool Act1 { get; set; }
            [DataMember(Name = "act2")]
            public bool Act2 { get; set; }
            [DataMember(Name = "act3")]
            public bool Act3 { get; set; }
            [DataMember(Name = "act4")]
            public bool Act4 { get; set; }
            [DataMember(Name = "act5")]
            public bool Act5 { get; set; }
        }

        [DataContract]
        public abstract class ArtisanInfo
        {
            [DataMember(Name = "slug")]
            public string Slug { get; set; }
            [DataMember(Name = "level")]
            public int Level { get; set; }
            [DataMember(Name = "stepCurrent")]
            public int StepCurrent { get; set; }
            [DataMember(Name = "stepMax")]
            public int StepMax { get; set; }
        }

        [DataContract]
        public class Blacksmith : ArtisanInfo
        {
            
        }

        [DataContract]
        public class Jeweler : ArtisanInfo
        {
            
        }

        [DataContract]
        public class Mystic : ArtisanInfo
        {
            
        }

        [DataContract]
        public class BlacksmithHardcore : ArtisanInfo
        {
            
        }

        [DataContract]
        public class JewelerHardcore : ArtisanInfo
        {
            
        }

        [DataContract]
        public class MysticHardcore : ArtisanInfo
        {
            
        }

        [DataContract]
        public class Season
        {
            [DataMember(Name = "seasonId")]
            public int SeasonId { get; set; }
            [DataMember(Name = "paragonLevel")]
            public int ParagonLevel { get; set; }
            [DataMember(Name = "paragonLevelHardcore")]
            public int ParagonLevelHardcore { get; set; }
            [DataMember(Name = "kills")]
            public Kills Kills { get; set; }
            [DataMember(Name = "timePlayed")]
            public TimePlayed TimePlayed { get; set; }
            [DataMember(Name = "highestHardcoreLevel")]
            public int HighestHardcoreLevel { get; set; }
            [DataMember(Name = "progression")]
            public Progression Progression { get; set; }
        }

        [DataContract]
        public class SeasonalProfiles
        {
            [DataMember(Name = "season0")]
            public Season Season0 { get; set; }
            [DataMember(Name = "season1")]
            public Season Season1 { get; set; }
            [DataMember(Name = "season2")]
            public Season Season2 { get; set; }
            [DataMember(Name = "season3")]
            public Season Season3 { get; set; }
            [DataMember(Name = "season4")]
            public Season Season4 { get; set; }
            [DataMember(Name = "season5")]
            public Season Season5 { get; set; }
            [DataMember(Name = "season6")]
            public Season Season6 { get; set; }
            [DataMember(Name = "season7")]
            public Season Season7 { get; set; }
            [DataMember(Name = "season8")]
            public Season Season8 { get; set; }
            [DataMember(Name = "season9")]
            public Season Season9 { get; set; }
        }
    }
}
