using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace IttTune.Network
{
    class deteccionApi
    {
        // Clave de suscripción a la API de traducción de Azure
        private static readonly string key = "7a35de61b98f4b3796fba8757b1ae714";

        // Punto de conexión de la API de traducción de Azure
        private static readonly string endpoint = "https://api.cognitive.microsofttranslator.com";

        // Región en la que se encuentra el recurso de Azure
        private static readonly string location = "westus";

        public static async Task<string> SendDetectionRequest(string textToTranslate)
        {
            // Construye la ruta de la solicitud
            string route = "/detect?api-version=3.0";

            // Crea el cuerpo de la solicitud
            object[] body = new object[] { new { Text = textToTranslate } };
            string requestBody = JsonConvert.SerializeObject(body);

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                // Configura la solicitud
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(endpoint + route);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Headers.Add("Ocp-Apim-Subscription-Key", key);
                request.Headers.Add("Ocp-Apim-Subscription-Region", location);

                // Envía la solicitud y obtiene la respuesta
                HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);

                // Lee la respuesta como una cadena
                string result = await response.Content.ReadAsStringAsync();
                await Console.Out.WriteLineAsync("Respuesta leida");


                JObject jsonObject = JObject.Parse(result);

                
                    string detectedLanguage = jsonObject["detectedLanguage"]["language"].Value<string>();
                    await Console.Out.WriteLineAsync(detectedLanguage);

                    return detectedLanguage;
               
            }
        }
    }
}