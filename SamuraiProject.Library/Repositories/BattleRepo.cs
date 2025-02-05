﻿using Microsoft.EntityFrameworkCore.Storage;
using SamuraiProject.Library.Interface;
using SamuraiProject.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiProject.Library.Repositories
{
    public class BattleRepo : IBattle
    {
        DatabaseContext ctx;
        public BattleRepo(DatabaseContext context)
        {
            ctx = context;
        }
        public List<Battle> GetBattles()
        {
            return ctx.Battle.ToList();
        }
        public List<Samurai> GetSamuraiByBattleId(int battleId)
        {
            return ctx.Battle.Where(b => b.BattleId == battleId).SelectMany(battle => battle.Samurais).ToList();
        }
        public List<Battle> GetBattlesBySamuraiId(int SamuraiId)
        {
            Samurai samurai = ctx.Samurai.Where(s => s.Id == SamuraiId).FirstOrDefault();
            return samurai.Battles;
        }
    }
}