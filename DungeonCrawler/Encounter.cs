using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawler.Items;

namespace DungeonCrawler
{
    public class Encounter
    {

        public string title;
        public string prompt;
        public List<ActionButton> actions;
        public Player player;
        public static Encounter currentEncounter;


        public Encounter(string title, string prompt, List<ActionButton> actions)
        {
            this.title = title;
            this.prompt = prompt;
            this.actions = actions;
        }

        public Encounter(string title, string prompt)
        {
            this.title = title;
            this.prompt = prompt;
        }

        public Encounter()
        {
            actions = new List<ActionButton>();
        }

        public virtual void StartEncounter(Player player)
        {
            this.player = player;
        }

        public virtual void OnFinish()
        {
            GameUtil.instance.DoNextEncounter();
        }

        public void RefreshActions()
        {
            GameUtil.game.RefreshActions(this);
        }



    }
}
