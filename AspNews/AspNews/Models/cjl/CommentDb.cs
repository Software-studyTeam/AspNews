using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNews.Models.cjl
{
    [Table("CommentDb")]
    public class CommentDb
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [Display(Name = "评论编号")]
        public int CommentID { get; set; }

        [Required]
        [Display(Name = "新闻编号")]
        [StringLength(10)]
        public string NewsId { get; set; }

        [Required]
        [Display(Name = "用户编号")]
        public int UserID { set; get; }

        [Required]
        [Display(Name = "评论内容")]
        [StringLength(300)]
        public string CommentContent { get; set; }

        [Required]
        [Display(Name = "评论时间")]
        public DateTime CommentTime { get; set; }

        public virtual UserDb UserDb { set; get; }
        public virtual NewsDb NewsDb { set; get; }
        public virtual ICollection<UserDb> UserDbs { get; set; }
    }
}