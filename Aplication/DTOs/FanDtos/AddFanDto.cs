

namespace Aplication.DTOs.FanDtos
{
    public  class AddFanDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Spiker {  get; set; } = string.Empty;
        public double Price { get; set; }
    }
}
