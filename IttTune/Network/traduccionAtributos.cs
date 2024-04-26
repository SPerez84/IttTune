using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IttTune.Network
{

    public class TranslationRequest
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("to")]
        public string TargetLanguage { get; set; }

        // Agrega esta propiedad si la API de Azure requiere el idioma de origen
        // [JsonProperty("from")]
        // public string SourceLanguage { get; set; }
    }

    /*
     [{
    "detectedLanguage": {
        "language": "en",
        "score": "1"
    }
    "translations": [{
        "text": "Hola",
        "to": "es"
    }]
}]
     */
}
