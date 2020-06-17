using Newtonsoft.Json;

namespace VK.Data
{
    /// <summary>
    /// Информация о военной службе пользователя
    /// </summary>
    public class Military
    {
        /// <summary>
        /// Номер части
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Идентификатор части в базе данных
        /// </summary>
        [JsonProperty("unit_id")]
        public int UnitId { get; set; }

        /// <summary>
        /// Идентификатор страны, в которой находится часть
        /// </summary>
        [JsonProperty("country_id")]
        public int CountryId { get; set; }

        /// <summary>
        /// Год начала службы
        /// </summary>
        [JsonProperty("from")]
        public int From { get; set; }

        /// <summary>
        /// Год окончания службы
        /// </summary>
        [JsonProperty("until")]
        public int Until { get; set; }
    }
}