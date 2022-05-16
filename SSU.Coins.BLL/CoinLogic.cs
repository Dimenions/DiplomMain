using SSU.Coins.BLL.Interface;
using SSU.Coins.Entities;
using Microsoft.EntityFrameworkCore;

namespace SSU.Coins.BLL
{
    public class CoinLogic : ICoinLogic
    {
        private DbContext _coinLogic;

        /*public CoinLogic(IContext coinLogic)
        {
            _coinLogic = coinLogic;
        }
        */
        public void Add(Coin coin, out ICollection<Error> errorList)
        {
            errorList = new List<Error>();
            try
            {
                _coinLogic.Add(coin);
            }
            catch (Exception ex)
            {
                errorList.Add(new Error { Message = ex.Message });
            }
        }

        public IEnumerable<Coin> GetAll()
        {
            return null;
        }

        public IEnumerable<Coin> GetByCountry(int id)
        {
            return null;
        }

        public IEnumerable<Coin> GetByDate(int id)
        {
            return null;
        }

        public Coin GetById(int id)
        {
            return null;
        }

        public IEnumerable<Coin> GetByMaterial(int id)
        {
            return null;
        }

        public IEnumerable<Coin> GetByPrice(int price)
        {
            return null;
        }

        public IEnumerable<Coin> GetByTitle(string title)
        {
            return null;
        }

        public IEnumerable<Coin> GetByTitleAndCountry(string title, int idCountry)
        {
            return null;
        }

        public void RemoveById(int id, ICollection<Error> errorList)
        {
           //ToDo 
        }

        public void Update(Coin coin, ICollection<Error> errorList)
        {
            _coinLogic.Update(coin);
        }
    }
}