
using Domain.Enums;

namespace Domain.Entities
{
    public  class User:BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone {  get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty ;
        public double Balance { get; set; } = 0;
        public bool IsVerified {  get; set; } = false;
      
        public Gender   Gender { get; set; }
        public Role Role { get; set; } = Role.User;



    }
}
