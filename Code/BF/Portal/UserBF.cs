
using System;
using exin.Portal.EF.DA.Portal;
using exin.Portal.EF.Data.Portal;

namespace exin.Portal.EF.BF.Portal
{
    public class BFUser:ExinBaseBF
    {
                //添加
        public void add(UserModel data)
        {
            DAUser da = new DAUser(UnitOfData);
            data.PID = Guid.NewGuid().ToString();
            da.Add(data);
        }

        //更新
        public void Update(UserModel data)
        {
            DAUser da = new DAUser(UnitOfData);
            var model = da.GetMany(a => a.PID == data.PID).FirstOrDefault();
            if (model != null)
            {
                da.Update(data);
            }
        }

        //分页查询
        public Pagination<UserModel> ListByPain(int pagaIndex, int pageSize)
        {
            DAUser da = new DAUser(UnitOfData);
            return da.QueryMany(a => true).OrderBy(a => a.PID).FetchPage(currentPageIndex: pagaIndex, pageSize: pageSize);
        }

        //条件查询
        public List<UserModel> QueryData()
        {
            DAUser da = new DAUser(UnitOfData);
            return da.GetMany(a => true).ToList();
        }

        public void Delete(UserModel data)
        {
             DAUser da = new DAUser(UnitOfData);
            //没有isDelete的字段情况下使用 Delete 有IsDelete的情况下使用Update
             
            da.Delete(data);
              
        }

  
        /// <summary>
        /// 通过id获取实体
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public UserModel GetModelById(string pId)
        {
            DAUser da = new DAUser(UnitOfData);
             
			return da.GetMany(a => a.PID == pId).FirstOrDefault();//要加上isDelete的条件
			   
        }

         
        /// <summary>
        /// 映射到DTO上面
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IQueryable<UserModelDTO> GetModelDTO(Expression<Func<UserModel, bool>> predicate = null)
        {
            DAUser da = new DAUser(UnitOfData);
            if (predicate == null)
            {
                predicate = model => true;
            }

            var query = from a in da.DataContext.Set<UserModel>().Where(a => true)
                        where predicate.Invoke(a)
                        select new AddressModelDTO()
                        {
                            
							PID=a.PID, 
							UserID=a.UserID, 
							UserName=a.UserName, 
							Photo_Upload=a.Photo_Upload, 
							PassWord=a.PassWord, 
							Mobile=a.Mobile, 
							UserType_Sel=a.UserType_Sel, 
							LastLoginTime=a.LastLoginTime, 
							State_Sel=a.State_Sel, 
							Remark=a.Remark, 
							DepartmentID_SelSource=a.DepartmentID_SelSource, 
							Number=a.Number, 
							CreateUser=a.CreateUser, 
							CreateTime=a.CreateTime, 
							GroupID=a.GroupID, 
							Email=a.Email                        };

            return query;
        }
        


    }
}
