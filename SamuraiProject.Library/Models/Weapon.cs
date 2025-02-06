using SamuraiProject.Library.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
namespace SamuraiProject.Library.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int samuraiId { get; set; }

        [ForeignKey("SamuraiId")]
        [JsonIgnore]
        public virtual Samurai? Samurai { get; set; }

    }
}
