using SSU.Coins.BLL.Interface;
using SSU.Coins.BLL.Extensions;

namespace SSU.Coins.BLL
{
    public class MyRoleProviderLogic : IMyRoleProviderLogic
    {
       private CoinsContext _context;

        public MyRoleProviderLogic(CoinsContext roleLogic)
        {
            _context = roleLogic;
        }

        /*public string GetRolesForUser(string username)
        {
            return _context.RoleWebSites
                 .Where(p => p.Name == username)
                 .Select(p => p.ToRoleWebSite);
        }*/
    }
}
