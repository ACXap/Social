using Newtonsoft.Json;

namespace vkpars.Data
{
    /// <summary>
    /// Партнер
    /// </summary>
    public class RelationPartner
    {
        /// <summary>
        /// Идентификатор пользователя.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }
}