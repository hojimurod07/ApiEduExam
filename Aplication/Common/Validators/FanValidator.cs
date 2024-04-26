
using Domain.Entities;
using FluentValidation;

namespace Aplication.Common.Validators
{
    public  class FanValidator:AbstractValidator<Fan>
    {
        public FanValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Fan nomi kiritilish Kerak");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Fan Narxi kiritilish Kerak");

            RuleFor(x => x.Spiker).NotEmpty().WithMessage("Fan Spikiri kiritilish Kerak");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Fan tafsifi kiritilish Kerak");
        }
    }
}
