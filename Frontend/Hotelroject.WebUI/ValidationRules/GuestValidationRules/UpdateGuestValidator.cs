using FluentValidation;
using Hotelroject.WebUI.Dtos.GuestDto;

namespace Hotelroject.WebUI.ValidationRules.GuestValidationRules
{
    public class UpdateGuestValidator : AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.GuestId).NotEmpty();
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field cannot be empty!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname field cannot be empty!");
            RuleFor(x => x.City).NotEmpty().WithMessage("City field cannot be empty!");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Please enter minimum 2 character!");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Please enter minimum 2 character!");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Please enter minimum 3 character!");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Please enter maximum 50 character!");
            RuleFor(x => x.Surname).MaximumLength(50).WithMessage("Please enter maximum 50 character!");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("Please enter maximum 20 character!");

        }
    }
}
