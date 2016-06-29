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
        public class Active : BasicSkill
        {
            
        }

        [DataContract]
        public class Passive : BasicSkill
        {
            
        }
    }
}
