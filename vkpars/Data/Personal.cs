using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vkpars.Data
{
    /// <summary>
    /// Информация о полях из раздела «Жизненная позиция»
    /// </summary>
    public class Personal
    {
        /// <summary>
        /// Политические предпочтения
        /// 1 — коммунистические; 2 — социалистические;
        /// 3 — умеренные; 4 — либеральные;    
        /// 5 — консервативные; 6 — монархические;       
        /// 7 — ультраконсервативные; 8 — индифферентные;  
        /// 9 — либертарианские
        /// </summary>
        [JsonProperty("political")]
        public int Political { get; set; }

        /// <summary>
        /// Языки
        /// </summary>
        [JsonProperty("langs")]
        public List<string> Langs { get; set; }
        
        /// <summary>
        /// Мировоззрение
        /// </summary>
        [JsonProperty("religion")]
        public string Religion { get; set; }

        /// <summary>
        /// Идентификатор мировоззрения
        /// </summary>
        [JsonProperty("religion_id")]
        public int ReligionId { get; set; }

        /// <summary>
        /// Источники вдохновения
        /// </summary>
        [JsonProperty("inspired_by")]
        public string InspiredBy { get; set; }

        /// <summary>
        /// Главное в людях
        /// 1 — ум и креативность; 2 — доброта и честность;
        /// 3 — красота и здоровье; 4 — власть и богатство;
        /// 5 — смелость и упорство; 6 — юмор и жизнелюбие
        /// </summary>
        [JsonProperty("people_main")]
        public int PeopleMain { get; set; }

        /// <summary>
        /// Главное в жизни
        /// 1 — семья и дети; 2 — карьера и деньги;
        /// 3 — развлечения и отдых; 4 — наука и исследования;
        /// 5 — совершенствование мира; 6 — саморазвитие;
        /// 7 — красота и искусство; 8 — слава и влияние
        /// </summary>
        [JsonProperty("life_main")]
        public int LifeMain { get; set; }

        /// <summary>
        /// Отношение к курению
        /// 1 — резко негативное; 2 — негативное;
        /// 3 — компромиссное; 4 — нейтральное;
        /// 5 — положительное
        /// </summary>
        [JsonProperty("smoking")]
        public int Smoking { get; set; }

        /// <summary>
        /// Отношение к алкоголю
        ///1 — резко негативное; 2 — негативное;
        ///3 — компромиссное; 4 — нейтральное;
        ///5 — положительное
        /// </summary>
        [JsonProperty("alcohol")]
        public int Alcohol { get; set; }

        public string LangToString()
        {
            if (Langs == null || !Langs.Any()) return null;

            var s = new StringBuilder();
            foreach (var item in Langs)
            {
                s.Append($"{item},");
            }

            return s.ToString().TrimEnd(new char[] { ',' });
        }
    }
}