using FluentValidation;
using kanban.API.Resources;

namespace kanban.Validators
{
    public class RefreshTokenResourceValidator : AbstractValidator<RefreshTokenResource>
    {
        public RefreshTokenResourceValidator()
        {
            RuleFor(rt => rt.Token).NotNull();
            RuleFor(rt => rt.UserEmail).MaximumLength(255).EmailAddress().NotNull();
        }
    }
}
