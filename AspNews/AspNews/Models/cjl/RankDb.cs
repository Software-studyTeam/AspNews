using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNews.Models.cjl
{
    [Table("RankDb")]
    public class RankDb
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [Display(Name = "等级编号")]
        public int RankID { get; set; }

        [Required]
        [Display(Name = "等级名称")]
        [StringLength(30)]
        public string RankName { get; set; }

        [Required]
        [Display(Name = "等级描述")]
        [StringLength(50)]
        public string RankDescribed { get; set; }

        public virtual ICollection<NewsDb> NewsDb { get; set; }
    }
}