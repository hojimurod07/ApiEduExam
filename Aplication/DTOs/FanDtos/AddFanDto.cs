

using Domain.Entities;
using System.Linq.Expressions;

namespace Aplication.DTOs.FanDtos
{
    public  class AddFanDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Spiker {  get; set; } = string.Empty;
        public double Price { get; set; }


        //public static implicit operator Fan(FanDto dto)
        //{
        //    return new Fan()
        //    {
        //        Title = dto.Title,
        //        Description = dto.Description,
        //        Spiker = dto.Spiker,
        //        Price = dto.Price,

        //    };
        //}
      
    }
}
