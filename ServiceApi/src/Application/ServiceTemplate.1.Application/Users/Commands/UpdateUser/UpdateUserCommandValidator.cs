using ApplicationFramework.Application.Exceptions;
using FluentValidation;
using FluentValidation.Validators;
using Microsoft.EntityFrameworkCore;
using ServiceTemplate._1.Application.Interfaces;
using ServiceTemplate._1.Domain.Entities;

namespace ServiceTemplate._1.Application.Users.Commands.UpdateUser;

public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
    private readonly IServiceTemplate__1DbContext _dbContext;

    public UpdateUserCommandValidator(IServiceTemplate__1DbContext dbContext)
    {
        _dbContext = dbContext;
        
        RuleFor(x => x.Id).MustAsync(Exist);
    }

    private async Task<bool> Exist(Guid id, CancellationToken cancellationToken)
    {
        return await _dbContext.Users.AnyAsync(x => x.Id == id, cancellationToken)
            ? true
            : throw new NotFoundException(nameof(User), id);
    }
}