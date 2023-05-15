using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler.Items
{
    public class ItemBase
    {
        public string name;
        public string desc;
        public int quantity;
        public int value = 1;

        public ItemBase(string name, int quantity = 1)
        {
            this.name = name;
            this.quantity = quantity;
        }

        public ItemBase(string name, int value, int quantity = 1)
        {
            this.name = name;
            this.quantity = quantity;
            this.value = value;
        }

        public void SetQuantity(int amount)
        {
            quantity = amount;
        }
        public void AddQuantity(int amount)
        {
            quantity += amount;
        }

        public virtual ItemBase Create(int quantity = 1)
        {
            return new ItemBase(name, value, quantity);
        }

        public virtual List<EncounterAction> GetCombatActions()
        {
            return new List<EncounterAction>();
        }


    }
}
