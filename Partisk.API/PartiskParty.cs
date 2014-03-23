using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partisk.API
{
    public class PartiskParty
    {
        [JsonProperty("id")]
        public string Id;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("website")]
        public string Website;
        [JsonProperty("color")]
        public string Color;
        [JsonProperty("created_by")]
        public string CreatedBy;
        [JsonProperty("deleted")]
        public bool Deleted;
        [JsonProperty("last_result_parliment")]
        public string LastResultParliment;
        [JsonProperty("last_result_eu")]
        public string LastResultEU;
        [JsonProperty("updated_by")]
        public string UpdatedBy;
        [JsonProperty("created_date")]
        public DateTime CreatedDate;
        [JsonProperty("updated_date")]
        public DateTime UpdateDate;
        [JsonProperty("description")]
        public string Description;
        [JsonProperty("short_name")]
        public string ShortName;
        [JsonProperty("best_result")]
        public string BestResult;
        [JsonProperty("answers")]
        public PartiskAnswer[] Answers;
    }
}
