

using Modelos;
using System.Collections;

namespace Datos.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<bool> NuevoAsync(Usuario user);
        Task<bool> ActualizarAsync(Usuario user);
        Task<bool> EliminarAsync(String codigoUsuario);
        Task<IEnumerable<Usuario>> GetListaAsync();
        Task<Usuario>GetPorCodigoAsync(String codigoUsuario);
    }
}
