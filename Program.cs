using System;
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




            //Declaracion de Variables
            bool varBoolean; //Alias Boolean
            int varInt; //Alias int32
            double varDouble;
            string varString;//Alias String
            DateTime varDateTime; // Alias DateTime

            //Asigna un nuevo valor a cada variablea.

            varBoolean = true;
            varInt = 1123123322;
            varDouble = 16.70;
            varString = "asdas 92213 5+ {}";
            varDateTime = DateTime.Now;

            Console.WriteLine("Variables y tipos de datos");
            Console.WriteLine();

            //Muestra el valor de la variable
            Console.WriteLine("Boolean = {0}", varBoolean);
            Console.WriteLine();

            Console.WriteLine("Int = {0}", varInt);
            Console.WriteLine("Double = {0}", varDouble);
            Console.WriteLine();

            Console.WriteLine("String = {0}", varString);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Pulse una tecla para continuar ...");
            Console.ReadLine();
            Console.Clear();//Borra la consola

            Console.WriteLine("DateTime");
            Console.WriteLine();

            Console.WriteLine("DateTime ={0} ", varDateTime);
            Console.WriteLine();

            //Muestra algunas de las propiedades disponibles en el tipo DateTime
            Console.WriteLine("DateTime.Date = {0}", varDateTime.Date);
            //Faltas
        }

    }
}