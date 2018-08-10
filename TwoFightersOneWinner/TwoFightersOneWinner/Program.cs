using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoFightersOneWinner
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fighter f1 = new Fighter("Harry", 13, 4);
            Fighter f2 = new Fighter("Jerry", 28, 3);

            string result = declareWinner(f1, f2, f1.Name);
            Console.WriteLine(result);
            Console.ReadKey();           
        }

        public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            string winner = "";

            Console.WriteLine("{0} health: {1} and {2} health: {3}", fighter1.Name, fighter1.Health, fighter2.Name, fighter2.Health);

            while (fighter1.Health >= 0 & fighter2.Health >= 0)
            {
                if(firstAttacker == fighter1.Name)
                {
                    fighter2.Health = fighter2.Health - fighter1.DamagePerAttack;
                    if (fighter2.Health <= 0)
                        winner = fighter1.Name;
                    else
                        fighter1.Health = fighter1.Health - fighter2.DamagePerAttack;

                    if (fighter1.Health <= 0)
                        winner = fighter2.Name;
                }
                else if(firstAttacker == fighter2.Name)
                {
                    fighter1.Health = fighter1.Health - fighter2.DamagePerAttack;
                    if (fighter1.Health <= 0)
                        winner = fighter2.Name;
                    else
                        fighter2.Health = fighter2.Health - fighter1.DamagePerAttack;

                    if (fighter2.Health <= 0)
                        winner = fighter1.Name;
                }

            }
            return winner;
        }
    }
}
