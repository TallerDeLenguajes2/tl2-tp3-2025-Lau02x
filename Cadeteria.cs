namespace Sistema
{
    public class Cadeteria
    {
        public string Nombre { get; set; }
        public float Telefono { get; set; }
        public List<Cadete> ListadoCadetes { get; set; }
        public List<Pedidos> ListaPedidos { get; set; }
        public Cadeteria()
        {
            Nombre = string.Empty;
            ListaPedidos = new List<Pedidos>();
            ListadoCadetes = new List<Cadete>();
        }
        public Cadete? BuscarCadetePorId(int id)
        {
            return ListadoCadetes.Find(C => C.Id == id);
        }
        public void AsignarCadeteAPedido(int Id_c, int Id_p)
        {
            Cadete? CadeteEncontrado = BuscarCadetePorId(Id_c);
            Pedidos PedidoEncontrado = BuscarPedidoPorNumero(Id_c);
            if (CadeteEncontrado != null && PedidoEncontrado!=null)
            {
                PedidoEncontrado.CadeteAsignado = CadeteEncontrado;
            }    
        }
        public int JornalACobrar(int Id)
        {
            int jornal = 0;
            Cadete? CadeteEncontrado = BuscarCadetePorId(Id);
            if (CadeteEncontrado == null) return 0;
            foreach (Pedidos p in ListaPedidos)
            {
                if (p.Estado && p.CadeteAsignado.Id == CadeteEncontrado.Id)
                {
                    jornal += 500;
                }
            }
            return jornal;
        }
        public Pedidos BuscarPedidoPorNumero(int nro)
        {
            return ListaPedidos.Find(p => p.Numero == nro);
        }
        public void MostrarCadetes()
        {
            foreach (Cadete c in ListadoCadetes)
            {
                System.Console.WriteLine("\nNombre del cadete: " + c.Nombre + "\n , Id: " + c.Id);
            }
        }
         public void MostrarPedidos()
        {
            if (ListaPedidos.Count == 0)
            {
                System.Console.WriteLine("La Cadetederia no tiene pedidos");
            }
            else
            {
                System.Console.WriteLine(" \n -- Pedidos de la cadeteria -- \n");
                foreach (Pedidos p in ListaPedidos)
                {
                    Console.WriteLine("\n-- Nro del pedido: " + p.Numero+ " --");
                    if (p.CadeteAsignado != null)
                    {
                        Console.WriteLine("-- Nombre del cadete asignado: " + p.CadeteAsignado.Nombre + "\n");
                        Console.WriteLine("-- Id del cadete asignado: " + p.CadeteAsignado.Id + "\n");
                    }
                    else
                    {
                            Console.WriteLine("Sin cadete Asignado" + "\n");
                    }
                    Console.WriteLine("Observacion:" + p.Observacion);
                    Console.WriteLine("Nombre del Cliente:" + p.Cliente.Nombre);
                    Console.WriteLine("Direccion del Cliente:" + p.Cliente.Direccion);
                    Console.WriteLine("Estado del pedido:" + p.Estado+ "\n");
                }
            }
        }
    }


}
