namespace Calc_polonesa
{
    class Elemento
    {
        protected string val;
        protected Elemento prox;

        //Leandro
        
        internal Elemento Prox 
        {
        	get 
        	{
        		return prox;
        	}
        	set 
        	{
        		prox = value; 
        	}
        }
        //internal Elemento Prox {
        
        //internal Elemento Prox { get => prox; set => prox = value; }

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
