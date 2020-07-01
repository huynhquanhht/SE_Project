using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DTO
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength]
        [Column(TypeName = "nvarchar")]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "bit")]
        [Required]
        public bool Gender { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Birthday { get; set; }
        [MaxLength]
        [Column(TypeName = "nvarchar")]
        [Required]
        public string Address { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [Column(TypeName = "nvarchar")]
        public string Phone { get; set; }
        [Required]
        [DefaultValue("false")]
        public bool Is_Deleted { get; set; }
    
        //public virtual Account Account { get; set; }
        //public virtual Bill Bill { get; set; }
    }
}
