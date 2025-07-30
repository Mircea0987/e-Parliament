using e_Parliament.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.Repository
{
    internal interface UserRepository
    {
        List<Users> getAllUsers();
        Users getUserById(int userId);
        void addUser(Users user);
    }
}
