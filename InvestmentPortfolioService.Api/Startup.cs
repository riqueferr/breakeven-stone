using Domain.Contracts;
using MediatR;
using InvestmentPortfolioService.Api.Contracts.v1.Requests;
using InvestmentPortfolioService.Repository.Contexts;
using InvestmentPortfolioService.Repository.Repositories;
using Microsoft.EntityFrameworkCore;

namespace InvestmentPortfolioService.Api;

public class Startup
{
    private IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
        services.AddControllers();
        services.AddMediatR(typeof(CreateAccountBankingCommand));
        
        // Contexts
        services.AddDbContext<ReadModelSqlContext>(options => 
            options.UseSqlServer(Configuration.GetConnectionString("ReadModelSqlConnection")));
        // services.AddDbContext<EventStoreSqlContext>(options => 
        //     options.UseSqlServer(Configuration.GetConnectionString("EventStoreSqlConnection")));

        //Repositories
        services.AddScoped<IAccountBankingRepository, AccountBankingSqlRepository>();
        // services.AddScoped<IEventStoreRepository, EventStoreSqlRepository>();
        // services.AddScoped<ITransactionRepository, TransactionSqlRepository>();
        
        //Validators
        // services.AddScoped<IValidator<CreateAccountCommand>, CreateAccountCommandValidator>();
        // services.AddScoped<IValidator<CreateTransactionCommand>, CreateTransactionCommandValidator>();

        
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new() { Title = "InvestmentPortfolioService", Version = "v1" });
        });
        }

    public void Configure(IApplicationBuilder app)
    {
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();
        app.UseEndpoints(endpoints => endpoints.MapControllers());
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            options.RoutePrefix = string.Empty;
        });       
    }
}