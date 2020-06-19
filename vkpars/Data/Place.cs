using Newtonsoft.Json;

namespace vkpars.Data
{

    public class Place
    {
        /// <summary>
        /// Идентификатор места
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Название места
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}