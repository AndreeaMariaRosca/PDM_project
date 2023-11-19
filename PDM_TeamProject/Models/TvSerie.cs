using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PDM_TeamProject.Classes
{
    public class TvSerie
    {
        public string first_air_date { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string original_language { get; set; }
        public string overview { get; set; }
        public float popularity { get; set; }
        public string poster_path { get; set; }
        public float vote_average { get; set; }
        
    }
}
