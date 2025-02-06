﻿namespace WeaponDamage
{
    internal class Program
    {
        static Random random = new();
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new(RollDice(3));
            ArrowDamage arrowDamage = new(RollDice(1));

            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
                char key = Console.ReadKey().KeyChar;
                if (key != '0' && key != '1' && key != '2' && key != '3') return;

                Console.Write("\n S for word, A for arrow, anything else to quit: ");
                char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

                switch (weaponKey)
                {
                    case 'S':
                        swordDamage.Roll = RollDice(3);
                        swordDamage.Magic = (key == '1' || key == '3');
                        swordDamage.Flaming = (key == '2' || key == '3');
                        Console.WriteLine($"\nRolled {swordDamage.Roll} for {swordDamage.Damage} HP\n");
                        break;
                    case 'A':
                        arrowDamage.Roll = RollDice(3);
                        arrowDamage.Magic = (key == '1' || key == '3');
                        arrowDamage.Flaming = (key == '2' || key == '3');
                        Console.WriteLine($"\nRolled {arrowDamage.Roll} for {arrowDamage.Damage} HP\n");
                        break;
                    default:
                        return;
                }
            }
        }

        private static int RollDice(int numOfRolls)
        {
            int total = 0;
            for (int i = 0; i < numOfRolls; i++) total += random.Next(1, 7);
            return total;
        }
    }
}
