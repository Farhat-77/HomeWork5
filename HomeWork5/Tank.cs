using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5
{
    public class Tank
    {
        protected string name;
        protected int ammunition;
        protected int lvlArmor;
        protected int lvlManeuverability;
        public Tank(int ammnunition, int lvlArmor, int lvlManeuverability, string v)
        {
            this.name = name;
            this.ammunition = ammunition;
            this.lvlArmor = lvlArmor;
            this.lvlManeuverability = lvlManeuverability;
        }
        public Tank()
        {
            name = "null";
            ammunition = 0;
            lvlArmor = 0;
            lvlManeuverability = 0;
        }
        public void Print()
        {
            Console.WriteLine("name - " + name);
            Console.WriteLine("ammunition =" + ammunition + "lvlArmor =" + lvlArmor + "lvlManeuverability =" + lvlManeuverability);
        }
        public static Tank operator *(Tank t34, Tank pantera)
        {
            if(t34.ammunition > pantera.ammunition && t34.lvlArmor > pantera.lvlArmor)
            {
                return t34;
            }
            if(t34.ammunition > pantera.ammunition && t34.lvlManeuverability > pantera.lvlManeuverability)
            {
                return t34;
            }
            if(t34.lvlArmor > pantera.lvlArmor && t34.lvlManeuverability > pantera.lvlManeuverability)
            {
                return t34;
            }
            else
            {
                return pantera;
            }
        }
    }
    class Program
    {
        public void Main(string[] args)
        {
            Random rand = new Random();
            Tank[] VIN = new Tank[5];
            Tank[] t34 = new Tank[5];
            for(int i = 0; i < t34.Length; i++)
            {
                VIN[i] = new Tank();
            }
            for(int i = 0; i < t34.Length; i++)
            {
                t34[i] = new Tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "t34");
            }
            Tank[] pantera = new Tank[5];
            for(int i = 0; i < pantera.Length; i++)
            {
                pantera[i] = new Tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "pantera");
            }
            for(int i = 0; i < 5; i++)
            {
                t34[i].Print();
                pantera[i].Print();
                VIN[i] = t34[i] * pantera[i];
                Console.WriteLine();
                Console.WriteLine($"B{i + 1} won the fight");
                VIN[i].Print();
                Console.WriteLine();
            }
        }
    }
}
