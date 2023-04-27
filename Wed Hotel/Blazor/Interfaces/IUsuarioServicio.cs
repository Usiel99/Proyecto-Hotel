using Modelos;

namespace Blazor.Interfaces
{
    public interface IUsuarioServicio
    {
        Task<bool> NuevoAsync(Usuario user);
        Task<bool> ActualizarAsync(Usuario user);
        Task<bool> EliminarAsync(String codigoUsuario);
        Task<IEnumerable<Usuario>> GetListaAsync();
        Task<Usuario> GetPorCodigoAsync(String codigoUsuario);
    }
}
