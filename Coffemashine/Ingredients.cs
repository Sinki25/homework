using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Coffemashine
{
    class Ingredients
    {
        private int coffeeGR { get; set; }
        private int sugarGR { get; set; }
        private int couples { get; set; }
        private double waterML { get; set; }
        private int milkGR { get; set; }
        private int chocolateGR { get; set; }

        public int CoffeeGR
        {
            get { return coffeeGR; }
            set
            {
                coffeeGR = value;
            }
        }
        public int SugarGR
        {
            get { return sugarGR; }
            set
            {
                sugarGR = value;
            }
        }
        public int Couples
        {
            get { return couples; }
            set
            {
                couples = value;
            }
        }
        public double WaterML
        {
            get { return waterML; }
            set
            {
                waterML = value;
            }
        }
        public int MilkGR
        {
            get { return milkGR; }
            set
            {
                milkGR = value;
            }
        }
        public int ChocolateGR
        {
            get { return chocolateGR; }
            set
            {
                chocolateGR = value;
            }
        }
       
        public void doAmericano(int coffee,int sugar,int cup, double water,int milk,int chocolate)
        {
            coffeeGR = coffeeGR - coffee;
            sugarGR = sugarGR - sugar;
            couples = couples - cup;
            waterML = waterML - water;
            milkGR = milkGR - milk;
            chocolateGR = chocolateGR - chocolate;
        }
        public void doCappuccino(int coffee, int sugar, int cup, double water, int milk, int chocolate)
        {
            coffeeGR = coffeeGR - coffee;
            sugarGR = sugarGR - sugar;
            couples = couples - cup;
            waterML = waterML - water;
            milkGR = milkGR - milk;
            chocolateGR = chocolateGR - chocolate;
        }
        public void doLatte(int coffee, int sugar, int cup, double water, int milk, int chocolate)
        {
            coffeeGR = coffeeGR - coffee;
            sugarGR = sugarGR - sugar;
            couples = couples - cup;
            waterML = waterML - water;
            milkGR = milkGR - milk;
            chocolateGR = chocolateGR - chocolate;
        }
        public void doChocolate(int coffee, int sugar, int cup, double water, int milk, int chocolate)
        {
            coffeeGR = coffeeGR - coffee;
            sugarGR = sugarGR - sugar;
            couples = couples - cup;
            waterML = waterML - water;
            milkGR = milkGR - milk;
            chocolateGR = chocolateGR - chocolate;
        }
        public void doExpresso(int coffee, int sugar, int cup, double water, int milk, int chocolate)
        {
            coffeeGR = coffeeGR - coffee;
            sugarGR = sugarGR - sugar;
            couples = couples - cup;
            waterML = waterML - water;
            milkGR = milkGR - milk;
            chocolateGR = chocolateGR - chocolate;
        }
        public void NoIngredients(int coffee, int sugar, int cup, double water, int milk, int chocolate, string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                while (sr.EndOfStream != true)
                {
                    coffee = Convert.ToInt32(sr.ReadLine());
                    sugar = Convert.ToInt32(sr.ReadLine());
                    cup = Convert.ToInt32(sr.ReadLine());
                    water = Convert.ToDouble(sr.ReadLine());
                    milk = Convert.ToInt32(sr.ReadLine());
                    chocolate= Convert.ToInt32(sr.ReadLine());
                }
            }
        }
        public void checkIngCoffee(int coffee, int couples, double water, int milk, Boolean can)
        {
            if (coffee>= 15 & couples >= 1 & water >= 100 & milk >= 50)
            {
                can = true;
            }
            else
            {
                can = false;
            }
            if (can==false)
            {
                NoIngredients(CoffeeGR,SugarGR,Couples,WaterML,MilkGR,ChocolateGR,"Ingredients.txt");
            }

        }
        public void GetRecipes (int coffee,int cup, double water, int milk, int chocolate, ref int money, int n,string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                int i=0;
                string s;
                while (i<n)
                {
                    i++;
                    s = sr.ReadLine();                   
                    if (i == n)
                    {
                        s=s.Remove(0, s.IndexOf("=") + 1);
                        string[] ss= s.Split(',');
                        coffee = Convert.ToInt32(ss[0]);
                        cup = Convert.ToInt32(ss[1]);
                        water = Convert.ToDouble(ss[2]);
                        milk = Convert.ToInt32(ss[3]);
                        chocolate = Convert.ToInt32(ss[4]);
                        money = Convert.ToInt32(ss[5]);
                    }                  
                }
            }
        }
    }
}
