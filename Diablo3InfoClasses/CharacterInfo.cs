using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Codeforge.Diablo3InfoClasses
{
    /// <summary>
    /// Contains information for the selected character
    /// </summary>
    [DataContract]
    public class CharacterInfo
    {
        // The following properties (Code and Reason) are used only if the character is not found.
        // If the parameters used for this request are in proper format, but their values are wrong,
        // the service will still respond with 200OK, but the response will contain only these two fields.
        [DataMember(Name = "code")]
        public String Code { get; set; }
        [DataMember(Name = "reason")]
        public String Reason { get; set; }

        [DataMember(Name = "id", Order = 0)]
        public int Id { get; set; }
        [DataMember(Name = "name", Order = 1)]
        public string Name { get; set; }
        [DataMember(Name = "class", Order = 2)]
        public string @Class { get; set; }
        [DataMember(Name = "gender", Order = 3)]
        public int? Gender { get; set; }
        [DataMember(Name = "level", Order = 4)]
        public int? Level { get; set; }
        [DataMember(Name = "kills", Order = 5)]
        public Kills KillsInfo { get; set; }
        [DataMember(Name = "paragonLevel", Order = 6)]
        public int? ParagonLevel { get; set; }
        [DataMember(Name = "hardcore")]
        public bool? Hardcore { get; set; }
        [DataMember(Name = "seasonal")]
        public bool? Seasonal { get; set; }
        [DataMember(Name = "seasonCreated")]
        public int? SeasonCreated { get; set; }
        [DataMember(Name = "skills")]
        public Skills SkillsInfo { get; set; }
        [DataMember(Name = "items")]
        public Items ItemsInfo { get; set; }
        [DataMember(Name = "followers")]
        public Followers FollowersInfo { get; set; }
        [DataMember(Name = "stats")]
        public Stats StatsInfo { get; set; }
        [DataMember(Name = "progression")]
        public Progression ProgressionInfo { get; set; }
        [DataMember(Name = "dead")]
        public bool? Dead { get; set; }
        [DataMember(Name = "invalid_name_last_updated")]
        public int? InvalidNameLastUpdated { get; set; }
        [DataMember(Name = "legendaryPowers")]
        public LegendaryPower[] legendaryPowers { get; set; }

        [DataContract]
        public class Skills
        {
            [DataMember(Name = "active")]
            public List<Active> Active { get; set; }
            [DataMember(Name = "passive")]
            public List<Passive> Passive { get; set; }
        }

        [DataContract]
        public class Skill
        {
            [DataMember(Name = "slug")]
            public string slug { get; set; }
            [DataMember(Name = "name")]
            public string name { get; set; }
            [DataMember(Name = "icon")]
            public string icon { get; set; }
            [DataMember(Name = "level")]
            public int level { get; set; }
            [DataMember(Name = "categorySlug")]
            public string categorySlug { get; set; }
            [DataMember(Name = "tooltipUrl")]
            public string tooltipUrl { get; set; }
            [DataMember(Name = "description")]
            public string description { get; set; }
            [DataMember(Name = "flavor")]
            public string flavor { get; set; }
            [DataMember(Name = "simpleDescription")]
            public string simpleDescription { get; set; }
            [DataMember(Name = "skillCalcId")]
            public string skillCalcId { get; set; }
        }
        [DataContract]
        public class Rune
        {
            [DataMember(Name = "slug")]
            public string Slug { get; set; }
            [DataMember(Name = "type")]
            public string Type { get; set; }
            [DataMember(Name = "name")]
            public string Name { get; set; }
            [DataMember(Name = "level")]
            public int Level { get; set; }
            [DataMember(Name = "description")]
            public string Description { get; set; }
            [DataMember(Name = "simpleDescription")]
            public string SimpleDescription { get; set; }
            [DataMember(Name = "tooltipParams")]
            public string TooltipParams { get; set; }
            [DataMember(Name = "skillCalcId")]
            public string SkillCalcId { get; set; }
            [DataMember(Name = "order")]
            public int Order { get; set; }
        }

        [DataContract]
        public class Active
        {
            [DataMember(Name = "skill")]
            public Skill Skill { get; set; }
            [DataMember(Name = "rune")]
            public Rune Rune { get; set; }
        }

        [DataContract]
        public class Passive
        {
            [DataMember(Name = "skill")]
            public Skill Skill;
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
            [DataMember(Name = "recipe")]
            public Recipe Recipe { get; set; }
            [DataMember(Name = "transmogItem")]
            public Item TransmogItem { get; set; }
            [DataMember(Name = "craftedBy")]
            public List<CraftedBy> CraftedBy { get; set; }
        }

        [DataContract]
        public class ItemProduced : BasicItem
        {
            
        }

        [DataContract]
        public class LegendaryPower : BasicItem
        {

        }

        [DataContract]
        public class CraftedBy
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
            [DataMember(Name = "itemProduced")]
            public ItemProduced ItemProduced { get; set; }
        }

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
            [DataMember(Name = "itemProduced")]
            public ItemProduced ItemProduced { get; set; }
        }

        [DataContract]
        public class Items
        {
            [DataMember(Name = "special")]
            public Item Special { get; set; }
            [DataMember(Name = "head")]
            public Item Head { get; set; }
            [DataMember(Name = "torso")]
            public Item Torso { get; set; }
            [DataMember(Name = "feet")]
            public Item Feet { get; set; }
            [DataMember(Name = "hands")]
            public Item Hands { get; set; }
            [DataMember(Name = "shoulders")]
            public Item Shoulders { get; set; }
            [DataMember(Name = "legs")]
            public Item Legs { get; set; }
            [DataMember(Name = "bracers")]
            public Item Bracers { get; set; }
            [DataMember(Name = "mainHand")]
            public Item MainHand { get; set; }
            [DataMember(Name = "offHand")]
            public Item OffHand { get; set; }
            [DataMember(Name = "waist")]
            public Item Waist { get; set; }
            [DataMember(Name = "rightFinger")]
            public Item RightFinger { get; set; }
            [DataMember(Name = "leftFinger")]
            public Item LeftFinger { get; set; }
            [DataMember(Name = "neck")]
            public Item Neck { get; set; }
        }

        [DataContract]
        public class Followers
        {
            [DataMember(Name = "templar")]
            public Follower Templar { get; set; }
            [DataMember(Name = "scoundrel")]
            public Follower Scoundrel { get; set; }
            [DataMember(Name = "enchantress")]
            public Follower Enchantress { get; set; }
        }

        [DataContract]
        public class Follower
        {
            [DataMember(Name = "slug")]
            public string Slug { get; set; }
            [DataMember(Name = "level")]
            public int Level { get; set; }
            [DataMember(Name = "items")]
            public Items Items { get; set; }
            [DataMember(Name = "stats")]
            public Stats Stats { get; set; }
            [DataMember(Name = "skills")]
            public List<Passive> Skills { get; set; }
        }

        [DataContract]
        public class Stats
        {
            [DataMember(Name = "life")]
            public int Life { get; set; }
            [DataMember(Name = "damage")]
            public double Damage { get; set; }
            [DataMember(Name = "toughness")]
            public double Toughness { get; set; }
            [DataMember(Name = "healing")]
            public double Healing { get; set; }
            [DataMember(Name = "attackSpeed")]
            public double AttackSpeed { get; set; }
            [DataMember(Name = "armor")]
            public int Armor { get; set; }
            [DataMember(Name = "strength")]
            public int Strength { get; set; }
            [DataMember(Name = "dexterity")]
            public int Dexterity { get; set; }
            [DataMember(Name = "vitality")]
            public int Vitality { get; set; }
            [DataMember(Name = "intelligence")]
            public int Intelligence { get; set; }
            [DataMember(Name = "physicalResist")]
            public int PhysicalResist { get; set; }
            [DataMember(Name = "fireResist")]
            public int FireResist { get; set; }
            [DataMember(Name = "coldResist")]
            public int ColdResist { get; set; }
            [DataMember(Name = "lightningResist")]
            public int LightningResist { get; set; }
            [DataMember(Name = "poisonResist")]
            public int PoisonResist { get; set; }
            [DataMember(Name = "arcaneResist")]
            public int ArcaneResist { get; set; }
            [DataMember(Name = "critDamage")]
            public double CritDamage { get; set; }
            [DataMember(Name = "blockChance")]
            public double BlockChance { get; set; }
            [DataMember(Name = "blockAmountMin")]
            public int BlockAmountMin { get; set; }
            [DataMember(Name = "blockAmountMax")]
            public int BlockAmountMax { get; set; }
            [DataMember(Name = "damageIncrease")]
            public double DamageIncrease { get; set; }
            [DataMember(Name = "critChance")]
            public double CritChance { get; set; }
            [DataMember(Name = "damageReduction")]
            public double DamageReduction { get; set; }
            [DataMember(Name = "thorns")]
            public double Thorns { get; set; }
            [DataMember(Name = "lifeSteal")]
            public double LifeSteal { get; set; }
            [DataMember(Name = "lifePerKill")]
            public double LifePerKill { get; set; }
            [DataMember(Name = "goldFind")]
            public double GoldFind { get; set; }
            [DataMember(Name = "magicFind")]
            public double MagicFind { get; set; }
            [DataMember(Name = "lifeOnHit")]
            public double LifeOnHit { get; set; }
            [DataMember(Name = "primaryResource")]
            public int PrimaryResource { get; set; }
            [DataMember(Name = "secondaryResource")]
            public int SecondaryResource { get; set; }
        }

        [DataContract]
        public class Kills
        {
            [DataMember(Name = "elites")]
            public int Elites { get; set; }
        }

        [DataContract]
        public class CompletedQuest
        {
            [DataMember(Name = "slug")]
            public string Slug { get; set; }
            [DataMember(Name = "name")]
            public string Name { get; set; }
        }

        [DataContract]
        public class Act
        {
            [DataMember(Name = "completed")]
            public bool Completed { get; set; }
            [DataMember(Name = "completedQuests")]
            public List<CompletedQuest> CompletedQuests { get; set; }
        }

        [DataContract]
        public class Progression
        {
            [DataMember(Name = "act1")]
            public Act Act1 { get; set; }
            [DataMember(Name = "act2")]
            public Act Act2 { get; set; }
            [DataMember(Name = "act3")]
            public Act Act3 { get; set; }
            [DataMember(Name = "act4")]
            public Act Act4 { get; set; }
            [DataMember(Name = "act5")]
            public Act Act5 { get; set; }

        }
    }
}
