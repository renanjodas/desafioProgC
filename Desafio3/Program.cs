using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra = Console.ReadLine().Replace(" ", ""); 
            
            if(isPalindromo(palavra))   { Console.WriteLine(" é palíndromo"); }
            else                        { Console.WriteLine(" não palíndromo"); }
            
            Console.ReadKey();
        }
        public static bool isPalindromo(string palavra)
        {
            char[] inversaoDaPalavra = palavra.ToCharArray(); 

            Array.Reverse(inversaoDaPalavra);

            string palavraInvertida = new string(inversaoDaPalavra); 
            if (palavra.Equals(palavraInvertida)) { return true;  }
            return false;
        }
    }
}
