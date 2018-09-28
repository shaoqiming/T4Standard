using System;
using exin.Portal.EF.BF.Portal;
using exin.Portal.EF.Data.Portal;

namespace exin.Portal.EF.Service.Portal
{
    public class OnlineUserService
    {
                //添加
        public void add(OnlineUserModel model)
        {
            BFOnlineUser bf = new BFOnlineUser();
            model.PID = Guid.NewGuid().ToString();
            bf.add(model);
            bf.EFSubmit();
        }

        //更新
        public void Update(OnlineUserModel model)
        {
            BFOnlineUser bf = new BFOnlineUser();
            bf.Update(model);
            bf.EFSubmit();
        }

        public void Delete(string key)
        {
            BFOnlineUser bf = new BFOnlineUser();
            var model = bf.GetModelById(key);
            if (model != null)
            {
                bf.Delete(model);
            }

            bf.EFSubmit();
        }

        public Pagination<OnlineUserModel> GetListbyPain(int pageIndex, int pageSize)
        {
            BFOnlineUser bf = new BFOnlineUser();
            return bf.ListByPain(pageIndex, pageSize);
        }

        public OnlineUserModel GetDetailByKey(string key)
        {
            BFOnlineUser bf = new BFOnlineUser();
            return bf.GetModelById(key);
        }

    }
}
