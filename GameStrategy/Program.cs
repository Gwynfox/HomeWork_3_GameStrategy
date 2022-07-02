using System;

namespace GameStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Hello, my Lord. " +
                "In my barracks you can buy warriors and war machinery for your army.");
            Console.ReadLine();

            Console.WriteLine($"- This is what I can offer you:");// должно быть сортированно по стоимости

            var swordsman = СreateSwordsman();
            var archer = СreateArcher();
            var lancer = СreateLancer();
            var horseman = СreateHorseman();
            var catapult = СreateCatapult();

            Console.WriteLine("\n 1:"); swordsman.Print();
            Console.WriteLine("2:"); archer.Print();
            Console.WriteLine("3:"); lancer.Print();
            Console.WriteLine("4:"); horseman.Print();
            Console.WriteLine("5:"); catapult.Print();

            Console.ReadLine();  
            

        }
        static void CreateArmy()
        {
            Console.WriteLine($"Choose unit");
            var choice = int.Parse(Console.ReadLine());
            int armyCost = 0;
            switch (choice)
                {
                    case 1:
                        Console.WriteLine("Good choise!");
                        int a = 
                        armyCost = 0 + swordsman.cost = 20;
                        return armyCost;
                    CreateArmy();
                    case 2:
                        //метод сложения
                        break;
                    case 3:
                        //метод сложения
                        break;
                    case 4:
                        //метод сложения
                        break;
                    case 5:
                        //метод сложения
                        break;                        
                    default:
                        Console.WriteLine("I nave only 5 type of units");
                        break;
                }
                        
        }
        public static Units СreateSwordsman()
        {
            var swordsman = new Units();

            swordsman.unitClass = "Swordsman";
            swordsman.healthPoint = 6;
            swordsman.damage = 3;
            swordsman.defense = 5;
            swordsman.cost = 20;

            return swordsman;
        }
        static Units СreateArcher()
        {
            var archer = new Units();

            archer.unitClass = "Archer";
            archer.healthPoint = 4;
            archer.damage = 5;
            archer.defense = 2;
            archer.cost = 30;

            return archer;
        }
        static Units СreateLancer()
        {
            var lancer = new Units();

            lancer.unitClass = "Lanser";
            lancer.healthPoint = 5;
            lancer.damage = 4;
            lancer.defense = 4;
            lancer.cost = 25;

            return lancer;
        }
        static Units СreateHorseman()
        {
            var horseman = new Units();

            horseman.unitClass = "Horseman";
            horseman.healthPoint = 6;
            horseman.damage = 5;
            horseman.defense = 5;
            horseman.cost = 50;

            return horseman;
        }
        static Units СreateCatapult()
        {
            var catapult = new Units();

            catapult.unitClass = "Catapult";
            catapult.healthPoint = 8;
            catapult.damage = 10;
            catapult.defense = 0;
            catapult.cost = 100;

            return catapult;
        }
    }
}
            //Random rnd = new Random();
            //int capital = rnd.Next(0, 1000);
            //
            //Console.WriteLine($"(You have {capital} coins");
            //Console.ReadLine();                

            //Console.WriteLine($"{swordsman.cost + archer.cost}");
            //
            //int[] costUnits = new int[] { swordsman.cost, archer.cost };
            //Array.Sort(costUnits);
            //foreach (int c in costUnits)
            //Console.WriteLine(c);