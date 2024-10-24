﻿namespace SchoolProject.Core.Validators.UseValidators;

public class ConfirmEmailCommandValidator
    : AbstractValidator<ConfirmEmailCommand>
{
    public ConfirmEmailCommandValidator()
    {
        RuleFor(x => x.code)
          .NotEmpty().WithMessage("{PropertyName} must not be empty")
          .NotNull().WithMessage("{PropertyName} must not be null");
    }
}
