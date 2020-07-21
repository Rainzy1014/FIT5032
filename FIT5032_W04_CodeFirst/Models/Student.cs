namespace FIT5032_Week03_CodeFirst.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    [Table("Student")]
    public class Student
    {
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //使用“Student”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        //“FIT5032_Week03_CodeFirst.Models.Student”数据库。
        // 
        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“Student”
        //连接字符串。
        public Student()
            //: base("name=Student")
        {
        }
      
            public int ID { get; set; }

            [Display(Name = "Name")]
            [Required]
            [StringLength(200, MinimumLength = 2)]
            public string Name { get; set; }

            [Display(Name = "Sex")]
            [Required]
            [Range(0, 1)]
            public int Gender { get; set; }


            [Display(Name = "Major")]
            [Required]
            [StringLength(200)]
            public string Major { get; set; }


        //为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
        //的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。

        //public virtual DbSet<Student> MyEntities { get; set; }
    }
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}