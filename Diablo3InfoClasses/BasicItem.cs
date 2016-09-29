using System.Runtime.Serialization;

namespace Codeforge.Diablo3InfoClasses
{
    [DataContract]
    public class BasicItem
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "icon")]
        public string Icon { get; set; }
        [DataMember(Name = "displayColor")]
        public string DisplayColor { get; set; }
        [DataMember(Name = "tooltipParams")]
        public string TooltipParams { get; set; }
    }
}
