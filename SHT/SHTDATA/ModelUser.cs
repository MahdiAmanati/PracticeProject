using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHT.SHTDATA
{
    public class ModelUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        [Required]
        [MaxLength(80)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(11)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(10)]
        public string Age { get; set; }
        [Required]
        [MaxLength(4)]
        public string SportField { get; set; }
        [Required]
        [MaxLength(80)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(10)]
        public string Password { get; set; }
        [MaxLength(1)]
        public string Deleted { get; set; } = "0";
    }
}
