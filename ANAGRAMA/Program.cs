using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ANAGRAMA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CREAMOS UNA LISTA PARA REALIZAR LA COMPARACION ENTRE PALABRAS
            List<char> primeraLista = new List<char>();

            Console.WriteLine("Por favor, ingrese una palabra: ");
            // TOMAMOS EL VALOR COMPLETO Y LO LLEVAMOS A MINUSCULAS
            string primeraPalabra = Console.ReadLine().ToLower();

            // CONVERTIMOS EN CARACTER CARA VALOR INDIVIDUAL INGRESADO
            char[] primerChars = primeraPalabra.ToCharArray();
            
            // LO ORDENAMOS PARA REALIZAR LA COMPRARACION
            Array.Sort(primerChars);
            Console.Write("Los valores ingresando en orden son: ");
            Console.WriteLine(primerChars);

            // VERFICAMOS LOS CARACTERES EN ORDEN
            Console.WriteLine("Los valores de caracter ingresados son: ");
            foreach (char c in primerChars)
            {
                Console.WriteLine(c);
                // AGREGAMOS LOS VALORES EN ORDEN A LA LISTA DECLARADA
                primeraLista.Add(c);
            }
           
            // VERIFICAMOS LOS VALORES DE LA LISTA
            Console.WriteLine("Los valores de caracter ingresados a la lista son: ");
            foreach (char a in primeraLista)
            {
                Console.WriteLine(a);
            }


            // CREAMOS OTRA LISTA PARA REALIZAR DICHA COMPARACION ENTRE PALABRAS
            // REALIZAMOS EL MISMO PROCESO ANTERIOR
            List<char> segundaLista = new List<char>();

            Console.WriteLine("Por favor, ingrese otra palabra: ");
            string segundaPalabra = Console.ReadLine().ToLower();
            char[] segundoChars = segundaPalabra.ToCharArray();
            Array.Sort(segundoChars);
            Console.Write("Los valores ingresando en orden son: ");
            Console.WriteLine(segundoChars);

            Console.WriteLine("Los valores de caracter ingresados son: ");
            foreach (char d in segundoChars)
            {
                Console.WriteLine(d);
                segundaLista.Add(d);
            }
           
            Console.WriteLine("Los valores de caracter ingresados a la lista son: ");
            foreach (char b in segundaLista)
            {
                Console.WriteLine(b);
            }

            
            // Console.WriteLine(List<char>.Equals(primeraLista, 
            //     segundaLista));
            // Console.WriteLine(Char.Equals(primerChars, primerChars)); 
            
            // LLAMAMOS A LA FUNCION, A SU VALOR BOLEANO
            if (Anagrama(primeraLista,
            segundaLista))
            {
                Console.WriteLine("{0} y {1} son anagramas!", primeraPalabra, 
                    segundaPalabra);
            }
            else
            {
                Console.WriteLine("{0} y {1} no son anagramas!", primeraPalabra, 
                    segundaPalabra);
            }              

            Console.Read();

        }
        //FUNCION PARA VERFICAR SI ES O NO UN ANAGRAMA
        public static bool Anagrama(List<char> primeraLista,
            List<char> segundaLista)
        {
            if (primeraLista.Count == segundaLista.Count)
            {
                for (int i = 0; i < primeraLista.Count; i++)
                {
                    if (primeraLista[i] == segundaLista[i])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        
        }
    }
}
