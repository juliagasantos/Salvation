using Aplication.Models;
using Microsoft.EntityFrameworkCore;
using Salvation.Data;
using Salvation.Interfaces;

namespace Salvation.Repositories
{
    public class ClassificacaoRepository : IClassificacaoRepository
    {
        private readonly SalvationDbContext _context;
        public ClassificacaoRepository(SalvationDbContext context)
        {
            _context = context;
        }

        //implementar somente este metodo
        public async Task<List<Classificacao>> GetAllAsync()
        {
            return await _context.Classificacoes.ToListAsync();
        }

        //stand by

        public Task<Classificacao> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Classificacao classificacao)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Classificacao classificacao)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
