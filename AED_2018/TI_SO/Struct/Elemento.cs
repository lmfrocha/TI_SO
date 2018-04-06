using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_SO.Struct
{
    class Elemento
    {
        protected string val;
        protected Elemento prox;

        internal Elemento Prox { get => prox; set => prox = value; }

        public Elemento(string d)
        {
            this.val = d;
        }

        public string GetDado()
        {
            return val;
        }
    }
}
