using Newtonsoft.Json;

namespace VK.Data
{
    /// <summary>
    /// Университет
    /// </summary>
    public class University
    {
        /// <summary>
        /// Идентификатор университета
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор страны, в которой расположен университет
        /// </summary>
        [JsonProperty("country")]
        public int Country { get; set; }

        /// <summary>
        /// Идентификатор города, в котором расположен университет
        /// </summary>
        [JsonProperty("city")]
        public int City { get; set; }

        /// <summary>
        /// Наименование университета
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Идентификатор факультета
        /// </summary>
        [JsonProperty("faculty")]
        public int Faculty { get; set; }

        /// <summary>
        /// Наименование факультета
        /// </summary>
        [JsonProperty("faculty_name")]
        public string FacultyName { get; set; }

        /// <summary>
        /// Идентификатор кафедры
        /// </summary>
        [JsonProperty("chair")]
        public int Chair { get; set; }

        /// <summary>
        /// Наименование кафедры
        /// </summary>
        [JsonProperty("chair_name")]
        public string ChairName { get; set; }

        /// <summary>
        /// Год окончания обучения
        /// </summary>
        [JsonProperty("graduation")]
        public int Graduation { get; set; }

        /// <summary>
        /// Форма обучения
        /// </summary>
        [JsonProperty("education_form")]
        public string EducationForm { get; set; }

        /// <summary>
        /// Статус(например, «Выпускник (специалист)»)
        /// </summary>
        [JsonProperty("education_status")]
        public string EducationStatus { get; set; }
    }
}