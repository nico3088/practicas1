using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_1
{
    class Program
    {
        public static object Public { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa N nombres");
            List<string> listadenombres = new List<string>();

            
            bool condicion = true;
            while(condicion) 
            {
                string nombre = Console.ReadLine();

                if (nombre.ToUpper() == "SALIR") condicion = false;
                 
                else
                {
                    listadenombres.Add(nombre);
                }
            }
            List<string> largopalabras = wordlenght(listadenombres);
            string combindedString = string.Join(",", largopalabras.ToArray());
            
            Console.WriteLine(combindedString);

            Console.WriteLine(listadenombres.Count);

            for (int x = 0; x < 5; x++) ;
            
            foreach(var item in listadenombres.GroupBy(x => x))

            Console.WriteLine($"{item.Key} aparece {item.Count()} veces");

            Console.ReadKey();

            /* Console.WriteLine("Aca tenes el ejercicio cara mamada");
            string nombres;
            List<string> listanombres = new List<string>();
            nombres = Console.ReadLine();
            
            {
                listanombres.Add = Console.ReadLine();


                foreach (string data in listanombres)
                    Console.WriteLine(data.Length);
            }
            Console.ReadKey();*/
        }
        public static List<string> wordlenght(List<string> nombres) 
        {
            List<string> result = new List<string>();
            
            foreach(string n in nombres) 
            {
                result.Add(n.Length.ToString());

            }

            return result;

            
        }

        
        
    }
}
