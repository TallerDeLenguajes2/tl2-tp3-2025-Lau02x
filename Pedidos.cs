namespace Sistema
{
    public class Pedidos
    {
        public int Numero { get; set; }
        public string? Observacion { get; set; }
        public Cliente Cliente { get; set; }
        public Cadete? CadeteAsignado {get; set;}
        public bool Estado { get; set; }
        public void VerDatosCliente(Pedidos p)
        {
            Console.WriteLine("\n Nombre del Cliente:" + p.Cliente.Nombre);
            Console.WriteLine("Direccion:" + p.VerDireccionCliente);
            Console.WriteLine("Datos de referencia: " + p.Cliente.DatosReferenciaDireccion);
            Console.WriteLine("Telefono:" + p.Cliente.Telefono);
        }
        public string? VerDireccionCliente(Cliente C)
        {
            return C.Direccion;
        }
        public Pedidos DarDeAltaPedidos(int nro, string obs, Cliente c, bool est)
        {
            Pedidos p = new();
            p.Numero = nro;
            p.Observacion = obs;
            p.Cliente = c;
            p.Estado = est;
            return p;
        }
        
   
    }
}