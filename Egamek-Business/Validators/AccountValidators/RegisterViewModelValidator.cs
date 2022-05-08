﻿using System;
using System.Collections.Generic;
using System.Text;
using Egamek_Business.ViewModels.AccountViewModels;
using FluentValidation;

namespace Egamek_Business.Validators.AccountValidators
{
    public class RegisterViewModelValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterViewModelValidator()
        {
            RuleFor(u => u.Name).NotNull().NotEmpty().MaximumLength(255)
                .WithMessage("Please enter a name !");
            RuleFor(u => u.Surname).NotNull().NotEmpty().MaximumLength(255)
                .WithMessage("Please enter a surname !");
            RuleFor(u => u.Email).NotNull().NotEmpty().MaximumLength(255).EmailAddress()
                .WithMessage("Please enter a email !");
            RuleFor(u => u.Password).NotNull().NotEmpty().MaximumLength(255)
                .WithMessage("Please enter a password !");
            RuleFor(u => u.PasswordConfirm).NotNull().NotEmpty().MaximumLength(255)
                .WithMessage("Please enter a name confirm password !");
        }
    }
}
