namespace Infrastructure.Services;

using Dapper;

using Domain.Models;
using Infrastructure.DataContex;

public class TransactionService
{
    private readonly DapperContext _context;
    public TransactionService()
    {
        _context = new DapperContext();
    }
    public void AddTransactions(Transactions transactions)
    {
        var sql = "insert into Transactions (data,summa,senderid,takerid) values (@data,@summa,@senderid,@takerid)";
        _context.Connection().Execute(sql , transactions);
    }

    public List<Transactions> TransactionsHistory(int id)
    {
        var sql = "select * from transactions where senderid = @id or takerid = @id";
        var result = _context.Connection().Query<Transactions>(sql , new {Id = id}).ToList();
        return result;
    }

    public List<Transactions> JournalFinance()
    {
        var sql = "select * from transactions";
        var result = _context.Connection().Query<Transactions>(sql).ToList();
        return result;
    }

}
