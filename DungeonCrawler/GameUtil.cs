using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DungeonCrawler
{

    class GameUtil
    {
        public static GameUtil instance;
        public static Game game;
        public static Player currentPlayer;

        public GameUtil(Game instance)
        {
            currentPlayer = new Player();
            game = instance;

            currentPlayer.InvAdd(Items.Collectables.sword);
            currentPlayer.InvAdd(Items.Collectables.knife);//add starting items
              
            DoNextEncounter();//start first encounter

        }

        public void DoNextEncounter()
        {
            game.SetEncounter(CombatEncounter.GenerateEncounter());
        }

        public void RestartGame()
        {
            Process.Start(Environment.GetCommandLineArgs()[0]);

            Environment.Exit(0);
        }



    }
}
