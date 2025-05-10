using Bookstore.Application.DTOs.BookDTOs;
using FluentValidation;

namespace Bookstore.Application.Validations.NewFolder;

public class BookValidator : AbstractValidator<BookCreateDTO>
{
    public BookValidator()
    {
        RuleFor(book => book.Name)
            .NotEmpty().WithMessage("Kitab adı boş ola bilməz.");

        RuleFor(x => x.Amount)
            .NotEmpty().WithMessage("Kitab miqdarı boş ola bilməz.")
            .GreaterThan(0)
            .WithMessage("Miqdar 0-dan böyük olmalıdır.");
       
        RuleFor(x=>x.Price)
            .NotEmpty().WithMessage("Kitab qiyməti boş ola bilməz.")
            .GreaterThan(0)
            .WithMessage("Qiyməti 0-dan böyük olmalıdır.");
    }
   
}
