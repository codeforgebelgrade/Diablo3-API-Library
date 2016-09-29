using System.Runtime.Serialization;

namespace Codeforge.Diablo3InfoClasses
{
    [DataContract]
    public class BasicSkill
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
}
