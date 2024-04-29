

using Data.DB;
using Data.Interfaces;
using Domain.Entities;

namespace Data.Repositories
{
    public class FanRepository(AppDbContext dbContext) : Repository<Fan>(dbContext), IFanRepository
    {
        private readonly AppDbContext _dbContext = dbContext;

        public async Task<List<string>> GetAllTopic()
        {
            var fans = _dbContext.Fans.ToList();
            List<string> topics = new List<string>();
            foreach (var fan in fans)
            {
                topics.AddRange(fan.Topics);
            }
            return topics;
        }
    }
}
