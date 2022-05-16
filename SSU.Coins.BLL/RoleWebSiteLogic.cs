using SSU.Coins.BLL.Interface;
using SSU.Coins.Entities;
using System.Collections.Generic;

namespace SSU.Coins.BLL
{
    public class RoleWebSiteLogic : IRoleWebSiteLogic
    {
        /*private IRoleWebSiteDao _roleWebSiteLogic;

        public RoleWebSiteLogic(IRoleWebSiteDao roleWebSiteLogic)
        {
            _roleWebSiteLogic = roleWebSiteLogic;
        }*/
        public IEnumerable<RoleWebSite> GetAll()
        {
            //return _roleWebSiteLogic.GetAll();
            return null;
        }

        public RoleWebSite GetById(int id)
        {
            //return _roleWebSiteLogic.GetById(id);
            return null;
        }

        public RoleWebSite GetByName(string name)
        {
            //return _roleWebSiteLogic.GetByName(name);
            return null;
        }
    }
}
