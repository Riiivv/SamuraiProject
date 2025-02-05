using SamuraiProject.Library.Interface;
using SamuraiProject.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiProject.Library.Repositories
{
    public class WeaponRepo : IWeapon
    {
        DatabaseContext ctx;

        public WeaponRepo(DatabaseContext context)
        {
            ctx = context;
        }
        public List<Weapon> GetWeapons()
        {
            return ctx.Weapons.ToList();
        }
    }
}
