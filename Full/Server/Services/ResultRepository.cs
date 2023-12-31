﻿using Full.Server.Data;
using Full.Server.Repositories;
using Full.Shared;
using Microsoft.EntityFrameworkCore;

namespace Full.Server.Services
{
    public class ResultRepository : IResultRepository
    {
        private readonly AppDbContext _context;
        public ResultRepository(AppDbContext context) => _context = context;
        public async Task<List<Result>> GetResultListAsync(int educationId) => await _context.Result.Include(e => e.Education).Include(u => u.User).Where(f => f.Education.Id == educationId).ToListAsync();
    }
}
