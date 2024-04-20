using BestPractices.Services.DIP.Interfaces;

namespace BestPractices.Services.DIP
{
    public class FrenchTranslator : ITranslator 
    {
        IDictionary<string, string> translations = new Dictionary<string, string>();
        public string Translate(string input)
        {
            string translation;
            translations.TryGetValue(input, out translation);
            return translation;
        }
    }
}
