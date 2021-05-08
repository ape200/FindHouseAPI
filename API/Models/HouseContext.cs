using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class HouseContext : DbContext
    {
        //Add-Migration Init  //其中Init是你的版本名称
        //回车执行，注意Init可以改成例如1.0
        //update-database Init //更新数据库操作 init为版本名称
        //回车执行，注意Init需要跟上面版本一致。
        //检查数据库表中是否创建完成。

        public HouseContext() { }
        public HouseContext(DbContextOptions<HouseContext> options) : base(options) { }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<House> Houses { get; set; }
        /// <summary>
        /// 首页功能
        /// </summary>
        public DbSet<FristPage> FristPages { get; set; }
        /// <summary>
        /// 二手房
        /// </summary>
        public DbSet<Second_House> Second_Houses { get; set; }

        /// <summary>
        /// 权限管理操作模块
        /// </summary>
        public DbSet<EmployeeInfo> EmployeeInfo { get; set; }
        public DbSet<EmpRole> EmpRole { get; set; }
        public DbSet<MenuInfo> MenuInfo { get; set; }
        public DbSet<RoleInfo> RoleInfo { get; set; }
        public DbSet<RoleMenu> RoleMenu { get; set; }
        public DbSet<EmpMenu> EmpMenu { get; set; }
        /// <summary>
        /// 用户模块
        /// </summary>
        public DbSet<users> users { get; set; }
        //新房和用户
        public DbSet<userNew> userNew { get; set; }
        //新房
        public DbSet<NewHome> NewHome { get; set; }
        //出租房
        public DbSet<rental> rental { get; set; }


    }
}
