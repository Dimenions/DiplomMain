using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.Coins.dbContext
{
    public class Coin
    {
        public int CoinId { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public int Price { get; set; }

        //TODO
        //public string Anniversary { get; set; } юбилейная

        public string Description { get; set; }

        //public int? IdCountry { get; set; }

        public Country Country { get; set; }

        //public int? IdMaterial { get; set; }

        public Material Material { get; set; }

        public byte[] Picture { get; set; }

        /*public SaleCoins SaleCoins { get; set; }

        public UserCoin UserCoin { get; set; }*/

        public bool Activ { get; set; }

        public int UserId { get; set; }// внешний ключ

        public User User { get; set; }// навигационное свойство

        public bool IsPresentation { get; set; }
    }
}
