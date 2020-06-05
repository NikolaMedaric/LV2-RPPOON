using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoller dice = new DiceRoller(20);
            for( int i=0; i<20;i++)
            {
                dice.InsertDie(new Die(6));
            }
            dice.RollAllDice();
            IList<int> results = dice.GetRollingResults();
            foreach (int result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
