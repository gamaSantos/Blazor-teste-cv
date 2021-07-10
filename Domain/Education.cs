using System;

namespace Curriculum.Domain
{
    public class Educations
    {
        public string Institution { get; set; }
        public string Course { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
    }
}