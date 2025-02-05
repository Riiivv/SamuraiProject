using SamuraiProject.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SamuraiProject.Library.Interface;

namespace SamuraiProject.Library.Repositories
{
    public class HorseRepo : IHorse
    {
        DatabaseContext ctx;

        public HorseRepo(DatabaseContext context)
        {
            ctx = context;
        }

        public List<Horse> GetHorses()
        {
            return ctx.Horse.ToList();
        }

        public Samurai GetSamuraiByHorse(int horseId)
        {
            return ctx.Horse.Where(h => h.Id == horseId).Select(h => h.Samurai).FirstOrDefault();
        }
    }
}
