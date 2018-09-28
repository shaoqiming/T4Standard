
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using exin.Portal.EF.Data.Table;
using exin.Portal.EF.Data.Portal;

namespace exin.Portal.EF.Map.Portal
{
    public class OnlineUserMap: EntityTypeConfiguration<OnlineUserModel>
    {
        public  OnlineUserMap(string schema = "dbo")
        {
            entityMap.ToTable(schema + ".Portal_OnlineUsers");
         entityMap.HasKey(a => a.FId);
            entityMap.Property(a => a.FId).HasColumnName("FId").IsRequired().HasMaxLength(50);
            entityMap.Property(a => a.FToken).HasColumnName("FToken");
            entityMap.Property(a => a.FUserId).HasColumnName("FUserId");
            entityMap.Property(a => a.FRealName).HasColumnName("FRealName");
            entityMap.Property(a => a.FClientIP).HasColumnName("FClientIP");
            entityMap.Property(a => a.FFirstRequestTime).HasColumnName("FFirstRequestTime");
            entityMap.Property(a => a.FStartOnlineTime).HasColumnName("FStartOnlineTime");
            entityMap.Property(a => a.FLastRequestTime).HasColumnName("FLastRequestTime");
            entityMap.Property(a => a.FRefreshToken).HasColumnName("FRefreshToken");
            entityMap.Property(a => a.FAppKey).HasColumnName("FAppKey");
            entityMap.Property(a => a.FExpirationTime).HasColumnName("FExpirationTime");
            entityMap.Property(a => a.FScope).HasColumnName("FScope");
            entityMap.Property(a => a.FIsOnline).HasColumnName("FIsOnline");
            entityMap.Property(a => a.FLoginType).HasColumnName("FLoginType");
         
        }
}
}
