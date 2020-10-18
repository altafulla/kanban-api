using FluentValidation;
using Kanban.API.Domain.Resources;

public class CardCreateValidator : AbstractValidator<CardCreate>
{
    public CardCreateValidator()
    {
        RuleFor(cardc => cardc.Name).NotNull();
    }
}