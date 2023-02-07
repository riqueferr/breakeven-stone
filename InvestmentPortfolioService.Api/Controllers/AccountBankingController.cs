using Domain.Contracts;
using InvestmentPortfolioService.Api.Contracts.v1.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InvestmentPortfolioService.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountBankingController : ControllerBase
{

    private readonly IAccountBankingRepository _accountRepository;
    private readonly IMediator _mediator;
    
    public AccountBankingController(IAccountBankingRepository accountRepository, IMediator mediator)
    {
        _accountRepository = accountRepository;
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAccountBanking([FromBody] CreateAccountBankingCommand command)
    {
        try
        {
            Console.WriteLine(command.Document);
            Console.WriteLine(command.Password);
            // var result = await _mediator.Send(command);
            // await _accountRepository.Save();
            
            
            return Ok(command);
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(ex.Message);
        }
    }
}