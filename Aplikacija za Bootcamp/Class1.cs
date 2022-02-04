using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_za_Bootcamp
{
    class Program
    {
        public static void Class(string[] args)
        {
            Pizza pizza = new Pizza("stuffed crust", "red sauce", "gondola");


            Console.ReadKey();

        }
         class Pizza
        {
            string bread;
            string sauce;
            string cheese;
            string topping;
            public Pizza(string bread, string sauce, string cheese, string topping)
            {
                this.bread = bread;
                this.sauce = sauce;
                this.cheese = cheese;
                this.topping = topping;
            }
            public Pizza(string bread, string sauce, string cheese)
            {
                this.bread = bread;
                this.sauce = sauce;
                this.cheese = cheese;
            }
        }

    }

}

