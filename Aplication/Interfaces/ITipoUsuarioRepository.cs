using Salvation.Models;

namespace Salvation.Interfaces
{
    public interface ITipoUsuarioRepository
    {
        Task<List<TipoUsuario>> GetAllAsync();
        //stand by
        Task<TipoUsuario> GetByIdAsync(int id);
        Task AddAsync(TipoUsuario tipoUsuarionero);
        Task UpdateAsync(TipoUsuario tipoUsuario);
        Task DeleteAsync(int id);
    }
}
