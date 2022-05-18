using SSU.Coins.BLL.Interface;
using System.Security.Cryptography;

namespace SSU.Coins.BLL
{
    public class AuthLogic : IAuthLogic
    {
        private CoinsContext _authDao;
        public AuthLogic(CoinsContext authDao)
        {
            _authDao = authDao;
        }   
    }
}