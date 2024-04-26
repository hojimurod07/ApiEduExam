

using Domain.Entities;
using FluentValidation;

namespace Aplication.Common.Validators
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x=>x.FullName)
                .NotEmpty().WithMessage("Ism bosh bolmasligi kerak");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email bosh bolmasligi kerak");
            RuleFor(x => x.Gender).NotEmpty().WithMessage("Jinsni kiritish kerak");


        }
    }
}
