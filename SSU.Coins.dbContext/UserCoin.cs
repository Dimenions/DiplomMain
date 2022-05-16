using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.Coins.dbContext
{
    public class UserCoin
    {
        public int UserCoinId { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public ICollection<Coin> Coins { get; set; }

        //public int CoinId { get; set; }

        public Coin Coin { get; set; } 

        public double SaleCoin { get; set; }

        public string Information{ get; set; }

        public byte[] Picture { get; set; }
    }
}
