using SSU.Coins.CustomException;
using SSU.Coins.BLL.Interface;
using SSU.Coins.Entities;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace SSU.Coins.BLL
{
    public class UserLogic //: IUserLogic
    {
        /*private IUserDao _userDao;

        public UserLogic(IUserDao userLogic)
        {
            _userDao = userLogic;
        }*/

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
                //_userDao.Add(user);
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
            //return _userDao.GetAll();
            return null;
        }

        public IEnumerable<User> GetAllUserByRole(int id)
        {
            //return _userDao.GetAllUserByRole(id);
            return null;
        }

        public User GetById(int id)
        {
            //return _userDao.GetById(id);
            return null;
        }

        public User GetByLogin(string login)
        {
            //return _userDao.GetByLogin(login);
            return null;
        }
        /*
        public void Remove(int id, out ICollection<Error> listError)
        {
            listError = new List<Error>();
            try
            {
                if (_userDao.GetById(id) == null)
                {
                    listError.Add(new Error
                    {
                        Message = "User won't find"
                    });
                    return;
                }

                _userDao.Remove(id);
            }
            catch
            {
                listError.Add(new Error
                {
                    Message = "Internal error, try again"
                });
            }
        }

        public void Update(User user, out ICollection<Error> listError)
        {
            listError = new List<Error>();
            try
            {
                if (_userDao.GetById(user.Id) == null)
                {
                    listError.Add(new Error
                    {
                        Message = "User won't find"
                    });
                    return;
                }

                _userDao.Update(user);
            }
            catch (RoleUndefinedException ex)
            {
                listError.Add(new Error
                {
                    Message = ex.Message
                });
            }
        }*/
    }
}
