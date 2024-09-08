using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class EX02_Existe_A
    {
        
        static void Main(string[] args)
        {
            int soma = 0;
            string texto=null;
            char[] letras;
            Console.WriteLine("Bem-Vindo! Contador de Caracter A/a");
            do
            {
                Console.WriteLine("Digite um texto:");
                texto=Console.ReadLine();
            }
            while (texto==null) ;
            texto = texto.ToLower();
            letras = texto.ToCharArray();
            foreach (char c in letras) 
            { 
                if (c == 'a') 
                {
                    soma++;
                }
            }
            if (soma == 1) 
            {
                Console.WriteLine("Há " + soma + " ocorrência da Letra A");
            }
            else
            {
                Console.WriteLine("Há " + soma + " ocorrências da Letra A");
            }
            Console.ReadKey();
        }
        
    
    }
}
