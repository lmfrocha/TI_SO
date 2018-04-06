using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TI_SO.Struct
{
    class Lista
    {
        /// <summary>
        /// Metodo generico para implementar a lista !!!
        /// </summary>
        private Elemento primeiro, ultimo;
        //private int contElementos;


        //1)a
        public Lista()
        {
            this.primeiro = new Elemento();
            this.ultimo = this.primeiro;
        }
        //1)b
        //Insere no final da lista
        public void addFim(Dado d)
        {
            Elemento novo = new Elemento(d);
            this.ultimo.prox = novo;
            this.ultimo = novo;
        }
        //1)C
        

        //Localiza o dado e o retorna
        public Dado localizar(Dado d)
        {
            Elemento aux = this.primeiro.Prox;
            while (aux != null)
            {
                //Busca
                if (aux.GetDado().Equals(d))
                {
                    // arrumar return aux.;
                }
                else aux = aux.Prox;
            }
            return null;
        }

        //Remover item da lista
        public Dado retirar(Dado d)
        {
            Elemento aux = this.primeiro;
            while (aux.Prox != null)
            {
                //Busca
                if (aux.Prox.GetDado().Equals(d))
                {
                    Elemento retorno = aux.Prox;
                    aux.Prox = retorno.Prox;
                    if (retorno == this.ultimo)
                    {
                        this.ultimo = aux;
                    }
                    else
                    {
                        retorno.Prox = null;
                        return retorno;
                    }
                }
                aux = aux.Prox;
            }
            return null;
        }

        public override string ToString()
        {
            Elemento aux = this.primeiro.Prox;
            StringBuilder ret = new StringBuilder();

            while (aux != null)
            {
                ret.AppendLine(aux.dado.ToString());
                aux = aux.Prox;
            }
            return ret.ToString();
        }

        //Concatenar lista
        public void Concatenar(Lista Outra)
        {
            this.ultimo.Prox = Outra.primeiro.Prox;
            this.ultimo = Outra.ultimo;
            Outra = new Lista(); //Limpa a lista outra e o garbage colector o limpa depois.....
        }
    }
}
