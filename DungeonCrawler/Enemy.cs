using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public class Enemy : LivingBase
    {
        public Enemy(string name, int maxHealth, int power)
        {
            this.name = name;
            this.power = power;

            genericMaxHealth = maxHealth;
            currentHealth = GetMaxHealth();

        }


        public void FightBack(CombatEncounter encounter, Player player)
        {
            if (isDead)
            {
                GameUtil.game.AppendText($"{name} has died.");
                return;
            }
            EncounterAction[] actions = GetCombatActions().ToArray();
            EncounterAction.EncounterActionDelegate action;
            if(actions==null || actions.Length<1)
            {
                action = Strike;
            }
            else
            {
                action = actions[RandomHelper.rand.Next(0, actions.Length)].action;
            }

            action(encounter, this, player);
        }



        private static string[] enemyPrefix = new string[] { "Arch", "Undead", "Blood", "Shadow" };
        private static string[] enemyTypes = new string[] { "Fire", "Ice", "Poison", "Lightning" };
        private static string[] enemyTitles = new string[] { "Priest", "Mage", "Warrior", "Fiend" };
        public static Enemy GenerateEnemy()
        {
            string name = $"{enemyPrefix[RandomHelper.rand.Next(enemyPrefix.Length)]} {enemyTypes[RandomHelper.rand.Next(enemyTypes.Length)]}" +
                $" {enemyTitles[RandomHelper.rand.Next(enemyTitles.Length)]}";

            Enemy enemy = new Enemy(name, RandomHelper.DoRoll(4,2)+2, RandomHelper.DoRoll(2));
            enemy.inventory.Add((RandomHelper.rand.Next(4) == 0) ? Items.Collectables.shortSword.Create():Items.Collectables.knife.Create());

            return enemy;
        }
    }
}
