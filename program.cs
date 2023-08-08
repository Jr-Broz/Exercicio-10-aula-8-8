using System;
using System.Net;

namespace Aula_Presencial_8_80
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int dia, mes, ano;


            dia = EntrarNumero("Entre com o dia:  ");

            mes = EntrarNumero("Entre com o mes: ");

            ano = EntrarNumero("Entre com o ano: ");


            if (ano < 1900) {

                Console.WriteLine("Ano inválido");
                return;
            }


            switch (mes) {

                case 4: case 6: case 9: case 11:

                    if((dia < 1) || (dia > 31)){

                        Console.WriteLine("Dia inválido");

                    }
                    break;


                case 1: case 3: case 5: case 7:  case 8: case 10: case 12:

                    if ((dia < 31) || (dia > 31)) {

                        Console.Write("Dia inválido");
                    }
                    break;


                case 2:

                    if((ano % 400) == 0) {

                        if((dia < 1) || (dia > 29)){

                            Console.Write("Dia inválido");
                        }
                    }
                    else {
                        if((dia < 1) || (dia > 28)) {

                            Console.WriteLine("Dia Inválido");

                        }
                    }

                    break;

           
                default:
                Console.WriteLine("Mês invalido");
                break;            
     }
    } //Main a partir daqui.
        static int EntrarNumero(string msg) {

            int num = 0;

            do {
                try {
                    Console.WriteLine(msg);
                    num = Int32.Parse(Console.ReadLine());
                    break;

                } catch {
                    Console.WriteLine("Erro:  Entrada invalido");
                }
            } while (true);
                return num;
        }






    }
}
