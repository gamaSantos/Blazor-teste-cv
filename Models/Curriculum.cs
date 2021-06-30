using System.Collections.Generic;

namespace dinamico
{
    public class Curriculum
    {
        public Curriculum()
        {
            Experiences = new List<Experience>();
            Skills = new List<Skill>();
            Educations = new List<Educations>();
        }
        public Person Owner { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Educations> Educations { get; set; }

    }
}