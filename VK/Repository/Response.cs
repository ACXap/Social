using Newtonsoft.Json;
using System.Collections.Generic;
using VK.Data;

namespace VK.Repository
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