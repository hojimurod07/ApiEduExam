
using Data.DB;
using Data.Interfaces;

namespace Data.Repositories
{
    public class UnitOfWork(AppDbContext dbContext) : IUnitOfWork
    {
        private readonly AppDbContext _dbContext = dbContext;

        public IUserRepository UserRepository => new UserRepository(_dbContext);

        public IFanRepository FanRepository => new FanRepository(_dbContext);
    }
}
