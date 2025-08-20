using e_Parliament.enums;
using e_Parliament.models;
using e_Parliament.Services;
using System;

namespace e_Parliament
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountTypesServices typesServices = new AccountTypesServices();
            AccountType accountType = new AccountType()
            {
                Id = 1,
                typeName = TypeNameEnum.Admin,
                Actions = "Create, Read, Update, Delete",
            };

            typesServices.AddAccountType(accountType);

            UsersService usersServices = new UsersService();
            Users user = new Users
            {
                Id = 3,
                FirstName = "Michael",
                LastName = "Doe",
                Email = "Michael@gmail.com",
                Country = "USA",
                AccountTypeId = 1  
            };

            usersServices.addUser(user);




        }
    }
}
