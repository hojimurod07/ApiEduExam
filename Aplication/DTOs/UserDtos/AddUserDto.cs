using Domain.Enums;

namespace Aplication.DTOs.UserDtos
{
    public  class AddUserDto
    {
        public string FullName {  get; set; } = string.Empty;
        public string Email { get; set; }  = string.Empty;
        public string Password { get; set; } =string.Empty;
        public double Balance {  get; set; }
        
    }
}
