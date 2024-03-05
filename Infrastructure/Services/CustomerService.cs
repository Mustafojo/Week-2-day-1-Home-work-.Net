using Infrastructure.DataContex;
using Domain.Models;
using Dapper;
namespace Infrastructure.Services;

public class CustomerService
{
    private readonly DapperContext _context;
    public CustomerService()
    {
        _context = new DapperContext();
    }

    public void AddCustomers(Customers customer)
    {
        var sql = "insert into Customers (name,balance) values (@name,@balance)";
        _context.Connection().Execute(sql , customer);
    }
    
    
}
