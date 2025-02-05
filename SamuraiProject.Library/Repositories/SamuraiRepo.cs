using SamuraiProject.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SamuraiProject.Library.Interface;

namespace SamuraiProject.Library.Repositories
{
    public class SamuraiRepo : ISamurai
    {
        DatabaseContext ctx;

        public SamuraiRepo(DatabaseContext context)
        {
            ctx = context;
        }

        public List<Samurai> GetSamurais()
        {
            return ctx.Samurai.ToList();
        }
    }
}
