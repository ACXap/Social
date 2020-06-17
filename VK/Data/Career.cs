using Newtonsoft.Json;

namespace VK.Data
{
    /// <summary>
    /// Информация о карьере пользователя
    /// </summary>
    public class Career
    {
        /// <summary>
        /// Название компании(если доступно, иначе group_id)
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// Идентификатор страны
        /// </summary>
        [JsonProperty("country_id")]
        public int CountryId { get; set; }

        /// <summary>
        /// Идентификатор города(если доступно, иначе city_name)
        /// </summary>
        [JsonProperty("city")]
        public int CityId { get; set; }

        /// <summary>
        /// Название города(если доступно, иначе city_id)
        /// </summary>
        [JsonProperty("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        [JsonProperty("position")]
        public string Position { get; set; }

        /// <summary>
        /// Год начала работы
        /// </summary>
        [JsonProperty("from")]
        public int From { get; set; }
       
        /// <summary>
        /// Год окончания работы
        /// </summary>
        [JsonProperty("until")]
        public int Until { get; set; }

        /// <summary>
        /// Идентификатор сообщества(если доступно, иначе company)
        /// </summary>
        [JsonProperty("group_id")]
        public int GroupId { get; set; }
    }
}