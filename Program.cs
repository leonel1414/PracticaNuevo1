﻿using System;
namespace Program
{ 
    class Program{ 
        public static void Main(string[] args) {

            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Hola soy yo de nuevo jaja!!");
            int a = 3;

            if (a > 0)
            {
                Console.WriteLine("El valor es positivo");
                a = 1;
                Console.WriteLine($"el valor de a es: {a}");
            }
            else {
                Console.WriteLine("El valor es negativo");
                a = -1;
                Console.WriteLine($"el valor de a es: {a}");
            }



            //Console.WriteLine("Hola");
            if (a > 0)
            {
                Console.WriteLine("El valor positivo...");
                if (a > 1000)
                {
                    Console.WriteLine(".... y muy grande");
                }
                else
                {
                    Console.WriteLine("...chico");
                }
            }
            else
            {
                Console.WriteLine("El valor es negativo...");
                if (a < -1000)
                {
                    Console.WriteLine(".... y muy grande ");
                }
                else
                {
                    Console.WriteLine("...chico!!");
                }
            }

        }

    }
}