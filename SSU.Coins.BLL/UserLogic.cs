using SSU.Coins.CustomException;
using SSU.Coins.BLL.Interface;
using SSU.Coins.Entities;
using System.Collections.Generic;
using System.Security.Cryptography;
using SSU.Coins.BLL.Extensions;

namespace SSU.Coins.BLL
{
    public class UserLogic : IUserLogic
    {
        private CoinsContext _context;

        public UserLogic(CoinsContext userLogic)
        {
            _context = userLogic;
        }

        public void Add(User user, out ICollection<Error> listError)
        {
            listError = new List<Error>();

            try
            {
                using (SHA256 mySHA256 = SHA256.Create())
                {
                    byte[] hashValue = mySHA256.ComputeHash(user.HashPassword);
                    user.HashPassword = hashValue;
                }
                _context.Add(user);
            }
            catch (UniqueIdentifierException ex)
            {
                listError.Add(new Error
                {
                    Message = ex.Message
                });
            }
            catch (RoleUndefinedException)
            {
                listError.Add(new Error
                {
                    Message = "Registration failed, please try again"
                });
            }
            catch
            {
                listError.Add(new Error
                {
                    Message = "Something went wrong"
                });
            }

        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.Select(p => p.ToUser());
        }

        public IEnumerable<User> GetAllUserByRole(int id)
        {
            return _context.Users
                .Where(p => p.RoleWebSite.RoleWebSiteId == id)
                .Select(p => p.ToUser());
        }

        public User GetById(int id)
        {
            var user = _context.Users
                .FirstOrDefault(p => p.UserId == id);

            return user.ToUser();
        }

        public User GetByLogin(string login)
        {
            var user = _context.Users
                .FirstOrDefault(p => p.Login == login);

            return user.ToUser();
        }
        public void Remove(int id, ICollection<Error> listError)
        {
            var user = _context.Users
                 .FirstOrDefault(p => p.UserId == id);
            if (user == null) { return; }

            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public void Update(User user, ICollection<Error> listError)
        {
            var userModel = user.ToUserModel();

            var newUser = _context.Users
       .FirstOrDefault(c => c.UserId == user.Id);


            var newRoleWebSite = _context.RoleWebSites
       .FirstOrDefault(c => c.Name == user.RoleWebSite);

            userModel.RoleWebSite = newRoleWebSite;

            _context.Users.Update(userModel);

            _context.SaveChanges();

        }
    }
}
