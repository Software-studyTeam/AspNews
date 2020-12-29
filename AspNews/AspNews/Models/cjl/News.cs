namespace AspNews.Models.cjl
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    public class News : DbContext
    {
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //使用“News”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        //“AspNews.Models.cjl.News”数据库。
        // 
        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“News”
        //连接字符串。
        public News()
            : base("name=News")
        {
        }
        public virtual DbSet<CommentDb> CommentDb { get; set; }
        public virtual DbSet<NewsDb> NewsDb { get; set; }
        public virtual DbSet<RankDb> RankDb { get; set; }
        public virtual DbSet<RightDb> RightDb { get; set; }
        public virtual DbSet<TypeDb> TypeDb { get; set; }
        public virtual DbSet<UserDb> UserDb { get; set; }
     //   protected override void OnModelCreating(DbModelBuilder modelBuilder)
     //   {
     //       modelBuilder.Entity<CommentDb>()
      //          .Property(e => e.CommentID)
      //          .IsFixedLength();

     //   }
        //为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
        //的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
