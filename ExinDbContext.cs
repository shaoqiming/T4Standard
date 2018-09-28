

using System.Data.Entity;
using exin.Portal.EF.Core;
using exin.Portal.EF.Data.Table;
using exin.Portal.EF.DB.Map;

namespace Bronze.HiRead.Entities
{
    public partial class HiReadEntities 
    {
		#region 属性


        /// <summary>
        /// 在线用户表
        /// </summary
        public virtual IDbSet<OnlineUserModel> OnlineUser { get; set; }


        /// <summary>
        /// 状态：启用、禁用
        /// </summary>
        public virtual IDbSet<UserModel> User { get; set; }

		#endegion 

		#region 映射
        

        /// <summary>
        /// 在线用户表
        /// </summary>
        modelBuilder.Configurations.Add(new OnlineUserMap());
    

        /// <summary>
        /// 状态：启用、禁用
        /// </summary>
        modelBuilder.Configurations.Add(new UserMap());
    

	#endegion 
    }
}
