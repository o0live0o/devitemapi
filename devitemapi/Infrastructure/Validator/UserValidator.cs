using System;
using devitemapi.Dto.User;
using FluentValidation;

namespace devitemapi.Infrastructure.Validator
{
    public class UserValidator:AbstractValidator<UserAddOrUpdateDto>
    {
        public UserValidator()
        {
            RuleFor(u => u.Account).Length(10,20);
            RuleFor(u => u.OperateDate).NotEmpty().GreaterThan(DateTime.Now);

        }
    }
}