using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamuraiProject.Library.Models;

namespace SamuraiProject.Library.Interface
{
    internal interface IHorse
    {
        public List<Horse> GetHorses();
        public Samurai GetSamuraiByHorse(int horseId);
        public List<Horse> GetHorsesByName(string name);
        public Horse GetHorseById(int id);
    }
}
