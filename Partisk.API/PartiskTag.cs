using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partisk.API
{
    public class PartiskTag
    {
        /// <summary>
        /// Unique for all tags. Probably an int.
        /// </summary>
        [JsonProperty("id")]
        public string Id;
        /// <summary>
        /// The name of the tag. E.g. "skatt"
        /// </summary>
        [JsonProperty("name")]
        public string Name;
        /// <summary>
        /// True if the question is deleted from Partisk.nu.
        /// </summary>
        [JsonProperty("deleted")]
        public string Deleted;
        [JsonProperty("created_by")]
        public string CreatedBy;
        [JsonProperty("created_date")]
        public DateTime CreatedDate;
        [JsonProperty("updated_by")]
        public string UpdatedBy;
        [JsonProperty("updated_date")]
        public DateTime UpdatedDate;
        [JsonProperty("is_category")]
        public bool? IsCategory;
        /// <summary>
        /// Array of question id's
        /// </summary>
        [JsonProperty("questions")]
        public string[] Questions;
    }
}
