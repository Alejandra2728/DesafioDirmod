using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDirmod
{

    class Program
    {
        static void Main(string[] args)
        {
            char[] letras = new char[27];
            string[] numeros = { "0", "2", "22", "222", "3", "33", "333", "4", "44", "444", "5", "55", "555", "6", "66", "666", "7", "77", "777", "7777", "8", "88", "888", "9", "99", "999", "9999" };

            letras[0] = Convert.ToChar(32);

            /*--Introducir el texto*/

            Console.WriteLine("Introduzca un texto");
            String textoIngresado;
            textoIngresado = Console.ReadLine();
            string resultado = "";
            int letraAscii = 97;

            /*Carga de array del abecedario*/

            for (int j = 1; j < letras.GetLength(0); j++)
            {
                letras[j] = Convert.ToChar(letraAscii);
                letraAscii++;
            }

            char aux = '"';
            int c = 0;

            foreach (var tex in textoIngresado)
            {

                for (int i = 0; i < letras.Length; i++)
                {

                    if (tex == letras[i])
                    {

                        if (c == 0)
                        {
                            resultado += numeros[i];

                            aux = Convert.ToChar(resultado.Substring(resultado.Length - 1));

                            c++;
                        }
                        else if (c != 0)
                        {
                            aux = Convert.ToChar(resultado.Substring(resultado.Length - 1));

                            char[] primeraLetra = numeros[i].ToCharArray();
                            char aux1 = primeraLetra[0];

                            if (aux == aux1)
                            {
                                resultado = resultado + " " + numeros[i];
                            }
                            else
                            {
                                resultado += numeros[i];

                            }
                        }

                    }
                }
            }
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}


   

