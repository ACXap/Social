using Newtonsoft.Json;

namespace vkpars.Data
{
    /// <summary>
    /// Родственник
    /// </summary>
    public class Relative
    {
        /// <summary>
        /// Идентификатор пользователя.
        /// Если родственник не является пользователем ВКонтакте, то предыдущее значение id возвращено не будет
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Имя родственника
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Тип родственной связи
        /// child — сын/дочь; sibling — брат/сестра;
        /// parent — отец/мать; grandparent — дедушка/бабушка;
        /// grandchild — внук/внучка.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}