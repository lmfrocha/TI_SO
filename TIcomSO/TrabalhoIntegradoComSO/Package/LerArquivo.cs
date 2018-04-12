using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using TrabalhoIntegradoComSO.Structs;
using TrabalhoIntegradoComSO.Package;

namespace TrabalhoIntegradoComSO.Package
{
    static class LerArquivo
    {
        public static Lista Ler() // objeto é passado sempre como referencia
        {
            Lista list = new Lista();
            string arq = "TI.txt";
            StreamReader sr = new StreamReader(arq, Encoding.Default); // abre o arquivo para leitura
            string aux;
            string[] atributos = new string[5];
            Processo p;

            while (!sr.EndOfStream) // enquanto não chegar ao final do arquivo
            {
                aux = sr.ReadLine(); // aux recebe a próxima linha do arquivo
                atributos = aux.Split(';'); // vetor atributos é construido com strings separadas pelo ";" de aux

                //int string int int int


                p = new Processo(int.Parse(atributos[0]), atributos[1], int.Parse(atributos[2]), float.Parse(atributos[3]), int.Parse(atributos[4]));


                list.addFim(p);
            }

            return list;
        }
    }
}
    

