using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawler.Items;

namespace DungeonCrawler
{
    public class CombatEncounter : Encounter
    {
        public static CombatEncounter currentCombatEncounter;
        Enemy enemy;
        public CombatEncounter(string title, string prompt, List<ActionButton> actions, Enemy enemy) : base(title, prompt, actions)
        {
            this.enemy = enemy;
        }

        public override void StartEncounter(Player player)
        {
            base.StartEncounter(player);

            foreach (EncounterAction action in player.GetCombatActions())
            {
                if (action.item != null) // Check if the action is an item
                {
                    actions.Add(new ActionButton(action.item.name, (Encounter encounter) =>
                    {
                        CombatEncounter e = (CombatEncounter)encounter;
                        GameUtil.game.WriteText("");
                        action.action(e, e.player, e.enemy);
                        e.enemy.FightBack(e, e.player);
                        WriteHealth(e);
                        GameUtil.game.UpdatePlayerStats();
                        if (e.enemy.isDead)
                        {
                            e.player.InvAdd(e.enemy.inventory.ToArray());
                            encounter.actions.Clear();
                            encounter.actions.Add(new ActionButton("Continue?", (Encounter en) => { GameUtil.instance.DoNextEncounter(); }));
                            encounter.RefreshActions();
                        }

                        if (GameUtil.currentPlayer.ShouldDie())
                        {
                            encounter.actions.Clear();
                            encounter.actions.Add(new ActionButton("Play Again?", (Encounter en) => { GameUtil.instance.RestartGame(); }));
                            GameUtil.game.UpdatePlayerDeath();
                            encounter.RefreshActions();
                            GameUtil.game.WriteText("You have lost all of your health. Reset the game to start a new run.");
                        }
                    }));
                }
                else // If action is not an item, it must be a StrikeAction
                {
                    StrikeAction strikeAction = new StrikeAction("Strike", (Encounter e, LivingBase user, LivingBase target) =>
                    {
                        user.Attack(target);
                        GameUtil.game.WriteText(user.name + " used Strike on " + target.name + "!");
                    });
                    actions.Insert(0, new ActionButton(action.Name, (Encounter encounter) =>
                    {
                        CombatEncounter e = (CombatEncounter)encounter;
                        GameUtil.game.WriteText("");
                        strikeAction.Action(e, e.player, e.enemy);
                        e.enemy.FightBack(e, e.player);
                        WriteHealth(e);
                        GameUtil.game.UpdatePlayerStats();
                        if (e.enemy.isDead)
                        {
                            e.player.InvAdd(e.enemy.inventory.ToArray());
                            encounter.actions.Clear();
                            encounter.actions.Add(new ActionButton("Continue?", (Encounter en) => { GameUtil.instance.DoNextEncounter(); }));
                            encounter.RefreshActions();
                        }

                        if (GameUtil.currentPlayer.ShouldDie())
                        {
                            encounter.actions.Clear();
                            encounter.actions.Add(new ActionButton("Play Again?", (Encounter en) => { GameUtil.instance.RestartGame(); }));
                            GameUtil.game.UpdatePlayerDeath();
                            encounter.RefreshActions();
                            GameUtil.game.WriteText("You have lost all of your health. Reset the game to start a new run.");
                        }
                    }));
                }
            }
        }

        private void WriteHealth(CombatEncounter c)
        {
            if (c.enemy.isDead) return;
            GameUtil.game.AppendText($"{c.enemy.name} : {c.enemy.currentHealth}");

        }



        private static string[] prompts = new string[] { "You turn the corner and see a", "At the end of the hall, there is a", "Looking into the room, you see a"};
        public static CombatEncounter GenerateEncounter()
        {
            Enemy enemy = Enemy.GenerateEnemy();
            string prompt = $"{prompts[RandomHelper.rand.Next(prompts.Length)]} {enemy.name}.\n{enemy.name}: {enemy.currentHealth}";
            CombatEncounter encounter = new CombatEncounter("Fight!", prompt, new List<ActionButton>(),enemy);
            return encounter;
        }
    }
}
