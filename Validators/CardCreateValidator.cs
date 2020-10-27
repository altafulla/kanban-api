using FluentValidation;
using kanban.API.Resources;

namespace Kanban.API.Validators
{
    public class CardCreateValidator : AbstractValidator<CardCreate>
    {
        public CardCreateValidator()
        {
            RuleFor(cardc => cardc.Name).NotNull();
        }
    }
}