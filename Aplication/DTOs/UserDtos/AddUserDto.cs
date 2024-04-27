using Domain.Entities;
using Domain.Enums;

namespace Aplication.DTOs.UserDtos
{
    public  class AddUserDto
    {
        public string FullName {  get; set; } = string.Empty;
        public string Email { get; set; }  = string.Empty;
        public string Password { get; set; } =string.Empty;
        public string Phone { get; set; }
        public double Balance {  get; set; }
        

        //public static implicit operator User(UserDto userDto)
        //{
        //    return new User()
        //    {
        //        FullName = userDto.FullName,
        //        Email = userDto.Email,
        //        Password = userDto.Password,
        //        Balance = userDto.Balance,
        //        Phone = userDto.Phone,
        //    };

        //}
    }
}
