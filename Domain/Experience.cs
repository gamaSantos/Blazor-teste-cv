using System;

namespace Curriculum.Domain
{
    public class Experience
    {
        public string Name { get; set; }
        public Description Role { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public string[] Activies { get; set; }
        public string[] Technologies { get; set; }
    }
}