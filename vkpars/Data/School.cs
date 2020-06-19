using Newtonsoft.Json;

namespace vkpars.Data
{
    /// <summary>
    /// Школа
    /// </summary>
    public class School
    {
        /// <summary>
        /// Идентификатор школы
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор страны, в которой расположена школа
        /// </summary>
        [JsonProperty("country")]
        public int Country { get; set; }

        /// <summary>
        /// Идентификатор города, в котором расположена школа
        /// </summary>
        [JsonProperty("city")]
        public int City { get; set; }

        /// <summary>
        /// Наименование школы
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Год начала обучения
        /// </summary>
        [JsonProperty("year_from")]
        public int YearFrom { get; set; }

        /// <summary>
        /// Год окончания обучения
        /// </summary>
        [JsonProperty("year_to")]
        public int YearTo { get; set; }

        /// <summary>
        /// Год выпуска
        /// </summary>
        [JsonProperty("year_graduated")]
        public int YearGraduated { get; set; }

        /// <summary>
        /// Буква класса
        /// </summary>
        [JsonProperty("class")]
        public string ClassLatter { get; set; }
       
        /// <summary>
        /// Специализация
        /// </summary>
        [JsonProperty("speciality")]
        public string Speciality { get; set; }

        /// <summary>
        /// Идентификатор типа
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// Название типа
        /// 0 — "школа"; n1 — "гимназия";
        /// 2 —"лицей"; 3 — "школа-интернат";
        /// 4 — "школа вечерняя"; 5 — "школа музыкальная";
        /// 6 — "школа спортивная"; 7 — "школа художественная";
        /// 8 — "колледж"; 9 — "профессиональный лицей";
        /// 10 — "техникум"; 11 — "ПТУ";
        /// 12 — "училище"; 13 — "школа искусств"
        /// </summary>
        [JsonProperty("type_str")]
        public string TypeStr { get; set; }
    }
}