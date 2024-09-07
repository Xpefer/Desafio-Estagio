using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class EX01_Fibonacci
    {
        static int num=0;
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindo! Descubra Se Um Número Pertence a Sequência Fibonacci");
            EscolherNumero();
            Console.WriteLine(VerificarNumero(num));
            Console.ReadKey();
        }

        static void EscolherNumero() 
        {
            Console.WriteLine("Digite Um Número");
            try 
            {
                num = Convert.ToInt32(Console.ReadLine()); 
            }
            catch 
            {
                Console.WriteLine("Valor Invalido");
                EscolherNumero();
            }
            
        }
        static string VerificarNumero(int NumeroInformado) 
        {
            int numAtual=1, numAnterior=0, Intermediario;
            if (numAtual == 0)
            {
                return "o número informado pertence a sequência";
            }
            do
            {
                Intermediario = numAtual;
                numAtual = numAtual + numAnterior;
                numAnterior = Intermediario;
                if (numAtual == NumeroInformado) 
                {
                    return "o número informado pertence a sequência";
                }
            }while(numAtual<NumeroInformado);
            return "o número informado não pertence a sequência";
        }
    }
}
