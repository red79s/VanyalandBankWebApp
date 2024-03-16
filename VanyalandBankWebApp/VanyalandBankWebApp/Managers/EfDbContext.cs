using Eloe.RemoteEfExecute;
using Microsoft.EntityFrameworkCore;
using VanyalandBank.Models;

namespace VanyalandBankWebApp.Managers
{
    public class EfDbContext : RemoteDbContextBase
    {
        public IRemoteDbSet<BankAccount> BankAccounts { get; set; }
        public IRemoteDbSet<BankCard> BankCards { get; set; }
        public IRemoteDbSet<CompanyRegister> CompanyRegister { get; set; }
        public IRemoteDbSet<CompanyShare> CompanyShares { get; set; }
        public IRemoteDbSet<CompanySharesTransaction> CompanySharesTransactions { get; set; }
        public IRemoteDbSet<Currency> Currencies { get; set; }
        public IRemoteDbSet<Passport> Passports { get; set; }
        public IRemoteDbSet<Person> Persons { get; set; }
        public IRemoteDbSet<Transaction> Transactions { get; set; }


        public EfDbContext(IRemoteDbSetExecuter executer)
            : base(executer)
        {
            BankAccounts = new RemoteDbSet<BankAccount>(nameof(BankAccounts), executer);
            AddRemoteDbSet(BankAccounts);

            BankCards = new RemoteDbSet<BankCard>(nameof(BankCards), executer);
            AddRemoteDbSet(BankCards);

            CompanyRegister = new RemoteDbSet<CompanyRegister>(nameof(CompanyRegister), executer);
            AddRemoteDbSet(CompanyRegister);

            CompanyShares = new RemoteDbSet<CompanyShare>(nameof(CompanyShares), executer);
            AddRemoteDbSet(CompanyShares);

            CompanySharesTransactions = new RemoteDbSet<CompanySharesTransaction>(nameof(CompanySharesTransactions), executer);
            AddRemoteDbSet(CompanySharesTransactions);

            Currencies = new RemoteDbSet<Currency>(nameof(Currencies), executer);
            AddRemoteDbSet(Currencies);

            Passports = new RemoteDbSet<Passport>(nameof(Passports), executer);
            AddRemoteDbSet(Passports);

            Persons = new RemoteDbSet<Person>(nameof(Persons), executer);
            AddRemoteDbSet(Persons);

            Transactions = new RemoteDbSet<Transaction>(nameof(Transactions), executer);
            AddRemoteDbSet(Transactions);
        }
    }
}
