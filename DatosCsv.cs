namespace Sistema
{
    public class AccesoADatosCSV : IAccesoADatos
    {
     public List<Cadete> LeerCadetes(string path)
        {
            string dato;
            string[] datos;
            int idC;
            string nombreC, direccionC, telefonoC;
            List<Cadete> lista = new List<Cadete>();
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                Console.WriteLine("No se pudo determinar el directorio relativo.");
                return lista;
            }
            try
            {
                using StreamReader reader = new(path);    
                while ((dato = reader.ReadLine()) != null)
                {
                    datos = dato.Split(';');
                    if (datos.Length >= 4)
                    {
                        idC = int.Parse(datos[0]);
                        nombreC = datos[1];
                        direccionC = datos[2];
                        telefonoC = datos[3];
                        Cadete cadeteLeido = new Cadete(idC, nombreC, direccionC, telefonoC);
                        lista.Add(cadeteLeido);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo leer el archivo");
                Console.WriteLine(e.Message);
            }
            return lista;
        }

    }


}
