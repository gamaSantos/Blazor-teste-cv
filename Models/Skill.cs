namespace dinamico
{
    public class Skill
    {
        public string Name { get; set; }
        public uint Grade { get; set; }
        public string Description { get; set; }
        public SkillType Type{get;set;}
    }

    public enum SkillType
    {
        Specific, Soft
    }
}