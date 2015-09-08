using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Codeforge.Diablo3InfoClasses
{
    /// <summary>
    /// Contains follower information
    /// </summary>
    [DataContract]
    public class FollowerInfo
    {
        [DataMember(Name="slug")]
        public string Slug { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "realName")]
        public string RealName { get; set; }
        [DataMember(Name = "portrait")]
        public string Portrait { get; set; }
        [DataMember(Name = "skills")]
        public Skills SkillsInfo { get; set; }

        [DataContract]
        public class Skills
        {
            [DataMember(Name = "active")]
            public List<Active> Active { get; set; }
            [DataMember(Name = "passive")]
            public List<Passive> Passive { get; set; }
        }

        [DataContract]
        public class Active
        {
            [DataMember(Name = "slug")]
            public string slug { get; set; }
            [DataMember(Name = "name")]
            public string name { get; set; }
            [DataMember(Name = "icon")]
            public string icon { get; set; }
            [DataMember(Name = "level")]
            public int level { get; set; }
            [DataMember(Name = "tooltipUrl")]
            public string tooltipUrl { get; set; }
            [DataMember(Name = "description")]
            public string description { get; set; }
            [DataMember(Name = "simpleDescription")]
            public string simpleDescription { get; set; }
            [DataMember(Name = "skillCalcId")]
            public string skillCalcId { get; set; }
        }

        [DataContract]
        public class Passive
        {
            [DataMember(Name = "slug")]
            public string slug { get; set; }
            [DataMember(Name = "name")]
            public string name { get; set; }
            [DataMember(Name = "icon")]
            public string icon { get; set; }
            [DataMember(Name = "level")]
            public int level { get; set; }
            [DataMember(Name = "tooltipUrl")]
            public string tooltipUrl { get; set; }
            [DataMember(Name = "description")]
            public string description { get; set; }
            [DataMember(Name = "simpleDescription")]
            public string simpleDescription { get; set; }
            [DataMember(Name = "skillCalcId")]
            public string skillCalcId { get; set; }
        }
    }
}
