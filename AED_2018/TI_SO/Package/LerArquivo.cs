using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI_SO;

namespace TI_SO.Package
{
    class LerArquivo
    {
        public static void carregaArquivo(string caminho)
        {
            Lista nova = new Lista();
            Pessoa eleitor;
            StreamReader arq = new StreamReader(caminho);
            string[] linhaAtual = new string[5];
            string linha = arq.ReadLine();

            do
            {
                linhaAtual = linha.Split('-');
                nova.addFim(eleitor = new Pessoa(linhaAtual[0], linhaAtual[1], int.Parse(linhaAtual[2]), int.Parse(linhaAtual[3]), int.Parse(linhaAtual[4])));

            } while (linha != null);

        }
    }
}
