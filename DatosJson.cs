using System.Text.Json.Serialization;
using System.Text.Json;

namespace Sistema

{
   public class AccesoADatosJSON: IAccesoADatos 
   {
    public List<Cadete> LeerCadetes(string path)
    {
        List<Cadete> ListadoCadetes = new List<Cadete>();
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                Console.WriteLine("No se pudo determinar el directorio relativo.");
                return ListadoCadetes;
            }
            string stringJson = File.ReadAllText(path);
            try
            {
                ListadoCadetes = JsonSerializer.Deserialize<List<Cadete>>(stringJson) ?? new List<Cadete>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al deserializar: " + ex.Message);
            }
            return ListadoCadetes;
    }
   }


}