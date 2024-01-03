namespace WarriorWars
{
    class EntryPoint
    {

        static Random rng = new Random();
        static void Main(string[] args)
        {
            
            Warrior goodGuy = new Warrior("Thamoddya",Enum.Faction.GoodGuy);
            Warrior badGuy= new Warrior("Senan",Enum.Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }

                Thread.Sleep(300);
            }

        }
    }
}