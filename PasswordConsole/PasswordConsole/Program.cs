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
            char[] num = "123456789".ToCharArray();

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
        public static void Shuffle(char[] array)
        {
            Random rng = new Random();
            int n = array.Length;       
            while (n > 1)
            {
                int k = rng.Next(n);  
                n--;                     
                char temp = array[n];     
                array[n] = array[k];
                array[k] = temp;
            }
            Console.WriteLine("La contraseña generada es: ");
            Console.WriteLine(array);
        }

    }
}
