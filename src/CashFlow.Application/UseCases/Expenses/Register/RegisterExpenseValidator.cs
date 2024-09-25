using CashFlow.Communication.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Application.UseCases.Expenses.Register
{
    public class RegisterExpenseValidator : AbstractValidator<RequestRegisterExpenseJson>
    {
        public RegisterExpenseValidator()
        {
            RuleFor(expense => expense.Title).NotEmpty().WithMessage("O titulo é obrigatório");

            RuleFor(expense => expense.Amount).GreaterThan(0).WithMessage("As despesas não podem ser para o futuro");

            RuleFor(expense => expense.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("As despesas não podem ser para o futuro");

            RuleFor(expense => expense.PaymentType).IsInEnum().WithMessage("Tipo de pagamento inválido");
        }

    }
}
