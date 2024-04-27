

using Domain.Entities;
using Domain.Enums;
using System.Transactions;

namespace Aplication.DTOs.UserDtos
{
    public  class UpdateUserDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public double Balance { get; set; } 
        public Gender Gender { get; set; }
        public static implicit operator User(UpdateUserDto dto)
        {
            return new User()
            {
                FullName = dto.FirstName,
                Email = dto.Email,
                Gender = dto.Gender,
                Balance = dto.Balance
            };
        }
    }
}
