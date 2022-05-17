using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SSU.Coins.dbContext
{
    public class RoleWebSite
    {
        public int RoleWebSiteId { get; set; }

        public int UserId { get; set; } //Внешний ключ
        public User User { get; set; } // навигационное свойство
        public string Name { get; set; }

    }
}
