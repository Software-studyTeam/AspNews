using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNews.Models.cjl
{
    [Table("NewsDb")]
    public class NewsDb
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [Display(Name = "新闻编号")]
        public string NewsId { get; set; }

        [Required]
        [Display(Name = "类别编号")]
        public int TypeID { get; set; }

        [Required]
        [Display(Name = "等级编号")]
        public int RankID { get; set; }

        [Required]
        [Display(Name = "新闻描述")]
        [StringLength(200)]
        public string NewsDescribed { get; set; }

        [Required]
        [Display(Name = "新闻作者")]
        [StringLength(30)]
        public string NewsWriter { get; set; }

        [Required]
        [Display(Name = "新闻标题")]
        [StringLength(100)]
        public string NewsTitle { set; get; }

        [Required]
        [Display(Name = "新闻来源")]
        [StringLength(30)]
        public string NewsSource { get; set; }

        [Required]
        [Display(Name = "新闻关键字")]
        [StringLength(30)]
        public string NewsKeywords { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd-hh-mm-ss}")]
        [Display(Name = "发布时间")]
        public DateTime ReleaseTime { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "新闻内容")]
        public string NewsContent { get; set; }

        [Required]
        [Display(Name = "图片")]
        [StringLength(100)]
        public string ImageURL { get; set; }
        [NotMapped]
        public string AvatarUploader { get; set; }


        [Display(Name = "阅读量")]
        public int ReadingNum { get; set; }

        public virtual TypeDb TypeDb { set; get; }
        public virtual RankDb RankDb { set; get; }

    }
}