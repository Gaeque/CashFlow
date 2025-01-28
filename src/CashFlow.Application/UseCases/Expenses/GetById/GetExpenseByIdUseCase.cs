using AutoMapper;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Repositories.Expenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Application.UseCases.Expenses.GetById
{
    public class GetExpenseByIdUseCase : IGetExpenseByIdUseCase
    {
        private readonly IExpenseReadOnlyRepository _repository;
        private readonly IMapper _mapper;

        public GetExpenseByIdUseCase(IExpenseReadOnlyRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResponseExpenseJson> Execute(long id)
        {
            var result = await _repository.GetById(id);

            return _mapper.Map<ResponseExpenseJson>(result);    
        }
    }
}
