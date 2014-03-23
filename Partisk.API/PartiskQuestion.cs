using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partisk.API
{
    public class PartiskQuestion
    {
        [JsonProperty("question_id")]
        public string QuestionId;
        [JsonProperty("title")]
        public string Title;
        [JsonProperty("type")]
        public string Type;
        [JsonProperty("description")]
        public string Description;
        [JsonProperty("created_date")]
        public DateTime CreatedDate;
        [JsonProperty("updated_date")]
        public DateTime UpdatedDate;
        [JsonProperty("answers")]
        public PartiskAnswer[] Answers;
        [JsonProperty("tags")]
        public PartiskTag[] Tags;
    }
}
