using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNews.Models.cjl
{
    [Table("UserDb")]
    public class UserDb
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [Display(Name = "用户编号")]
        public int UserID { get; set; }

        [Required]
        [Display(Name = "用户名称")]
        [StringLength(30)]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "权限编号")]
        public int RightID { set; get; }

        [Required]
        [Display(Name = "用户密码")]
        [StringLength(20)]
        public string UserPassword { get; set; }

        [ForeignKey("RightID")]
        public virtual RightDb RightDb { set; get; }
        public virtual ICollection<RightDb> RightDbs { get; set; }
    }
}