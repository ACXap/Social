using Newtonsoft.Json;
using System.Collections.Generic;
using vkpars.Data;

namespace vkpars.Repository
{
    public class Response
    {
        /// <summary>
        /// Response
        /// </summary>
        [JsonProperty("response")]
        public List<EntityPerson> CollectionPerson { get; set; }
    }
}