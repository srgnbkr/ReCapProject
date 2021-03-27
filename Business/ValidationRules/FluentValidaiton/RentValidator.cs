using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidaiton
{
    public class RentValidator:AbstractValidator<Rental>
    {
        public RentValidator()
        {
            RuleFor(r => r.RentDate).GreaterThan(DateTime.Now).WithMessage("Geçmiş Güne kiralama yapılmaz");
            RuleFor(r => r.ReturnDate).GreaterThanOrEqualTo(r => r.RentDate).WithMessage("iade  tarihi kiralama tarihinden önce olmalıdır");

        }
    }
}
