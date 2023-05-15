using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public class StrikeAction : EncounterAction
    {
        public EncounterActionDelegate Strike { get; set; }

        public StrikeAction()
        {
            Name = "Strike";
            Strike = (Encounter encounter, LivingBase user, LivingBase target) =>
            {
                Damage amount = user.Attack(target);
                GameUtil.game.AppendText($"{user.name} punches {target.name} for {amount.amount} {amount.type} damage.\n");
            };
            Action = Strike;
        }

    }
}



    