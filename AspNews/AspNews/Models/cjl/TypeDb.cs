using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; //用到 [Index], [ForeignKey]

namespace AspNews.Models.cjl
{   [Table("TypeDb")]
    public class TypeDb
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [Display(Name = "类别编号")]
        public int TypeID { get; set; }

        [Required]
        [Display(Name = "类别名称")]
        [StringLength(30)]
        public string TypeName { get; set; }

        [Required]
        [Display(Name ="类别英文")]
        public string TypeEnName { get; set; }
        public virtual ICollection<NewsDb> NewsDb { get; set; }
    }
}