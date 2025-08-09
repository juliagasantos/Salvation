using Aplication.Models;

namespace Salvation.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> GetAllAsync();
        Task<List<Usuario>> GetAllAtivosAsync();
        //stand by
        Task<Usuario> GetByIdAsync(int id);
        Task AddAsync(Usuario usuario);
        Task UpdateAsync(Usuario usuario);
        Task DeleteAsync(int id);
        Task InativarAsync(int id);
        Task ReativarAsync(int id);
        Task<Usuario> ValidarLoginAsync(string email, string senha);
    }
}
