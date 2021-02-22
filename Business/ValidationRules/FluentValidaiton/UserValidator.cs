using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidaiton
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.EMail).EmailAddress().When(u=> !string.IsNullOrEmpty(u.EMail)).WithMessage("Geçersiz Email");
            RuleFor(u => u.Password).Length(5, 22).NotEmpty().WithMessage("Şifre 5 Karakterden Kısa Olamaz");
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("İsim Alanı Boş Bırakılamaz");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("Soyadı Alanı Boş Bırakılamaz");
        }
    }
}
