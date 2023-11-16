namespace Entidades
{
    public delegate bool DelegadoBuscador<T>(T objeto);


    public class ListaEnlazada<T>
    {
        private Nodo<T>? primerNodo;


        public int CantidadDeElementos
        {
            get { return this.GetCantidadElementos(); }
        }

        private int UltimoIndice
        {
            get
            {
                return this.CantidadDeElementos - 1;
            }
        }

        public T this[int indice]
        {
            get
            {
                Nodo<T> nodo =  this.ObtenerNodoPorIndice(indice);
                if(nodo is null)
                {
                    throw new IndexOutOfRangeException("Indice fuera de rango");
                }
                return nodo.Elemento;
            }
        }


        private int GetCantidadElementos()
        {
            Nodo<T>? nodo = this.primerNodo;
            int cantidad = 0;
            while( nodo is not null )
            {
                cantidad++;
                nodo = nodo.SiguienteNodo;
            }

            return cantidad;
        }

        private Nodo<T> ObtenerNodoPorIndice(int indice)
        {
            if(indice > -1 && indice < this.CantidadDeElementos)
            {
                Nodo<T>? nodo = this.primerNodo;

                if(indice == 0)
                {
                    return nodo;
                }

                int i = 1;
                nodo = nodo.SiguienteNodo;

                while ( nodo is not null && i != indice )
                {
                    i++;
                    nodo = nodo.SiguienteNodo;
                }
                return nodo;
            }
            return null;
        }

        public void AgregarElemento(T elemento)
        {
       
            Nodo<T>? nuevoNodo = new Nodo<T>();
            nuevoNodo.Elemento = elemento;

            if(this.primerNodo is null)
            {
                this.primerNodo = nuevoNodo;
            }
            else
            {
                Nodo<T>? ultimoNodo = this.ObtenerNodoPorIndice(this.UltimoIndice);
                ultimoNodo.SiguienteNodo = nuevoNodo;
            }
        }
        
        public T Buscar(DelegadoBuscador<T> buscador)
        {
            Nodo<T>? nodo = this.primerNodo;

            while( nodo is not null)
            {
                if(buscador(nodo.Elemento))
                {
                    return nodo.Elemento;
                }

                nodo = nodo.SiguienteNodo;
            }
            return default;
        }
       
        
        public int IndiceDe(DelegadoBuscador<T> buscador)
        {
            Nodo<T>? nodo = this.primerNodo;
            int indice = -1;
            int posicion = 0;

            while (nodo is not null)
            {
                if (buscador(nodo.Elemento))
                {
                    indice = posicion;
                    return indice;
                }

                posicion++;
                nodo = nodo.SiguienteNodo;
            }



            return indice;

        }
    }
}
