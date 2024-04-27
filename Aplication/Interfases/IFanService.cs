using Aplication.DTOs.FanDtos;

namespace Aplication.Interfases
{
    public  interface IFanService
    {
        Task CreateAsync(AddFanDto dto);
        Task UpdateAsync(FanDto dto);
        Task DeleteAsync(int id);
        Task<List<FanDto>> GetAllAsync();
        Task<FanDto?> GetByIdAsync(int id);
        
    }
}
