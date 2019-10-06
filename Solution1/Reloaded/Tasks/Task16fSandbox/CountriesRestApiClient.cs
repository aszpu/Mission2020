using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16fSandbox
{
    public class CountriesRestApiClient
    {
        public async Task<CountryDto[]> GetCountries(string countryName)
        {
            var query = $"name/{countryName}";
            var countries = await GetData<CountryDto[]>(query);
            
            // nie podoba mi się ten kod, ale inaczej nie dałem rady... ;/
            var countriesTemp = new CountryDto[countries.Length];
            var j = 0;
            for(int i = 0; i < countries.Length; i++)
            {
                if (countries[i].Name.ToUpper().Contains(countryName.ToUpper()))
                {
                    countriesTemp[j] = countries[i];
                    j++;
                }
            }

            var countriesCorrected = new CountryDto[j];
            for(int i = 0; i < j; i++)
            {
                countriesCorrected[i] = countriesTemp[i];
            }
            // -----------------------------------------------------------
            
            if (countriesCorrected.Length == 0)
            {
                throw new Exception($"Nie udało się odnaleźć informacji na temat państwa: {countryName}.");
            }

            return countriesCorrected;
        }

        private async Task<T> GetData<T>(string query)
            where T : class // constraint nałożony na typ generyczny wymuszający aby jako typ generyczny podawać dowolną klasę
        {
            // tworzymy klienta http

            var client = new HttpClient();

            // tworzymy i przygotowujemy request http - strzał GET pod odpowiedni adres. Request musi mieć dołączone odpowiednie nagłówki http zgodnie z tym co tu napisano: https://rapidapi.com/apilayernet/api/rest-countries-v1

            var requestUri = $"https://restcountries-v1.p.rapidapi.com/{query}";
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            AppendRapidApiHttpRequestHeaders(request);

            // wysyłamy request (żądanie) i pobieramy response (odpowiedź) http.
            // oraz pobieramy zawartości odpowiedzi

            var responseTask = client.SendAsync(request);
            var response = await responseTask;
            var responseContent = await response.Content.ReadAsStringAsync();

            // deserializujemy treść odpowiedzi do przekazanego typu generycznego T (odpowiedzi przyjeżdżają z https://restcountries-v1.p.rapidapi.com w formacie JSON)

            var serializer = new DataContractJsonSerializer(typeof(T));
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(responseContent));
            var data = serializer.ReadObject(stream) as T;
            return data;
        }

        private void AppendRapidApiHttpRequestHeaders(HttpRequestMessage httpRequestMessage)
        {
            httpRequestMessage.Headers.Add("x-rapidapi-host", "restcountries-v1.p.rapidapi.com");
            httpRequestMessage.Headers.Add("x-rapidapi-key", "02e933c494mshd699fecee0021fdp1315d0jsn62f6eff166fd");
        }
    }
}
