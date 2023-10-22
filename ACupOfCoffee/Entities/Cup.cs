using ACupOfCoffee.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACupOfCoffee.Entities
{
    public class Cup : CupBase, IContainingCoffee, IContainingWater, IContainingMilk, IContainingSugar
    {
        public void AddCoffee()
        {
            Console.WriteLine("Add coffee to the cup");
        }

        public void AddMilk()
        {
            Console.WriteLine("Add milk to the cup");
        }

        public void AddSugar()
        {
            Console.WriteLine("Add sugar to the cup");
        }

        public void AddWater()
        {
            Console.WriteLine("Add water to the cup");
        }

        public override void Stir()
        {
            Console.WriteLine("Stirring...");
        }
    }
}
