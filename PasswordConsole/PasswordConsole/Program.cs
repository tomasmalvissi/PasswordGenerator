using System;

namespace PasswordConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longitud: ");
            int longi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cantidad de mayusculas: ");
            int cantidadmayus = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cantidad de minisculas: ");
            int cantidadminus = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cantidad de numeros: ");
            int cantidadnum = Convert.ToInt32(Console.ReadLine());
            Pass(longi, cantidadmayus, cantidadminus, cantidadnum);
        }

        public static void Pass(int longitud, int cantmayus, int cantminus, int cantnum) 
        {            
            char[] mayus = "ABCDEFGHIJKLMÑOPQRSTUVWXYZ".ToCharArray();
            char[] minus = "abcdefghijklmñopqrstuvwxyz".ToCharArray();
            char[] num = "0123456789".ToCharArray();

            string value = "";

            if (longitud == (cantnum + cantminus + cantmayus))
            {
                Random rnd = new();
                string valuemayus = "";
                string valueminus = "";
                string valuenum = "";
                for (int i = 0; i < cantmayus; i++) //asignacion de mayusculas
                {                    
                    valuemayus = valuemayus + mayus.GetValue(rnd.Next(0, cantmayus));
                }

                for (int i = 0; i < cantminus; i++) //asignacion de minusculas
                {                    
                    valueminus = valueminus + minus.GetValue(rnd.Next(0, cantminus));
                }

                for (int i = 0; i < cantnum; i++) //asignacion de numeros
                {                    
                    valuenum = valuenum + num.GetValue(rnd.Next(0, cantnum));
                }

                value = valuemayus + valueminus + valuenum;             
            }
            else
            {
                Console.WriteLine("Algo falló.");
            }
            char[] password = value.ToCharArray();
            Shuffle(password);
        }
        public static void Shuffle(char[] ordenar)
        {
            Random rnd = new Random();
            int largo = ordenar.Length;       
            while (largo > 1)
            {
                int aleat = rnd.Next(largo);
                largo--;                     //elijo una posicion random del array y se la asigno
                char temp = ordenar[largo];     //a medida que el while recorre el array
                ordenar[largo] = ordenar[aleat];
                ordenar[aleat] = temp;
            }
            Console.WriteLine("La contraseña generada es: ");
            Console.WriteLine(ordenar);
        }

    }
}
