﻿using Aplication.Models;

namespace Salvation.Interfaces
{
    public interface IGeneroRepository
    {
        Task<List<Genero>> GetAllAsync();
        //stand by
        Task<Genero> GetByIdAsync(int id);
        Task AddAsync(Genero genero);
        Task UpdateAsync(Genero genero);
        Task DeleteAsync(int id);
    }
}
