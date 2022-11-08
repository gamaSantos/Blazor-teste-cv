using System.Collections.Generic;

namespace Curriculum.Domain
{
    public class Description
    {
        public Description() { }
        public Description(string portugueseText, string englishText)
        {
            Texts = new Dictionary<string, string>(){
                {"pt", portugueseText},
                {"en", englishText}
            };
        }
        internal static string DEFAULT_CULTURE = "pt";
        public static string CURRENT_CULTURE = "pt";

        public Dictionary<string, string> Texts = new Dictionary<string, string>();

        public override string ToString()
        {
            if (Texts.ContainsKey(CURRENT_CULTURE)) return Texts[CURRENT_CULTURE];
            return Texts[DEFAULT_CULTURE];
        }
    }

    public class DescriptionCollection
    {
        public Dictionary<string, IEnumerable<string>> Texts;
        public DescriptionCollection(IEnumerable<string> pt, IEnumerable<string> en)
        {
            Texts = new Dictionary<string, IEnumerable<string>>()
            {
                {"pt", pt},
                {"en", en}
            };
        }

        public IEnumerable<string> GetValues()
        {
            if (Texts.ContainsKey(Description.CURRENT_CULTURE)) return Texts[Description.CURRENT_CULTURE];
            return Texts[Description.DEFAULT_CULTURE];
        }
    }
}