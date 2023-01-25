using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API_palindrome.Models
{
    [Table("tbl_palindrome")]
    public class DBclass
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Inputvalue { get; set; }
        public string Outputvalue { get; set; }
        public int count { get; set; }
    }
}