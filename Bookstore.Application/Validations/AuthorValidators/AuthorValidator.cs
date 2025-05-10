using Bookstore.Application.DTOs.AuthorDTOs;
using FluentValidation;

namespace Bookstore.Application.Validations.AuthorValidators;

public class AuthorValidator : AbstractValidator<AuthorCreateDTO>
{
    public AuthorValidator()
    {
        RuleFor(customer => customer.Name)
            .NotEmpty().WithMessage("Müştəri adı boş ola bilməz.");
     
    }

}
