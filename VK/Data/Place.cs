using Newtonsoft.Json;

namespace VK.Data
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