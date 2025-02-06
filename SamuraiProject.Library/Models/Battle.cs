using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace SamuraiProject.Library.Models
{
    public class Battle
    {
        public int BattleId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        [ForeignKey("SamuraiId")]
        [JsonIgnore]
        public virtual List<Samurai>? Samurais { get; set; }
    }
}
