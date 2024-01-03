using WarriorWars.Enum;

namespace WarriorWars.Equipments
{
    class Weapon
    {
        private int damage;
        private const int GOOD_GUY_DAMAGE =5;
        private const int BAD_GUY_DAMAGE =5;


        public Weapon(Faction faction)
        {

            switch (faction)
            {
                case Faction.GoodGuy:
                    damage = GOOD_GUY_DAMAGE;
                    break;
                case Faction.BadGuy:
                    damage = BAD_GUY_DAMAGE;
                    break;
                default:
                    break;
            }

        }



        public int Damage
        {
            get
            {
                return damage;
            }



        }

    }
}
