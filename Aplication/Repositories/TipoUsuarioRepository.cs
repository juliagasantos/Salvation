using Microsoft.EntityFrameworkCore;
using Salvation.Data;
using Salvation.Interfaces;
using Salvation.Models;

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
        public async Task<List<TipoUsuario>> GetAllAsync()
        {
            return await _context.TipoUsuarios.Include(t => t.Usuarios).ToListAsync();
        }



        public async Task AddAsync(TipoUsuario tipoUsuario)
        {
            await _context.TipoUsuarios.AddAsync(tipoUsuario);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var tipoUsuario = await _context.TipoUsuarios.FirstOrDefaultAsync(t => t.IdTipoUsuario == id);
            if (tipoUsuario != null)
            {
                _context.TipoUsuarios.Remove(tipoUsuario);
                await _context.SaveChangesAsync();
            }
        }

        

        public async Task<TipoUsuario> GetByIdAsync(int id)
        {
            return await _context.TipoUsuarios.Include(t => t.Usuarios).FirstOrDefaultAsync(t => t.IdTipoUsuario == id);
        }

        public async Task UpdateAsync(TipoUsuario tipoUsuario)
        {
            _context.TipoUsuarios.Update(tipoUsuario);
            await _context.SaveChangesAsync();
        }
    }
}
