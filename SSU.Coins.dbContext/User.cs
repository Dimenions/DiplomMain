using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SSU.Coins.dbContext
{
    public class User
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Login { get; set; }

        public byte[] HashPassword { get; set; }

        //public int? RoleWebSiteID { get; set; }

        public RoleWebSite RoleWebSite { get; set; }

        public byte[] Avatar { get; set; }

        //public int CoinId { get; set; }

        public ICollection<Coin> Coins { get; set; }//Коллекция монет

        /*public SaleCoins SaleCoins { get; set; }

        public UserCoin UserCoin { get; set; }*/

        //public Coin Coin { get; set; }
    }
}

