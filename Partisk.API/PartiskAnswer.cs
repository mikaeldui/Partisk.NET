using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partisk.API
{
    public class PartiskAnswer
    {
        [JsonProperty("id")]
        public string Id;
        [JsonProperty("party_id")]
        public string PartyId;
        [JsonProperty("answer")]
        public string Answer;
        [JsonProperty("question_id")]
        public string QuestionId;
        [JsonProperty("approved")]
        public bool Approved;
        [JsonProperty("created_by")]
        public string CreatedBy;
        [JsonProperty("deleted")]
        public bool Deleted;
        [JsonProperty("description")]
        public string Description;
        [JsonProperty("source")]
        public string Source;
		
    }
}
