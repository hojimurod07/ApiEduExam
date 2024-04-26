

using Data.DB;
using Data.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class UserRepository(AppDbContext dbContext) : Repository<User>(dbContext), IUserRepository
    {
        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(e => e.Email == email);
        }
    }
}
