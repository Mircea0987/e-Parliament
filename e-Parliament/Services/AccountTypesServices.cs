using e_Parliament.DbContextApp;
using e_Parliament.models;
using e_Parliament.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.Services
{
    internal class AccountTypesServices : AccountTypeRepository
    {

        private AppDbContext _context;

        public void AddAccountType(AccountType accountType)
        {
            if(accountType == null)
            {
                throw new Exception("Account type cannot be null!");
            }
            else
            {
              using(_context = new AppDbContext())
                {
                    _context.account_types.AddAsync(accountType);
                    _context.SaveChanges();
                }
            }
        }
    }
}
