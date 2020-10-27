using FluentValidation;
using kanban.API.Resources;

namespace kanban.API.Validators
{
    public class RevokeTokenResourceValidator : AbstractValidator<RevokeTokenResource>
    {
        public RevokeTokenResourceValidator()
        {
            RuleFor(rt => rt.Token).NotNull();
        }
    }
}
