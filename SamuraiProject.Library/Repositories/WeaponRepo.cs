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
        public Samurai GetSamuraiByWeapon(int weaponId)
        {
            return ctx.Weapons.Where(w => w.Id == weaponId).Select(w => w.Samurai).FirstOrDefault();
        }
        public SamuraiAndHorse GetSamuraiAndHorseByWeapon(int WeaponId)
        {
            Samurai test1 = ctx.Weapons.Where(w => w.Id == WeaponId).Select(w => w.Samurai).FirstOrDefault();

            Horse test2 = ctx.Horse.Where(h => h.SamuraiId == test1.Id).FirstOrDefault();

            SamuraiAndHorse SaH1 = new();
            SaH1.Samurai = test1;
            SaH1.Horse = test2;
            return SaH1;
        }
    }
}
