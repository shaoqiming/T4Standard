using System;

namespace exin.Portal.EF.Data.Portal
{
    public class OnlineUserModel  
    {
             public string FId { get; set; }
        /// <summary>
        /// 生产的TokenId
        /// </summary>
        public string FToken { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public string FUserId { get; set; }
        /// <summary>
        /// 真是姓名
        /// </summary>
        public string FRealName { get; set; }
                public string FClientIP { get; set; }
                public DateTime? FFirstRequestTime { get; set; }
                public DateTime? FStartOnlineTime { get; set; }
                public DateTime? FLastRequestTime { get; set; }
                public string FRefreshToken { get; set; }
                public string FAppKey { get; set; }
                public DateTime? FExpirationTime { get; set; }
                public string FScope { get; set; }
                public bool? FIsOnline { get; set; }
                public int? FLoginType { get; set; }
                }
}
