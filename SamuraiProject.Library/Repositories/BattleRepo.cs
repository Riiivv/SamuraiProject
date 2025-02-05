using Microsoft.EntityFrameworkCore.Storage;
using SamuraiProject.Library.Interface;
using SamuraiProject.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiProject.Library.Repositories
{
    public class BattleRepo :IBattle
    {
        DatabaseContext cxt;
        public BattleRepo(DatabaseContext context) 
        {

        }
    }
}
