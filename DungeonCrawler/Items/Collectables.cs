using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler.Items
{
    public static class Collectables
    {

        //item objects
        public static ItemBase goldCoin = new ItemBase("Gold Coin");



        //weapons objects
        public static WeaponBase knife = new WeaponBase("Knife",5);
        public static WeaponBase shortSword = new WeaponBase("Short Sword", 8, () => { return RandomHelper.DoRoll(8); });
        public static WeaponBase sword = new WeaponBase("Sword", 12,() => { return RandomHelper.DoRoll(6, 2); });
    }
}
