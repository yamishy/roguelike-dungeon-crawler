using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawler.Items;
namespace DungeonCrawler
{
    public class EncounterAction
    {
        public delegate void EncounterActionDelegate(Encounter encounter, LivingBase user, LivingBase target);

        public ItemBase item;
        public EncounterActionDelegate action;
        public LivingBase strike;

        public string Name { get; set; }
        public EncounterActionDelegate Action { get; set; }

        public EncounterAction(ItemBase item, EncounterActionDelegate action)
        {
            this.item = item;
            this.action = action;
        }

        public EncounterAction(string name,EncounterActionDelegate action)
        {
            this.Name = name;
            this.action = action;

        }

        public EncounterAction()
        {

        }


    }
}
