using Core.Entities.Concrete;
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
            RuleFor(u => u.Email).EmailAddress().When(u=> !string.IsNullOrEmpty(u.Email)).WithMessage("Geçersiz Email");
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("İsim Alanı Boş Bırakılamaz");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("Soyadı Alanı Boş Bırakılamaz");


        }
    }
}
