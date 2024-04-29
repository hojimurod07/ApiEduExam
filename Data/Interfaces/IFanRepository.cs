

using Domain.Entities;

namespace Data.Interfaces
{
    public  interface IFanRepository:IRepository<Fan>
    {
        Task<List<string>> GetAllTopic();
    }
}
