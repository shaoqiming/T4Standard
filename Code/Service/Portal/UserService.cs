using System;
using exin.Portal.EF.BF.Portal;
using exin.Portal.EF.Data.Portal;

namespace exin.Portal.EF.Service.Portal
{
    public class UserService
    {
                //添加
        public void add(UserModel model)
        {
            BFUser bf = new BFUser();
            model.PID = Guid.NewGuid().ToString();
            bf.add(model);
            bf.EFSubmit();
        }

        //更新
        public void Update(UserModel model)
        {
            BFUser bf = new BFUser();
            bf.Update(model);
            bf.EFSubmit();
        }

        public void Delete(string key)
        {
            BFUser bf = new BFUser();
            var model = bf.GetModelById(key);
            if (model != null)
            {
                bf.Delete(model);
            }

            bf.EFSubmit();
        }

        public Pagination<UserModel> GetListbyPain(int pageIndex, int pageSize)
        {
            BFUser bf = new BFUser();
            return bf.ListByPain(pageIndex, pageSize);
        }

        public UserModel GetDetailByKey(string key)
        {
            BFUser bf = new BFUser();
            return bf.GetModelById(key);
        }

    }
}
