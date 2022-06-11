using System;
using DuckConsole.Implementation;
using DuckConsole.Model;

namespace DuckConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck(new QuackingRealDuck(),new FlyingRealDuck());

            Console.WriteLine("Real Duck");

            Action(duck);

            Console.WriteLine();

            Console.WriteLine("Wooden Duck");

            duck.SetQuackType(new QuackingWoodenDuck());
            duck.SetFlyType(new FlyingWoodenDuck());


            Action(duck);

            Console.WriteLine();
            Console.WriteLine("Rubber Duck");

            duck.SetQuackType(new QuackingRubberDuck());
            duck.SetFlyType(new FlyingRubberDuck());


            Action(duck);

        }

        static void Action(Duck duck)
        {
            Console.WriteLine("Quacking:");
            Console.WriteLine();
            duck.Quack();
            Console.WriteLine();
            Console.WriteLine("Flying:");
            Console.WriteLine("");
            duck.Fly();

        }
    }
}
