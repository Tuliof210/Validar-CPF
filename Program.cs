using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cpf = new int[11];
            //int[] verificador = new int[9];

            int dig1, dig2;
            int aux, sum;

            bool ok = false;

            do
            {
                Console.Write("Informe seu cpf (somente numeros): ");
                string dados = Console.ReadLine();

                try
                {
                    for (int i = 0; i < cpf.Length; i++)
                    {
                        cpf[i] = int.Parse(dados[i].ToString());
                    }

                    ok = true;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Dados invalidos!\nPressione para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            while (!ok);

            aux = 10;
            sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += cpf[i] * aux;
                aux--;
            }

            dig1 = sum % 11;
            dig1 = 11 - dig1;
            if (dig1 > 9) dig1 = 0;

            if(cpf[9] == dig1) ok = true;

            aux = 11;
            sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += cpf[i] * aux;
                aux--;
            }

            dig2 = sum % 11;
            dig2 = 11 - dig2;
            if (dig2 > 9) dig2 = 0;

            if(cpf[10] == dig2) ok = true;

            if (ok) Console.WriteLine("CPF Valido");
            else Console.WriteLine("CPF Invalido");

            Console.ReadKey();
        }
    }
}
