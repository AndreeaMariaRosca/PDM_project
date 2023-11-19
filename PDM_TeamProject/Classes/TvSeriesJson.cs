using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PDM_TeamProject.Classes
{
    public class TvSeriesJson
    {
        public int page { get; set; }
        public List<TvSerie> results { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
    }
}
