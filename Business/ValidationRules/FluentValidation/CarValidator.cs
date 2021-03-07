using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).MinimumLength(2).WithMessage("sdfsdfsdfsdfsdfsdfsdfsdfsdfdsfsdfdsf");
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0).NotEmpty();
            RuleFor(c => c.Id).NotEmpty();
            RuleFor(c => c.ModelYear).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.Description).NotEmpty();

        }
    }
}
