using FluentValidation;
using SpryStoreEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryStoreBusinessLayer.ValidationRules.ContactValidationRules
{
    public class ContactAddValidator : AbstractValidator<Contact>
    {
        public ContactAddValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Ad Soyad alanı boş geçilemez");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj içeriği boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail bilgisi boş geçilemez");
            RuleFor(x => x.NameSurname).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz");
            RuleFor(x => x.NameSurname).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter giriniz");
            RuleFor(x => x.Mail).MinimumLength(12).WithMessage("Lütfen en az 12 karakterlik  bir mail adresi giriniz");
            RuleFor(x => x.Mail).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter giriniz");
        }
    }
}
