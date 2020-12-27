using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNews.Models.cjl
{
    [Table("RightDb")]
    public class RightDb
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [Display(Name = "权限编号")]
        public int RightID { get; set; }

        [Required]
        [Display(Name = "权限名称")]
        [StringLength(20)]
        public string RightName { get; set; }

    }
}