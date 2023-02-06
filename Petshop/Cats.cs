using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
    internal class Cats
    {
        public string Nickname { get; set; }
        public double Age { get; set; }
        public bool Gender { get; set; }
        public int Energy { get; set; }
        public double Price { get; set; }
        public int MealQuantity { get; set; }

        public void Eat()
        {
            if (MealQuantity == 100)
            {
                Console.WriteLine("Toxdu");
            }
            else
            {
                MealQuantity += 10;
                Console.WriteLine("Yeyir");
            }
        }
        public void Sleep()
        {
            if (Energy == 100)
            {
                Console.WriteLine("Enerjilidi");
            }
            else
            {
                Energy = 100;
                Console.WriteLine("Yatirrr");
            }
        }
        public void Play()
        {
            if (Energy >= 10 && MealQuantity >= 10)
            {
                Console.WriteLine();
                Energy -= 10;
                MealQuantity -= 10;
            }
            if (Energy <= 0)
            {
                Console.WriteLine("Yuxusu");
                Sleep();
            }
            if (MealQuantity <= 0)
            {
                Console.WriteLine("Acdi");
                Eat();
            }

        }
    }
}
