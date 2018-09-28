
using System;
using exin.Portal.EF.Api;
using exin.Portal.EF.Data.Portal;

namespace exin.Portal.EF.DA.Portal
{
    public class DAOnlineUser: ExinRepository<OnlineUserModel>
    {
        public DAOnlineUser(IUnitOfData dbContext)
            : base(dbContext)
        {
        }
    }
}
