using e_Parliament.DbContextApp;
using e_Parliament.models; // Add this using directive to reference the correct Users model
using e_Parliament.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.Services
{
    internal class UsersService : UserRepository
    {
        private AppDbContext _context;
        public List<Users> getAllUsers()
        {
            using (_context = new AppDbContext())
            {
                return _context.users.ToList();
            }
        }

        public Users getUserById(int id)
        {
            using (_context = new AppDbContext())
            {
                Users user = _context.users.FirstOrDefault(u => u.Id == id);
                if(user == null)
                {
                    throw new Exception("User not found");
                }
                else
                {
                  return user;
                }
            }
        }
        public void addUser(Users user)
        {
            using(_context = new AppDbContext())
            {
                _context.users.Add(user);
                _context.SaveChanges();
            }
        }
    }
}
