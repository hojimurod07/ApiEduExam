

using Data.DB;
using Data.Interfaces;
using Domain.Entities;

namespace Data.Repositories
{
    public  class FanRepository(AppDbContext dbContext):Repository<Fan>(dbContext),IFanRepository
    {
    }
}
