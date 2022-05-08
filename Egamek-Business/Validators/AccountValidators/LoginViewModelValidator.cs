﻿using System;
using System.Collections.Generic;
using System.Text;
using Egamek_Business.ViewModels.AccountViewModels;
using FluentValidation;

namespace Egamek_Business.Validators.AccountValidators
{
    public class LoginViewModelValidator : AbstractValidator<LoginViewModel>
    {
        public LoginViewModelValidator()
        {
            RuleFor(u => u.Email).NotNull().NotEmpty().MaximumLength(255).EmailAddress()
                .WithMessage("Please enter a email !");
            RuleFor(u => u.Password).NotNull().NotEmpty().MaximumLength(255)
                .WithMessage("Please enter a password !");
        }
    }
}
