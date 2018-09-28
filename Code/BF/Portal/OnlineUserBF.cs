
using System;
using exin.Portal.EF.DA.Portal;
using exin.Portal.EF.Data.Portal;

namespace exin.Portal.EF.BF.Portal
{
    public class BFOnlineUser:ExinBaseBF
    {
                //添加
        public void add(OnlineUserModel data)
        {
            DAOnlineUser da = new DAOnlineUser(UnitOfData);
            data.PID = Guid.NewGuid().ToString();
            da.Add(data);
        }

        //更新
        public void Update(OnlineUserModel data)
        {
            DAOnlineUser da = new DAOnlineUser(UnitOfData);
            var model = da.GetMany(a => a.PID == data.PID).FirstOrDefault();
            if (model != null)
            {
                da.Update(data);
            }
        }

        //分页查询
        public Pagination<OnlineUserModel> ListByPain(int pagaIndex, int pageSize)
        {
            DAOnlineUser da = new DAOnlineUser(UnitOfData);
            return da.QueryMany(a => true).OrderBy(a => a.PID).FetchPage(currentPageIndex: pagaIndex, pageSize: pageSize);
        }

        //条件查询
        public List<OnlineUserModel> QueryData()
        {
            DAOnlineUser da = new DAOnlineUser(UnitOfData);
            return da.GetMany(a => true).ToList();
        }

        public void Delete(OnlineUserModel data)
        {
             DAOnlineUser da = new DAOnlineUser(UnitOfData);
            //没有isDelete的字段情况下使用 Delete 有IsDelete的情况下使用Update
             
            da.Delete(data);
              
        }

  
        /// <summary>
        /// 通过id获取实体
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public OnlineUserModel GetModelById(string pId)
        {
            DAOnlineUser da = new DAOnlineUser(UnitOfData);
             
			return da.GetMany(a => a.PID == pId).FirstOrDefault();//要加上isDelete的条件
			   
        }

         
        /// <summary>
        /// 映射到DTO上面
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IQueryable<OnlineUserModelDTO> GetModelDTO(Expression<Func<OnlineUserModel, bool>> predicate = null)
        {
            DAOnlineUser da = new DAOnlineUser(UnitOfData);
            if (predicate == null)
            {
                predicate = model => true;
            }

            var query = from a in da.DataContext.Set<OnlineUserModel>().Where(a => true)
                        where predicate.Invoke(a)
                        select new AddressModelDTO()
                        {
                            
							FId=a.FId, 
							FToken=a.FToken, 
							FUserId=a.FUserId, 
							FRealName=a.FRealName, 
							FClientIP=a.FClientIP, 
							FFirstRequestTime=a.FFirstRequestTime, 
							FStartOnlineTime=a.FStartOnlineTime, 
							FLastRequestTime=a.FLastRequestTime, 
							FRefreshToken=a.FRefreshToken, 
							FAppKey=a.FAppKey, 
							FExpirationTime=a.FExpirationTime, 
							FScope=a.FScope, 
							FIsOnline=a.FIsOnline, 
							FLoginType=a.FLoginType                        };

            return query;
        }
        


    }
}
