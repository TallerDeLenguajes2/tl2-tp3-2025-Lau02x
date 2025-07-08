namespace Sistema
{
    public class Cliente
    {
        public string? Nombre { get; set; }
        public string?Direccion{ get; set; }
        public string Telefono { get; set; }
        public string? DatosReferenciaDireccion { get; set; }
        public Cliente CrearCliente(string nom, string dir, string tel, string referencia)
        {
            Cliente C = new();
            Nombre = nom;
            Direccion = dir;
            Telefono = tel;
            DatosReferenciaDireccion = referencia;
            return C;
        }
    }
} 