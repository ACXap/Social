using Newtonsoft.Json;

namespace vkpars.Data
{
    /// <summary>
    /// Время последнего посещения
    /// </summary>
    public class LastSeen
    {
        /// <summary>
        /// Время последнего посещения в формате Unixtime
        /// </summary>
        [JsonProperty("time")]
        public int Time { get; set; }

        /// <summary>
        /// Тип платформы. 
        /// 1 - мобильная версия; 2 - приложение для iPhone; 3 - приложение для iPad; 4 - приложение для Android
        /// 5 - приложение для Windows Phone; 6 - приложение для Windows 10; 7 - полная версия сайта
        /// </summary>
        [JsonProperty("platform")]
        public int Platform { get; set; }
    }
}
