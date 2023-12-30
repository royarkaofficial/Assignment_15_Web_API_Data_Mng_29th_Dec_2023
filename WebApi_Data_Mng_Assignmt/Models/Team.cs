using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApi_Data_Mng_Assignmt.Models
{
    [Table("Team")]
    public class Team
    {
        [Key]
        public int TId { get; set; }
        [Required]
        [StringLength(50)]
        public string TName { get; set; }
        [Required]
        [StringLength(100)]
        public string TEmail { get; set; }
        [Required]
        [StringLength(100)]
        public string TSlogan { get; set; }
    }
}