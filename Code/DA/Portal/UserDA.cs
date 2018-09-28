
using System;
using exin.Portal.EF.Api;
using exin.Portal.EF.Data.Portal;

namespace exin.Portal.EF.DA.Portal
{
    public class DAUser: ExinRepository<UserModel>
    {
        public DAUser(IUnitOfData dbContext)
            : base(dbContext)
        {
        }
    }
}
