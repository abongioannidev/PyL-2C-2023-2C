namespace Entidades
{
    public class Nodo<T>
    {
        internal T? Elemento { get; set; }
        internal Nodo<T>? SiguienteNodo { get; set; }
        
    }
}