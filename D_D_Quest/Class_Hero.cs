using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Quest
{
    class Hero
    {


        public void Name()
        {
            Console.WriteLine("Назовите Вашего героя ");
            string heroName = Console.ReadLine();
        }


        public void Health()
        {
            Random rand = new Random();
            int health = rand.Next(12);

        }

        public void Mana()
        {
            Random rand = new Random();
            int mana = rand.Next(12);
        }

        public void Strength()
        {
            Random rand = new Random();
            int strength = rand.Next(6);
        }

        public void Character()
        {
            
        }
            //Console.WriteLine(heroName);
        }
    }
}
