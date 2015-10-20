using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Police.Core
{
    public class StreetLevelCrimes
    {
        [JsonProperty("category")]
        public string Category{ get; set; }
        [JsonProperty("persistant_id")]
        public string PersistentId { get; set; }
        [JsonProperty("location_type")]
        public string LocationType { get; set; }
        [JsonProperty("location_subtype")]
        public string LocationSubType { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("location")]
        public Location Location { get; set; }
        [JsonProperty("context")]
        public string Context { get; set; }
        [JsonProperty("month")]
        public string Month { get; set; }
        [JsonProperty("outcome_status")]
        public OutcomeStatus OutcomeStatus { get; set; }
    }

    public class Location
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }
        [JsonProperty("longitude")]
        public string Longitude { get; set; }
        [JsonProperty("street")]
        public Street Street { get; set; }
    }

    public class Street
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OutcomeStatus
    {
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class CategoryGroup
    {
        public string Category { get; set; }
        public int Count { get; set; }
    }
}
