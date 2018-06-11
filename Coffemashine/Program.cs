using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Coffemashine
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingredients ing = new Ingredients();
            Money money=new Money() ;
            //Начало
            #region

            Console.WriteLine("Введите деньги:");
           
            money.Rub = Convert.ToInt32(Console.ReadLine());
            #endregion

            //Меню
       
            using (StreamReader sr = new StreamReader("Ingredients.txt"))
            {
                while (sr.EndOfStream != true)
                {
                    ing.CoffeeGR = Convert.ToInt32(sr.ReadLine());
                    ing.SugarGR = Convert.ToInt32(sr.ReadLine());
                    ing.Couples = Convert.ToInt32(sr.ReadLine());
                    ing.WaterML = Convert.ToDouble(sr.ReadLine());
                    ing.MilkGR = Convert.ToInt32(sr.ReadLine());
                    ing.ChocolateGR = Convert.ToInt32(sr.ReadLine());
                }
            }
            bool f = true;
            while (f==true)
            {                
                Console.WriteLine("Добавить сахар? Да - 1, нет - 2");
                int response = int.Parse(Console.ReadLine());
                if (response == 1)
                {
                    Console.WriteLine("Сколько ложек?");
                    response = int.Parse(Console.ReadLine());
                    Console.WriteLine("Вы уверены? Да - 1, нет - 2");
                    if (int.Parse(Console.ReadLine()) == 1)
                    {
                        ing.SugarGR = response*15;
                    }
                }
             int n=0;
             Console.WriteLine("Выберите продукт");
            #region
            Console.WriteLine("1.Американо");
            Console.WriteLine("2.Капучино");
            Console.WriteLine("3.Латте");
            Console.WriteLine("4.Горячий шоколад");
            Console.WriteLine("5.Экспрессо");
                #endregion
                Boolean ff = true;
                ing.checkIngCoffee(ing.CoffeeGR,ing.Couples,ing.WaterML,ing.MilkGR,ff);
                switch (int.Parse(Console.ReadLine()))
                {
                    case (1): { ing.GetRecipes(ing.CoffeeGR, ing.Couples, ing.WaterML, ing.MilkGR, ing.ChocolateGR, ref n, 1, "Recipes.txt"); ing.doAmericano(ing.CoffeeGR, ing.SugarGR,ing.Couples, ing.WaterML,ing.MilkGR, ing.ChocolateGR); break; }
                    case (3): { ing.GetRecipes(ing.CoffeeGR, ing.Couples, ing.WaterML, ing.MilkGR, ing.ChocolateGR, ref n, 2, "Recipes.txt"); ing.doLatte(ing.CoffeeGR, ing.SugarGR, ing.Couples, ing.WaterML, ing.MilkGR, ing.ChocolateGR); break; }
                    case (2): { ing.GetRecipes(ing.CoffeeGR, ing.Couples, ing.WaterML, ing.MilkGR, ing.ChocolateGR, ref n, 3, "Recipes.txt"); ing.doCappuccino(ing.CoffeeGR, ing.SugarGR, ing.Couples, ing.WaterML, ing.MilkGR, ing.ChocolateGR); break; }
                    case (4): { ing.GetRecipes(ing.CoffeeGR, ing.Couples, ing.WaterML, ing.MilkGR, ing.ChocolateGR, ref n, 4, "Recipes.txt"); ing.doChocolate(ing.CoffeeGR, ing.SugarGR, ing.Couples, ing.WaterML, ing.MilkGR, ing.ChocolateGR); break; }
                    case (5): { ing.GetRecipes(ing.CoffeeGR, ing.Couples, ing.WaterML, ing.MilkGR, ing.ChocolateGR, ref n, 5, "Recipes.txt"); ing.doExpresso(ing.CoffeeGR, ing.SugarGR, ing.Couples, ing.WaterML, ing.MilkGR, ing.ChocolateGR); break; }
                }
                Console.WriteLine("Ваш кофе готов");
                Console.WriteLine("Получить сдачу? Да - 1, нет - 2");
                if (int.Parse(Console.ReadLine()) == 1)
                {
                    money.GetMoney(n);
                    Console.WriteLine(money.Rub);
                    f = false;
                    break;
                }
                else
                {
                    f = true;
                    Console.WriteLine("Хотите ввести деньги? Да - 1, нет - 2");
                    if (int.Parse(Console.ReadLine()) == 1)
                    {
                        Console.WriteLine("Введите деньги");
                        money.Rub=money.Rub+(Convert.ToInt32(Console.ReadLine()));
                    }
                }
            }

        }
    }
}
