

using Domain.Entities;

namespace Aplication.DTOs.FanDtos
{
    public  class FanDto:AddFanDto
    {
   


        public static implicit operator FanDto(Fan fan) { 
        
            return new FanDto()
            {
                Title = fan.Title,
                Description = fan.Description,
                Spiker   = fan.Spiker,
                Price = fan.Price,
            };
        }
    }
}
