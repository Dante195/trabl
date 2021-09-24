using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_2_v0._1
{
    class Program
    {
        static void Main()
        {
            Animal animal = new Animal();
            Goat goat = new Goat();
            Leopard leopard = new Leopard();

            goat.Fun();
            animal.Food();
            leopard.Food();
            Console.ReadKey();
        }
    }
}
