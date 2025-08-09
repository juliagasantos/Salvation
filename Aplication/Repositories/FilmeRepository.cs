using Aplication.Models;
using Microsoft.EntityFrameworkCore;
using Salvation.Data;
using Salvation.Interfaces;

namespace Salvation.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly SalvationDbContext _context;
        public FilmeRepository(SalvationDbContext context)
        {
            _context = context;
        }

        //Create
        public async Task AddAsync(Filme filme)
        {
            await _context.Filmes.AddAsync(filme);
            await _context.SaveChangesAsync();

        }

        //delete
        public async Task DeleteAsync(int id)
        {
            var filme = await _context.Filmes.FirstOrDefaultAsync(f => f.IdFilme == id);
            if (filme != null) {
                _context.Filmes.Remove(filme);
                await _context.SaveChangesAsync();
            }
        }

        //GetAll
        public async Task<List<Filme>> GetAllAsync()
        {
            return await _context.Filmes.Include(f => f.Genero)
                                        .Include(f => f.Classificacao).ToListAsync();
        }

        //GetById
        public async Task<Filme> GetByIdAsync(int id)
        {
            return await _context.Filmes
                .Include(f => f.Genero)
                .Include(f => f.Classificacao)
                .FirstOrDefaultAsync(f => f.IdFilme == id);
        }
        //Update
        public async Task UpdateAsync(Filme filme)
        {
            _context.Filmes.Update(filme);
            await _context.SaveChangesAsync();
        }
    }
}
