using SamuraiProject.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiProject.Library.Interface
{
    internal interface IWeapon
    {
        public List<Weapon> GetWeapons();
        public Samurai GetSamuraiByWeapon(int weaponId);
        public SamuraiAndHorse GetSamuraiAndHorseByWeapon(int WeaponId);
        public Weapon GetWeaponById(int id);
        public List<Weapon> GetWeaponsByName(string name);
        public List<Weapon> GetWeaponsByType(string type);
        public List<Weapon> GetWeaponsBySamurai(int samuraiId);
    }
}
