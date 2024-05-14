using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface Servicio_Crud<T>
    {
        string Guardar(T t);
        List<T> Consultar();
        T Buscar(string Date);
        string Eliminar(string Date);
        string Actualizar(T t);
    }
}
