using FluentValidation;
using Kanban.API.Domain.Models;

public class CardCreateValidator : AbstractValidator<CardCreate>
{
    public CardCreateValidator()
    {
        RuleFor(cardc => cardc.Name).NotNull();
    }
}