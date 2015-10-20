using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Police.Core
{
    public class Service
    {
        public async Task<List<StreetLevelCrimes>> GetCrimes()
        {
            var request = new Uri("https://data.police.uk/api/crimes-street/all-crime?lat=52.629729&lng=-1.131592&date=2015-01");
            var result = new List<StreetLevelCrimes>();

            var client = new HttpClient();
            var response = await client.GetAsync(request);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            
            result = JsonConvert.DeserializeObject<List<StreetLevelCrimes>>(content);
            
            return result;
        }

        public async Task<IEnumerable<CategoryGroup>> GroupCategories()
        {
            var crimes = await GetCrimes();
            var query = from c in crimes
                        orderby c.Category
                        group c.Category by c.Category into grp
                        select new CategoryGroup { Category = grp.Key, Count = grp.Count() };
            
            return query;
        }
    }
}
