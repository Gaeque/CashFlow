using CashFlow.Domain.Repositories.Expenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Application.UseCases.Expenses.Reports.Pdf
{
    public class GenerateExpensesReportPdfUseCase : IGenerateExpensesReportPdfUseCase
    {
        private const string CURRENCY_SYMBOL = "€";
        private readonly IExpenseReadOnlyRepository _repository;

        public GenerateExpensesReportPdfUseCase(IExpenseReadOnlyRepository repository)
        {
            _repository = repository;
        }

        public async Task<byte[]> Execute(DateOnly month)
        {
            var expenses = await _repository.FilterByMonth(month);
            if (expenses.Count == 0)
            {
                return [];
            }



            return [];
        }
    }
}
