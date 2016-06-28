using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Codeforge.Diablo3InfoClasses
{
    /// <summary>
    /// Contains artisan data
    /// </summary>
    [DataContract]
    public class ArtisanInfo
    {
        [DataMember(Name = "slug")]
        public string Slug { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "portrait")]
        public string Portrait { get; set; }
        [DataMember(Name = "training")]
        public Training TrainingInfo { get; set; }

        [DataContract]
        public class Recipe
        {
            [DataMember(Name = "id")]
            public string Id { get; set; }
            [DataMember(Name = "slug")]
            public string Slug { get; set; }
            [DataMember(Name = "name")]
            public string Name { get; set; }
            [DataMember(Name = "cost")]
            public int Cost { get; set; }
            [DataMember(Name = "reagents")]
            public List<Reagent> Reagents { get; set; }
        }

        [DataContract]
        public class Reagent
        {
            [DataMember(Name = "quantity")]
            public int Quantity { get; set; }
            [DataMember(Name = "item")]
            public Item Item { get; set; }
        }

        [DataContract]
        public class Item : BasicItem
        {
            
        }

        [DataContract]
        public class Level
        {
            [DataMember(Name = "tier")]
            public int Tier { get; set; }
            [DataMember(Name = "tierLevel")]
            public int TierLevel { get; set; }
            [DataMember(Name = "percent")]
            public int Percent { get; set; }
            [DataMember(Name = "trainedRecipes")]
            public List<Recipe> TrainedRecipes { get; set; }
            [DataMember(Name = "taughtRecipes")]
            public List<Recipe> TaughtRecipes { get; set; }
            [DataMember(Name = "upgradeCost")]
            public int UpgradeCost { get; set; }
            [DataMember(Name = "upgradeItems")]
            public List<object> UpgradeItems { get; set; }
        }

        [DataContract]
        public class Tier
        {
            [DataMember(Name = "tier")]
            public int TierValue { get; set; }
            [DataMember(Name = "levels")]
            public List<Level> Levels { get; set; }
        }

        [DataContract]
        public class Training
        {
            [DataMember(Name = "tiers")]
            public List<Tier> Tiers { get; set; }
        }
    }
}
