using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler.Items
{
    public class WeaponBase : ItemBase
    {
        public Damage.GetDamage damageCalc = () => { return RandomHelper.DoRoll(4) + 1; };
        public string damageType = "normal";

        public WeaponBase(string name) : base(name)
        {

        }

        public WeaponBase(string name, int value) : base(name, value,1)
        {

        }
        public WeaponBase(string name, int value, Damage.GetDamage calc, string damageType = "normal") : base(name, value,1)
        {
            damageCalc = calc;
            this.damageType = damageType;
        }

        public override ItemBase Create(int quantity = 1)
        {
            return new WeaponBase(name, value, damageCalc, damageType);
        }


        public Damage GetDamage()
        {
            return new Damage(damageCalc(), damageType);
        }

        public override List<EncounterAction> GetCombatActions()
        {
            return new List<EncounterAction>() { new EncounterAction(this, DoCombat) };
        }

        public virtual void DoCombat(Encounter encounter, LivingBase user, LivingBase target)
        {
            //combat code
            Damage amount = user.Attack(target, GetDamage());
            GameUtil.game.AppendText($"{user.name} attacks {target.name} for {amount.amount} {amount.type} damage.\n");
        }
    }
}
