using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Prezados, 

boa tarde. Está no SGA o arquivo de dados para o trabalho interdisciplinar com SO.
É um arquivo texto, contendo em cada linha as informações de um processo, com a seguinte 
estrutura, separada por ponto e vírgula: 

*PID do processo (identificador, int) 
*nome do processo (string) 
*prioridade (int) 
*tempo de execução de uso da cpu (float, em segundos) 
*número de ciclos de cpu para terminar. 

Exemplificando, o processo abaixo: 

35;/usr/lib/evolution/evolution-addressbook-factory;4;0,65;7 

Tem um PID 35, se chama "/usr/lib/evolution/evolution-addressbook-factory", tem a prioridade 4, 
a cada vez que vai para a CPU executa por 0,65 segundos e precisa ir à CPU 7 vezes para terminar. 

Havendo dúvidas, me escrevam. 

Att, 
João
 */


namespace TrabalhoIntegradoComSO.Package
{
    class Processo
    {
        private int iD;
        private string nome;
        private int prioridade;
        private float timeExec;
        private int ciclos;

        //Construtor
        public Processo(int iD, string nome, int prioridade, float timeExec, int ciclos)
        {
            this.iD = iD;
            this.nome = nome;
            this.prioridade = prioridade;
            this.timeExec = timeExec;
            this.ciclos = ciclos;
        }
        //Métodos Get and Set
        public int ID { get => iD; set => iD = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Prioridade { get => prioridade; set => prioridade = value; }
        public float TimeExec { get => timeExec; set => timeExec = value; }
        public int Ciclos { get => ciclos; set => ciclos = value; }

        public override string ToString()
        {
            return ID + Nome + Prioridade + TimeExec + Ciclos ;
        }




    }
}
