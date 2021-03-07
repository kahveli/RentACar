using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Passwd).NotEmpty();
            RuleFor(u => u.Passwd).MinimumLength(12);
            RuleFor(u => u.FirstName).MinimumLength(3);
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Id).NotEmpty();
            RuleFor(u => u.Email).NotEmpty();


        }
    }
}
