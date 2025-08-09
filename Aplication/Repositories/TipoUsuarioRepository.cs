using Aplication.Models;
using Microsoft.EntityFrameworkCore;
using Salvation.Data;
using Salvation.Interfaces;

namespace Salvation.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private readonly SalvationDbContext _context;
        public TipoUsuarioRepository(SalvationDbContext context)
        {
            _context = context;
        }

        // Implementar somente este método
        public Task<List<TipoUsuario>> GetAllAsync()
        {
            return _context.TipoUsuarios.ToListAsync();
        }



        public Task AddAsync(TipoUsuario tipoUsuarionero)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        

        public Task<TipoUsuario> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TipoUsuario tipoUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
