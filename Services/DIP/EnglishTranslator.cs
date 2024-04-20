using BestPractices.Services.DIP.Interfaces;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections;
using System.Collections.Generic;

namespace BestPractices.Services.DIP
{
    public class EnglishTranslator : ITranslator
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
