using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class EFAccRepository:IAccRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Account> Accounts
        {
            get { return context.Accounts; }
        }
        public void SaveAccount(Account ac)
        {
            if (ac.ID == null || ac.ID == Guid.Empty)
            {
                Account a = new Account();
                a.ID = ac.ID;
                a.Login = ac.Login;
                a.Password = ac.Password;
                a.E_mail = ac.E_mail;
                a.Surname = ac.Surname;
                a.Name = ac.Name;
                a.Otch = ac.Otch;
                a.City = ac.City;
                context.Accounts.Add(a);
            }
            context.SaveChanges();
        }
    }
}
