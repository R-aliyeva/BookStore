using Bookstore.Application.DTOs.GenreDTOs;
using FluentValidation;

namespace Bookstore.Application.Validations.GenreValidators;

public class GenreValidator : AbstractValidator<GenreCreateDTO>
{
    public GenreValidator()
    {
        RuleFor(genre => genre.Name)
            .NotEmpty().WithMessage("Janr  boş ola bilməz.");
        
    }

}
