using FluentValidation;
using FluentValidation.Validators;

namespace ServiceTemplate._1.Application.Users.Commands.UpdateUser;

public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
    public UpdateUserCommandValidator()
    {
        //RuleFor(x => x.TenantId).NotEmpty();
    }
}