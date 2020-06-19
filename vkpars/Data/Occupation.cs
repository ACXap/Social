using Newtonsoft.Json;

namespace vkpars.Data
{
    /// <summary>
    /// Информация о текущем роде занятия пользователя
    /// </summary>
    public class Occupation
    {
        /// <summary>
        /// Тип
        /// work — работа; school — среднее образование; university — высшее образование
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Идентификатор школы, вуза, сообщества компании(в которой пользователь работает)
        /// </summary>
        [JsonProperty("Id")]
        public int Id { get; set; }

        /// <summary>
        /// Название школы, вуза или места работы
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}