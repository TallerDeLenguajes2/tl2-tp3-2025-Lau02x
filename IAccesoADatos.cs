using System.Collections.Generic;
namespace Sistema
{
    public interface IAccesoADatos
    {
        List<Cadete> LeerCadetes(string path);
    }

}
    