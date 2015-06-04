using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Core;

namespace Client.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("DYNAMIC\t--------");
            var tank = new Tank();
            tank.Move();
            tank.ChangeMode();
            tank.Attack(new Tank());

            tank.Move();
            tank.ChangeMode();
            tank.Move();
            tank.Attack(new Tank());
            System.Console.WriteLine("--------");


            System.Console.WriteLine("Multiinheritance\n--------");

            System.Console.WriteLine("--------");


            System.Console.WriteLine("Abstract/Polymorph\n--------");

            System.Console.WriteLine("--------");


            System.Console.WriteLine("Multiaspect\n--------");

            System.Console.WriteLine("--------");

            System.Console.ReadKey();
        }
    }
}
