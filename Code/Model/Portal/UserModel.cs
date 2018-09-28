using System;

namespace exin.Portal.EF.Data.Portal
{
    public class UserModel  
    {
     /// <summary>
        /// PID
        /// </summary>
        public string PID { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string Photo_Upload { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 用户类型 [0.系统管理员|1.服务人员|2.普通会员]
        /// </summary>
        public int? UserType_Sel { get; set; }
        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime? LastLoginTime { get; set; }
        /// <summary>
        /// 状态[0.启用|1.停用]
        /// </summary>
        public int? State_Sel { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 所属部门[SourceName.Portal_Department|Name.Name|Value.PID]
        /// </summary>
        public string DepartmentID_SelSource { get; set; }
        /// <summary>
        /// 编号
        /// </summary>
        public int? Number { get; set; }
        /// <summary>
        /// 创建用户
        /// </summary>
        public string CreateUser { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 组织编码
        /// </summary>
        public string GroupID { get; set; }
                public string Email { get; set; }
                }
}
