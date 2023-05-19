using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public class StrikeAction : EncounterAction
    {
        public StrikeAction(string name, EncounterActionDelegate action) : base(name, action)
        {
        }

        public StrikeAction() : base("Strike", (Encounter e, LivingBase user, LivingBase target) =>
        {
            user.Attack(target);
            GameUtil.game.WriteText(user.name + " used Strike on " + target.name + "!");
        })
        {
        }
    }
}


    
