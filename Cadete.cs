
using System.Text.Json.Serialization;

namespace Sistema
{
    public class Cadete
    {
        [JsonPropertyName("id")]
        public int Id { get; }
        [JsonPropertyName("nombre")]
        public string Nombre { get; }
        [JsonPropertyName("direccion")]
        public string Direccion { get; }
        [JsonPropertyName("telefono")]
        public string Telefono { get; }
        public Cadete(int id, string nombre, string direccion, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
  