
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using exin.Portal.EF.Data.Table;
using exin.Portal.EF.Data.Portal;

namespace exin.Portal.EF.Map.Portal
{
    public class UserMap: EntityTypeConfiguration<UserModel>
    {
        public  UserMap(string schema = "dbo")
        {
            entityMap.ToTable(schema + ".Portal_User");
         entityMap.HasKey(a => a.PID);
            entityMap.Property(a => a.PID).HasColumnName("PID").IsRequired().HasMaxLength(50);
            entityMap.Property(a => a.UserID).HasColumnName("UserID");
            entityMap.Property(a => a.UserName).HasColumnName("UserName");
            entityMap.Property(a => a.Photo_Upload).HasColumnName("Photo_Upload");
            entityMap.Property(a => a.PassWord).HasColumnName("PassWord");
            entityMap.Property(a => a.Mobile).HasColumnName("Mobile");
            entityMap.Property(a => a.UserType_Sel).HasColumnName("UserType_Sel");
            entityMap.Property(a => a.LastLoginTime).HasColumnName("LastLoginTime");
            entityMap.Property(a => a.State_Sel).HasColumnName("State_Sel");
            entityMap.Property(a => a.Remark).HasColumnName("Remark");
            entityMap.Property(a => a.DepartmentID_SelSource).HasColumnName("DepartmentID_SelSource");
            //数据库自增配置
            entityMap.Property(a => a.Number).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).HasColumnName("Number");
            entityMap.Property(a => a.CreateUser).HasColumnName("CreateUser");
            entityMap.Property(a => a.CreateTime).HasColumnName("CreateTime");
            entityMap.Property(a => a.GroupID).HasColumnName("GroupID");
            entityMap.Property(a => a.Email).HasColumnName("Email");
         
        }
}
}
