using FluentValidation;
using FluentValidation.Validators;

namespace ServiceTemplate._1.Application.Users.Commands.DeleteUser;

public class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
{
    public DeleteUserCommandValidator()
    {
        //RuleFor(x => x.TenantId).NotEmpty();
    }
}